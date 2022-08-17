using Microsoft.AspNetCore.Mvc;
using TCC_CoreApi.Model;
using TCC_CoreApi.Common.Tool;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using TCC_CoreApi.Model.entity;
using TCC_WebAPI.App_Code;
using System.Linq;
using static TCC_WebAPI.App_Code.PaymentPublicHelper;

namespace TCC_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentHelperController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public PaymentHelperController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        ///  付款 周转金持卡人
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="Currency">币种</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（CardholdLogin:持卡人用户名,CardholdName:持卡人姓名,Balance:周转金余额)</response>
        [HttpGet("GetCardholderByPro")]
        public string GetCardholderByPro(string ProjectCode, string Currency)
        {
            string rlt = "[]";
            try
            {
                //TODO:蓝领添加流程中占用借款、流程归档后占用借款
                string sql = @"WITH data
                              AS ( SELECT   Request_LoginName ,Currency ,ProjectCode ,SUM(MONEY_YB) AS Money_YB
                                   FROM     ( SELECT    Request_LoginName ,Currency ,ProjectCode ,MONEY_YB
                                              FROM      dbo.view_ExpensingInfo
                                              WHERE     BorrowType = 2 AND ProjectCode = @ProjectCode
                                              UNION ALL
                                              SELECT    Requst_LoginName ,CurrencyAbbreviation ,ProjectCode ,MONEY_YB
                                              FROM      dbo.view_HasHappened_BorrowMoneyInfo
                                              WHERE     BorrowType = 2 AND BorrowPurpose = 1
                                                        AND ProjectCode = @ProjectCode
                                            ) tt
                                   GROUP BY tt.ProjectCode ,tt.Request_LoginName ,tt.Currency
                            )
                            SELECT  CardholdUserIdentity AS CardholdLogin ,CardholdName ,ISNULL(Money_YB,0) AS Balance
                            FROM    dbo.TCC_ProjectLoanApplication main
                                    INNER JOIN data tmp ON tmp.ProjectCode = main.ProjectCode
                                                           AND tmp.Request_LoginName = main.CardholdLogin
                                                           AND tmp.Currency = main.CardCurrency
                            WHERE   Enabled = 1
                                    AND main.ProjectCode = @ProjectCode
                                    AND CardCurrency = @Currency";
                List<SqlParameter> parmas = new List<SqlParameter>();
                parmas.Add(new SqlParameter("ProjectCode", ProjectCode));
                parmas.Add(new SqlParameter("Currency", Currency));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
                return rlt;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        ///  付款 行程单
        /// </summary>
        /// <param name="jnw">境内外</param>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="searchKey">查询条件(默认空，可选参数待定)</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（PersonLogin:用户名,PersonRealName:姓名,UserIdentity:身份证号,BAFormNumber:出差单号,toplace:目的地,TravelDate:出差时间)</response>
        [HttpGet("GetItineraryByPro")]
        public string GetItineraryByPro(string jnw, string ProjectCode, string searchKey = "")
        {
            string rlt = "[]";
            try
            {
                //TODO:蓝领需自行判断员工可选出差表单号（涉及往返）
                string sqlwhere = string.Empty;
                if (!string.IsNullOrEmpty(searchKey))
                {
                }
                int Oversea;
                switch (jnw)
                {
                    case "境外":
                        Oversea = 2;
                        break;
                    case "境内":
                        Oversea = 1;
                        break;
                    default:
                        Oversea = 0;
                        break;
                }
                string sql = @"SELECT  PersonLogin,PersonRealName,UserIdentity,BAFormNumber,toplace,TravelDate
                               FROM    ( SELECT    '' AS ECFormNumber ,Request_LoginName AS PersonLogin ,Request_RealName AS PersonRealName ,Request_UserIdentity AS UserIdentity ,
                                                    FormNumber AS BAFormNumber ,toplace AS toplace , TravelDate AS TravelDate ,
                                                    '' AS StrokeNumber ,'' AS PersonDeptCode ,'' AS PersonDeptName ,
                                                    AccountProject , AccountProjectName ,AccountDept ,
                                                    CASE WHEN Request_UserIdentity IN (select a0177 FROM Tcc106Server.ykchr.dbo.UsrA01 WHERE c012o='01')
                                                         THEN '010212'
						                                 WHEN ISNULL(ProjectCode,'') = ''  THEN Request_DeptCode
                                                         ELSE ProjectCode
                                                    END AS deptcode
                                          FROM      View_BusinessTripOfairInfo t
                                          WHERE ToDomesticOversea = @jnw 
                                        ) t
                                where deptcode=@ProjectCode";
                List<SqlParameter> parmas = new List<SqlParameter>();
                parmas.Add(new SqlParameter("jnw", Oversea));
                parmas.Add(new SqlParameter("ProjectCode", ProjectCode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
                return rlt;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        #region 分公司拨款相关信息
        /// <summary>
        ///  分公司拨款--拨款限额、已拨款额、已申请额、成本扣除额、拨款余额 取值
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="fd_id">蓝领外键（默认空）</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（total:拨款限额,amount:已拨款额,apply:已申请额,cost:成本扣除额,balance:拨款余额)</response>
        [HttpGet("GetCompanybkInfo")]
        public string GetCompanybkInfo(string ProjectCode, string fd_id)
        {
            decimal total = 0, amount = 0, apply = 0, managerFee = 0, humanPrice = 0;
            try
            {
                PaymentPublicHelper payHelper = new PaymentPublicHelper();
                total = payHelper.GetProjectSingleBudget(ProjectCode, enumBudgetName_EPC.拨款限额);
                amount = payHelper.GetBKHistory(ProjectCode);
                apply = payHelper.GetBKApply(ProjectCode, 0);//todo.付款流程上线后需要修改已申请金额

                if (!payHelper.GetProjectIsEPC(ProjectCode))
                {
                    string jsonBalance = new PaymentPublicHelper().GetProjectProfitMargin(ProjectCode);
                    DataTable dt = JsonHelper.DeserializeObject<DataTable>(jsonBalance);
                    if (dt.Rows.Count > 0)
                    {
                        //拨款限额为资金结存+已拨款额（因为已拨款额在资金结存中是减出去的)
                        total = Convert.ToDecimal(dt.Rows[0]["ProjectProfitMargin_Show"].ToString()) + amount;
                    }
                }
            }
            catch (Exception ee)
            {
                throw new Exception(ee.ToString());
            }
            string result = "{\"total\":" + total.ToString() + ",\"amount\":" + amount.ToString() + ",\"apply\":" + apply.ToString() + ",\"cost\":" + (managerFee + humanPrice).ToString() + ",\"balance\":" + (total - amount - apply).ToString() + "}";

            return result;
        }
        #endregion

        #region 项目付款历史记录
        /// <summary>
        /// 项目付款记录插入
        /// </summary>
        /// <param name="items">项目付款明细</param>
        /// <returns></returns>
        [HttpPost("InsertPayHistory")]
        public async Task<string> InsertPayHistory([FromBody] List<LandrayPaymentHistory> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                if (items.Count == 0)
                {
                    resultMessage.Message = "添加项为空!";
                    resultMessage.Result = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        item.Flag = 0;
                        _dbContext.Landray_PaymentHistory.Add(item);
                        await _dbContext.SaveChangesAsync();
                    }
                    resultMessage.Message = "添加成功！";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                resultMessage.Message = "添加预算错误:" + ex.Message;
                resultMessage.Result = 1;
                throw new Exception(ex.ToString());
            }
            return resultMessage.ToJson();
        }

        /// <summary>
        /// 项目付款记录修改
        /// </summary>
        /// <param name="items">项目付款明细</param>
        /// <returns></returns>
        [HttpPost("ModefiedPayHistory")]
        public async Task<string> ModefiedPayHistory(List<LandrayPaymentHistory> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                string warnmessage = "";
                string errmessage = "";
                string message = "";
                int resultcode = 0;
                if (items.Count == 0)
                {
                    errmessage = "修改项为空!";
                    resultcode = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        var todos = _dbContext.Landray_PaymentHistory.Where(t => t.fd_id == item.fd_id).ToList();
                        if (todos.Count == 0)
                        {
                            warnmessage += "【" + item.fd_id + "】,";//修改项在数据库中未找到!
                        }
                        else
                        {
                            foreach (var todo in todos)
                            {
                                _dbContext.Landray_PaymentHistory.Update(todo);
                                await _dbContext.SaveChangesAsync();
                            }
                            message += "【" + item.fd_id + "】,";//修改成功
                            resultcode = 0;
                        }
                    }

                }
                warnmessage = warnmessage == "" ? "" : warnmessage.Substring(0, warnmessage.Length - 1) + "修改项在数据库中未找到! ";
                message = message == "" ? "" : message.Substring(0, message.Length - 1) + "修改成功";
                string alertmessage = warnmessage + message;
                resultMessage.Message = errmessage != "" ? errmessage : alertmessage;
                resultMessage.Result = resultcode;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }
        #endregion


        #region 非项目付款历史记录
        /// <summary>
        /// 非项目付款记录插入
        /// </summary>
        /// <param name="items">非项目付款明细</param>
        /// <returns></returns>
        [HttpPost("InsertPayNoHistory")]
        public async Task<string> InsertPayNoHistory([FromBody] List<LandrayPaymentHistoryNotProject> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                if (items.Count == 0)
                {
                    resultMessage.Message = "添加项为空!";
                    resultMessage.Result = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        item.Flag = 1;
                        _dbContext.Landray_PaymentHistoryNotProject.Add(item);
                        await _dbContext.SaveChangesAsync();
                    }
                    resultMessage.Message = "添加成功！";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                resultMessage.Message = "添加预算错误:" + ex.Message;
                resultMessage.Result = 1;
                throw new Exception(ex.ToString());
            }
            return resultMessage.ToJson();
        }

        /// <summary>
        /// 非项目付款记录修改
        /// </summary>
        /// <param name="items">非项目付款明细</param>
        /// <returns></returns>
        [HttpPost("ModefiedPayNoHistory")]
        public async Task<string> ModefiedPayNoHistory(List<LandrayPaymentHistoryNotProject> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                string warnmessage = "";
                string errmessage = "";
                string message = "";
                int resultcode = 0;
                if (items.Count == 0)
                {
                    errmessage = "修改项为空!";
                    resultcode = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        var todos = _dbContext.Landray_PaymentHistoryNotProject.Where(t => t.fd_id == item.fd_id).ToList();
                        if (todos.Count == 0)
                        {
                            warnmessage += "【" + item.fd_id + "】,";//修改项在数据库中未找到!
                        }
                        else
                        {
                            foreach (var todo in todos)
                            {
                                _dbContext.Landray_PaymentHistoryNotProject.Update(todo);
                                await _dbContext.SaveChangesAsync();
                            }
                            message += "【" + item.fd_id + "】,";//修改成功
                            resultcode = 0;
                        }
                    }

                }
                warnmessage = warnmessage == "" ? "" : warnmessage.Substring(0, warnmessage.Length - 1) + "修改项在数据库中未找到! ";
                message = message == "" ? "" : message.Substring(0, message.Length - 1) + "修改成功";
                string alertmessage = warnmessage + message;
                resultMessage.Message = errmessage != "" ? errmessage : alertmessage;
                resultMessage.Result = resultcode;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }
        #endregion

        #region 付款用途押金保证金、退回
        /// <summary>
        ///  付款 行程单
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <param name="searchKey">查询条件(默认空，可选参数待定)</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（ContractCode:合同编号,ContractName:合同名称,DeptCode:部门编号,DeptName:部门名称,ProjectCode:项目编号,ProjectName:项目名称,ReceiveAmount:收款金额,WithholdingAmount:扣款金额,Exchange:汇率,ChangeLocalCurrencyAmount:折人民币金额,Currency:币种,ReceivedDate:收款日期,IncidentNo:流程实例号,ProcessName:流程名称,RequestType:申请类型编号(项目收款1, 其他收款2),RequestTypeName:申请类型名称(项目收款, 其他收款),RequestPayCategory:收款类型编号,RequestPayCategoryName:收款类型名称,RequestLoginName:申请人用户名,RequestRealName:申请人姓名,RequestDeptCode:申请人主管部门编号,RequestDeptName:申请人主管部门名称,RequestDate:申请日期,RequestFormNumber:申请表单号,PayCmpName:付款单位名称,PayCmpCode:付款单位编号,PayCmpAddress:付款单位地址,PayCmpBank:付款银行,PayCmpBankAcct:付款银行帐号,PayCmpBankUnionAcct:付款银行行号,BillCategory:押金/保证金类别编号,BillCategoryName:押金/保证金类别名称,GrtLtType:保函类别,ContCode:合同编号,cont_type:合同类别,htmc:合同名称,PaymentAmount:付款金额)</response>
        [HttpGet("GetReturnDepoitInfo")]
        public string GetReturnDepoitInfo(string loginName, string searchKey = "")
        {
            string rlt = "[]";
            try
            {
                string sqlwhere = string.Empty;
                if (!string.IsNullOrEmpty(searchKey))
                {
                    sqlwhere += " AND (t.RequestFormNumber LIKE '%" + searchKey + "%' OR paycmpname LIKE '%" + searchKey + "%' OR CONVERT(VARCHAR,ReceiveAmount) LIKE '%" + searchKey + "%')";
                }
                string sql = @"SELECT  t.*,u.cont_type ,u.htmc,pa.PaymentAmount
                               FROM    view_ReceiveHistory_Deposit_Inbox t
                               LEFT JOIN dbo.View_Peptj_PayContract u ON t.ContCode= u.htbh and ISNULL(t.ContCode,'')!=''
                               LEFT JOIN ( SELECT DISTINCT PaymentLinkFormNumber , ProcessStatus FROM    dbo.TCC_PaymentProcessMultiple
                                           WHERE   ProcessStatus <> 2
                                          ) m ON t.RequestFormNumber = m.PaymentLinkFormNumber
                               LEFT JOIN ( SELECT SUM(PaymentAmount) AS PaymentAmount,PaymentLinkFormNumber FROM dbo.TCC_PaymentProcessMultiple WHERE ProcessStatus <> 2 GROUP BY PaymentLinkFormNumber
                                         ) pa ON t.RequestFormNumber = pa.PaymentLinkFormNumber
                                WHERE  (pa.PaymentAmount < t.ReceiveAmount OR pa.PaymentAmount IS NULL) and t.RequestLoginName = @loginName" + sqlwhere;
                List<SqlParameter> parmas = new List<SqlParameter>();
                parmas.Add(new SqlParameter("loginName", loginName));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
                return rlt;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #endregion


        #region 汇票锁定状态修改
        /// <summary>
        /// 汇票锁定状态修改
        /// </summary>
        /// <param name="Dids">汇票ID(数组)</param>
        /// <param name="LockUserName">锁定人姓名</param>
        /// <param name="LockUserLoginName">锁定人用户名</param>
        /// <param name="IsLock">状态：1、锁定  0、释放</param>
        /// <returns></returns>
        [HttpPost("ModefiedDraftLockStatus")]
        public string ModefiedDraftLockStatus(string[] Dids,string LockUserName,string LockUserLoginName, int IsLock)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                if (Dids.Count() > 0)
                {
                    string sql = "";
                    string ids = "";
                    for(int i=0;i< Dids.Count(); i++)
                    {
                        ids += Dids[i] + ",";
                    }
                    ids = ids.Substring(0, ids.Length - 1);
                    if (IsLock == 1)
                    {
                        string checksql = @"Select * from TCC_DraftInfo where IsLock=2 and  LockUserLoginName!='"+ LockUserLoginName + "' and ID IN (" + ids + ")";
                        DataTable dt= SqlHelper.Query(checksql, BusinessConnectionStringTest, null);
                        if (dt.Rows.Count > 0)
                        {
                            resultMessage.Message = "汇票信息已被其他人锁定";
                            resultMessage.Result = 1;
                            return resultMessage.ToJson();
                        }
                    }
                    
                    switch (IsLock)
                    {
                        case 1:
                            sql = @"UPDATE  dbo.TCC_DraftInfo SET IsLock = 2 , LockUserLoginName = '"+ LockUserLoginName + "' ,LockUserName = '"+ LockUserName + "' FROM    dbo.TCC_DraftInfo  WHERE ID IN (" + ids + ")";
                            break;
                        case 0:
                            sql = @"UPDATE  dbo.TCC_DraftInfo SET IsLock = 0 , LockUserLoginName = '' ,LockUserName = '' FROM    dbo.TCC_DraftInfo  WHERE ID IN (" + ids + ")";
                            break;
                    }
                    
                    SqlHelper.ExecuteSql(sql, BusinessConnectionStringTest, null);
                    resultMessage.Message = "修改成功！";
                    resultMessage.Result = 0;
                }
                else
                {
                    resultMessage.Message = "无修改项";
                    resultMessage.Result = 1;
                }
            }
            catch (System.Exception ex)
            {
                resultMessage.Message = "添加汇票状态错误:" + ex.Message;
                resultMessage.Result = 1;
                throw new Exception(ex.ToString());
            }
            return resultMessage.ToJson();
        }
        #endregion

        #region 汇票信息修改
        /// <summary>
        /// 汇票信息修改
        /// </summary>
        /// <param name="Dids">汇票ID(数组)</param>
        /// <param name="OperateUserName">操作人姓名（出纳）</param>
        /// <param name="OperateLoginUserName">操作人用户名（出纳）)</param>
        /// <param name="ProjectCode">项目号(可以空)</param>
        /// <param name="ProjectName">项目名称(可以空)</param>
        /// <param name="PaymentReceivingCompanyName">收款单位名称</param>
        /// <param name="PaymentReceivingCompanyCode">收款单位编号</param>
        /// <param name="CasierClaimUserName">财务接单会计姓名</param>
        /// <param name="CasierClaimLoginUserName">财务接单会计用户名</param>
        /// <param name="AccountingAuditUserName">财务审核会计姓名</param>
        /// <param name="AccountingAuditLoginUserName">财务审核会计用户名</param>
        /// <param name="SubjectCode">入帐科目编号：录入发票-传成本科目，不传税额科目；不录入发票-借方预付科目</param>
        /// <param name="SubjectName">入帐科目名称</param>
        /// <returns></returns>
        [HttpPost("ModefiedDraftInfo")]
        public string ModefiedDraftInfo(string[] Dids, string OperateUserName, string OperateLoginUserName,string ProjectCode,string ProjectName,string PaymentReceivingCompanyName,string PaymentReceivingCompanyCode,string CasierClaimUserName,string CasierClaimLoginUserName,string AccountingAuditUserName,string AccountingAuditLoginUserName, string SubjectCode,string SubjectName)
        {
            ResultMessage resultMessage = new ResultMessage();
            SqlTransaction tran = SqlHelper.BeginTrans(BusinessConnectionStringTest);
            try
            {
                List<SqlParameter> paras = new List<SqlParameter>();
                if (Dids.Count() > 0)
                {
                    string ids = "";
                    for (int i = 0; i < Dids.Count(); i++)
                    {
                        ids += Dids[i] + ",";
                    }
                    ids = ids.Substring(0, ids.Length - 1);
                    //更新汇票log的状态
                    string strSqlLog = @"INSERT  INTO dbo.TCC_DraftInfo_Log  ( DraftInfoID , OriginalStatus , NewStatus , OriginalChangeDate , NewChangeDate , CreatorUserLoginName , CreatorUserName )
                                     SELECT d.ID, d.STATUS, 4, LastStatusChangeDate, GETDATE(),'" + OperateUserName + @"','" + OperateLoginUserName + @"'
                                     FROM  dbo.TCC_DraftInfo as d
                                     WHERE status IN (1,2) AND ID IN (" + ids + ") GROUP BY d.ID,d.STATUS,LastStatusChangeDate ";

                    SqlHelper.ExecuteSql(strSqlLog, paras, tran);

                    //更新汇票business状态
                    string strSqlBus = @"INSERT INTO dbo.TCC_DraftInfo_Business ( DIID , CreateTime , Description , Operator , OperatorLoginName )
                                         SELECT  d.ID ,GETDATE() ,CONVERT(VARCHAR, GETDATE(), 120) + '，背书操作。'
                                             + CASE WHEN '" + ProjectCode + @"'!='' THEN 
                                                ( SELECT  '项目:" + ProjectCode + " : " + ProjectName + " ；供应商： " + PaymentReceivingCompanyName + ":科目：" + SubjectCode + " :" + SubjectName + @" ；'FOR XML PATH('') )
                                                    ELSE ''
                                                END,
                                        '" + OperateUserName + @"' ,
                                        '" + OperateLoginUserName + @"' 
                                        FROM    ( SELECT    *  FROM dbo.TCC_DraftInfo WHERE  ID IN (" + ids + @")  ) d
                                        GROUP BY d.ID";
                    SqlHelper.ExecuteSql(strSqlBus, paras, tran);
                    //更新汇票信息
                    string strSql = @"
                            UPDATE  TCC_DraftInfo
                            SET     Status = 4,
                                    StatusName = '背书',
                                    EndorseSupplier = @PaymentReceivingCompanyName ,
                                    EndorseSupplierCode = @PaymentReceivingCompanyCode ,
                                    EndorseOperator = @CasierClaimUserName ,
                                    EndorseOperatorLoginName = @CasierClaimLoginUserName ,
                                    EndorseAuditor = @AccountingAuditUserName ,
                                    EndorseAuditorLoginUserName = @AccountingAuditLoginUserName ,
                                    ProjectCode = @ProjectCode ,
                                    ProjectName = @ProjectName ,
                                    --ContractCode = s.ContractCode ,
                                    --ContractName = s.ContractName ,
                                    operator = '" + OperateUserName + @"' ,
                                    OperateLoginUserName = '" + OperateLoginUserName + @"' ,
                                    OperatorTime = GETDATE(),
                                    LastStatusChangeDate = GETDATE(),
                                    IsLock = 0
                            WHERE status IN (1,2)  AND ID IN (" + ids + ")";
                    paras.Add(new SqlParameter("PaymentReceivingCompanyName", PaymentReceivingCompanyName));
                    paras.Add(new SqlParameter("PaymentReceivingCompanyCode", PaymentReceivingCompanyCode));
                    paras.Add(new SqlParameter("CasierClaimUserName", CasierClaimUserName));
                    paras.Add(new SqlParameter("CasierClaimLoginUserName", CasierClaimLoginUserName));
                    paras.Add(new SqlParameter("AccountingAuditUserName", AccountingAuditUserName));
                    paras.Add(new SqlParameter("AccountingAuditLoginUserName", AccountingAuditLoginUserName));
                    paras.Add(new SqlParameter("ProjectCode", string.IsNullOrEmpty(ProjectCode) ? "" : ProjectCode));
                    paras.Add(new SqlParameter("ProjectName", string.IsNullOrEmpty(ProjectName) ? "" : ProjectName));

                    SqlHelper.ExecuteSql(strSql, paras, tran);

                    tran.Commit();
                    resultMessage.Message = "修改成功！";
                    resultMessage.Result = 0;
                }
                else
                {
                    resultMessage.Message = "无修改项";
                    resultMessage.Result = 1;
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                resultMessage.Message = "修改汇票信息错误:" + ex.Message;
                resultMessage.Result = 1;
                throw ex;
            }
            return resultMessage.ToJson();
        }
        #endregion

        #region 查询汇票信息进行修改
        /// <summary>
        /// 查询汇票信息进行修改
        /// </summary>
        /// <param name="ids">汇票ID (逗号隔开)</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">DraftType:汇票种类,Status:票据状态（1取得（收款）、2开据、3退票、4背书（付款）、5托收、6贴现、7质押、8转应收）,StatusName:状态名称,DraftCode:汇票编号,DrawerDate:出票日期,DueDate:汇票到期日（设置提醒日期5天）,DueDay:付款期限,DrawerPlace:出票地,DrawerName:出票人全称,DrawerAccounts:出票人帐号,PutawayDate:入库日期,AcceptAgreementNumber:承兑协议编号,Drawee:付款人,PayingBankName:付款行全称,PayingBankNumber:付款行行号,PayingBankAddress:付款行地址,DraftAmount:汇票金额（小写）,DraftAmountChineseNumeral:汇票金额（大写）,DraftSource:汇票来源（1开据、2收款）,Currency:货币,ExchangeRate:汇率,Acceptor:承兑人,ProjectType:项目类型，１项目；２非项目,ProjectCode:项目代号,ProjectName:项目名称,ContractCode:合同代码,ContractName:合同名称,DepartName:收款人全称,PayeeName:收款人全称,PayeeAccounts:收款人帐号,PayeeBank:收款人开户行  ,PayeeCode:收款人编号,RecourseType:带追索权,SourceName:来源方全称,VoucherNumber:凭证号,CreationVoucherDate:生成凭证号,VoucherAbstract:凭证摘要,EndorseSupplier:背书供应商名称,EndorseSupplierCode:背书供应商名称,EndorseClientele:背书客户名称,EndorseAuditor:背书审核人,EndorseAuditorLoginUserName:背书审核人登陆名,Operator:操作人,OperateLoginUserName:操作人登陆名,SubmitDepartName:提交单位,SubmitDepartCode:提交单位,Submitter:提交人,SubmitLoginUserName:提效人登陆名,SubmitDate:提交时间,DiscountAmount:贴现金额,DiscountRate:贴现利率,DiscountCharges:贴率,IsPayment:是否付款 1付,2未付,IsLock:是否锁定,LockUserLoginName:锁定人登陆人,LockUserName:锁定人,CreatorUserLoginName:创建人用户名,CreatorUserName:创建人姓名,CreateDate:创建时间,LastStatusChangeDate:状态最后修改时间,FundsProjectCode:来源方项目编号,FundsProjectName:来源方项目名,SubjectCode:入帐凭证编号,EndorseOperator:背书人操作人,EndorseOperatorLoginName:背书人操作人登陆名,OperatorTime:操作人时间,PaymentTime:付款时间,PaymentOperator:付款操作人,PaymentOperatorLoginName:付款操作登陆人,OperateSubjectCode:操作科目编号,OperateSubjectName:操作科目名称,VOUCHERID:凭证main表主键,PaymentDepositRate:保证金比率,PaymentDepositSubjectCode:保证金科目,PaymentDepositSubjectName:保证金科目,PaymentSubjectCode:付款费用科目,PaymentSubjectName:付款费用科目,CollectionDate:托收日期,CollectionAmount:托收金额,CollectionSubjectCode:托收科目,CollectionSubjectName:托收科目a,DiscountBank:贴现银行,DiscountDay:贴现天数,DiscountDate:贴现日期,DiscountSubjectCode:贴现科目,DiscountSubjectName:贴现科目,PartBID:签定方,PartBName:签定方,DeleteModefier:删除人,DeleteDate:删除时间</response>
        [HttpGet("GetDraftInfo")]
        public string GetDraftInfo(string ids)
        {
            string rlt = "[]";
            try
            {
                string sql = "";
                sql = @"SELECT ID
                        DraftType,Status,StatusName,DraftCode,DrawerDate,DueDate,DueDay,DrawerPlace,DrawerName,DrawerAccounts,PutawayDate,
                        AcceptAgreementNumber,Drawee,PayingBankName,PayingBankNumber,PayingBankAddress,DraftAmount,DraftAmountChineseNumeral,
                        DraftSource,Currency,ExchangeRate,Acceptor,ProjectType,ProjectCode,ProjectName,ContractCode,ContractName,DepartName,
                        PayeeName,PayeeAccounts,PayeeBank,PayeeCode,RecourseType,SourceName,VoucherNumber,CreationVoucherDate,VoucherAbstract,
                        EndorseSupplier,EndorseSupplierCode,EndorseClientele,EndorseAuditor,EndorseAuditorLoginUserName,Operator,OperateLoginUserName,
                        SubmitDepartName,SubmitDepartCode,Submitter,SubmitLoginUserName,SubmitDate,DiscountAmount,DiscountRate,DiscountCharges,
                        IsPayment,IsLock,LockUserLoginName,LockUserName,CreatorUserLoginName,CreatorUserName,CreateDate,LastStatusChangeDate,
                        FundsProjectCode,FundsProjectName,SubjectCode,EndorseOperator,EndorseOperatorLoginName,OperatorTime,PaymentTime,PaymentOperator,
                        PaymentOperatorLoginName,OperateSubjectCode,OperateSubjectName,VOUCHERID,PaymentDepositRate,PaymentDepositSubjectCode,
                        PaymentDepositSubjectName,PaymentSubjectCode,PaymentSubjectName,CollectionDate,CollectionAmount,CollectionSubjectCode,
                        CollectionSubjectName,DiscountBank,DiscountDay,DiscountDate,DiscountSubjectCode,DiscountSubjectName,PartBID,PartBName,DeleteModefier,DeleteDate
                        FROM dbo.TCC_DraftInfo 
                        WHERE ID IN (" + ids + ")";
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionStringTest, null);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }

            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return rlt;
        }
        #endregion

        #region 押金/保证金收回
        /// <summary>
        /// 提供已收回押金/保证金信息
        /// </summary>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">ProcessName:收款确认流程名称,Incident:收款确认流程实例号,AccountingTime:收款确认流程入账时间,Name:收款类型,SourceFormNumber:关联付款单号</response>
        [HttpGet("GetPaymentMarginInfo")]
        public string GetPaymentMarginInfo()
        {
            string rlt = "[]";
            try
            {
                string sql = "";
                sql = @"SELECT  ISNULL(v.ProcessName,'') AS ProcessName ,
                                ISNULL(v.Incident,0) AS Incident ,
                                ISNULL(v.AccountingTime,'') AS AccountingTime ,
                                v1.Name ,
                                a.SourceFormNumber
                    FROM    dbo.FinanceRequestProcess AS a
                            LEFT JOIN ( SELECT  a.ProcessName ,
                                                a.Incident ,
                                                a.ProcessFinishDate ,
                                                AccountingTime ,
                                                b.ApplyFormNumber
                                        FROM    dbo.FinanceRequestProcessOfCashier
                                                AS a
                                                LEFT JOIN dbo.FinanceRequestProcessOfCashierContract
                                                AS b ON a.ProcessName = b.ProcessName
                                                        AND a.Incident = b.Incident
                                      ) AS v ON a.Request_FormNumber = v.ApplyFormNumber
                            LEFT JOIN ( SELECT  *
                                        FROM    dbo.TCC_BasicData
                                        WHERE   Flag = 'NoProjectPayment'
                                      ) AS v1 ON a.RequestPayCategory = v1.Code
                    WHERE   RequestType = 2
                            AND ProcessStatus = 1
                            AND ISNULL(a.SourceFormNumber,'')<>''
                ";
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionStringTest, null);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }

            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return rlt;
        }
        #endregion
    }
}
