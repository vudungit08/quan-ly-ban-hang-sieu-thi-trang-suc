using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLBH.DataAccessLayer
{
    class DataProvider
    {   
        protected static string connectionString { get; set; }
        protected SqlConnection connection;
        protected SqlCommand command;
        protected SqlDataAdapter adapter;
        /// <summary>
        /// Hàm kết nối đến CSDL
        /// </summary>
        public void connect() {
            connection = new SqlConnection(connectionString);
        }
        /// <summary>
        /// Hàm ngắt kết nối CSDL
        /// </summary>
        public void disconnect() {
            if (connection.State == ConnectionState.Open) {
                connection.Close();
            }
        }
        /// <summary>
        /// Hàm thực hiện câu lệnh SQL {SELECT}
        /// </summary>
        /// <param name="sqlString">Chuỗi truy vấn</param>
        /// <returns>Datatable</returns>
        public DataTable executeQuery(string sqlString) {
            DataTable dt=new DataTable();
            try
            {
                command = new SqlCommand(sqlString, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi: Thực hiện câu lệnh");                
            }
            return dt;
        }
        /// <summary>
        /// Hàm thực hiện câu lênh SQL {INSERT,UPDATE,DELETE}
        /// </summary>
        /// <param name="sqlString">Chuỗi truy vấn</param>
        public void executeNonQuery(string sqlString) {
            try
            {
                command = new SqlCommand(sqlString, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException) {
                throw new Exception("Lỗi : Thực hiện câu lệnh");
            }
        }
        /// <summary>
        /// Hàm thực hiện câu lệnh SQL {SELECT}
        /// </summary>
        /// <param name="sqlString">chuỗi truy vấn</param>
        /// <returns>object</returns>
        public object executeScalar(string sqlString) {
            try
            {
                command = new SqlCommand(sqlString, connection);
                return command.ExecuteScalar();
            }
            catch (SqlException)
            {
                throw new Exception("Lỗi : Thực hiện câu lệnh");
                return null;
            }
        }

    }
}
