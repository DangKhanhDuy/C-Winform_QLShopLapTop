using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormDoiMatKhau : Form
    {
        TaiKhoanBLL tkbll = new TaiKhoanBLL();

        public FormDoiMatKhau()
        {
            if (FormTrangChu.tennguoidung == "admin")
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("Chỉ có admin mới có thể truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();

            FormTrangChu tc = new FormTrangChu();
            tc.Show();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txt_tentaikhoan.Text;
            string matKhauCu = txt_matkhaucu.Text;
            string matKhauMoi = txt_matkhaumoi.Text;
            string nhapLaiMatKhau = txt_nhaplaimatkhau.Text;

            if (matKhauMoi != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TaiKhoan taiKhoan = new TaiKhoan
            {
                TenTaiKhoan = tenTaiKhoan,
                MatKhau = matKhauMoi
            };

            bool result = tkbll.ChangePassword(taiKhoan, matKhauMoi);

            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);     
                
                this.Close();

                FormTrangChu tc = new FormTrangChu();
                tc.Show();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng kiểm tra lại thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
