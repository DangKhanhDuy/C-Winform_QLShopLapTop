namespace GUI
{
    partial class FormKhachHang
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
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label eMAILLabel;
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.kHACHHANGTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            this.btn_clear = new System.Windows.Forms.Button();
            this.maKHTextBox = new System.Windows.Forms.TextBox();
            this.tenKHTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.mATKHAUTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.kHACHHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maKHLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // qLShoplaptopDataSet
            // 
            this.qLShoplaptopDataSet.DataSetName = "QLShoplaptopDataSet";
            this.qLShoplaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(719, 259);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 53);
            this.btn_sua.TabIndex = 150;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(456, 259);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 53);
            this.btn_xoa.TabIndex = 151;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(203, 259);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 53);
            this.btn_them.TabIndex = 152;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KHOHANGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(978, 259);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(130, 53);
            this.btn_clear.TabIndex = 153;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Location = new System.Drawing.Point(52, 27);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(105, 17);
            maKHLabel.TabIndex = 153;
            maKHLabel.Text = "Mã khách hàng";
            // 
            // maKHTextBox
            // 
            this.maKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MaKH", true));
            this.maKHTextBox.Location = new System.Drawing.Point(295, 24);
            this.maKHTextBox.Name = "maKHTextBox";
            this.maKHTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKHTextBox.TabIndex = 154;
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Location = new System.Drawing.Point(52, 75);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(111, 17);
            tenKHLabel.TabIndex = 154;
            tenKHLabel.Text = "Tên khách hàng";
            // 
            // tenKHTextBox
            // 
            this.tenKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "TenKH", true));
            this.tenKHTextBox.Location = new System.Drawing.Point(295, 72);
            this.tenKHTextBox.Name = "tenKHTextBox";
            this.tenKHTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenKHTextBox.TabIndex = 155;
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(53, 127);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(71, 17);
            ngaySinhLabel.TabIndex = 155;
            ngaySinhLabel.Text = "Ngày sinh";
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kHACHHANGBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(295, 122);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 156;
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(53, 177);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(60, 17);
            gioiTinhLabel.TabIndex = 156;
            gioiTinhLabel.Text = "Giới tính";
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(295, 172);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 22);
            this.gioiTinhTextBox.TabIndex = 157;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(797, 29);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(51, 17);
            diaChiLabel.TabIndex = 157;
            diaChiLabel.Text = "Địa chỉ";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(1031, 24);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(189, 22);
            this.diaChiTextBox.TabIndex = 158;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(797, 79);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(40, 17);
            sDTLabel.TabIndex = 158;
            sDTLabel.Text = "SDT:";
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(1031, 72);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(189, 22);
            this.sDTTextBox.TabIndex = 159;
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(797, 177);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(79, 17);
            mATKHAULabel.TabIndex = 159;
            mATKHAULabel.Text = "MATKHAU:";
            // 
            // mATKHAUTextBox
            // 
            this.mATKHAUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MATKHAU", true));
            this.mATKHAUTextBox.Location = new System.Drawing.Point(1031, 172);
            this.mATKHAUTextBox.Name = "mATKHAUTextBox";
            this.mATKHAUTextBox.Size = new System.Drawing.Size(189, 22);
            this.mATKHAUTextBox.TabIndex = 160;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(797, 129);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(52, 17);
            eMAILLabel.TabIndex = 160;
            eMAILLabel.Text = "EMAIL:";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(1031, 124);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(189, 22);
            this.eMAILTextBox.TabIndex = 161;
            // 
            // kHACHHANGDataGridView
            // 
            this.kHACHHANGDataGridView.AutoGenerateColumns = false;
            this.kHACHHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.kHACHHANGDataGridView.DataSource = this.kHACHHANGBindingSource;
            this.kHACHHANGDataGridView.Location = new System.Drawing.Point(56, 352);
            this.kHACHHANGDataGridView.Name = "kHACHHANGDataGridView";
            this.kHACHHANGDataGridView.RowTemplate.Height = 24;
            this.kHACHHANGDataGridView.Size = new System.Drawing.Size(1164, 249);
            this.kHACHHANGDataGridView.TabIndex = 161;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKH";
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn7.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MATKHAU";
            this.dataGridViewTextBoxColumn8.HeaderText = "MATKHAU";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 658);
            this.Controls.Add(this.kHACHHANGDataGridView);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(mATKHAULabel);
            this.Controls.Add(this.mATKHAUTextBox);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(tenKHLabel);
            this.Controls.Add(this.tenKHTextBox);
            this.Controls.Add(maKHLabel);
            this.Controls.Add(this.maKHTextBox);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLShoplaptopDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox maKHTextBox;
        private System.Windows.Forms.TextBox tenKHTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox gioiTinhTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox mATKHAUTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.DataGridView kHACHHANGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}