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
    public class GioHangController : Controller
    {
        //
        // GET: /GioHang/
        QLLaptopDataContext qllt = new QLLaptopDataContext();
        //
        // GET: /GioHang/
        public ActionResult Index()
        {
            return View();
        }
        //Phương thức lấy giỏ hàng/
        public List<GioHang> LayGioHang()
        {
            List<GioHang> listGH = Session["GioHang"] as List<GioHang>;
            if (listGH == null)
            {
                listGH = new List<GioHang>();
                Session["GioHang"] = listGH;
            }
            return listGH;
        }
        //Phương thức thêm giỏ hàng/
        public ActionResult ThemGioHang(string MaSP, string strURL)
        {
            List<GioHang> listGH = LayGioHang();
            GioHang sanpham = listGH.Find(sp => sp.pMaSP == MaSP);
            if (sanpham == null)
            {
                sanpham = new GioHang(MaSP);
                listGH.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.pSoLuong++;
                return Redirect(strURL);
            }
        }
        //Tổng số lượng/
        private int TongSoLuong()
        {
            int tsl = 0;
            List<GioHang> listGH = Session["GioHang"] as List<GioHang>;
            if (listGH != null)
            {
                tsl = listGH.Sum(sp => sp.pSoLuong);
            }
            return tsl;
        }
        //Phương thức tính tổng thành tiền/
        private double TongThanhTien()
        {
            double ttt = 0;
            List<GioHang> listGH = Session["GioHang"] as List<GioHang>;
            if (listGH != null)
            {
                ttt += listGH.Sum(sp => sp.ThanhTien);
            }
            return ttt;
        }
        // Xây dựng trang giỏ hàng
        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "GioHang");
            }
            List<GioHang> listGH = LayGioHang();

            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return View(listGH);
        }
        public ActionResult ShowGioHang()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return PartialView();
        }
        //Xóa giỏ hàng
        public ActionResult XoaGioHang(string MaSP)
        {
            List<GioHang> listGH = LayGioHang();
            GioHang sanpham = listGH.Find(sp => sp.pMaSP == MaSP);
            if (sanpham != null)
            {
                listGH.RemoveAll(sp => sp.pMaSP == MaSP);
                return RedirectToAction("GioHang", "GioHang");
            }
            if (listGH.Count == 0)
            {
                return RedirectToAction("Index", "GioHang");
            }
            return RedirectToAction("GioHang", "GioHang");
        }
        public ActionResult XoaGioHang_All()
        {
            List<GioHang> listGH = LayGioHang();
            listGH.Clear();
            return RedirectToAction("Index", "GioHang");
        }
        public ActionResult CapNhatGioHang(string MaSP, int newAmount)
        {
            // Lấy thông tin sản phẩm từ bảng sanpham trong cơ sở dữ liệu
            var sanPham = qllt.SANPHAMs.SingleOrDefault(sp => sp.MaSP == MaSP);

            if (sanPham != null)
            {
                int soLuongTonKho = (int)sanPham.SoLuong;

                // Kiểm tra xem số lượng mới có lớn hơn 0 không
                if (newAmount > 0)
                {
                    // Kiểm tra xem số lượng mới có nhỏ hơn hoặc bằng số lượng tồn kho không
                    if (newAmount <= soLuongTonKho)
                    {
                        // Thực hiện cập nhật giỏ hàng
                        List<GioHang> ShoppingCart = Session["GioHang"] as List<GioHang>;
                        GioHang EditAmount = ShoppingCart.FirstOrDefault(m => m.pMaSP == MaSP);

                        if (EditAmount != null)
                        {
                            EditAmount.pSoLuong = newAmount;

                            // Lưu thay đổi vào cơ sở dữ liệu nếu cần
                            qllt.SubmitChanges();

                            TempData["Message"] = null; // Đặt lại thông báo lỗi
                        }
                        else
                        {
                            TempData["Message"] = "Không tìm thấy sản phẩm trong giỏ hàng.";
                        }
                    }
                    else
                    {
                        TempData["Message"] = "Sản phẩm không đủ số lượng tồn kho.";
                    }
                }
                else
                {
                    TempData["Message"] = "Số lượng mới phải lớn hơn 0.";
                }
            }
            else
            {
                TempData["Message"] = "Không tìm thấy thông tin sản phẩm.";
            }

            // Chuyển hướng đến action CheckOut
            return RedirectToAction("CheckOut", "GioHang");
        }

        public ActionResult CheckOut()
        {
          
   
            List<GioHang> listGH = LayGioHang();
            ViewBag.TongTien = listGH.Sum(item => item.pSoLuong * item.pDonGia);
            
            return View(listGH);

        }

        
        public ActionResult SendMail(string mail, string name,DateTime ngaySinh , int SDT, string address)
        {
            // Kiểm tra địa chỉ email hợp lệ
            if (!IsValidEmail(mail))
            {
                return Content("Địa chỉ email không hợp lệ.");
            }
            Random rd = new Random();
            int randomNumber;
            HashSet<string> usedCodes = new HashSet<string>();
            string temp;
            do
            {
                randomNumber = rd.Next(7, 101);
                temp = string.Format("KH{0}", randomNumber);
            } while (!usedCodes.Add(temp)); 
            KHACHHANG khs = new KHACHHANG();
            khs.MaKH = temp;
            khs.TenKH = name;
            khs.GioiTinh = "Nam";
            khs.DiaChi = address;
            khs.NgaySinh = ngaySinh;
            khs.EMAIL =mail;
            khs.SDT = SDT;
            khs.MATKHAU = "123";


            qllt.KHACHHANGs.InsertOnSubmit(khs);
            qllt.SubmitChanges();



            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,  // Cập nhật cổng
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "dulichphapaz@gmail.com",
                    Password = "fjtc cumn vfxs knun"
                    //UserName = "2001200775@hufi.edu.vn",
                    //Password = "3c@m!8dS"
                }
            };
            MailAddress FromeMail = new MailAddress("dulichphapaz@gmail.com", "FCB LAPTOP");
            MailAddress ToeMail = new MailAddress(mail, name);


            String Body = "<h2>THÔNG TIN ĐƠN HÀNG - DÀNH CHO NGƯỜI MUA</h2>";
            List<GioHang> listGH = LayGioHang();
            if (listGH == null)
            {
                return Content("Lỗi: Session không chứa danh sách sản phẩm.");
            }
            Body += "<table><tr><td>id</td><td></td><td>Tên sản phẩm</td><td></td><td>Giá</td><td></td><td>Số lượng</td><td></td><td>Thành tiền</td></tr> ";
            

            // Sinh mã hóa đơn một cách duy nhất
            string maHoaDon = string.Format("HD{0}", randomNumber);
            double Tongtien = 0;
            double Thanhtien = 0; // Di chuyển ra khỏi vòng lặp
            for (int i = 0; i < listGH.Count; i++)
            {
                double giaBan = 0;
                double soLuong = 0;

                // Kiểm tra và chuyển đổi kiểu dữ liệu nếu cần
                if (listGH[i].pDonGia != null && listGH[i].pSoLuong != null && double.TryParse(listGH[i].pDonGia.ToString(), out giaBan) && double.TryParse(listGH[i].pSoLuong.ToString(), out soLuong))
                {
                    Thanhtien = giaBan * soLuong; // Cập nhật giá trị Thanhtien cho từng sản phẩm
                    Tongtien += Thanhtien; // Tính tổng tiền
                    // Thêm vào Body chỉ khi chuyển đổi thành công
                    Body += "<tr><td>" + listGH[i].pMaSP + "</td><td></td><td>" + listGH[i].pTenSP + "</td>";
                    Body += "<td></td><td>" + giaBan + "</td><td></td><td>" + soLuong + "</td><td></td><td>" + Thanhtien + "</td><td></td>";
                    int maNV = rd.Next(1, 6);
                    HOADON hd = new HOADON()
                    {
                        MaHD = maHoaDon, // Bạn cần sinh mã hóa đơn một cách duy nhất
                        MaNV = string.Format("NV{0}", maNV),
                        MaKH = temp,
                        MaSP = listGH[i].pMaSP, // Cần lấy mã sản phẩm từ dữ liệu người dùng hoặc gửi từ trang web
                        NgayBan = DateTime.Now,
                        TongTien = (int)Thanhtien,
                        TrangThai = false
                    };

                    // Thêm hóa đơn vào cơ sở dữ liệu
                    qllt.HOADONs.InsertOnSubmit(hd);
                    qllt.SubmitChanges();

                    // Lặp qua danh sách sản phẩm trong giỏ hàng và thêm vào chi tiết hóa đơn
                    foreach (var item in listGH)
                    {

                        // Kiểm tra và chuyển đổi kiểu dữ liệu nếu cần
                        if (item.pDonGia != null && item.pSoLuong != null && double.TryParse(item.pDonGia.ToString(), out giaBan) && double.TryParse(item.pSoLuong.ToString(), out soLuong))
                        {
                            double thanhTien = giaBan * soLuong;

                            // Tạo đối tượng chi tiết hóa đơn
                            CHITIETHOADON cthd = new CHITIETHOADON()
                            {
                                //MaCTHD = string.Format("MaCTHD{0}", randomNumber),
                                MaHD = maHoaDon,
                                MaSP = item.pMaSP,
                                SoLuong = item.pSoLuong,
                                DonGia = (int)giaBan,
                                ThanhTien = (int)Tongtien
                            };

                            // Thêm chi tiết hóa đơn vào cơ sở dữ liệu
                            qllt.CHITIETHOADONs.InsertOnSubmit(cthd);
                        }
                        else
                        {
                            // Xử lý nếu không thể chuyển đổi kiểu dữ liệu
                            return Content("Lỗi chuyển đổi kiểu dữ liệu.");
                        }
                    }

                    qllt.SubmitChanges();
                }
                else
                {
                    // Xử lý nếu không thể chuyển đổi kiểu dữ liệu
                    return Content("Lỗi chuyển đổi kiểu dữ liệu.");
                }
                //var sanPham = qllt.SANPHAMs.FirstOrDefault(sp => sp.MaSP == listGH[i].pMaSP);
                //if (sanPham != null)
                //{
                //    sanPham.SoLuong -= (int)soLuong;
                //}
            }
            

            Body += "<tr><td colspan='3'>Ngày lập:   </td><td colspan='2'>" + DateTime.Now + "</td></tr></table>";
            Body += "<tr><td colspan='3'>Tổng tiền cần thanh toán là:   </td><td colspan='2'>" + Tongtien + "</td></tr></table>";

            MailMessage Message = new MailMessage()
            {
                From = FromeMail,
                Subject = "Đơn hàng #2209197FNP6X82 đã đặt hàng thành công",
                Body = Body
            };
            Message.To.Add(ToeMail);
            Message.IsBodyHtml = true;
            try
            {
                Client.Send(Message);
            }
            catch (SmtpException ex)
            {
                return Content("Lỗi: " + ex.Message);
            }
            qllt.SubmitChanges();
            listGH.Clear();

            return Content("<div style='text-align:center; font-size: 38px'><p style='color:green;'>Thanh toán thành công. Đơn hàng của bạn đã được xác nhận.</p>   <a href='" + Url.Action("", "") + "' class='btn btn-primary'>Quay về trang chủ</a></div>");

            
        }
        // Hàm kiểm tra địa chỉ email hợp lệ
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
	}
}