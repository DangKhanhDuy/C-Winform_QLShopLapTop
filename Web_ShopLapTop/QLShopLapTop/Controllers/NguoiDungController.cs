using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLShopLapTop.Models;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc.Html;
namespace QLShopLapTop.Controllers
{
    public class NguoiDungController : Controller
    {
        QLLaptopDataContext qllt = new QLLaptopDataContext();
        //
        // GET: /NguoiDung/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangKy(KHACHHANG model)
        {
            if (ModelState.IsValid)
            {

                Random random = new Random();
                if (!string.IsNullOrEmpty(model.TenKH) && !string.IsNullOrEmpty(model.EMAIL)/* Kiểm tra các trường khác */)
                {
                    var lastCustomer = qllt.KHACHHANGs.OrderByDescending(c => c.MaKH).FirstOrDefault();
                if (lastCustomer != null)
                {
                    int lastNumber = int.Parse(lastCustomer.MaKH.Substring(2));
                    int randomNumber = random.Next(1, 101);

                    model.MaKH = string.Format("KH{0}", lastNumber + randomNumber);
                }
                else
                {
                    model.MaKH = "KH1";
                }

                qllt.KHACHHANGs.InsertOnSubmit(model);
                qllt.SubmitChanges();
                ViewBag.Message = "Đăng ký thành công!";
                
                }
                else
                {

                    return View(model);
                }
                
            }
            
            return View(model);
        }
        public ActionResult ShowDangNhap()
        {
            return View();
        }
        public ActionResult DangNhap(FormCollection f)
        {
            var tendn = f["SDT"];
            var matkhau = f["MATKHAU"];

            if (!String.IsNullOrWhiteSpace(tendn) && !String.IsNullOrWhiteSpace(matkhau))
            {
                KHACHHANG kh = qllt.KHACHHANGs.SingleOrDefault(c => c.SDT.ToString() == tendn && c.MATKHAU == matkhau);

                if (kh != null)
                {
                    ViewBag.TB = "Đăng nhập thành công !!!";
                    Session["SDT"] = kh;

                    if (Session["SDT"] != null)
                    {
                        return RedirectToAction("ShowSanPham", "SanPham");
                    }
                }
                else
                {
                    ViewBag.TB = "Sai tên đăng nhập hoặc sai mật khẩu, vui lòng nhập lại";
                }
            }
            return View();
        }
        public ActionResult DangXuat()
        {
            Session["SDT"] = null;
            return RedirectToAction("", ""); 
        }
	}
}