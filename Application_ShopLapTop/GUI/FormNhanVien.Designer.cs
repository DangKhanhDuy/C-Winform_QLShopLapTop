namespace GUI
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label tenNVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            this.nHANVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.maNVTextBox = new System.Windows.Forms.TextBox();
            this.tenNVTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.nHANVIENTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            maNVLabel = new System.Windows.Forms.Label();
            tenNVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(216, 38);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(93, 17);
            maNVLabel.TabIndex = 1;
            maNVLabel.Text = "Mã nhân viên";
            // 
            // tenNVLabel
            // 
            tenNVLabel.AutoSize = true;
            tenNVLabel.Location = new System.Drawing.Point(214, 91);
            tenNVLabel.Name = "tenNVLabel";
            tenNVLabel.Size = new System.Drawing.Size(99, 17);
            tenNVLabel.TabIndex = 3;
            tenNVLabel.Text = "Tên nhân viên";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(214, 139);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(71, 17);
            ngaySinhLabel.TabIndex = 5;
            ngaySinhLabel.Text = "Ngày sinh";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(216, 236);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(51, 17);
            diaChiLabel.TabIndex = 7;
            diaChiLabel.Text = "Địa chỉ";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(217, 282);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(40, 17);
            sDTLabel.TabIndex = 9;
            sDTLabel.Text = "SDT:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(214, 186);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(69, 17);
            gioiTinhLabel.TabIndex = 16;
            gioiTinhLabel.Text = "Gioi Tinh:";
            // 
            // nHANVIENDataGridView
            // 
            this.nHANVIENDataGridView.AutoGenerateColumns = false;
            this.nHANVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHANVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.nHANVIENDataGridView.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENDataGridView.Location = new System.Drawing.Point(217, 352);
            this.nHANVIENDataGridView.Name = "nHANVIENDataGridView";
            this.nHANVIENDataGridView.RowTemplate.Height = 24;
            this.nHANVIENDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nHANVIENDataGridView.Size = new System.Drawing.Size(860, 220);
            this.nHANVIENDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgaySinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn5.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn6.HeaderText = "SDT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // qLShoplaptopDataSet
            // 
            this.qLShoplaptopDataSet.DataSetName = "QLShoplaptopDataSet";
            this.qLShoplaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "MaNV", true));
            this.maNVTextBox.Location = new System.Drawing.Point(434, 35);
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(200, 22);
            this.maNVTextBox.TabIndex = 2;
            // 
            // tenNVTextBox
            // 
            this.tenNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "TenNV", true));
            this.tenNVTextBox.Location = new System.Drawing.Point(434, 88);
            this.tenNVTextBox.Name = "tenNVTextBox";
            this.tenNVTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenNVTextBox.TabIndex = 4;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHANVIENBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(434, 134);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 6;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(434, 231);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 22);
            this.diaChiTextBox.TabIndex = 8;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(434, 277);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(200, 22);
            this.sDTTextBox.TabIndex = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(947, 55);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(130, 53);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(769, 104);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 53);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(769, 186);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 53);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(769, 18);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 53);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.Location = new System.Drawing.Point(947, 168);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.Size = new System.Drawing.Size(130, 53);
            this.btn_xuatexcel.TabIndex = 13;
            this.btn_xuatexcel.Text = "Xuất Excel";
            this.btn_xuatexcel.UseVisualStyleBackColor = true;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(434, 181);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 22);
            this.gioiTinhTextBox.TabIndex = 17;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOHANGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 633);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(this.btn_xuatexcel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(tenNVLabel);
            this.Controls.Add(this.tenNVTextBox);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(this.maNVTextBox);
            this.Controls.Add(this.nHANVIENDataGridView);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLShoplaptopDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nHANVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox maNVTextBox;
        private System.Windows.Forms.TextBox tenNVTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xuatexcel;
        private System.Windows.Forms.TextBox gioiTinhTextBox;

    }
}