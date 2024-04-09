using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        public static string TenND = "";

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            TenND = txt_taikhoan.Text;
            taikhoan.TenTaiKhoan = txt_taikhoan.Text;
            taikhoan.MatKhau = txt_matkhau.Text;
            string getuser = tkbll.CheckLogin(taikhoan);

            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormTrangChu trangChu = new FormTrangChu();
            trangChu.Show();
            this.Hide();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_taikhoan_Click(object sender, EventArgs e)
        {
            txt_taikhoan.Clear();
        }

        private void txt_matkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.Clear();
        }

    }
}
