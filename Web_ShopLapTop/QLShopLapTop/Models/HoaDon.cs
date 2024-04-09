using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLShopLapTop.Models
{
    public class HoaDon
    {
        public string pMaHD { set; get; }
        public string pMaNV{ set; get; }
        public string pMaKH { set; get; }
        public string pMaSP { set; get; }
        public int pSoLuong { set; get; }
        public DateTime pNgayBan { set; get; }
        public double pThanhTien{ set; get; }
    }
}