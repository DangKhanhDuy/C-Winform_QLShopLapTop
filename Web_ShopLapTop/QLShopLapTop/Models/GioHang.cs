using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLShopLapTop.Models
{
    public class GioHang
    {
        QLLaptopDataContext qllt = new QLLaptopDataContext();
        public string pMaSP { set; get; }
        public string pTenSP { set; get; }
        public string pHinhAnh { set; get; }
        public double pDonGia { set; get; }
        public int pSoLuong { set; get; }
        public KhachHangInfo KHACHHANG { get; set; }

        public class KhachHangInfo
        {
            public string EMAIL { get; set; }
            public string SDT { get; set; }
        }
        public double ThanhTien
        {
            get { return pSoLuong * pDonGia; }
        }
        public GioHang(string ms)
        {
            pMaSP = ms;
            SANPHAM sanpham = qllt.SANPHAMs.SingleOrDefault(sp => sp.MaSP == pMaSP);
            if (sanpham != null)
            {
                pTenSP = sanpham.TenSP;
                pHinhAnh = sanpham.HinhAnh;
                pDonGia = double.Parse(sanpham.GiaBan.ToString());
                pSoLuong = 1;
            }
        }

    }
}