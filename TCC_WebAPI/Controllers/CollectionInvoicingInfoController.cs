using Microsoft.AspNetCore.Mvc;
using TCC_CoreApi.Model;
using TCC_CoreApi.Common.Tool;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using TCC_CoreApi.Model.entity;
using System.Linq;

namespace TCC_WebAPI.Controllers
{
    [Route("api/CollectionInv")]
    [ApiController]
    public class CollectionInvoicingInfoController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public CollectionInvoicingInfoController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        #region 开票相关
        /// <summary>
        /// 已收费额、已收费比例 查询
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（proid:项目号,project_name:项目名称,Total:项目合同总额,RAmount_CNY:已收费额,RPer_CNY:已收费比例（%））</response>
        [HttpGet("GetCollectionInfoByPro")]
        public string GetCollectionInfoByPro(string ProjectCode)
        {
            string rlt = "";
            try
            {
                Logger.Info("GetCollectionInfoByPro-"+ ProjectCode);
                string sql = @"select proid,project_name,RAmount_CNY,RPer_CNY 
                               from View_ProjectInfo_Finance_Receivables_CNY 
                               WHERE   proid = @ProjectCode";
                List<SqlParameter> parmas = new List<SqlParameter>();
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
                Logger.Info("CollectionInvoicingInfoController-已收费额、已收费比例 查询(GetCollectionInfoByPro)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// 合同累计开票额(包含正在进行中的数据)
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="OwnerCode">业主编号</param>
        /// <param name="fd_id">项目号</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（BillAmount:合同累计开票额(包含正在进行中的数据)）</response>
        [HttpGet("GetReBillAmountInfo")]
        public string GetReBillAmountInfo(string ProjectCode, string OwnerCode, string fd_id)
        {
            string rlt = "";
            try
            {
                //合同累计开票额(包含正在进行中的数据)
                string sql = @"SELECT ISNULL(SUM(ISNULL(RenInvoicesAmount,0)),0) AS BillAmount 
                           FROM view_Finance_InvoicesInfo 
                           WHERE ProjectCode=@projectcode AND ISNULL(OwnerCode,'')=@OwerCode 
                                 AND NOT(fd_id=@fd_id)";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@projectcode", ProjectCode));
                paras.Add(new SqlParameter("@OwerCode", OwnerCode));
                paras.Add(new SqlParameter("@fd_id", fd_id));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, paras);
                rlt = JsonHelper.SerializeObject(dt);
            }
            catch (System.Exception ee)
            {
                Logger.Info("CollectionInvoicingInfoController-合同累计开票额(包含正在进行中的数据)(GetReBillAmountInfo)----报错" + ee.ToString());
                throw new Exception(ee.ToString());
            }
            return rlt;
        }

