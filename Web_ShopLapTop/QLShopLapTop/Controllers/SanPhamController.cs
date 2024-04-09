using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLShopLapTop.Models;
namespace QLShopLapTop.Controllers
{
    public class SanPhamController : Controller
    {
        QLLaptopDataContext qllt = new QLLaptopDataContext();
        //
        // GET: /SanPham/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowSanPham()
        {
            var listSanpham = qllt.SANPHAMs.OrderBy(s => s.TenSP).ToList();
            return View(listSanpham);
        }
        public ActionResult SanPhamTheoNCC(string pMaNCC)
        {
            var listSPTNCC = qllt.SANPHAMs.Where(sp => sp.MaNCC == pMaNCC).OrderBy(sp => sp.GiaBan).ToList();
            if (listSPTNCC.Count == 0)
            {
                ViewBag.TB = "Không có sản phẩm thuộc nhà cung cấp này!";
            }
            return View(listSPTNCC);
        }
        public ActionResult ChiTietSanPham(string pMaSP)
        {
            SANPHAM sanpham = qllt.SANPHAMs.SingleOrDefault(sp => sp.MaSP == pMaSP);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);

        }
	}
}