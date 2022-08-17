using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TCC_CoreApi.Common.Tool;
using TCC_CoreApi.Model;

namespace TCC_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DraftInfoController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public DraftInfoController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 汇票查询
        /// </summary>
        /// <param name="LoginName">用户名</param>
        /// <param name="companyCode">收款单位编号</param>
        /// <param name="signcode">合同签定单位编号</param>
        /// <param name="drafttype">汇票种类</param>
        /// <returns></returns>
        [HttpGet("GetDraftInfo")]
        public string GetDraftInfo(string LoginName, string companyCode, string signcode,string drafttype)
        {
            string rlt = "";
            try
            {
                //todo 锁定状态为2：流程中正在锁定的汇票，需要排除
                //--or isLock = 2 and ID IN(SELECT DraftID FROM dbo.TCC_Invoices_Received_DraftInfo di WHERE di.RID = '" + paymentid + @"'))
                string sql = @"SELECT ID as DraftID, *, CONVERT(VARCHAR(1000), CAST(DraftAmount AS MONEY), 1) AS DraftAmountFmt,
                        CASE DraftSource WHEN 1 THEN PayeeName WHEN 2 THEN PayingBankName END AS FKYHGYS
                        FROM dbo.TCC_DraftInfo
                        WHERE ISNULL(ISDel, 0) <> 1
                               AND(Status = 1 or status = 2)
                               and(isLock = 1 and LockUserLoginName = @LoginName
                                    or isLock is null
                                    or isLock = 0
                                   )
                                AND(DraftSource = 1 AND PayeeCode = @companyCode
                                     OR DraftSource = 2 AND(ISNULL(PartBID, '000000') <> '010669' AND '000000' =@signcode
                                     OR ISNULL(PartBID, '000000') = '010669' AND '010669' = @signcode)
                                     ) ";
                if (drafttype != "")
                {
                    sql += drafttype == "集团ABS" || drafttype == "付款代理" ? " and DraftType='" + drafttype + "' " : " and DraftType!='集团ABS' and  DraftType!='付款代理' ";
                }

                List<SqlParameter> parmas = new List<SqlParameter>();
                parmas.Add(new SqlParameter("LoginName", LoginName));
                parmas.Add(new SqlParameter("companyCode", companyCode));
                parmas.Add(new SqlParameter("signcode", signcode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionStringTest, parmas);
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
        /// 汇票库存金额
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetDraftAmount")]
        public string GetDraftAmount()
        {
            string rlt = "";
            try
            {
                string sql = @"SELECT ISNULL(SUM(DraftAmount),0) AS total FROM dbo.TCC_DraftInfo
WHERE (Status =1 or Status=2) AND (IsLock = 0 or IsLock is null) AND DueDate >= DATEADD(dd,-1,GETDATE())";
                List<SqlParameter> parmas = new List<SqlParameter>();
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
    }
}
