using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL: DatabaseDAL
    {
        public string CheckLogin(TaiKhoan taikhoan)
        {
            string tk = CheckLoginTK(taikhoan);
            return tk;
        }

        public bool DoiMK(TaiKhoan taikhoan, string matKhauMoi)
        {
            return DoiMatKhau(taikhoan, matKhauMoi);
        }
    }
}
