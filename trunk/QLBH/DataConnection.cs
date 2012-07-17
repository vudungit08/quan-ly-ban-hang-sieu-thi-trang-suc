using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLBH
{
    class DataConnection
    {
        private string strConnectString = "";
       protected SqlConnection cnn;
       protected SqlCommand cmd;
       protected SqlDataAdapter adap;

        public DataConnection() {            
            strConnectString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+System.Windows.Forms.Application.StartupPath+@"\DATA\QLBH_DATA.mdf;Integrated Security=True;User Instance=True";
        }
        public DataConnection(string connectionString) {
            
            strConnectString = connectionString;
        }
        /// <summary>
        /// Mở kết nối
        /// </summary>
        protected void Open(){
            try{
                cnn = new SqlConnection(strConnectString);
                cnn.Open();
            }catch(SqlException){throw new Exception("Lỗi mở kết nối");}
        }
        /// <summary>
        /// Đóng kết nối
        /// </summary>
        protected void Close() {
            if (cnn.State == ConnectionState.Open) cnn.Close();
        }
    }
    
    class DataProcess:DataConnection{
        public DataProcess()
            : base(@"Data Source=SVNTEAM062211\SQLEXPRESS;Initial Catalog=QLBH_DATA;Integrated Security=True")
        { 
        }
        /// <summary>
        /// Lấy toàn bộ dữ liệu của bảng
        /// </summary>
        /// <param name="strSQL">Chuỗi truy vấn</param>
        /// <returns>DataTable</returns>
        public DataTable getAllData(string strSQL) {
            DataTable dt=new DataTable();
            try
            {
                Open();
                adap = new SqlDataAdapter(strSQL, cnn);
                adap.Fill(dt);
            }
            catch (SqlException)
            {
                throw;
            }
            finally {
                Close();
            }
            return dt;
        }
        /// <summary>
        /// Lấy toàn bộ dữ liệu của bảng
        /// </summary>
        /// <param name="strSQL">Tên Proc</param>
        /// <returns>DataTable</returns>
        public DataTable getAllData(string strProc, List<DbParameter> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                
                    cmd = new SqlCommand(strProc, cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        foreach (DbParameter dbParameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(dbParameter.Name, dbParameter.Value);
                        }
                    }
                    adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);
                
            }
            catch (SqlException)
            {
                throw;
            }
            finally {
                Close();
            }
            return dt;
            

        }
        /// <summary>
        /// Lấy 1 dữ liệu
        /// </summary>
        /// <param name="strSQL">chuỗi truy vấn</param>
        /// <returns>object</returns>
        public object getOneData(string strSQL)
        {
            object result = null;
            try
            {
                Open();
                cmd = new SqlCommand(strSQL, cnn);
                result = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                Close();
            }
            return result;
        }
        public object getOneData(string strProc, List<DbParameter> parameters)
        {
            object result = null;
            try
            {
                Open();
                if (parameters != null)
                {
                    cmd = new SqlCommand(strProc, cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DbParameter dbParameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(dbParameter.Name, dbParameter.Value);
                    }
                    result = cmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Close();
            }
            return result;
        }
        
        /// <summary>
        /// Thực hiện câu lệnh
        /// </summary>
        /// <param name="strSQL">Chuối truy vấn</param>
        /// <returns>int</returns>
        public int executeSQL(string strSQL) {
            int result=0;
            try
            {
                Open();
                cmd = new SqlCommand(strSQL, cnn);
                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException) { throw; }
            finally { Close(); }
            return result;
        }
        public int executeSQL(string strProc, List<DbParameter> parameters)
        {
            int result = 0;
            try {
                Open();
                if (parameters != null)
                {
                    cmd = new SqlCommand(strProc, cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DbParameter dbParameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(dbParameter.Name, dbParameter.Value);                        
                    }                     
                    
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException) { throw; }
            finally { Close(); }
            return result;

        }
        
    }    
    public class DbParameter
    {
        public string Name { get; set; }     
        public object Value { get; set; }

        public DbParameter(string paramName,object paramValue)
        {
            Name = '@'+paramName;            
            Value = paramValue;
        }
    }

}
