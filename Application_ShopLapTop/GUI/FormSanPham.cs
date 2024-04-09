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
    public partial class FormSanPham : Form
    {
        SanPhamBLL spbll = new SanPhamBLL();

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            this.sANPHAMTableAdapter.Fill(this.qLShoplaptopDataSet.SANPHAM);
            maNCCComboBox.DataSource = qLShoplaptopDataSet.SANPHAM;
            maNCCComboBox.DisplayMember = "MaNCC"; 
            maNCCComboBox.ValueMember = "MaNCC"; 
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham pSanPham = new SanPham
            {
                MaSP = maSPTextBox.Text,
                TenSP = tenSPTextBox.Text,
                SoLuong = int.Parse(soLuongTextBox.Text),
                GiaBan = int.Parse(giaBanTextBox.Text),
                CPU = cPUTextBox.Text,
                VGA = vGATextBox.Text,
                DISPLAY = dISPLAYTextBox.Text,
                MaNCC = maNCCComboBox.SelectedValue.ToString()
            };

            if (maSPTextBox.Text != null)
            {
                int? kq = this.sANPHAMTableAdapter.KTKCSP(maSPTextBox.Text);
                if (kq.Value > 0)
                {
                    MessageBox.Show("Trùng khóa mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            spbll.ThemSanPham(pSanPham);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.sANPHAMTableAdapter.Fill(this.qLShoplaptopDataSet.SANPHAM);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (sANPHAMDataGridView.SelectedRows.Count > 0)
            {
                string maSP = sANPHAMDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    spbll.XoaSanPham(maSP);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sANPHAMDataGridView.DataSource = spbll.LoadSanPham();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SanPham pSanPham = new SanPham
            {
                MaSP = maSPTextBox.Text,
                TenSP = tenSPTextBox.Text,
                SoLuong = int.Parse(soLuongTextBox.Text),
                GiaBan = int.Parse(giaBanTextBox.Text),
                MaNCC = maNCCComboBox.SelectedValue.ToString(),
                CPU = cPUTextBox.Text,
                VGA = vGATextBox.Text,
                DISPLAY = dISPLAYTextBox.Text
            };

            spbll.SuaSanPham(pSanPham);

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.sANPHAMTableAdapter.Fill(this.qLShoplaptopDataSet.SANPHAM);
        }

        private void btn_showallsp_Click(object sender, EventArgs e)
        {
            this.sANPHAMTableAdapter.Fill(this.qLShoplaptopDataSet.SANPHAM);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            maSPTextBox.Clear();
            tenSPTextBox.Clear();
            soLuongTextBox.Clear();
            giaBanTextBox.Clear();
            maNCCComboBox.SelectedItem = null;
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
            if (sANPHAMDataGridView != null)
            {
                for (int i = 1; i < sANPHAMDataGridView.Columns.Count + 1; i++)
                {
                    if (sANPHAMDataGridView.Columns[i - 1] != null)
                    {
                        worksheet.Cells[1, i] = sANPHAMDataGridView.Columns[i - 1].HeaderText;
                    }
                }

                for (int i = 0; i < sANPHAMDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < sANPHAMDataGridView.Columns.Count; j++)
                    {
                        if (sANPHAMDataGridView.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = sANPHAMDataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
