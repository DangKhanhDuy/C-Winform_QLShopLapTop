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
    public partial class FormKhachHang : Form
    {
        KhachHangBLL khbll = new KhachHangBLL();

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLShoplaptopDataSet.KHACHHANG);

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang
            {
                MaKH = maKHTextBox.Text,
                TenKH = tenKHTextBox.Text,
                NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text),
                GioiTinh = gioiTinhTextBox.Text, 
                DiaChi = diaChiTextBox.Text,
                Email = eMAILTextBox.Text,
                MatKhau = maKHTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };
            if (maKHTextBox.Text != null)
            {
                int? kq = this.kHACHHANGTableAdapter.KTKCKH(maKHTextBox.Text);
                if (kq.Value > 0)
                {
                    MessageBox.Show("Trùng khóa mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            khbll.ThemKhachHang(kh);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.kHACHHANGTableAdapter.Fill(this.qLShoplaptopDataSet.KHACHHANG);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (kHACHHANGDataGridView.SelectedRows.Count > 0)
            {
                string maKH = kHACHHANGDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    khbll.XoaKhachHang(maKH);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kHACHHANGDataGridView.DataSource = khbll.LoadKhachHang();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang
            {
                MaKH = maKHTextBox.Text,
                TenKH = tenKHTextBox.Text,
                NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text),
                GioiTinh = gioiTinhTextBox.Text,
                DiaChi = diaChiTextBox.Text,
                Email = eMAILTextBox.Text,
                MatKhau = maKHTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };

            khbll.SuaKhachHang(kh);

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.kHACHHANGTableAdapter.Fill(this.qLShoplaptopDataSet.KHACHHANG);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            maKHTextBox.Clear();
            tenKHTextBox.Clear();
            gioiTinhTextBox.Clear();
            diaChiTextBox.Clear();
            sDTTextBox.Clear();
            ngaySinhDateTimePicker.Value = DateTime.Now;
        }
    }
}
