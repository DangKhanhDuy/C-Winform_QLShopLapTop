using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTrangChu : Form
    {
        private IconButton currentbtn;
        private Panel lefborderbtn;
        private Form currentchildform;
        public static string tennguoidung = "";

        public FormTrangChu()
        {
            InitializeComponent();
            lefborderbtn = new Panel();
            lefborderbtn.Size = new Size(15, 50);
            PanelMenu.Controls.Add(lefborderbtn);
            timer1.Start();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-K3P9F51;Initial Catalog=QLShoplaptop;Persist Security Info=True;User ID=sa;Password=sa");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr;

            try
            {
                connect.Open();
                cmd.CommandText = "SELECT TenTaiKhoan, MatKhau FROM TAIKHOAN WHERE TenTaiKhoan = @TenTaiKhoan";
                cmd.Parameters.AddWithValue("@TenTaiKhoan", FormDangNhap.TenND);
                cmd.Connection = connect;

                rdr = cmd.ExecuteReader();
                bool temp = false;

                while (rdr.Read())
                {
                    LabelUser.Text = "Chức vụ: "+ rdr.GetString(0);
                    tennguoidung = rdr.GetString(0); 
                    temp = true;
                }

                //if (!temp)
                //    MessageBox.Show("Not found");

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowTenND(string username)
        {
            LabelUser.Text = "Chức vụ: " + username;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(145, 151, 154);

        }

        private void activebtn(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                disablebtn();
                currentbtn = (IconButton)senderbtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;

                lefborderbtn.BackColor = color;
                lefborderbtn.Location = new Point(0, currentbtn.Location.Y);
                lefborderbtn.Visible = true;
                lefborderbtn.BringToFront();

                iconmenusmall.IconChar = currentbtn.IconChar;
                iconmenusmall.IconColor = color;

            }
        }

        private void disablebtn()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(34, 36, 49);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void motrangcon(Form trangcon)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.FormBorderStyle = FormBorderStyle.None;
            trangcon.Dock = DockStyle.Fill;
            paneltrangcon.Controls.Add(trangcon);
            paneltrangcon.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();
            labelcon.Text = trangcon.Text;
        }

        private void Reset()
        {
            disablebtn();
            lefborderbtn.Visible = false;
            iconmenusmall.IconChar = IconChar.Home;
            iconmenusmall.IconColor = Color.Gainsboro;
            labelcon.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbDateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Hide();
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {

        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color2);
            motrangcon(new FormSanPham());
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color3);
            motrangcon(new FormKhachHang());
        }

        private void btn_nhasanxuat_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color4);
            motrangcon(new FormNhaCungCap());
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color5);
            motrangcon(new FormNhanVien());
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color1);
            motrangcon(new FormDoiMatKhau());
        }

        private void btn_khohang_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color2);
            motrangcon(new FormKhoHang());
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color3);
            motrangcon(new FormHoaDon());
        }     
    }
}
