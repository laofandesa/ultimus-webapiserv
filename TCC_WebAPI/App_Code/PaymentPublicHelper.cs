using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC_CoreApi.Common.Tool;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace TCC_WebAPI.App_Code
{
    public class PaymentPublicHelper
    {
        public string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");
        /// <summary>
        /// 已拨款额
        /// </summary>
        /// <param name="ProjectCode"></param>
        /// <returns></returns>
        public decimal GetBKHistory(string ProjectCode)
        {
            decimal result = 0;
            string sql = string.Empty;
            DataTable dt = new DataTable();
            List<SqlParameter> paras = new List<SqlParameter>();
            sql = @"SELECT ISNULL(SUM(ChangeLocalCurrencyAmount),0) AS jg  FROM dbo.TCC_PaymentHistory WHERE RequestPayCategory = 15 AND RequestType=1 AND ProjectCode=@ProjectCode ";

            paras.Add(new SqlParameter("@ProjectCode", ProjectCode));
            object o = SqlHelper.QuerySingle(sql, BusinessConnectionString, paras);
            result = Convert.ToDecimal(o);
            return result;
        }

        /// <summary>
        /// 已申请额
        /// </summary>
        /// <param name="ProjectCode"></param>
        /// <param name="incident"></param>
        /// <returns></returns>
        public decimal GetBKApply(string ProjectCode, int incident = 0)
        {
            decimal result = 0;
            string sql = string.Empty;
            DataTable dt = new DataTable();
            List<SqlParameter> paras = new List<SqlParameter>();
            sql = @"SELECT ISNULL(SUM(u.FinanceChangeLocalCurrencyAmount),0) AS jg 
                    FROM dbo.TCC_PaymentHistory t 
                    RIGHT JOIN dbo.TCC_PaymentProcessMultiple u ON t.PPID = u.ID 
                    WHERE t.ID IS NULL AND u.RequestPayCategory = 15 
                            AND u.RequestType=1 AND u.ProjectCode= @ProjectCode and u.incident!=@incident AND u.ProcessStatus <> 2";

            paras.Add(new SqlParameter("@ProjectCode", ProjectCode));
            paras.Add(new SqlParameter("@incident", incident));
            object o = SqlHelper.QuerySingle(sql, BusinessConnectionString, paras);
            result = Convert.ToDecimal(o);
            return result;
        }

        /// <summary>
        /// 判断是不是epc项目
        /// </summary>
        /// <param name="ProjectCode"></param>
        /// <returns></returns>
        public bool GetProjectIsEPC(string ProjectCode)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            string sql = @"  SELECT COUNT(1) AS cts FROM dbo.View_Peptj_ProjectInfo u WHERE u.proj_type_desc = '工程总承包项目'
              AND u.proj_sub_type_desc IN ( 'ec', 'pc', 'epc' ) AND project_id = @ProjectCode";
            paras.Add(new SqlParameter("@ProjectCode", ProjectCode));
            object o = SqlHelper.QuerySingle(sql, BusinessConnectionString, paras);

            return Convert.ToBoolean(o);
        }

        /// <summary>
        /// 获取项目相关类型
        /// </summary>
        /// <param name="projectCode">项目号</param>
        /// <param name="BudgetName_EPC">预算值</param>
        /// <returns></returns>
        public decimal GetProjectSingleBudget(string projectCode, enumBudgetName_EPC BudgetName_EPC)
        {
            decimal result = 0;
            string sql = string.Empty;
            DataTable dt = new DataTable();
            List<SqlParameter> paras = new List<SqlParameter>();
            sql = @"SELECT  subject_name ,
                            subject_sid ,
                            isnull(cost_apply*10000,0) as cost_apply ,
                            isnull(cost_approve*10000,0) as cost_approve ,
                            isnull(cost_change*10000,0) as cost_change ,
                            isnull(cost_changed*10000,0) as cost_changed 
                    FROM    peptj.PowerPMDB.dbo.view_tcc_intf_47
                    WHERE   proj_id = @projectCode and subject_sid = @subject_sid ";

            paras.Add(new SqlParameter("@projectCode", projectCode));
            paras.Add(new SqlParameter("@subject_sid", BudgetName_EPC));
            dt = SqlHelper.Query(sql, BusinessConnectionString, paras);
            if (dt.Rows.Count > 0)
            {
                result = Convert.ToDecimal(dt.Rows[0]["cost_changed"]);
            }
            return result;
        }

        public string GetProjectProfitMargin(string ProjectCode)
        {
            string rlt = "[]";
            try
            {
                DataSet ds = new DataSet();
                Hashtable ht = new Hashtable();
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@ProjectCode", ProjectCode));

                DataTable dt = new DataTable();
                string strSql = @"SELECT * FROM dbo.TCC_ProjectInfo_ForStatement WHERE ProjectCode = @ProjectCode";
                dt = SqlHelper.Query(strSql, BusinessConnectionString, paras);
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

        public string GetTaxRateName(string TaxRateCode)
        {
            string rlt = "";
            string sql = @"SELECT Name FROM dbo.TCC_BasicData WHERE Flag='TaxRate' AND Code='" + TaxRateCode + "'";
            rlt = SqlHelper.QuerySingle(sql, BusinessConnectionString, null).ToString();
            return rlt;
        }

        public enum enumBudgetName_EPC
        {
            建筑成本 = 2,
            安装成本 = 3,
            设备成本 = 4,
            材料成本 = 5,
            人工时_天辰员工 = 29,
            分包人工时_外单位员工 = 30,
            分包费 = 31,
            项目奖金_天辰员工 = 33,
            超限设备运输费 = 6,
            大型机具使用费 = 7,
            临建费 = 8,
            HSE费用 = 9,
            保险费用 = 10,
            其他费用 = 11,
            差旅费 = 40,
            招待费 = 45,
            办公费 = 46,
            文印费 = 47,
            资料费 = 48,
            汽车使用费 = 49,
            交通费 = 50,
            会务费 = 51,
            业务费 = 52,
            租赁费 = 53,
            通讯费 = 56,
            出国费用 = 57,
            集中办公用房 = 58,
            低值易耗品 = 59,
            税费_印花税 = 60,
            其他 = 61,
            出口设备退税 = 62,
            项目前期费用 = -1,
            项目税金及附加 = -2,
            境外项目税金 = -3,
            拨款限额 = -4
        }
    }
}
