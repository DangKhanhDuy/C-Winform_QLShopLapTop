using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLShopLapTop.Models
{
    public class NguoiDung
    {
        public List<GioHang> SPtrongGioHang { get; set; }
        public KHACHHANG KhachHang { get; set; }
        public string pMaKH { set; get; }
        public string pTenKH { set; get; }
        public DateTime pNgaySinh { set; get; }
        public string pGioiTinh { set; get; }
        public string pDiaChi { set; get; }
        public int pSDT { set; get; }
        public string pEmail { set; get; }
        public string pMK { set; get; }

    }
}