        /// <summary>
        /// 已开票金额 查询
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="OwnerCode">业主编号</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（ProjectCode:项目号,OwnerCode:业主编号,RenInvoicesAmount:已开票金额）</response>
        [HttpGet("GetInvcoingByPro")]
        public string GetInvcoingByPro(string ProjectCode,string OwnerCode)
        {
            string rlt = "";
            try
            {
                string sql = @"SELECT  ProjectCode,OwnerCode,SUM(ISNULL(RenInvoicesAmount,0)) AS RenInvoicesAmount
                            FROM    dbo.View_Finance_RenInvoices
                            WHERE   ProjectCode = @ProjectCode
                                    AND OwnerCode = @OwnerCode
                            GROUP BY ProjectCode,OwnerCode";
                List<SqlParameter> parmas = new List<SqlParameter>();
                parmas.Add(new SqlParameter("ProjectCode", ProjectCode));
                parmas.Add(new SqlParameter("OwnerCode", OwnerCode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("CollectionInvoicingInfoController-已开票金额 查询(GetInvcoingByPro)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }
            return rlt;
        }

        /// <summary>
        /// 历史开票信息查询
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="OwnerCode">业主编号</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">RenInvoiceDate:开票时间,RequestRealName:申请人,RecAmount:收款金额,RenInvoicesAmount:开出发票金额,taxrate:税率,EquipmentParagraph:设备材料采购款,ConstructionParagraph:施工工程款,DesignParagraph:设计款,ServicesParagraph:咨询及服务,RenBillsAmount:开出收据金额,PayBankAccount:付款单位帐号,PayCompanyName:付款单位名称,RecActualAmount:实收金额,
        /// TransactorRealName:经办人,BillStatus:状态(0:未开；1:已开)</response>
        [HttpGet("GetInvcoingHistory")]
        public string GetInvcoingHistory(string ProjectCode, string OwnerCode)
        {
            string rlt = "";
            try
            {
                string sql = @"SELECT  RenInvoiceDate,RequestRealName,RecAmount,RenInvoicesAmount,taxrate,EquipmentParagraph,ConstructionParagraph,
                                       DesignParagraph,ServicesParagraph,RenBillsAmount,PayBankAccount,PayCompanyName,RecActualAmount,
                                       TransactorRealName,BillStatus
                               FROM    dbo.View_Finance_RenInvoices
                               WHERE   ProjectCode = @ProjectCode
                                       AND OwnerCode = @OwnerCode
                               ";
                List<SqlParameter> parmas = new List<SqlParameter>();
                parmas.Add(new SqlParameter("ProjectCode", ProjectCode));
                parmas.Add(new SqlParameter("OwnerCode", OwnerCode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("CollectionInvoicingInfoController-历史开票信息查询(GetInvcoingHistory)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }
            return rlt;
        }

        /// <summary>
        /// 已收款金额、累计已开出发票金额、累计已开出收据金额
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="OwnerCode">业主编号</param>
        /// <param name="BillCategory">开票类型</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（ProjectCode:项目号,ReceiveAmount:已收款金额,AggregateRenInvoiceAmount:累计已开出发票金额,AggregateRenReceiptAmount:累计已开出收据金额）</response>
        [HttpGet("GetReceInfoByProandCate")]
        public string GetReceInfoByProandCate(string ProjectCode, string OwnerCode, string BillCategory)
        {
            string rlt = "[]";
            try
            {
                string sql = string.Empty;
                int Flag;
                string sqlwhere = " AND 1=1";
                switch (BillCategory)
                {
                    case "设备材料采购款":
                        Flag = 5;
                        sqlwhere += " AND ISNULL(EquipmentParagraph,0)!=0 ";
                        break;
                    case "施工工程款":
                        Flag = 1;
                        sqlwhere += " AND ISNULL(ConstructionParagraph,0)!=0 ";
                        break;
                    case "设计款":
                        Flag = 2;
                        sqlwhere += " AND ISNULL(DesignParagraph,0)!=0 ";
                        break;
                    case "技术服务费":
                        Flag = 3;
                        sqlwhere += " AND ISNULL(ServicesParagraph,0)!=0 ";
                        break;
                    default:
                        Flag = 0;
                        break;
                }
                if (Flag == 0)
                {
                    return rlt;
                }
                sql = @"
                    ;with ate as (
                        SELECT  ProjectCode,SUM(RenInvoicesAmount) AS AggregateRenInvoiceAmount,SUM(RenBillsAmount) AS AggregateRenReceiptAmount
                               FROM    dbo.View_Finance_RenInvoices
                               WHERE   ProjectCode = @ProjectCode
                                       AND OwnerCode = @OwnerCode
                               " + sqlwhere + @"
                               GROUP BY ProjectCode
                    )
                    SELECT TT.ProjectCode,TT.ReceiveAmount,RR.AggregateRenInvoiceAmount,RR.AggregateRenReceiptAmount
                    FROM (
                        SELECT a.xmbh as ProjectCode,ISNULL(SUM(a.skje),0) AS ReceiveAmount 
                        FROM dbo.View_Finance_Receive_History AS a 
                        LEFT JOIN dbo.TCC_ReceivablesRecord AS b ON a.id=b.Id
                        LEFT JOIN  dbo.FinanceRequestProcess AS c ON b.RequestFormNumber=c.Request_FormNumber
                        WHERE   a.xmbh=@ProjectCode AND	 c.RequestPayCategory=@category
                        GROUP BY a.xmbh
                    ) AS TT
                    LEFT JOIN ate AS RR ON TT.ProjectCode=RR.ProjectCode
                    ";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@ProjectCode", ProjectCode));
                paras.Add(new SqlParameter("@OwnerCode", OwnerCode));
                paras.Add(new SqlParameter("@category", Flag));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, paras);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("CollectionInvoicingInfoController-已收款金额、累计已开出发票金额、累计已开出收据金额(GetReceInfoByProandCate)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }
            return rlt;
        }

        #endregion

        #region 预缴税
        /// <summary>
        /// 预缴税选择收票信息
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="RateCode">税率编号 9% 对应15</param>
        /// <param name="searchKey">查询Value</param>
        /// <param name="fd_id">主表ID</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">Sprocessname:收票流程名称,Sincident:收票实例号,Incident:流程实例号,Sformnumber:表单号,BillCategoryValue：票据类型编号，BillCategoryText:票据类型名称,BillCode:发票编号,InvoiceDate:开票日期,BillAmount:票额,BillTaxAmount:税额,Amount:加税合计金额,TaxRateCode:税率编号,TaxRateText:税率名称,ContanctCode:合同号,SupplierCode:供应商编号,SupplierName:供应商名称,DeductibleAmount;抵扣金额,ReDeductibleAmount:剩余抵扣金额</response>
        [HttpGet("GetReceiptInfo")]
        public string GetReceiptInfo(string ProjectCode,string RateCode, string searchKey="",string fd_id="")
        {
            string rlt = "";
            try
            {
                //TODO:这里还要接收蓝领那边选择的预缴税
                string sqlwhere = string.Empty;
                if (!string.IsNullOrEmpty(searchKey))
                {
                    sqlwhere = @" AND 1=1 AND (a.BillCategoryText LIKE '%" + searchKey + "%' OR a.BillCode LIKE '%" + searchKey + "%' OR a.SupplierName LIKE '%" + searchKey + "%' OR a.ContanctCode LIKE '%" + searchKey + "%')";
                }

                if (!string.IsNullOrEmpty(RateCode))
                {
                    sqlwhere = @" AND a.TaxRateCode='"+ RateCode + "'";
                } 
                string sql = @";WITH ATE AS (
		                            SELECT  BillCode,SUM(DeductibleAmount) AS DeductibleAmount FROM (
                                        SELECT  a.BillCode,ISNULL(DeductibleAmount,0) AS DeductibleAmount
                                        FROM    TCC_Invoices_Rendered_Recevelist AS a
                                        LEFT  JOIN dbo.TCC_Invoices_Rendered AS b ON a.PID = b.ID
                                        WHERE   ISNULL(b.ProcessStatus,0) <> 2  AND ISNULL(a.PID,0)<>0 
                                        UNION ALL
                                        SELECT  BillCode,ISNULL(DeductibleAmount,0) AS DeductibleAmount 
                                        FROM dbo.Landray_Rendered_Recevelist
                                        WHERE ISNULL(LyID,'')!='"+ fd_id + @"'
                                    ) AS tt GROUP BY BillCode
                                ),
                                BillsManagement as (
                                    SELECT  ProcessName,Incident,BillSource,FormNumber,BillCategoryValue,BillCategoryText,BillCode,InvoiceDate,BillAmount,BillTaxAmount,Amount,TaxRateCode,TaxRateText, 
                                            ContanctCode,SupplierCode,SupplierName,PaymentCategory,DeleteFlag,ProjectCode
                                    FROM TCC_BillsManagement
                                    WHERE BillSource = '收取'
                                    UNION ALL
                                    SELECT  ProcessName,Incident,BillSource,FormNumber,BillCategoryValue,BillCategoryText,BillCode,InvoiceDate,BillAmount,BillTaxAmount,Amount,TaxRateCode,TaxRateText, 
                                            ContanctCode,SupplierCode,SupplierName,PaymentCategory,DeleteFlag,ProjectCode
                                    FROM Landray_BillsManagement
                                    WHERE BillSource = '收取' AND Flag=1
                            )
                            SELECT	 a.ProcessName AS Sprocessname,a.Incident AS Sincident,a.FormNumber AS Sformnumber,
                                     a.BillCategoryValue,a.BillCategoryText,a.BillCode,a.InvoiceDate,a.BillAmount,a.BillTaxAmount,
                                     a.Amount,a.TaxRateCode,a.TaxRateText,a.ContanctCode,a.SupplierCode,a.SupplierName,
                                     ISNULL(v.DeductibleAmount,0) AS DeductibleAmount,
                                     (ISNULL(a.Amount,0)-   ISNULL(v.DeductibleAmount,0))  AS ReDeductibleAmount
                            FROM    BillsManagement AS a
                            LEFT JOIN ATE  AS v ON a.BillCode=v.BillCode
                            WHERE   BillSource = '收取'
                                    AND (BillCategoryValue=1 OR BillCategoryValue=2)
                                    AND (PaymentCategory='安装工程费' OR PaymentCategory='土建工程费' OR PaymentCategory='其他工程费')
                                    AND ISNULL(DeleteFlag, 0) = 0
                                    AND ProjectCode=@ProjectCode
                                    AND (ISNULL(a.Amount,0)-ISNULL(v.DeductibleAmount,0))>0 " + sqlwhere;
                sql = sql + " ORDER BY	 ISNULL(v.DeductibleAmount,0) DESC ";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@projectcode", ProjectCode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, paras);

                DataRow row = dt.NewRow();
                row["Sprocessname"] = "";
                row["Sincident"] = 0;
                row["Sformnumber"] = "";
                row["BillCategoryValue"] = "-1";
                row["BillCategoryText"] = "全额预缴";
                row["BillCode"] = "";
                row["InvoiceDate"] = "1900-01-01";
                row["BillAmount"] = 0;
                row["BillTaxAmount"] = 0;
                row["Amount"] = 0;
                row["TaxRateCode"] = "";
                row["TaxRateText"] = "";
                row["ContanctCode"] = "";
                row["SupplierCode"] = "";
                row["SupplierName"] = "";
                row["DeductibleAmount"] = 0;
                row["ReDeductibleAmount"] = 0;
                dt.Rows.InsertAt(row, 0);
                ;
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

        /// <summary>
        /// 预缴税历史记录查询--用于测试，开票流程上线后需提供初始化记录
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">ID:主键,ProcessName:流程名称,Incident:流程实例号,FormNumber:表单号,InvoiceTotalAmount:销售额,ApplyRateText预征率（%）,ApprovalDate:报税时间, AmountDeducted:扣除金额,DiffAdvanceTax:预征税基数,TaxationDate:报税所属时间,PreTax:预征税额</response>
        [HttpGet("GetWithholdingTaxHistory")]
        public string GetWithholdingTaxHistory(string ProjectCode)
        {
            string rlt = "";
            try
            {
                //TODO:这里还要接收蓝领那边选择的预缴税
                string sql = @" SELECT a.ID,a.ProcessName,a.Incident,a.FormNumber,a.InvoiceTotalAmount,a.ApplyRateText+'%' AS ApplyRateText,a.ApprovalDate,
	                               a.AmountDeducted,a.DiffAdvanceTax,a.TaxationStart+'至'+a.TaxationEnd AS TaxationDate,
	                               (InvoiceTotalAmount - AmountDeducted) / (1 + CONVERT(DECIMAL(18,2),ApplyRateText) / 100) * CONVERT(DECIMAL(18,2),ApplyRateText) / 100 AS PreTax 
                            FROM    dbo.TCC_Invoices_Rendered AS a
                            WHERE a.ProcessStatus=1 AND a.ProjectCategory='工程总承包项目'   AND a.RenderedCategoryText='施工工程款'
	                              AND a.ProjectCode=@projectcode AND ISNULL(AmountDeducted,0)>0
                            ";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@projectcode", ProjectCode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, paras);
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


        /// <summary>
        /// 新增预缴税记录
        /// </summary>
        /// <param name="items">预缴税明细</param>
        /// <returns></returns>
        [HttpPost("TaxForCreate")]
        public async Task<string> TaxForCreate([FromBody] List<LandrayRenderedRecevelist> items)
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
                    //删除已新增数据
                    var DeleteDtos = _dbContext.Landray_Rendered_Recevelist.Where(t => t.LyID == items[0].LyID).ToList();
                    if (DeleteDtos.Count > 0)
                    {
                        foreach (var DeleteDto in DeleteDtos)
                        {
                            Logger.Info("CreateKBillInfo-" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 删除数据【" + DeleteDto.LyID + "】");
                            _dbContext.Landray_Rendered_Recevelist.Remove(DeleteDto);
                            await _dbContext.SaveChangesAsync();
                        }
                    }

                    foreach (var item in items)
                    {

                        item.Flag = 0;
                        _dbContext.Landray_Rendered_Recevelist.Add(item);
                        await _dbContext.SaveChangesAsync();
                    }
                    resultMessage.Message = "添加成功！";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }

        /// <summary>
        /// 修改预缴税记录
        /// </summary>
        /// <param name="items">修改预缴税明细(Flag 0:流程中,1:已完成 ,2:已撤销)</param>
        /// <returns></returns>
        [HttpPost("TaxForModefied")]
        public async Task<string> TaxForModefied(List<LandrayRenderedRecevelist> items)
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
                        var todos = _dbContext.Landray_Rendered_Recevelist.Where(t => t.LyID == item.LyID).Where(t => t.fd_id == item.fd_id).ToList();
                        if (todos.Count == 0)
                        {
                            warnmessage += "【" + item.fd_id + "】,";//修改项在数据库中未找到!
                        }
                        else
                        {
                            foreach (var todo in todos)
                            {
                                todo.Sprocessname = item.Sprocessname;
                                todo.Sincident = item.Sincident;
                                todo.Sformnumber = item.Sformnumber;
                                todo.BillCategoryValue = item.BillCategoryValue;
                                todo.BillCategoryText = item.BillCategoryText;
                                todo.BillCode = item.BillCode;
                                todo.InvoiceDate = item.InvoiceDate;
                                todo.BillAmount = item.BillAmount;
                                todo.BillTaxAmount = item.BillTaxAmount;
                                todo.Amount = item.Amount;
                                todo.TaxRateCode = item.TaxRateCode;
                                todo.TaxRateText = item.TaxRateText;
                                todo.ContanctCode = item.ContanctCode;
                                todo.SupplierCode = item.SupplierCode;
                                todo.SupplierCode = item.SupplierCode;
                                todo.DeductibleAmount = item.DeductibleAmount;
                                todo.ReDeductibleAmount = item.ReDeductibleAmount;
                                todo.ProofCode = item.ProofCode;
                                todo.Flag = item.Flag;

                                _dbContext.Landray_Rendered_Recevelist.Update(todo);
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


        /// <summary>
        /// 新增预缴税台账记录--最后一步执行
        /// </summary>
        /// <param name="fd_id">开出发票申请主表ID</param>
        /// <returns></returns>
        [HttpGet("InstallmentsForCreate")]
        public string InstallmentsForCreate(string fd_id)
        {
            int rlt = 0;
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@fd_id", fd_id));
                ds = SqlHelper.ExeProcedure(BusinessConnectionStringTest, paras, "Pro_InsertInstallments_Rendered_Landray");
                rlt = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return rlt > 0 ? "新增成功" : "新增失败";
        }
        #endregion

        /// <summary>
        /// 验证开出发票票据编号是否存在
        /// </summary>
        /// <param name="BillCode">票号(数组)</param>
        /// <param name="InvoiceCategoryText">票据类型(名称)</param>
        /// <param name="fd_id">蓝领外键</param>
        [HttpPost("IsExistRendered")]
        public string IsExistRendered([FromBody] string[] BillCode, string InvoiceCategoryText, string fd_id)
        {
            string rlt = "[]";
            string[] ExistBillCode;

            string strBill = "";
            for (int i = 0; i < BillCode.Length; i++)
            {
                strBill += ("select '" + BillCode[i] + "' as BillCode, '" + InvoiceCategoryText + "' as CVText UNION ");
            }

            strBill = strBill.Substring(0, strBill.Length - 6);

            string strSql = "";
            strSql = @" SELECT DISTINCT t.BillCode FROM View_BillsInfo_Rendered t  INNER JOIN (";
            strSql += strBill;
            strSql += @") u ON t.BillCode = u.BillCode AND t.InvoiceCategoryText = CVText ";
            strSql += @" WHERE NOT(ISNULL(t.fd_id,'')=@fd_id) ";

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@fd_id", fd_id));
            DataTable dt = SqlHelper.Query(strSql, BusinessConnectionString, paras);

            ExistBillCode = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ExistBillCode[i] = dt.Rows[i]["BillCode"].ToString();
            }
            if (ExistBillCode.Count() > 0)
            {
                rlt = ExistBillCode.ToJson();
            }
            return rlt;
        }

        

    }
}
