using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL dalsp = new KhachHangDAL();

        public DataTable LoadKhachHang()
        {
            return dalsp.LoadKhachHang();
        }

        public void ThemKhachHang(KhachHang pKhachHang)
        {
            dalsp.ThemKhachHang(pKhachHang);
        }

        public void XoaKhachHang(string maKhachHang)
        {
            dalsp.XoaKhachHang(maKhachHang);
        }

        public void SuaKhachHang(KhachHang pKhachHang)
        {
            dalsp.SuaKhachHang(pKhachHang);
        }
    }
}
