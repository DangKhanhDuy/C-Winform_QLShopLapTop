using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-K3P9F51;Initial Catalog=QLShoplaptop;Persist Security Info=True;User ID=sa;Password=sa";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }

    public class DatabaseDAL
    {
        public static string CheckLoginTK(TaiKhoan taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.TenTaiKhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.MatKhau);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }

        public static bool DoiMatKhau(TaiKhoan taikhoan, string matKhauMoi)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_DoiMatKhau", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tenTaiKhoan", taikhoan.TenTaiKhoan);
            command.Parameters.AddWithValue("@matKhauMoi", matKhauMoi);

            int rowsAffected = command.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0; 
        }

    }
}
