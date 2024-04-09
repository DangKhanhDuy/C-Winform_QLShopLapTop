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
    public class HoaDonBLL
    {
        HoaDonDAL hd = new HoaDonDAL();
        public void SuaHD(HoaDon pHoaDon)
        {
            hd.SuaHoaDon(pHoaDon);
        }
    }
}
