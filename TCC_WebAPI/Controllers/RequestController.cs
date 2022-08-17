using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TCC_CoreApi.Common.Tool;
using TCC_CoreApi.Model;
using TCC_CoreApi.Model.entity;

namespace TCC_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public RequestController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// 获取合同的历史收费金额
        /// </summary>
        /// <param name="ContractCode">票号(合同编号) </param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（Al_Amount:合同已收费金额）</response>
        [HttpGet("GetHistoryDatatofContanct")]
        public string GetHistoryDatatofContanct(string ContractCode)
        {
            string rlt = "[]";
            try
            {
                string res = string.Empty;
                string sql = string.Empty;
                string sqltemp = string.Empty;
                sql = "SELECT ISNULL(SUM(Amount),0) as Al_Amount FROM dbo.View_ProjectInfo_Finance_ReceivablesofContract WHERE ContractCode=@ContractCode";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@ContractCode", ContractCode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, paras);
                rlt = JsonHelper.SerializeObject(dt);
            }
            catch (System.Exception ee)
            {
                throw new Exception(ee.ToString());
            }
            return rlt;
        }



        /// <summary>
        /// 获取项目收费信息
        /// </summary>
        /// <param name="ProjectCode">项目号 </param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（Total_OC:项目收款合同总额,RAmount_OC:已收费额,RPer_OC已收费百分比)）</response>
        [HttpGet("GetProjectReceivableInfo")]
        public string GetProjectReceivablesInfoByDataTable(string ProjectCode)
        {
            string rlt = "[]";
            try
            {
                string res = string.Empty;
                string sql = @"select * from View_ProjectInfo_Finance_Receivables where proid = '" + ProjectCode + "'";
                List<SqlParameter> paras = new List<SqlParameter>();
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, paras);
                rlt = JsonHelper.SerializeObject(dt);
            }
            catch (System.Exception ee)
            {
                throw new Exception(ee.ToString());
            }
            return rlt;
        }

        /// <summary>
        /// 收款流程的收押金保证金扣款代收发票信息
        /// </summary>
        /// <param name="LoginName">用户名 </param>
        /// <param name="Currency">币种 </param>
        /// <param name="DeptCode">部门编号 </param>
        /// <param name="searchKey">查询条件(默认空，可选参数待定) </param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串（rownumber:序号,ApplyLoginName:申请人用户名,ApplyRealName:申请人姓名,ExpenseTypeCode:付款用途编号,ExpenseTypeName:付款用途名称,PayInfo_FormNumber:流程表单号,PayInfo_ReceiveCpmpany:收款单位名称,PaymentReceivingCompanyCode:收款单位编号,FinancePaymentTotal:扣款接,Rate:汇率,FinanceChangeLocalCurrencyAmount:折人民币金额,IsSupplierOrCustomer:供应商1/客户2,FinanceCurrency:币种)）</response>
        [HttpGet("GetDepoitInfo")]
        public string GetDepoitInfo(string LoginName,string Currency,string DeptCode,string searchKey = "")
        {
            string rlt = "[]";
            try
            {
                string strwhere = string.Empty;
                if (!string.IsNullOrEmpty(searchKey))
                {
                    strwhere = " AND (RequestFormNumber LIKE '%" + searchKey + "%' OR PaymentReceivingCompanyName LIKE '%" + searchKey + "%' OR a.FinancePaymentTotal LIKE '%" + searchKey + "%')";
                }

                string res = string.Empty;
                #region sql 语句
                string sql = @" WITH ate AS (
                                     SELECT a.R_ID ,
                                            d.ProcessName ,
                                            d.Incident ,
                                            d.Request_Date ,
                                            d.Request_RealName  AS RequestRealName,
                                            d.Request_LoginName  AS RequestLoginName,
                                            d.Request_FormNumber AS RequestFormNumber,
                                            d.PayCmpCode AS PaymentReceivingCompanyCode ,
                                            d.PayCmpName AS PaymentReceivingCompanyName ,
                                            230 AS PaymentApplicationCode ,
                                            '收押金/保证金' AS PaymentApplicationName ,
                                            NULL AS PaymentDescription ,
                                            d.DonateDK AS FinancePaymentTotal ,
                                            c.Currency AS FinanceCurrency ,
                                            ISNULL(b.Rate, 1) AS FinanceExchange ,
                                            d.DonateDK * ISNULL(b.Rate, 1) AS FinanceChangeLocalCurrencyAmount ,
                                            d.Request_DeptCode AS  PaymentVoucherDeptCode,
                                            d.Request_DeptName AS PaymentVoucherDeptName,
                                            2 AS IsSupplierOrCustomer ,
                                            YEAR(d.Request_Date) AS RequestYear ,
                                            MONTH(d.Request_Date) AS RequestQuarter
                                     FROM   dbo.TCC_ReceivablesRecord_Deposit (NOLOCK) AS a
                                            LEFT JOIN dbo.FinanceRequestProcessOfCashier (NOLOCK) AS b ON a.R_ID = b.ID
                                            LEFT JOIN dbo.FinanceRequestProcessOfCashierContract (NOLOCK) AS c ON b.Incident = c.Incident
                                                                                                  AND b.ProcessName = c.ProcessName
                                            LEFT JOIN dbo.FinanceRequestProcess (NOLOCK) AS d ON c.ApplyFormNumber = d.Request_FormNumber
                                            LEFT JOIN ( SELECT  DISTINCT
                                                                ProcessName ,
                                                                Incident
                                                        FROM    dbo.FinanceRequestProcessBillsNoProject (NOLOCK)
                                                      ) AS fpb ON d.ProcessName = fpb.ProcessName
                                                                  AND d.Incident = fpb.Incident
                                     WHERE  ISNULL(d.DonateDK, 0) > 0
                                            AND ISNULL(fpb.Incident, 0) = 0
                                     )       
                                     SELECT  ROW_NUMBER() OVER (ORDER BY a.RequestFormNumber desc) AS rownumber,
                                           a.RequestLoginName AS ApplyLoginName,a.RequestRealName AS ApplyRealName,
                                           a.PaymentApplicationCode as ExpenseTypeCode,a.PaymentApplicationName as ExpenseTypeName,
                                           a.RequestFormNumber AS PayInfo_FormNumber,a.PaymentReceivingCompanyName AS PayInfo_ReceiveCpmpany,
                                           a.PaymentReceivingCompanyCode AS PaymentReceivingCompanyCode,
                                           a.FinancePaymentTotal as FinancePaymentTotal,a.FinanceExchange as Rate,
                                           a.FinanceChangeLocalCurrencyAmount as FinanceChangeLocalCurrencyAmount,a.IsSupplierOrCustomer,
                                           FinanceCurrency
                                    FROM ate AS a 
                                    LEFT JOIN ( SELECT DISTINCT ProcessName,Incident,PayInfo_FormNumber FROM view_GeneralExpensesPayInfo)  AS gre ON a.RequestFormNumber = gre.PayInfo_FormNumber
                                    WHERE ISNULL(gre.ProcessName,'')='' 
                                    AND ( a.RequestLoginName = '" + LoginName + "'  OR PaymentVoucherDeptCode = '" + DeptCode + "' ) AND FinanceCurrency = '" + Currency + "'" + strwhere;
                #endregion
                List<SqlParameter> paras = new List<SqlParameter>();
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, null);
                rlt = JsonHelper.SerializeObject(dt);
            }
            catch (System.Exception ee)
            {
                throw new Exception(ee.ToString());
            }
            return rlt;
        }

    }
}
