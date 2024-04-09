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
    public class HoaDonDAL
    {
        HOADONTableAdapter da_hd = new HOADONTableAdapter();
        public HoaDonDAL()
        {

        }
        public void SuaHoaDon(HoaDon pHoaDon)
        {
            QLShoplaptop.HOADONRow rowToUpdate = da_hd.GetData().FindByMaHD(pHoaDon.MaHD);

            if (rowToUpdate != null)
            {

                //rowToUpdate.MaNV = pHoaDon.MaNV;
                //rowToUpdate.MaKH = pHoaDon.MaKH;
                //rowToUpdate.MaSP = pHoaDon.MaSP;
                //rowToUpdate.NgayBan = pHoaDon.NgayBan;
                //rowToUpdate.TongTien = pHoaDon.TongTien;
                rowToUpdate.TrangThai = pHoaDon.TrangThai;

                da_hd.Update(rowToUpdate);
            }
        }
    }
}
