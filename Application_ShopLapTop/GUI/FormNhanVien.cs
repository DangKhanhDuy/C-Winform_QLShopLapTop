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
    public partial class FormNhanVien : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        public FormNhanVien()
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

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLShoplaptopDataSet.NHANVIEN);

        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien
            {
                MaNV = maNVTextBox.Text,
                TenNV = tenNVTextBox.Text,
                NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text),
                GioiTinh = gioiTinhTextBox.Text,
                DiaChi = diaChiTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };
            if (maNVTextBox.Text != null)
            {
                int? kq = this.nHANVIENTableAdapter.KTKCNV(maNVTextBox.Text);
                if (kq.Value > 0)
                {
                    MessageBox.Show("Trùng khóa mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            nvbll.ThemNhanVien(nv);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.nHANVIENTableAdapter.Fill(this.qLShoplaptopDataSet.NHANVIEN);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (nHANVIENDataGridView.SelectedRows.Count > 0)
            {
                string maNV = nHANVIENDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nvbll.XoaNhanVien(maNV);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nHANVIENDataGridView.DataSource = nvbll.LoadNhanVien();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien
            {
                MaNV = maNVTextBox.Text,
                TenNV = tenNVTextBox.Text,
                NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text),
                GioiTinh = gioiTinhTextBox.Text,
                DiaChi = diaChiTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };

            nvbll.SuaNhanVien(nv);

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.nHANVIENTableAdapter.Fill(this.qLShoplaptopDataSet.NHANVIEN);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            maNVTextBox.Clear();
            tenNVTextBox.Clear();
            ngaySinhDateTimePicker.Value = DateTime.Now;
            gioiTinhTextBox.Clear();
            diaChiTextBox.Clear();
            sDTTextBox.Clear();
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            if (nHANVIENDataGridView != null)
            {
                for (int i = 1; i < nHANVIENDataGridView.Columns.Count + 1; i++)
                {
                    if (nHANVIENDataGridView.Columns[i - 1] != null)
                    {
                        worksheet.Cells[1, i] = nHANVIENDataGridView.Columns[i - 1].HeaderText;
                    }
                }

                for (int i = 0; i < nHANVIENDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < nHANVIENDataGridView.Columns.Count; j++)
                    {
                        if (nHANVIENDataGridView.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = nHANVIENDataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
