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
    [Route("api/SinglePool")]
    [ApiController]
    public class IReceivedBillsController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public IReceivedBillsController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 验证收取发票票据编号是否存在
        /// </summary>
        /// <param name="BillsInfo">票号(数组 示例：["票号1^发票代码1^票据类型1","票号2^发票代码2^票据类型2"]) </param>
        /// <param name="fd_id">蓝领外键</param>
        [HttpPost("IsExistReceived")]
        public string IsExistReceived([FromBody] string[] BillsInfo, string fd_id)
        {
            string rlt = "[]";
            string[] ExistBillCode;

            string strBill = "";
            for (int i = 0; i < BillsInfo.Length; i++)
            {
                string[] billlist = BillsInfo[i].Split('^');
                strBill += ("select '" + billlist[0] + "' as BillCode,'" + billlist[1] + "' AS InvoiceCode,'" + billlist[2] + "' as CVText UNION ");
            }

            strBill = strBill.Substring(0, strBill.Length - 6);

            string strSql = "";
            strSql = @" SELECT DISTINCT t.BillCode FROM View_BillsInfo_Received t  INNER JOIN (";
            strSql += strBill;
            strSql += @") u ON t.BillCode = u.BillCode AND ISNULL(t.InvoiceCode,'') = ISNULL(u.InvoiceCode,'') AND t.InvoiceCategoryText = CVText ";
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
