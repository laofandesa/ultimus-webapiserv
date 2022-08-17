using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TCC_CoreApi.Common.Tool
{
    public class SqlHelper
    {

        public static DataTable Query(string sql, string connString, List<SqlParameter> paras)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    if (paras != null)
                    {
                        foreach (var para in paras)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }
                    using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                    {
                        ada.Fill(result);
                    }
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public static DataTable Query(string sql, List<SqlParameter> paras, SqlTransaction tran)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = tran.Connection;
                cmd.CommandText = sql;
                cmd.Transaction = tran;
                if (paras != null)
                {
                    foreach (var para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {

                    ada.Fill(dt);
                }
                cmd.Parameters.Clear();
            }
            return dt;
        }
        //public static DataTable Query(string sql, string connString, SqlParameter para)
        //{
        //    List<SqlParameter> paras = new List<SqlParameter>();
        //    return Query(sql, connString, paras);
        //}
        public static object QuerySingle(string sql, string connString, List<SqlParameter> paras)
        {
            DataTable dt = new DataTable();
            dt = Query(sql, connString, paras);
            if (dt.Rows.Count<=0)
            {
                return string.Empty;
            }
            else
            {
                return dt.Rows[0][0];
            }
        }

        public static object QuerySingle(string sql, List<SqlParameter> paras, SqlTransaction tran)
        {
            DataTable dt = new DataTable();
            dt = Query(sql, paras, tran);
            if (dt.Rows.Count <= 0)
            {
                return string.Empty;
            }
            else
            {
                return dt.Rows[0][0];
            }
        }

        public static DataSet ExeProcedure(string connString, List<SqlParameter> paras, string ProcedureName)
        {
            DataSet result = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = ProcedureName;
                    cmd.CommandTimeout = 10000;
                    if (paras != null)
                    {
                        foreach (var para in paras)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }
                    using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                    {
                        ada.Fill(result);
                    }
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }


        //public static object QuerySingle(string sql, string connString, SqlParameter para)
        //{
        //    DataTable dt = new DataTable();
        //    dt = Query(sql, connString, para);
        //    if (dt.IsNullOrEmpty())
        //    {
        //        return string.Empty;
        //    }
        //    else
        //    {
        //        return dt.Rows[0][0];
        //    }

        //}
        public static int ExecuteSql(string sql, string connString, List<SqlParameter> paras)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.CommandTimeout = 100000;
                    if (paras != null)
                    {
                        foreach (var p in paras)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public static int ExecuteSql(string sql, List<SqlParameter> paras, SqlTransaction tran)
        {
            int result = 0;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = tran.Connection;
                cmd.CommandText = sql;
                if (paras != null)
                {
                    foreach (var p in paras)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                if (tran.Connection.State == ConnectionState.Closed)
                {
                    tran.Connection.Open();
                }
                cmd.Transaction = tran;
                result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            return result;
        }

        /// <summary>
        /// 插入数据 并 返回查入行的主键ID
        /// </summary>
        /// add by 李士富 on 2014-08-04  
        /// <param name="sql"></param>
        /// <param name="connString"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExecuteScalarSql(string sql, string connString, List<SqlParameter> paras)
        {
            object result = string.Empty;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.CommandTimeout = 100000;
                    if (paras != null)
                    {
                        foreach (var p in paras)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    result = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }



        private SqlTransaction trans;
        public static SqlTransaction BeginTrans(string connString)
        {
            SqlConnection conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn.BeginTransaction();
        }

        public static void SubmitTran(SqlTransaction tran)
        {
            tran.Commit();
            tran.Dispose();

        }
        public static void RollBack(SqlTransaction tran)
        {
            tran.Rollback();
            tran.Dispose();
        }

        //FJC = First Join Column

        //SJC = Second Join Column

        public static DataTable Join(DataTable First, DataTable Second, DataColumn[] FJC, DataColumn[] SJC)
        {

            //Create Empty Table

            DataTable table = new DataTable("Join");

            // Use a DataSet to leverage DataRelation

            using (DataSet ds = new DataSet())
            {

                //Add Copy of Tables

                ds.Tables.AddRange(new DataTable[] { First.Copy(), Second.Copy() });

                //Identify Joining Columns from First

                DataColumn[] parentcolumns = new DataColumn[FJC.Length];

                for (int i = 0; i < parentcolumns.Length; i++)
                {

                    parentcolumns[i] = ds.Tables[0].Columns[FJC[i].ColumnName];

                }

                //Identify Joining Columns from Second

                DataColumn[] childcolumns = new DataColumn[SJC.Length];

                for (int i = 0; i < childcolumns.Length; i++)
                {

                    childcolumns[i] = ds.Tables[1].Columns[SJC[i].ColumnName];

                }

                //Create DataRelation

                DataRelation r = new DataRelation(string.Empty, parentcolumns, childcolumns, false);

                ds.Relations.Add(r);

                //Create Columns for JOIN table

                for (int i = 0; i < First.Columns.Count; i++)
                {

                    table.Columns.Add(First.Columns[i].ColumnName, First.Columns[i].DataType);

                }

                for (int i = 0; i < Second.Columns.Count; i++)
                {

                    //Beware Duplicates

                    if (!table.Columns.Contains(Second.Columns[i].ColumnName))

                        table.Columns.Add(Second.Columns[i].ColumnName, Second.Columns[i].DataType);

                    else

                        table.Columns.Add(Second.Columns[i].ColumnName + "_Second", Second.Columns[i].DataType);

                }

                //Loop through First table

                table.BeginLoadData();

                foreach (DataRow firstrow in ds.Tables[0].Rows)
                {

                    //Get "joined" rows

                    DataRow[] childrows = firstrow.GetChildRows(r);

                    if (childrows != null && childrows.Length > 0)   //这里就是join，，中国朋友写错了。。nnd。。
                    {

                        object[] parentarray = firstrow.ItemArray;

                        foreach (DataRow secondrow in childrows)
                        {

                            object[] secondarray = secondrow.ItemArray;

                            object[] joinarray = new object[parentarray.Length + secondarray.Length];

                            Array.Copy(parentarray, 0, joinarray, 0, parentarray.Length);

                            Array.Copy(secondarray, 0, joinarray, parentarray.Length, secondarray.Length);

                            table.LoadDataRow(joinarray, true);

                        }

                    }

                }

                table.EndLoadData();

            }

            return table;

        }

        public static DataTable Join(DataTable First, DataTable Second, DataColumn FJC, DataColumn SJC)
        {

            return Join(First, Second, new DataColumn[] { FJC }, new DataColumn[] { SJC });

        }

        public static DataTable Join(DataTable First, DataTable Second, string FJC, string SJC)
        {

            return Join(First, Second, new DataColumn[] { First.Columns[FJC] }, new DataColumn[] { Second.Columns[SJC] });

        }


        /// <summary>  
        /// DataTable左连接（通过此方法模仿左连接效果）  
        /// </summary>  
        /// <param name="TargetTable">目标DataTable</param>  
        /// <param name="JoinTable">要合并的DataTable</param>  
        /// <param name="JoinColumnName">作为连接的列名</param>  
        /// <param name="AddColumnsFromJT">要纳入目标 DataTable的列名</param>  
        public static void DataTableLeftJoin(ref DataTable TargetTable, DataTable JoinTable, string JoinColumnName, params string[] AddColumnsFromJT)
        {
            if (!TargetTable.Columns.Contains(JoinColumnName))
            {
                throw new Exception("目标DataTable中无" + JoinColumnName + "列！");
            }
            if (!JoinTable.Columns.Contains(JoinColumnName))
            {
                throw new Exception("连接DataTable中无" + JoinColumnName + "列！");
            }
            try
            {
                bool Exist = false;//标志是否存在与当前行的zone/org对应的数字，不存在则赋0  
                int ColumnIndex = TargetTable.Columns.Count;//列的序号  
                foreach (string Column in AddColumnsFromJT)
                {
                    // 如果列名不与已有列重复，则用此列名，否则，用列的序号  
                    if (!TargetTable.Columns.Contains(Column))
                    {
                        TargetTable.Columns.Add(Column);
                    }
                    else
                    {
                        TargetTable.Columns.Add(ColumnIndex.ToString());
                    }

                    for (int i = 0; i < TargetTable.Rows.Count; i++)
                    {
                        Exist = false;
                        foreach (DataRow JoinRow in JoinTable.Rows)
                        {
                            if (JoinRow[JoinColumnName].ToString() == TargetTable.Rows[i][JoinColumnName].ToString())
                            {

                                TargetTable.Rows[i][ColumnIndex] = JoinRow[Column];
                                Exist = true;
                            }
                        }
                        if (!Exist)
                        {
                            TargetTable.Rows[i][ColumnIndex] = "0";
                        }
                    }
                    ColumnIndex++;
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行DataTableJoin失败。/n" + e.Message);
            }
        }

        /// <summary>  
        /// DataTable左连接（通过此方法模仿左连接效果）  
        /// </summary>  
        /// <param name="TargetTable">目标DataTable</param>  
        /// <param name="JoinTable">要合并的DataTable</param>  
        /// <param name="JoinColumnName">作为连接的列名</param>  
        /// <param name="defaultValue">批配不上的列赋值</param>
        /// <param name="AddColumnsFromJT">要纳入目标 DataTable的列名</param>  
        public static void DataTableLeftJoin(ref DataTable TargetTable, DataTable JoinTable, string JoinColumnName, string defaultValue, params string[] AddColumnsFromJT)
        {
            if (!TargetTable.Columns.Contains(JoinColumnName))
            {
                throw new Exception("目标DataTable中无" + JoinColumnName + "列！");
            }
            if (!JoinTable.Columns.Contains(JoinColumnName))
            {
                throw new Exception("连接DataTable中无" + JoinColumnName + "列！");
            }
            try
            {
                bool Exist = false;//标志是否存在与当前行的zone/org对应的数字，不存在则赋0  
                int ColumnIndex = TargetTable.Columns.Count;//列的序号  
                foreach (string Column in AddColumnsFromJT)
                {
                    // 如果列名不与已有列重复，则用此列名，否则，用列的序号  
                    if (!TargetTable.Columns.Contains(Column))
                    {
                        TargetTable.Columns.Add(Column);
                    }
                    else
                    {
                        TargetTable.Columns.Add(ColumnIndex.ToString());
                    }

                    for (int i = 0; i < TargetTable.Rows.Count; i++)
                    {
                        Exist = false;
                        foreach (DataRow JoinRow in JoinTable.Rows)
                        {
                            if (JoinRow[JoinColumnName].ToString() == TargetTable.Rows[i][JoinColumnName].ToString())
                            {

                                TargetTable.Rows[i][ColumnIndex] = JoinRow[Column];
                                Exist = true;
                            }
                        }
                        if (!Exist)
                        {
                            TargetTable.Rows[i][ColumnIndex] = defaultValue;
                        }
                    }
                    ColumnIndex++;
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行DataTableJoin失败。/n" + e.Message);
            }
        }


        #region  左连接 条件 = 多列   add on 2014-09-01
        /// <summary>  
        /// DataTable左连接（通过此方法模仿左连接效果）  
        /// </summary>  
        /// <param name="TargetTable">目标DataTable</param>  
        /// <param name="JoinTable">要合并的DataTable</param>  
        /// <param name="JoinColumnNames">作为连接的列名数组</param>  
        /// <param name="defaultValue">批配不上的列赋值</param>
        /// <param name="AddColumnsFromJT">要纳入目标 DataTable的列名</param>  
        public static void DataTableLeftJoin(ref DataTable TargetTable, DataTable JoinTable, string[] JoinColumnNames, string defaultValue, params string[] AddColumnsFromJT)
        {
            foreach (string JoinColumnName in JoinColumnNames)
            {
                if (!TargetTable.Columns.Contains(JoinColumnName))
                {
                    throw new Exception("目标DataTable中无" + JoinColumnName + "列！");
                }
                if (!JoinTable.Columns.Contains(JoinColumnName))
                {
                    throw new Exception("连接DataTable中无" + JoinColumnName + "列！");
                }
            }

            try
            {
                bool Exist = false;//标志是否存在与当前行的zone/org对应的数字，不存在则赋0  
                int ColumnIndex = TargetTable.Columns.Count;//列的序号  
                foreach (string Column in AddColumnsFromJT)
                {
                    // 如果列名不与已有列重复，则用此列名，否则，用列的序号  
                    if (!TargetTable.Columns.Contains(Column))
                    {
                        TargetTable.Columns.Add(Column, JoinTable.Columns[Column].DataType);
                    }
                    else
                    {
                        TargetTable.Columns.Add(ColumnIndex.ToString());
                    }

                    for (int i = 0; i < TargetTable.Rows.Count; i++)
                    {
                        Exist = false;
                        foreach (DataRow JoinRow in JoinTable.Rows)
                        {
                            if (GetBj(JoinColumnNames, TargetTable.Rows[i], JoinRow))
                            {
                                TargetTable.Rows[i][ColumnIndex] = JoinRow[Column];
                                Exist = true;
                            }
                        }
                        if (!Exist)
                        {
                            TargetTable.Rows[i][ColumnIndex] = defaultValue;
                        }
                    }
                    ColumnIndex++;
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行DataTableJoin失败。/n" + e.Message);
            }
        }

        private static bool GetBj(string[] joinColumnNames, DataRow row1, DataRow row2)
        {
            foreach (string str in joinColumnNames)
            {
                if (!row1[str].ToString().Trim().Equals(row2[str].ToString().Trim()))
                {
                    return false;
                }
            }

            return true;
        }

        #region 对比数据，区分字符串类型和数值类型
        /// <summary>  
        /// DataTable左连接（通过此方法模仿左连接效果）  
        /// </summary>  
        /// <param name="TargetTable">目标DataTable</param>  
        /// <param name="JoinTable">要合并的DataTable</param>  
        /// <param name="JoinColumnNames">作为连接的列名数组</param>  
        /// <param name="defaultValue">批配不上的列赋值</param>
        /// <param name="AddColumnsFromJT">要纳入目标 DataTable的列名</param>  
        public static void DataTableLeftJoinForPayment(ref DataTable TargetTable, DataTable JoinTable, string[] JoinStringColumnName, string[] JoinNumberColumnName, string defaultValue, params string[] AddColumnsFromJT)
        {
            //区分比较的是字符串还是数值
            foreach (string JoinColumnName in JoinStringColumnName)
            {
                if (!TargetTable.Columns.Contains(JoinColumnName))
                {
                    throw new Exception("目标DataTable中无" + JoinColumnName + "列！");
                }
                if (!JoinTable.Columns.Contains(JoinColumnName))
                {
                    throw new Exception("连接DataTable中无" + JoinColumnName + "列！");
                }
            }

            foreach (string JoinColumnName in JoinNumberColumnName)
            {
                if (!TargetTable.Columns.Contains(JoinColumnName))
                {
                    throw new Exception("目标DataTable中无" + JoinColumnName + "列！");
                }
                if (!JoinTable.Columns.Contains(JoinColumnName))
                {
                    throw new Exception("连接DataTable中无" + JoinColumnName + "列！");
                }
            }

            try
            {
                bool Exist = false;//标志是否存在与当前行的zone/org对应的数字，不存在则赋0  
                int ColumnIndex = TargetTable.Columns.Count;//列的序号

                foreach (string Column in AddColumnsFromJT)
                {
                    // 如果列名不与已有列重复，则用此列名，否则，用列的序号  
                    if (!TargetTable.Columns.Contains(Column))
                    {
                        TargetTable.Columns.Add(Column);
                    }
                    else
                    {
                        ColumnIndex = TargetTable.Columns.Count;
                        TargetTable.Columns.Add(ColumnIndex.ToString());
                    }
                }

                for (int i = 0; i < TargetTable.Rows.Count; i++)
                {
                    Exist = false;
                    foreach (DataRow JoinRow in JoinTable.Rows)
                    {
                        bool bjStringResult = GetBjForPaymentString(JoinStringColumnName, TargetTable.Rows[i], JoinRow);
                        bool bjNumberResult = GetBjForPaymentDouble(JoinNumberColumnName, TargetTable.Rows[i], JoinRow);

                        if (bjNumberResult && bjStringResult && JoinRow["Flag"].ToString() == "1")
                        {
                            foreach (string Column in AddColumnsFromJT)
                            {
                                TargetTable.Rows[i][Column] = JoinRow[Column];
                                Exist = true;

                                if (!Exist)
                                {
                                    TargetTable.Rows[i][Column] = defaultValue;
                                }
                            }
                            JoinRow["Flag"] = "0";
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行DataTableJoin失败。/n" + e.Message);
            }
        }

        private static bool GetBjForPaymentString(string[] joinColumnNames, DataRow row1, DataRow row2)
        {
            foreach (string str in joinColumnNames)
            {
                if (row1[str].ToString() != row2[str].ToString().Trim())
                {
                    return false;
                }
            }

            return true;
        }

        private static bool GetBjForPaymentDouble(string[] joinColumnNames, DataRow row1, DataRow row2)
        {
            foreach (string str in joinColumnNames)
            {
                if (Convert.ToDouble(row1[str].ToString()) != Convert.ToDouble(row2[str].ToString()))
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #endregion


        /// <summary>
        /// SQL查询并返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="connString"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet QueryForSet(string sql, string connString, List<SqlParameter> paras)
        {
            DataSet result = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    if (paras != null)
                    {
                        foreach (var para in paras)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }
                    using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                    {
                        ada.Fill(result);
                    }
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

    }
}
