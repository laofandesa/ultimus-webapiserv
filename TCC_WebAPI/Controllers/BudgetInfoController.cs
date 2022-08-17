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
    public class BudgetInfoController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public BudgetInfoController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// 部门预算查询
        /// </summary>
        /// <param name="Year">年度</param>
        /// <param name="DeptCode">部门</param>
        /// <param name="ItmeCode">预算科目码(非必填)</param>
        /// <returns></returns>
        [HttpGet("GetDeptBudgetInfoByDeptCode")]
        public string GetDeptBudgetInfoByDeptCode(int Year, string DeptCode, string ItmeCode = "")
        {
            string rlt = "";
            try
            {
                string sqlwhere = "";
                if (!string.IsNullOrEmpty(ItmeCode))
                {
                    sqlwhere = " AND ItemSubCode='" + ItmeCode + "' ";
                }
                string sql = @"SELECT  Year,DeptCode,DeptName,Item1,Item2,ItemCode,Item3,ItemSubCode,Budget,Using,HasedBudget,RemainBudget 
                               FROM dbo.TCC_Dept_AnnualBudget 
                               WHERE Year=@year AND DeptCode=@deptcode "+sqlwhere+ @"
                               ORDER BY ItemSubCode";
                List<SqlParameter> parmas = new List<SqlParameter>();
                parmas.Add(new SqlParameter("year", Year));
                parmas.Add(new SqlParameter("deptcode", DeptCode));
                DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
                return rlt;
            }
            catch (System.Exception ex)
            {
                Logger.Info("BudgetInfoController-部门预算查询(GetDeptBudgetInfoByDeptCode)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// 部门预算信息新增、修改
        /// </summary>
        /// <param name="items">预算明细(Flag 0:流程中,1:已完成 ,2:已撤销)</param>
        /// <returns></returns>
        [HttpPost("ModefiedBudHistory")]
        public async Task<string> ModefiedBudHistory([FromBody] List<LandrayBudgetHistory> items)
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
                    #region 删除操作
                    var todos = _dbContext.Landray_BudgetHistory.Where(t => t.LyID == items[0].LyID).ToList();
                    foreach (var todo in todos)
                    {
                        _dbContext.Landray_BudgetHistory.Remove(todo);
                    }
                    #endregion
                    foreach (var item in items)
                    {
                        _dbContext.Landray_BudgetHistory.Add(item);
                      
                    }
                    await _dbContext.SaveChangesAsync();

                    resultMessage.Message = "添加成功！";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                resultMessage.Message = "添加预算错误:" + ex.Message;
                resultMessage.Result = 1;
                Logger.Info("BudgetInfoController-部门预算信息新增、修改(ModefiedBudHistory)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }
            return resultMessage.ToJson();
        }

        /// <summary>
        /// 项目预算查询
        /// </summary>
        /// <param name="ProjectCode">项目号</param>
        /// <param name="RunningCost">项目预算分类</param>
        /// <returns></returns>
        ///<response code="201">返回字符串（ProjectCode:项目号,ProjectName:项目名称,proj_type_desc:项目类型,HappenedAmount:已发生金额,HappeningAmount:流程中金额）</response>
        [HttpGet("GetProBudgetInfoByProjectCode")]
        public string GetProBudgetInfoByProjectCode(string ProjectCode, int RunningCost)
        {
            string rlt = "[]";
            try
            {
                string sql = "";
                switch (RunningCost)
                {
                    case 1:
                        sql = @"SELECT  ProjectCode,ProjectName,proj_type_desc,Budget,HappenedAmount,HappeningAmount 
                                FROM dbo.View_Budget_ProjectBudgetRunningCost WHERE ProjectCode=@ProjectCode";
                        break;
                    case 2:
                    case 3:
                        sql = @"SELECT  ProjectCode,ProjectName,Proj_Type_Desc AS proj_type_desc,CostChanged AS Budget,HappenedAmount,HappeningAmount, CByGroup AS RunningCost
                                FROM dbo.View_Budget_ProjectBudgetSpecialCost 
                                WHERE ProjectCode=@ProjectCode AND CByGroup=" + RunningCost + "";
                        break;
                    default:
                        sql = "";
                        break;
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    List<SqlParameter> parmas = new List<SqlParameter>();
                    parmas.Add(new SqlParameter("ProjectCode", ProjectCode));
                    DataTable dt = SqlHelper.Query(sql, BusinessConnectionString, parmas);
                    if (dt.Rows.Count > 0)
                    {
                        rlt = JsonSerializationExtension.ToJson(dt);
                    }
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("BudgetInfoController-项目预算查询(GetProBudgetInfoByProjectCode)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return rlt;
        }


        /// <summary>
        /// 多项目预算查询
        /// </summary>
        /// <param name="ProjectList">项目号</param>
        /// <param name="RunningCost">项目预算分类</param>
        /// <returns></returns>
        ///<response code="201">返回字符串（ProjectCode:项目号,HappenedAmount:已发生金额,HappeningAmount:流程中金额,remainAmount:剩余金额,RunningCost:项目预算分类）</response>
        [HttpGet("GetProBudgetInfoByProjectList")]
        public string GetProBudgetInfoByProjectList(string ProjectList, int RunningCost)
        {
            string rlt = "[]";
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@ProjectCode", ProjectList));
                paras.Add(new SqlParameter("@RunningCost", RunningCost));
                ds = SqlHelper.ExeProcedure(BusinessConnectionString, paras, "Pro_QueryBudget_ProjectList_Landray");
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    rlt = JsonSerializationExtension.ToJson(dt);
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("BudgetInfoController-项目预算查询(GetProBudgetInfoByProjectCode)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }
            return rlt;
        }
    }
}

