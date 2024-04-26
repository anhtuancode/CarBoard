using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public static class Connection
    {
        static SqlConnection conn;
        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = "MINHLEE\\MLEE";
                builder["Integrated Security"] = true; // Chuyển sang xác thực SQL Server
                builder["User ID"] = "MINHLEE\\giang"; // Tên người dùng
                builder["Password"] = ""; // Mật khẩu
                builder["Initial Catalog"] = "CarRental";
                builder["MultipleActiveResultSets"] = true;
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
    }


}
