using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.QLShoplaptopTableAdapters;
using System.Data;

namespace DAL
{
    public class NhanVienDAL
    {
        NHANVIENTableAdapter da_NhanVien = new NHANVIENTableAdapter();

        public NhanVienDAL()
        {

        }

        public DataTable LoadNhanVien()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_NhanVien.GetData();
            return dataTable;
        }

        public void ThemNhanVien(NhanVien pNhanVien)
        {

            da_NhanVien.Insert(pNhanVien.MaNV, pNhanVien.TenNV, pNhanVien.NgaySinh, pNhanVien.GioiTinh, pNhanVien.DiaChi, pNhanVien.SDT);
        }

        public void XoaNhanVien(string maNhanVien)
        {
            QLShoplaptop.NHANVIENRow rowToDelete = da_NhanVien.GetData().FindByMaNV(maNhanVien);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_NhanVien.Update(rowToDelete);
            }
        }

        public void SuaNhanVien(NhanVien pNhanVien)
        {
            QLShoplaptop.NHANVIENRow rowToUpdate = da_NhanVien.GetData().FindByMaNV(pNhanVien.MaNV);

            if (rowToUpdate != null)
            {

                rowToUpdate.TenNV = pNhanVien.TenNV;
                rowToUpdate.NgaySinh = pNhanVien.NgaySinh;
                rowToUpdate.GioiTinh = pNhanVien.GioiTinh;
                rowToUpdate.DiaChi = pNhanVien.DiaChi;
                rowToUpdate.SDT = pNhanVien.SDT;

                da_NhanVien.Update(rowToUpdate);
            }
        }
    }
}
