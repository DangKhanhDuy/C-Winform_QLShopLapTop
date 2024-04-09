using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tk = new TaiKhoanDAL();

        public string CheckLogin(TaiKhoan taikhoan)
        {
            if (taikhoan.TenTaiKhoan == "")
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.MatKhau == "")
            {
                return "requeid_password";
            }

            string kttk = tk.CheckLogin(taikhoan);
            return kttk;
        }

        public bool ChangePassword(TaiKhoan taiKhoan, string newPassword)
        {
            return tk.DoiMK(taiKhoan, newPassword);
        }
    }
}
