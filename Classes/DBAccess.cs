using ESPNotice3._0.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ESPNotice3._0.Classes
{
    class DBAccess
    {
        private static SqlConnection? objConnection;
        //private static SqlDataAdapter objDataAdapter;
        //public static string ConnectionString = @"Data Source=VBS1TEC220\SERVER2008R2EXP; Initial Catalog=LaserWorldDesk; User Id=sa; Password=vbsoft";
        //public static string ConnectionString = @"Data Source=VBS1TEC220\SERVER2008R2EXP; Initial Catalog=LSD; User Id=sa; Password=vbsoft";
        //public static string ConnectionString = @"Data Source=ACCOUNTS\SQLEXPRESS; Initial Catalog=LaserWorldDesk; User Id=sa; Password=lwd@123";
        public static string ConnectionString = string.Empty;

        public static string GetConnectionString()
        {
            ConnectionString = string.Empty;

            //StreamReader sr = new StreamReader("DB.config");
            //string sRawData = sr.ReadToEnd();
            //string sDBData = CryptoEngine.Decrypt(sRawData, CryptoEngine.FixKey);
            //sr.Close();
            //sr.Dispose();

            //string[] arrDBData = sDBData.Split('|');

            //if (arrDBData.Length == 4)
            //{
            //    string DataSource = arrDBData[0];
            //    string InitialCatalog = arrDBData[1];
            //    string UserId = arrDBData[2];
            //    string Password = arrDBData[3];
            //    ConnectionString = @"Data Source=" + DataSource + "; Initial Catalog=" + InitialCatalog + "; User Id=" + UserId + "; Password=" + Password + "";
            //}
            ConnectionString = Settings.Default.connString;
            return ConnectionString;
        }

        public static bool CheckConnection()
        {
            bool bResult = false;

            try
            {
                ConnectionString = string.Empty;
                OpenConnection();
                if (objConnection != null)
                {
                    if (objConnection.State == ConnectionState.Open)
                    {
                        bResult = true;
                    }
                }
            }
            catch { bResult = false; }

            return bResult;
        }

        private static void OpenConnection()
        {
            try
            {
                if (System.String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
                if (objConnection == null)
                {
                    objConnection = new SqlConnection(ConnectionString);
                    objConnection.Open();
                }
                else
                {
                    if (objConnection.State != ConnectionState.Open)
                    {
                        objConnection = new SqlConnection(ConnectionString);
                        objConnection.Open();
                    }
                }
            }
            catch { }
        }
        //private static void CloseConnection() {  
        //    try {
        //        if (String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
        //        if (!(objConnection == null)) {  
        //            if (objConnection.State == System.Data.ConnectionState.Open) {  
        //                objConnection.Close();  
        //                objConnection.Dispose();  
        //            }  
        //        }  
        //    } catch {}  
        //}  
        public static bool ExecuteQuery(string query)
        {
            try
            {
                if (System.String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static DataTable GetDataTable(string query)
        {
            DataTable dtResult = new DataTable();
            try
            {
                if (System.String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        dtResult.Load(cmd.ExecuteReader());
                        connection.Close();
                        return dtResult;
                    }
                }
            }
            catch
            {
                return dtResult;
            }
        }

        public static DataTable GetSelectByQuery(string query)
        {
            DataTable objDt = new DataTable();

            if (System.String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    connection.Open();
                    adapter.Fill(objDt);
                    connection.Close();
                }
            }
            return objDt;
        }

        public static DataTable SelectTable(string Criteria, string ColumnList, string TableName, string OrderBy)
        {
            if (OrderBy.Length > 1)
                OrderBy = "Order By " + OrderBy;
            DataTable dataTable = new DataTable();

            if (System.String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("MASTER_SELECT_SP", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        connection.Open();

                        SqlParameter objParam = new SqlParameter();

                        objParam = cmd.Parameters.Add("@Criteria", SqlDbType.VarChar, 8000);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = Criteria;

                        objParam = cmd.Parameters.Add("@ColumnList", SqlDbType.VarChar, 8000);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = ColumnList;

                        objParam = cmd.Parameters.Add("@TableName", SqlDbType.VarChar, 8000);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = TableName;

                        objParam = cmd.Parameters.Add("@OrderBy", SqlDbType.VarChar, 100);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = OrderBy;

                        dataTable.Clear();
                        adapter.Fill(dataTable);

                        connection.Close();
                    }
                }
            }
            return dataTable;
        }

        public static int InsertRecord(DataRow dr, string strProcName, bool blnIsReturn)
        {
            int num = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strProcName, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            connection.Open();

                            SqlParameter sqlParameter = new SqlParameter();
                            for (int index = 0; index < dr.Table.Columns.Count; ++index)
                                sqlParameter = cmd.Parameters.AddWithValue("@" + dr.Table.Columns[index].ColumnName, dr[index]);
                            if (blnIsReturn)
                                cmd.Parameters.Add("@prKey", SqlDbType.Decimal, 18).Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();

                            if (blnIsReturn)
                                num = (int)cmd.Parameters["@prKey"].Value;

                            connection.Close();
                        }
                    }
                }
                return num;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static void FillDropDownList(string strTableName, string strDdlValue, string strDdlText, ComboBox cmbName, string strCriteria, bool blnIsNull, bool blnIsSelectRequired, bool blnHaving)
        {
            DataTable dataTable = new DataTable();

            if (System.String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT_DDL_SP", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        connection.Open();

                        SqlParameter objParam = new SqlParameter();

                        objParam = cmd.Parameters.Add("@TabName", SqlDbType.VarChar, 8000);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = strTableName;

                        objParam = cmd.Parameters.Add("@strValue", SqlDbType.VarChar, 8000);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = strDdlValue;

                        objParam = cmd.Parameters.Add("@strText", SqlDbType.VarChar, 8000);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = strDdlText;

                        objParam = cmd.Parameters.Add("@strCriteria", SqlDbType.VarChar, 100);
                        objParam.Direction = ParameterDirection.Input;
                        objParam.Value = strCriteria;

                        dataTable.Clear();
                        adapter.Fill(dataTable);

                        if (blnIsSelectRequired)
                        {
                            DataRow row = dataTable.NewRow();
                            row[0] = !blnIsNull ? (object)0 : (object)DBNull.Value;
                            row[1] = (object)"--Select--";
                            dataTable.Rows.InsertAt(row, 0);
                        }
                        if (strDdlText.ToUpper() == strDdlValue.ToUpper())
                            strDdlText += "1";
                        cmbName.DisplayMember = dataTable.Columns[1].ColumnName;
                        cmbName.ValueMember = dataTable.Columns[0].ColumnName;
                        cmbName.DataSource = (object)dataTable;

                        connection.Close();
                    }
                }
            }            
        }

        internal static void FillDropDownList(string strTableName, string strDdlValue, string strDdlText, ComboBox cmbName, string strCriteria)
        {
            DataTable dataTable = new DataTable();
            strCriteria = strCriteria.Length <= 2 ? " " : " where " + strCriteria;

            if (System.String.IsNullOrEmpty(ConnectionString)) GetConnectionString();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT_DDL_SP", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TabName", (object)strTableName);
                    cmd.Parameters.AddWithValue("@strValue", (object)strDdlValue);
                    cmd.Parameters.AddWithValue("@strText", (object)strDdlText);
                    cmd.Parameters.AddWithValue("@strCriteria", (object)strCriteria);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        connection.Open();

                        dataTable.Clear();
                        adapter.Fill(dataTable);
                        DataRow row = dataTable.NewRow();
                        row[0] = (object)DBNull.Value;
                        row[1] = (object)"--Select--";
                        dataTable.Rows.InsertAt(row, 0);
                        if (strDdlText.ToUpper() == strDdlValue.ToUpper())
                            strDdlText += "1";
                        cmbName.DisplayMember = dataTable.Columns[1].ColumnName;
                        cmbName.ValueMember = dataTable.Columns[0].ColumnName;
                        cmbName.DataSource = (object)dataTable;

                        connection.Close();
                    }
                }
            }
        }



    } //Class
}//Namsepace

