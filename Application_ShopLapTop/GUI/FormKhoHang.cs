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

namespace GUI
{
    public partial class FormKhoHang : Form
    {
        KhoHangBLL khbll = new KhoHangBLL();

        public FormKhoHang()
        {
            InitializeComponent();
        }

        private void kHOHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.KHOHANG' table. You can move, or remove it, as needed.
            this.kHOHANGTableAdapter.Fill(this.qLShoplaptopDataSet.KHOHANG);

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            this.kHOHANGTableAdapter.Fill(this.qLShoplaptopDataSet.KHOHANG);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (kHOHANGDataGridView.SelectedRows.Count > 0)
            {
                string maKho = kHOHANGDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    khbll.XoaKhoHang(maKho);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kHOHANGDataGridView.DataSource = khbll.LoadKhoHang();
                }
            }
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
            if (kHOHANGDataGridView != null)
            {
                for (int i = 1; i < kHOHANGDataGridView.Columns.Count + 1; i++)
                {
                    if (kHOHANGDataGridView.Columns[i - 1] != null)
                    {
                        worksheet.Cells[1, i] = kHOHANGDataGridView.Columns[i - 1].HeaderText;
                    }
                }

                for (int i = 0; i < kHOHANGDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < kHOHANGDataGridView.Columns.Count; j++)
                    {
                        if (kHOHANGDataGridView.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = kHOHANGDataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
