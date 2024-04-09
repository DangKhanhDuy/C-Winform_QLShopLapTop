namespace GUI
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maHDLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label ngayBanLabel;
            System.Windows.Forms.Label tongTienLabel;
            this.hOADONDataGridView = new System.Windows.Forms.DataGridView();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.maHDTextBox = new System.Windows.Forms.TextBox();
            this.maNVTextBox = new System.Windows.Forms.TextBox();
            this.maKHTextBox = new System.Windows.Forms.TextBox();
            this.maSPTextBox = new System.Windows.Forms.TextBox();
            this.ngayBanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tongTienTextBox = new System.Windows.Forms.TextBox();
            this.btn_xacnhna = new System.Windows.Forms.Button();
            this.cHITIETHOADONDataGridView = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            this.cHITIETHOADONTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.CHITIETHOADONTableAdapter();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            maHDLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            maKHLabel = new System.Windows.Forms.Label();
            maSPLabel = new System.Windows.Forms.Label();
            ngayBanLabel = new System.Windows.Forms.Label();
            tongTienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maHDLabel
            // 
            maHDLabel.AutoSize = true;
            maHDLabel.Location = new System.Drawing.Point(36, 64);
            maHDLabel.Name = "maHDLabel";
            maHDLabel.Size = new System.Drawing.Size(55, 17);
            maHDLabel.TabIndex = 2;
            maHDLabel.Text = "Ma HD:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(36, 92);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(54, 17);
            maNVLabel.TabIndex = 4;
            maNVLabel.Text = "Ma NV:";
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Location = new System.Drawing.Point(36, 120);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(54, 17);
            maKHLabel.TabIndex = 6;
            maKHLabel.Text = "Ma KH:";
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Location = new System.Drawing.Point(38, 196);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(53, 17);
            maSPLabel.TabIndex = 8;
            maSPLabel.Text = "Ma SP:";
            // 
            // ngayBanLabel
            // 
            ngayBanLabel.AutoSize = true;
            ngayBanLabel.Location = new System.Drawing.Point(38, 225);
            ngayBanLabel.Name = "ngayBanLabel";
            ngayBanLabel.Size = new System.Drawing.Size(74, 17);
            ngayBanLabel.TabIndex = 10;
            ngayBanLabel.Text = "Ngay Ban:";
            // 
            // tongTienLabel
            // 
            tongTienLabel.AutoSize = true;
            tongTienLabel.Location = new System.Drawing.Point(38, 252);
            tongTienLabel.Name = "tongTienLabel";
            tongTienLabel.Size = new System.Drawing.Size(77, 17);
            tongTienLabel.TabIndex = 12;
            tongTienLabel.Text = "Tong Tien:";
            // 
            // hOADONDataGridView
            // 
            this.hOADONDataGridView.AllowUserToAddRows = false;
            this.hOADONDataGridView.AutoGenerateColumns = false;
            this.hOADONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hOADONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.TrangThai});
            this.hOADONDataGridView.DataSource = this.hOADONBindingSource;
            this.hOADONDataGridView.Location = new System.Drawing.Point(413, 50);
            this.hOADONDataGridView.Name = "hOADONDataGridView";
            this.hOADONDataGridView.RowTemplate.Height = 24;
            this.hOADONDataGridView.Size = new System.Drawing.Size(1004, 255);
            this.hOADONDataGridView.TabIndex = 1;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // qLShoplaptopDataSet
            // 
            this.qLShoplaptopDataSet.DataSetName = "QLShoplaptopDataSet";
            this.qLShoplaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maHDTextBox
            // 
            this.maHDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MaHD", true));
            this.maHDTextBox.Location = new System.Drawing.Point(153, 62);
            this.maHDTextBox.Name = "maHDTextBox";
            this.maHDTextBox.Size = new System.Drawing.Size(200, 22);
            this.maHDTextBox.TabIndex = 3;
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MaNV", true));
            this.maNVTextBox.Location = new System.Drawing.Point(153, 90);
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(200, 22);
            this.maNVTextBox.TabIndex = 5;
            // 
            // maKHTextBox
            // 
            this.maKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MaKH", true));
            this.maKHTextBox.Location = new System.Drawing.Point(153, 118);
            this.maKHTextBox.Name = "maKHTextBox";
            this.maKHTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKHTextBox.TabIndex = 7;
            // 
            // maSPTextBox
            // 
            this.maSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MaSP", true));
            this.maSPTextBox.Location = new System.Drawing.Point(153, 192);
            this.maSPTextBox.Name = "maSPTextBox";
            this.maSPTextBox.Size = new System.Drawing.Size(200, 22);
            this.maSPTextBox.TabIndex = 9;
            // 
            // ngayBanDateTimePicker
            // 
            this.ngayBanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOADONBindingSource, "NgayBan", true));
            this.ngayBanDateTimePicker.Location = new System.Drawing.Point(153, 220);
            this.ngayBanDateTimePicker.Name = "ngayBanDateTimePicker";
            this.ngayBanDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngayBanDateTimePicker.TabIndex = 11;
            // 
            // tongTienTextBox
            // 
            this.tongTienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "TongTien", true));
            this.tongTienTextBox.Location = new System.Drawing.Point(153, 248);
            this.tongTienTextBox.Name = "tongTienTextBox";
            this.tongTienTextBox.Size = new System.Drawing.Size(200, 22);
            this.tongTienTextBox.TabIndex = 13;
            // 
            // btn_xacnhna
            // 
            this.btn_xacnhna.Location = new System.Drawing.Point(153, 366);
            this.btn_xacnhna.Name = "btn_xacnhna";
            this.btn_xacnhna.Size = new System.Drawing.Size(200, 54);
            this.btn_xacnhna.TabIndex = 16;
            this.btn_xacnhna.Text = "Xác Nhận Hóa Đơn";
            this.btn_xacnhna.UseVisualStyleBackColor = true;
            this.btn_xacnhna.Click += new System.EventHandler(this.btn_xacnhna_Click);
            // 
            // cHITIETHOADONDataGridView
            // 
            this.cHITIETHOADONDataGridView.AllowUserToAddRows = false;
            this.cHITIETHOADONDataGridView.AutoGenerateColumns = false;
            this.cHITIETHOADONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cHITIETHOADONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.dataGridViewTextBoxColumn8,
            this.SoLuong,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.cHITIETHOADONDataGridView.DataSource = this.cHITIETHOADONBindingSource;
            this.cHITIETHOADONDataGridView.Location = new System.Drawing.Point(413, 366);
            this.cHITIETHOADONDataGridView.Name = "cHITIETHOADONDataGridView";
            this.cHITIETHOADONDataGridView.RowTemplate.Height = 24;
            this.cHITIETHOADONDataGridView.Size = new System.Drawing.Size(786, 220);
            this.cHITIETHOADONDataGridView.TabIndex = 17;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn8.HeaderText = "MaHD";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn10.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn11.HeaderText = "ThanhTien";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // cHITIETHOADONBindingSource
            // 
            this.cHITIETHOADONBindingSource.DataMember = "CHITIETHOADON";
            this.cHITIETHOADONBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = this.hOADONTableAdapter;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOHANGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cHITIETHOADONTableAdapter
            // 
            this.cHITIETHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "MaHD";
            this.MaHD.Name = "MaHD";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaNV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaKH";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaSP";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaSP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgayBan";
            this.dataGridViewTextBoxColumn5.HeaderText = "NgayBan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn6.HeaderText = "TongTien";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 683);
            this.Controls.Add(this.cHITIETHOADONDataGridView);
            this.Controls.Add(this.btn_xacnhna);
            this.Controls.Add(maHDLabel);
            this.Controls.Add(this.maHDTextBox);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(this.maNVTextBox);
            this.Controls.Add(maKHLabel);
            this.Controls.Add(this.maKHTextBox);
            this.Controls.Add(maSPLabel);
            this.Controls.Add(this.maSPTextBox);
            this.Controls.Add(ngayBanLabel);
            this.Controls.Add(this.ngayBanDateTimePicker);
            this.Controls.Add(tongTienLabel);
            this.Controls.Add(this.tongTienTextBox);
            this.Controls.Add(this.hOADONDataGridView);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOADONDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLShoplaptopDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hOADONDataGridView;
        private System.Windows.Forms.TextBox maHDTextBox;
        private System.Windows.Forms.TextBox maNVTextBox;
        private System.Windows.Forms.TextBox maKHTextBox;
        private System.Windows.Forms.TextBox maSPTextBox;
        private System.Windows.Forms.DateTimePicker ngayBanDateTimePicker;
        private System.Windows.Forms.TextBox tongTienTextBox;
        private System.Windows.Forms.Button btn_xacnhna;
        private System.Windows.Forms.BindingSource cHITIETHOADONBindingSource;
        private QLShoplaptopDataSetTableAdapters.CHITIETHOADONTableAdapter cHITIETHOADONTableAdapter;
        private System.Windows.Forms.DataGridView cHITIETHOADONDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
    }
}