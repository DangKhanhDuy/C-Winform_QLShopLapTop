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
    public class SanPhamBLL
    {
        SanPhamDAL dalsp = new SanPhamDAL();

        public DataTable LoadSanPham()
        {
            return dalsp.LoadSanPham();
        }

        public void ThemSanPham(SanPham pSanPham)
        {
            dalsp.ThemSanPham(pSanPham);
        }

        public void XoaSanPham(string maSanPham)
        {
            dalsp.XoaSanPham(maSanPham);
        }

        public void SuaSanPham(SanPham pSanPham)
        {
            dalsp.SuaSanPham(pSanPham);
        }

        public void updateSLT(int pSoluong, string pMaSP)
        {
            dalsp.updateSLT(pSoluong, pMaSP);
        }
    }
}
