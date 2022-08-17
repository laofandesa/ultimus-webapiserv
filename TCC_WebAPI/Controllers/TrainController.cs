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
    [Route("api/Training")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public TrainController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        #region 选择培训单据
        /// <summary>
        /// 选择培训单据
        /// </summary>
        /// <param name="DeptCode">部门编号</param>
        /// <param name="fd_id">蓝领外键（默认空）</param>
        /// <param name="searchKey">检索条件（默认空：表单号、培训内容、申请人）</param>
        /// <returns>查询结果返回</returns>
        /// <response code="201">返回字符串-备注：{人力资源部可以看见所有}，返回字符串：{FormNumber:表单编号,ApplyName:申请人,ApplyDept:申请人部门,ApplyDate:申请日期,TotalCost:付款金额，TrainContent：培训内容，TrainTime：培训时间}</response>
        [HttpGet("GetTrainingInfo")]
        public string GetTrainingInfo(string DeptCode,string fd_id,string searchKey)
        {
            string rlt = "[]";
            try
            {
                string queryWhere = " 1=1 ";
                if (!string.IsNullOrWhiteSpace(searchKey))
                {
                    queryWhere += (" AND (FormNumber like '%" + searchKey + "%' OR TrainContent like '%" + searchKey + "%' OR ApplyName like '%" + searchKey + "%')");
                }
                //todo需要蓝领付款信息
                string strSql = @"SELECT  FormNumber ,ApplyName ,ApplyDept ,ApplyDate ,TotalCost ,TrainContent ,
                                          TrainStartTime + '-' + TrainEndTime AS TrainTime
                                  FROM    dbo.TCC_TS_TrainTeacherApply main
                                  LEFT JOIN dbo.TCC_PaymentProcessMultiple pay ON main.FormNumber = pay.PaymentLinkFormNumber AND pay.ProcessStatus <> 2
                                  WHERE   main.ProcessStatus = 1
                                          --Modify By Ly 2017-4-1 人力资源部可以看见所有
		                                  AND (ApplyDeptNo = @deptcode OR '010214' = @deptcode)
                                          AND pay.ID IS NULL
                                          AND " + queryWhere + @" ORDER BY FormNumber DESC";

                List<SqlParameter> paras = new List<SqlParameter>();
                //paras.Add(new SqlParameter("@fd_id", fd_id));
                paras.Add(new SqlParameter("@deptcode", DeptCode));
                DataTable dt = SqlHelper.Query(strSql, BusinessConnectionString, paras);
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
