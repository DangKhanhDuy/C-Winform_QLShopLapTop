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
    public class KhachHangDAL
    {
        KHACHHANGTableAdapter da_KhachHang = new KHACHHANGTableAdapter();

        public KhachHangDAL()
        {

        }

        public DataTable LoadKhachHang()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_KhachHang.GetData();
            return dataTable;
        }

        public void ThemKhachHang(KhachHang pKhachHang)
        {
            
            da_KhachHang.Insert(pKhachHang.MaKH, pKhachHang.TenKH, pKhachHang.NgaySinh, pKhachHang.GioiTinh, pKhachHang.DiaChi, pKhachHang.SDT, pKhachHang.Email, pKhachHang.MatKhau);
        }

        public void XoaKhachHang(string maKhachHang)
        {
            QLShoplaptop.KHACHHANGRow rowToDelete = da_KhachHang.GetData().FindByMaKH(maKhachHang);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_KhachHang.Update(rowToDelete);
            }
        }

        public void SuaKhachHang(KhachHang pKhachHang)
        {
            QLShoplaptop.KHACHHANGRow rowToUpdate = da_KhachHang.GetData().FindByMaKH(pKhachHang.MaKH);

            if (rowToUpdate != null)
            {

                rowToUpdate.TenKH = pKhachHang.TenKH;
                rowToUpdate.NgaySinh = pKhachHang.NgaySinh;
                rowToUpdate.GioiTinh = pKhachHang.GioiTinh;
                rowToUpdate.DiaChi = pKhachHang.DiaChi;
                rowToUpdate.SDT = pKhachHang.SDT;

                da_KhachHang.Update(rowToUpdate);
            }
        }
    }
}
