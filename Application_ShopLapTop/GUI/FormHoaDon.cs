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
    public partial class FormHoaDon : Form
    {
        HoaDonBLL hdbll = new HoaDonBLL();
        SanPhamBLL spbll = new SanPhamBLL();
        public FormHoaDon()
        {
            InitializeComponent();
            hOADONDataGridView.CellClick +=hOADONDataGridView_CellClick;
        }

        private void hOADONDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maHDTextBox.Text != string.Empty)
            {
                this.cHITIETHOADONTableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON, maHDTextBox.Text);
            }
            else
            {
                string t = hOADONDataGridView.Rows[0].Cells["MaHD"].Value.ToString();
                if (t != null)
                {
                    this.cHITIETHOADONTableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON, t);
                }
            }
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLShoplaptopDataSet.HOADON);

            maHDTextBox.Enabled = false;
            maNVTextBox.Enabled = false;
            maSPTextBox.Enabled = false;
            maKHTextBox.Enabled = false;
            ngayBanDateTimePicker.Enabled = false;
            tongTienTextBox.Enabled = false;
            this.cHITIETHOADONTableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON, maHDTextBox.Text);
        }

        private void btn_xacnhna_Click(object sender, EventArgs e)
        {

            if (!bool.Parse(hOADONDataGridView.CurrentRow.Cells["TrangThai"].Value.ToString()))
            {
                HoaDon hd = new HoaDon
                {
                    MaHD = maHDTextBox.Text,
                    TrangThai = true
                };

                for (int i = 0; i < cHITIETHOADONDataGridView.RowCount; i++)
                {
                    spbll.updateSLT(int.Parse(cHITIETHOADONDataGridView.Rows[i].Cells["SoLuong"].Value.ToString()), cHITIETHOADONDataGridView.Rows[i].Cells["MaSP"].Value.ToString());
                }
                hdbll.SuaHD(hd);
                MessageBox.Show("Đã xác nhận đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.hOADONTableAdapter.Fill(this.qLShoplaptopDataSet.HOADON);
            }
            else
            {
                MessageBox.Show("Đơn này đã được xác nhận!");
            }
            
        }
    }
}