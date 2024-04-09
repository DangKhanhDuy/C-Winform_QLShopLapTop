using DAL.QLShoplaptopTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SanPhamDAL
    {
        SANPHAMTableAdapter da_SanPham = new SANPHAMTableAdapter();
        CHITIETHOADONTableAdapter da_ChiTietHoaDon = new CHITIETHOADONTableAdapter();

        public SanPhamDAL()
        {

        }

        public DataTable LoadSanPham()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_SanPham.GetData();
            return dataTable;
        }

        public void ThemSanPham(SanPham pSanPham)
        {
            
            da_SanPham.Insert(pSanPham.MaSP, pSanPham.TenSP, pSanPham.SoLuong, pSanPham.GiaBan, pSanPham.HinhAnh, pSanPham.CPU, pSanPham.VGA, pSanPham.RAM, pSanPham.DISPLAY, pSanPham.MaNCC);
        }

        public void XoaSanPham(string maSanPham)
        {
            QLShoplaptop.SANPHAMRow rowToDelete = da_SanPham.GetData().FindByMaSP(maSanPham);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_SanPham.Update(rowToDelete);
            }
        }

        public void SuaSanPham(SanPham pSanPham)
        {
            QLShoplaptop.SANPHAMRow rowToUpdate = da_SanPham.GetData().FindByMaSP(pSanPham.MaSP);

            if (rowToUpdate != null)
            {

                rowToUpdate.TenSP = pSanPham.TenSP;
                rowToUpdate.SoLuong = pSanPham.SoLuong;
                rowToUpdate.GiaBan = pSanPham.GiaBan;
                rowToUpdate.MaNCC = pSanPham.MaNCC;

                da_SanPham.Update(rowToUpdate);
            }
        }

        public void updateSLT(int pSoluong, string pMaSP)
        {
            QLShoplaptop.SANPHAMRow rowToUpdate = da_SanPham.GetData().FindByMaSP(pMaSP);

            if (rowToUpdate != null)
            {

                rowToUpdate.SoLuong -= pSoluong;

                da_SanPham.Update(rowToUpdate);
            }
        }

    }
}
