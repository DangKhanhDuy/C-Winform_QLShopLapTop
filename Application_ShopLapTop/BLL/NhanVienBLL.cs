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
    public class NhanVienBLL
    {
        NhanVienDAL dalnv = new NhanVienDAL();

        public DataTable LoadNhanVien()
        {
            return dalnv.LoadNhanVien();
        }

        public void ThemNhanVien(NhanVien pNhanVien)
        {
            dalnv.ThemNhanVien(pNhanVien);
        }

        public void XoaNhanVien(string maNhanVien)
        {
            dalnv.XoaNhanVien(maNhanVien);
        }

        public void SuaNhanVien(NhanVien pNhanVien)
        {
            dalnv.SuaNhanVien(pNhanVien);
        }
    }
}
