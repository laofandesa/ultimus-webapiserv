using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC_CoreApi.Model;
using TCC_CoreApi.Model.entity;
using TCC_CoreApi.Common.Tool;
using System.Data;
using Newtonsoft.Json;

namespace TCC_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApiDBContent _dbContext;
        public ValuesController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
            
        }

        /// <summary>
        /// 借款明细查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("Queryborrowinfo")]
        public string Queryborrowinfo()
        {
            string rlt = "";
            Dictionary<string, object> parmas = new Dictionary<string, object>();
            DataTable dt = _dbContext.ExecSqlStr("SELECT  * FROM dbo.view_HasHappened_BorrowMoneyInfo", parmas);
            if (dt.Rows.Count > 0)
            {
                rlt = JsonSerializationExtension.ToJson(dt);
            }
            return rlt;
        }

        /// <summary>
        /// 通过条件查询借款信息（包含备用金与周转金）
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Currency"></param>
        /// <param name="ProjectCode"></param>
        /// <returns></returns>
        [HttpGet("QueryborrowinfoByID")]
        public string QueryborrowinfoByID(string ID,string Currency,string ProjectCode)
        {
            string rlt = "";
            string strSqlwhere = "";
            if (!string.IsNullOrEmpty(ProjectCode))
            {
                strSqlwhere = " AND ProjectCode='" + ProjectCode + "'";
            }
            string sql = @"SELECT  * FROM (
                            SELECT '备用金' AS borrowCategory,CurrencyAbbreviation,SUM(ISNULL(MONEY_YB,0)) AS amount 
                            FROM view_HasHappened_BorrowMoneyInfo 
                            WHERE BorrowType=1 AND Request_UserIdentity='"+ ID + @"'
                            GROUP BY CurrencyAbbreviation
                            UNION ALL
                            SELECT '周转金' AS borrowCategory,CurrencyAbbreviation,SUM(ISNULL(MONEY_YB,0)) AS xmzzj
                            FROM view_HasHappened_BorrowMoneyInfo 
                            WHERE BorrowType=2 AND Request_UserIdentity='"+ ID + "' AND CurrencyAbbreviation='"+ Currency + @"'"+strSqlwhere+@"
                            GROUP BY CurrencyAbbreviation
                           ) AS TT
                           WHERE ISNULL(amount,0)>0";
            Dictionary<string, object> parmas = new Dictionary<string, object>();
            DataTable dt = _dbContext.ExecSqlStr(sql, parmas);
            if (dt.Rows.Count > 0)
            {
                rlt = JsonSerializationExtension.ToJson(dt);
            }
            return rlt;
        }
    }
}
