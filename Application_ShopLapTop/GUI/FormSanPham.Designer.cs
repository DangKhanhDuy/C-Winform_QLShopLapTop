namespace GUI
{
    partial class FormSanPham
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
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label tenSPLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label cPULabel;
            System.Windows.Forms.Label vGALabel;
            System.Windows.Forms.Label rAMLabel;
            System.Windows.Forms.Label dISPLAYLabel;
            System.Windows.Forms.Label maNCCLabel;
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.sANPHAMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPTextBox = new System.Windows.Forms.TextBox();
            this.tenSPTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTextBox = new System.Windows.Forms.TextBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.cPUTextBox = new System.Windows.Forms.TextBox();
            this.vGATextBox = new System.Windows.Forms.TextBox();
            this.rAMTextBox = new System.Windows.Forms.TextBox();
            this.dISPLAYTextBox = new System.Windows.Forms.TextBox();
            this.maNCCComboBox = new System.Windows.Forms.ComboBox();
            maSPLabel = new System.Windows.Forms.Label();
            tenSPLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            cPULabel = new System.Windows.Forms.Label();
            vGALabel = new System.Windows.Forms.Label();
            rAMLabel = new System.Windows.Forms.Label();
            dISPLAYLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Location = new System.Drawing.Point(89, 34);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(93, 17);
            maSPLabel.TabIndex = 12;
            maSPLabel.Text = "Mã sản phẩm";
            // 
            // tenSPLabel
            // 
            tenSPLabel.AutoSize = true;
            tenSPLabel.Location = new System.Drawing.Point(89, 88);
            tenSPLabel.Name = "tenSPLabel";
            tenSPLabel.Size = new System.Drawing.Size(99, 17);
            tenSPLabel.TabIndex = 13;
            tenSPLabel.Text = "Tên sản phẩm";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(89, 141);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(64, 17);
            soLuongLabel.TabIndex = 14;
            soLuongLabel.Text = "Số lượng";
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Location = new System.Drawing.Point(973, 31);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(58, 17);
            giaBanLabel.TabIndex = 16;
            giaBanLabel.Text = "Giá bán";
            // 
            // cPULabel
            // 
            cPULabel.AutoSize = true;
            cPULabel.Location = new System.Drawing.Point(550, 34);
            cPULabel.Name = "cPULabel";
            cPULabel.Size = new System.Drawing.Size(40, 17);
            cPULabel.TabIndex = 17;
            cPULabel.Text = "CPU:";
            // 
            // vGALabel
            // 
            vGALabel.AutoSize = true;
            vGALabel.Location = new System.Drawing.Point(550, 91);
            vGALabel.Name = "vGALabel";
            vGALabel.Size = new System.Drawing.Size(41, 17);
            vGALabel.TabIndex = 18;
            vGALabel.Text = "VGA:";
            // 
            // rAMLabel
            // 
            rAMLabel.AutoSize = true;
            rAMLabel.Location = new System.Drawing.Point(550, 146);
            rAMLabel.Name = "rAMLabel";
            rAMLabel.Size = new System.Drawing.Size(42, 17);
            rAMLabel.TabIndex = 19;
            rAMLabel.Text = "RAM:";
            // 
            // dISPLAYLabel
            // 
            dISPLAYLabel.AutoSize = true;
            dISPLAYLabel.Location = new System.Drawing.Point(973, 139);
            dISPLAYLabel.Name = "dISPLAYLabel";
            dISPLAYLabel.Size = new System.Drawing.Size(69, 17);
            dISPLAYLabel.TabIndex = 20;
            dISPLAYLabel.Text = "DISPLAY:";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(973, 86);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(63, 17);
            maNCCLabel.TabIndex = 22;
            maNCCLabel.Text = "Ma NCC:";
            // 
            // qLShoplaptopDataSet
            // 
            this.qLShoplaptopDataSet.DataSetName = "QLShoplaptopDataSet";
            this.qLShoplaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOHANGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(92, 256);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 53);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(313, 256);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 53);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(663, 256);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 53);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(860, 256);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(130, 53);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.Location = new System.Drawing.Point(1121, 256);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.Size = new System.Drawing.Size(174, 53);
            this.btn_xuatexcel.TabIndex = 12;
            this.btn_xuatexcel.Text = "Xuất Excel";
            this.btn_xuatexcel.UseVisualStyleBackColor = true;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // sANPHAMDataGridView
            // 
            this.sANPHAMDataGridView.AutoGenerateColumns = false;
            this.sANPHAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sANPHAMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.sANPHAMDataGridView.DataSource = this.sANPHAMBindingSource;
            this.sANPHAMDataGridView.Location = new System.Drawing.Point(92, 365);
            this.sANPHAMDataGridView.Name = "sANPHAMDataGridView";
            this.sANPHAMDataGridView.RowTemplate.Height = 24;
            this.sANPHAMDataGridView.Size = new System.Drawing.Size(1203, 254);
            this.sANPHAMDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSP";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenSP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn4.HeaderText = "GiaBan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HinhAnh";
            this.dataGridViewTextBoxColumn5.HeaderText = "HinhAnh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CPU";
            this.dataGridViewTextBoxColumn6.HeaderText = "CPU";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VGA";
            this.dataGridViewTextBoxColumn7.HeaderText = "VGA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RAM";
            this.dataGridViewTextBoxColumn8.HeaderText = "RAM";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DISPLAY";
            this.dataGridViewTextBoxColumn9.HeaderText = "DISPLAY";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaNCC";
            this.dataGridViewTextBoxColumn10.HeaderText = "MaNCC";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // maSPTextBox
            // 
            this.maSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MaSP", true));
            this.maSPTextBox.Location = new System.Drawing.Point(265, 29);
            this.maSPTextBox.Name = "maSPTextBox";
            this.maSPTextBox.Size = new System.Drawing.Size(178, 22);
            this.maSPTextBox.TabIndex = 13;
            // 
            // tenSPTextBox
            // 
            this.tenSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TenSP", true));
            this.tenSPTextBox.Location = new System.Drawing.Point(265, 83);
            this.tenSPTextBox.Name = "tenSPTextBox";
            this.tenSPTextBox.Size = new System.Drawing.Size(178, 22);
            this.tenSPTextBox.TabIndex = 14;
            // 
            // soLuongTextBox
            // 
            this.soLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "SoLuong", true));
            this.soLuongTextBox.Location = new System.Drawing.Point(265, 136);
            this.soLuongTextBox.Name = "soLuongTextBox";
            this.soLuongTextBox.Size = new System.Drawing.Size(178, 22);
            this.soLuongTextBox.TabIndex = 15;
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "GiaBan", true));
            this.giaBanTextBox.Location = new System.Drawing.Point(1109, 29);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(186, 22);
            this.giaBanTextBox.TabIndex = 17;
            // 
            // cPUTextBox
            // 
            this.cPUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "CPU", true));
            this.cPUTextBox.Location = new System.Drawing.Point(663, 31);
            this.cPUTextBox.Name = "cPUTextBox";
            this.cPUTextBox.Size = new System.Drawing.Size(190, 22);
            this.cPUTextBox.TabIndex = 18;
            // 
            // vGATextBox
            // 
            this.vGATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "VGA", true));
            this.vGATextBox.Location = new System.Drawing.Point(663, 87);
            this.vGATextBox.Name = "vGATextBox";
            this.vGATextBox.Size = new System.Drawing.Size(190, 22);
            this.vGATextBox.TabIndex = 19;
            // 
            // rAMTextBox
            // 
            this.rAMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "RAM", true));
            this.rAMTextBox.Location = new System.Drawing.Point(663, 141);
            this.rAMTextBox.Name = "rAMTextBox";
            this.rAMTextBox.Size = new System.Drawing.Size(190, 22);
            this.rAMTextBox.TabIndex = 20;
            // 
            // dISPLAYTextBox
            // 
            this.dISPLAYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "DISPLAY", true));
            this.dISPLAYTextBox.Location = new System.Drawing.Point(1110, 136);
            this.dISPLAYTextBox.Name = "dISPLAYTextBox";
            this.dISPLAYTextBox.Size = new System.Drawing.Size(185, 22);
            this.dISPLAYTextBox.TabIndex = 21;
            // 
            // maNCCComboBox
            // 
            this.maNCCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MaNCC", true));
            this.maNCCComboBox.FormattingEnabled = true;
            this.maNCCComboBox.Location = new System.Drawing.Point(1109, 83);
            this.maNCCComboBox.Name = "maNCCComboBox";
            this.maNCCComboBox.Size = new System.Drawing.Size(186, 24);
            this.maNCCComboBox.TabIndex = 23;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 643);
            this.Controls.Add(maNCCLabel);
            this.Controls.Add(this.maNCCComboBox);
            this.Controls.Add(dISPLAYLabel);
            this.Controls.Add(this.dISPLAYTextBox);
            this.Controls.Add(rAMLabel);
            this.Controls.Add(this.rAMTextBox);
            this.Controls.Add(vGALabel);
            this.Controls.Add(this.vGATextBox);
            this.Controls.Add(cPULabel);
            this.Controls.Add(this.cPUTextBox);
            this.Controls.Add(giaBanLabel);
            this.Controls.Add(this.giaBanTextBox);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.soLuongTextBox);
            this.Controls.Add(tenSPLabel);
            this.Controls.Add(this.tenSPTextBox);
            this.Controls.Add(maSPLabel);
            this.Controls.Add(this.maSPTextBox);
            this.Controls.Add(this.sANPHAMDataGridView);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xuatexcel);
            this.Controls.Add(this.btn_them);
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLShoplaptopDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xuatexcel;
        private System.Windows.Forms.DataGridView sANPHAMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox maSPTextBox;
        private System.Windows.Forms.TextBox tenSPTextBox;
        private System.Windows.Forms.TextBox soLuongTextBox;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.TextBox cPUTextBox;
        private System.Windows.Forms.TextBox vGATextBox;
        private System.Windows.Forms.TextBox rAMTextBox;
        private System.Windows.Forms.TextBox dISPLAYTextBox;
        private System.Windows.Forms.ComboBox maNCCComboBox;
    }
}