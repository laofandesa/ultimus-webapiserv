using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using TCC_CoreApi.Model.entity;
using TCC_CoreApi.Common.Tool;

namespace TCC_CoreApi.Model
{
    public class ApiDBContent : DbContext
    {
        private IDbConnection connection = null;
        private SqlCommand command = null;

        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        //为EF上下文添加空构造
        public ApiDBContent()
        {

        }

        public ApiDBContent(DbContextOptions<ApiDBContent> options)
            : base(options)
        {
            if (null == connection)
                connection = Database.GetDbConnection();//这个GetDbConnection需要在NuGet中添加Microsoft.AspNetCore.App

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            if (command == null)
                command = connection.CreateCommand() as SqlCommand;
        }

        public DbSet<UserInfo> Users { get; set; }
        public DbSet<LandrayBorrowMoneyInfo> Landray_BorrowMoneyInfo { get; set; }
        public DbSet<LandrayBillsManagement> Landray_BillsManagement { get; set; }
        public DbSet<LandrayBudgetHistory> Landray_BudgetHistory { get; set; }
        public DbSet<LandrayRenderedRecevelist> Landray_Rendered_Recevelist { get; set; }
        public DbSet<LandrayCashierTaskFpInbox> Landray_CashierTask_FP_Inbox { get; set; }
        public DbSet<LandrayFinanceCashierConfirm> Landray_FinanceCashierConfirm { get; set; }
        public DbSet<LandrayPaymentHistory> Landray_PaymentHistory { get; set; }
        public DbSet<LandrayPaymentHistoryNotProject> Landray_PaymentHistoryNotProject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(BusinessConnectionString);
        }

        public int Insert<T>(T table)
        {
            try
            {
                command.CommandText = GetInsertSqlStr(table, command.Parameters);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ExecSqlStr(string sql, Dictionary<string, object> Parameters)
        {
            command.CommandText = sql;
            foreach (var str in Parameters.Keys)
            {
                var value = Parameters.GetValueOrDefault(str);
                command.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@" + str,
                        Value = value,
                        DbType = GetDbType(value.GetType())
                    }
                    );
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataSet myDataSet = new DataSet();
            da.Fill(myDataSet);
            DataTable db = myDataSet.Tables[0];
            return db;
        }

        public DataSet ExecProStr(string sql, Dictionary<string, object> Parameters)
        {
            command.CommandText = sql;
            foreach (var str in Parameters.Keys)
            {
                var value = Parameters.GetValueOrDefault(str);
                command.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@" + str,
                        Value = value,
                        DbType = GetDbType(value.GetType())
                    }
                    );
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataSet myDataSet = new DataSet();
            da.Fill(myDataSet);
            return myDataSet;
        }


        private string GetInsertSqlStr<T>(T table, SqlParameterCollection sqlParameters)
        {
            string strSql = "insert into " + typeof(T).Name + " (";
            //获得泛型类型的公共属性
            var pros = typeof(T).GetProperties().Where(pi => !Attribute.IsDefined(pi, typeof(NotMappedAttribute))).ToArray();
            string values = "";
            foreach (PropertyInfo p in pros)
            {
                strSql += p.Name + ",";
                values += "@" + p.Name + ",";

                sqlParameters.Add(new SqlParameter()
                {
                    ParameterName = "@" + p.Name,
                    Value = p.GetValue(table),
                    DbType = GetDbType(p.PropertyType)
                });
            }
            values = values.Substring(0, values.Length - 1);
            strSql = strSql.Substring(0, strSql.Length - 1) + ") values (" + values + ")";
            return strSql;
        }

        private DbType GetDbType(Type t)
        {
            switch (Type.GetTypeCode(t))
            {
                case TypeCode.Boolean:
                    return DbType.Boolean;
                case TypeCode.Byte:
                    return DbType.Byte;
                case TypeCode.DateTime:
                    return DbType.DateTime;
                case TypeCode.Decimal:
                    return DbType.Decimal;
                case TypeCode.Double:
                    return DbType.Double;
                case TypeCode.Int16:
                    return DbType.Int16;
                case TypeCode.Int32:
                    return DbType.Int32;
                case TypeCode.Int64:
                    return DbType.Int64;
                case TypeCode.String:
                    return DbType.String;
                default:
                    return DbType.Object;
            }
        }
    }

}
