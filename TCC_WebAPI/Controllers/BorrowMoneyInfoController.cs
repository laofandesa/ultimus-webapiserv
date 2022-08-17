using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC_CoreApi.Model;
using TCC_CoreApi.Common.Tool;
using TCC_CoreApi.Model.entity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace TCC_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowMoneyInfoController : ControllerBase
    {
        // 正式机
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        // 测试机
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public BorrowMoneyInfoController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<LandrayBorrowMoneyInfo> GetAll ()
        {
            return _dbContext.Landray_BorrowMoneyInfo.ToList();
        }
        
        [HttpGet("LandrayFormCode")]
        public async Task<LandrayBorrowMoneyInfo> Get(string LandrayFormCode)
        {
            try
            {
                var item = await _dbContext.Landray_BorrowMoneyInfo.FirstOrDefaultAsync(t => t.LandrayFormCode == LandrayFormCode);
                return item;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            //return JsonSerializationExtension.ToJson(_dbContext.Landray_BorrowMoneyInfo.Take(2).ToList());
        }

        /// <summary>
        /// 一般费用报销备用金和周转金（接单选择冲抵单据）接口	（新建）
        /// </summary>
        /// <returns>新建结果返回</returns> 
        /// <response code="201">返回字符串</response>
        [HttpPost("LandrayForCreate")]
        public async Task<string> Create([FromBody] List<LandrayBorrowMoneyInfo>  items)
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
                        var todos = _dbContext.Landray_BorrowMoneyInfo.Where(t => t.fd_id == item.fd_id).ToList();
                        if (todos.Count != 0)
                        {
                            foreach (var todo in todos)
                            {
                                _dbContext.Landray_BorrowMoneyInfo.Remove(todo);
                            }
                        }
                        item.Flag = 0;
                        _dbContext.Landray_BorrowMoneyInfo.Add(item);
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
        /// 一般费用报销备用金和周转金（接单选择冲抵单据）接口	（更新）
        /// </summary>
        /// <param name="LandrayFormCode">蓝凌唯一标识</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串</response>
        [HttpPost("LandrayForUpdate")]
        public async Task<string> Updadte(string LandrayFormCode, [FromBody] List<LandrayBorrowMoneyInfo> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            string warnmessage = "";
            string errmessage = "";
            string message = "";
            int resultcode = 0;
            try
            {
                if (items.Count == 0)
                {
                    errmessage = "修改项为空!";
                    resultcode = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        var todos = _dbContext.Landray_BorrowMoneyInfo.Where(t => t.fd_id == item.fd_id).ToList();
                        if (todos.Count == 0)
                        {
                            warnmessage += "【" + item.fd_id + "】,";//修改项在数据库中未找到!
                        }
                        else
                        {
                            foreach (var todo in todos)
                            {
                                todo.BorrowType = item.BorrowType;
                                todo.BorrowTypeText = item.BorrowTypeText;
                                todo.ProjectCode = item.ProjectCode;
                                todo.ProjectName = item.ProjectName;
                                todo.BorrowMoney_Small = item.BorrowMoney_Small;
                                todo.CurrencyAb = item.CurrencyAb;
                                todo.Rate = item.Rate;
                                todo.Money_Yb = item.Money_Yb;
                                todo.ConfirmStatus = item.ConfirmStatus;
                                todo.ConfirmDate = item.ConfirmDate;
                                todo.Flag = item.Flag;
                                todo.UpdateTime = item.UpdateTime;
                                _dbContext.Landray_BorrowMoneyInfo.Update(todo);
                                await _dbContext.SaveChangesAsync();
                            }
                            message += "【" + item.fd_id + "】,";//修改成功
                            resultcode = 0;
                        }
                    }
                    warnmessage = warnmessage == "" ? "" : warnmessage.Substring(0, warnmessage.Length - 1) + "修改项在数据库中未找到! ";
                    message = message == "" ? "" : message.Substring(0, message.Length - 1) + "修改成功";
                    string alertmessage = warnmessage + message;
                    resultMessage.Message = errmessage != "" ? errmessage : alertmessage;
                    resultMessage.Result = resultcode;
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }

        
        [HttpGet("QueryInfoAll")]
        public string QueryInfoAll()
        {
            string rlt = "";
            try
            {
                Dictionary<string, object> parmas = new Dictionary<string, object>();
                DataTable dt = _dbContext.ExecSqlStr("SELECT  * FROM dbo.view_HasHappened_BorrowMoneyInfo", parmas);
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
        /// 一般费用报销获取安马明细表数据（view_HasHappened_BorrowMoneyInfo）
        /// </summary>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串</response>
        /// <summary>
        /// 一般费用报销备用金和周转金（提单获取余额）接口（主表）
        /// </summary>
        /// <param name="UserIdentity">身份证号</param>
        /// <param name="Currency">币种</param>
        /// <param name="ProjectCode">项目号</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串</response>
        [HttpGet("QueryInfoByID")]
        public string QueryInfoByID(string UserIdentity, string Currency, string ProjectCode)
        {
            string rlt = "";
            try { 
                string strSqlwhere = "";
                if (!string.IsNullOrEmpty(ProjectCode))
                {
                    strSqlwhere = " AND ProjectCode='" + ProjectCode + "'";
                }
                string sql = @"SELECT  * FROM (
                            SELECT '备用金' AS borrowCategory,CurrencyAbbreviation,SUM(ISNULL(MONEY_YB,0)) AS amount 
                            FROM view_HasHappened_BorrowMoneyInfo 
                            WHERE BorrowType=1 AND Request_UserIdentity='" + UserIdentity + @"'
                            GROUP BY CurrencyAbbreviation
                            UNION ALL
                            SELECT '周转金' AS borrowCategory,CurrencyAbbreviation,SUM(ISNULL(MONEY_YB,0)) AS xmzzj
                            FROM view_HasHappened_BorrowMoneyInfo 
                            WHERE BorrowType=2 AND Request_UserIdentity='" + UserIdentity + "' AND CurrencyAbbreviation='" + Currency + @"'" + strSqlwhere + @"
                            GROUP BY CurrencyAbbreviation
                           ) AS TT
                           WHERE ISNULL(amount,0)>0";

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

        /// <summary>
        /// 一般费用报销备用金和周转金（提单获取余额）接口（财务）
        /// </summary>
        /// <param name="UserIdentity">身份证号</param>
        /// <param name="Currency">币种</param>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="Incident">fd_id</param>
        /// <returns>查询结果返回</returns> 
        /// <response code="201">返回字符串</response>
        [HttpGet("QueryInfoByID2")]
        public string QueryInfoByID2(string UserIdentity, string Currency, string ProjectCode, string Incident)
        {
            string rlt = "";
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@IdNumber", UserIdentity));
                paras.Add(new SqlParameter("@Type", ""));
                paras.Add(new SqlParameter("@Currency", Currency));
                paras.Add(new SqlParameter("@ProjectCode", string.IsNullOrEmpty(ProjectCode) ? "": ProjectCode));
                paras.Add(new SqlParameter("@Incident", string.IsNullOrEmpty(Incident) ? "" : Incident));
                //List<SqlParameter> parmas = new List<SqlParameter>();
                //string sql = "exec Pro_Query_GetBorrowInfoList '','" + UserIdentity+ "','"+ Currency+"','"+ ProjectCode + "','" + Incident+"'";
                //DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                ds = SqlHelper.ExeProcedure(BusinessConnectionString, paras, "Pro_Query_GetBorrowInfoList");
                DataTable dt = ds.Tables[1];
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
