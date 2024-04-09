namespace GUI
{
    partial class FormNhaCungCap
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
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label tenNCCLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sDTLabel;
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHACUNGCAPTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.NHACUNGCAPTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHACUNGCAPDataGridView = new System.Windows.Forms.DataGridView();
            this.maNCCTextBox = new System.Windows.Forms.TextBox();
            this.tenNCCTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            maNCCLabel = new System.Windows.Forms.Label();
            tenNCCLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(123, 56);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(117, 17);
            maNCCLabel.TabIndex = 2;
            maNCCLabel.Text = "Mã nhà cung cấp";
            // 
            // tenNCCLabel
            // 
            tenNCCLabel.AutoSize = true;
            tenNCCLabel.Location = new System.Drawing.Point(123, 107);
            tenNCCLabel.Name = "tenNCCLabel";
            tenNCCLabel.Size = new System.Drawing.Size(123, 17);
            tenNCCLabel.TabIndex = 4;
            tenNCCLabel.Text = "Tên nhà cung cấp";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(123, 157);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(51, 17);
            diaChiLabel.TabIndex = 6;
            diaChiLabel.Text = "Địa chỉ";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(123, 209);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(91, 17);
            sDTLabel.TabIndex = 8;
            sDTLabel.Text = "Số điện thoại";
            // 
            // qLShoplaptopDataSet
            // 
            this.qLShoplaptopDataSet.DataSetName = "QLShoplaptopDataSet";
            this.qLShoplaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOHANGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = this.nHACUNGCAPTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn4.HeaderText = "SDT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn3.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNCC";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNCC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNCC";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNCC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nHACUNGCAPDataGridView
            // 
            this.nHACUNGCAPDataGridView.AutoGenerateColumns = false;
            this.nHACUNGCAPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHACUNGCAPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nHACUNGCAPDataGridView.DataSource = this.nHACUNGCAPBindingSource;
            this.nHACUNGCAPDataGridView.Location = new System.Drawing.Point(680, 34);
            this.nHACUNGCAPDataGridView.Name = "nHACUNGCAPDataGridView";
            this.nHACUNGCAPDataGridView.RowTemplate.Height = 24;
            this.nHACUNGCAPDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nHACUNGCAPDataGridView.Size = new System.Drawing.Size(623, 270);
            this.nHACUNGCAPDataGridView.TabIndex = 1;
            // 
            // maNCCTextBox
            // 
            this.maNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "MaNCC", true));
            this.maNCCTextBox.Location = new System.Drawing.Point(357, 51);
            this.maNCCTextBox.Name = "maNCCTextBox";
            this.maNCCTextBox.Size = new System.Drawing.Size(212, 22);
            this.maNCCTextBox.TabIndex = 3;
            // 
            // tenNCCTextBox
            // 
            this.tenNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "TenNCC", true));
            this.tenNCCTextBox.Location = new System.Drawing.Point(357, 102);
            this.tenNCCTextBox.Name = "tenNCCTextBox";
            this.tenNCCTextBox.Size = new System.Drawing.Size(212, 22);
            this.tenNCCTextBox.TabIndex = 5;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(357, 152);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(212, 22);
            this.diaChiTextBox.TabIndex = 7;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(357, 206);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(212, 22);
            this.sDTTextBox.TabIndex = 9;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(495, 311);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(130, 53);
            this.btn_excel.TabIndex = 17;
            this.btn_excel.Text = "Xuất Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(307, 352);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(130, 53);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(307, 266);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 53);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(126, 352);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 53);
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(126, 266);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 53);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 579);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(tenNCCLabel);
            this.Controls.Add(this.tenNCCTextBox);
            this.Controls.Add(maNCCLabel);
            this.Controls.Add(this.maNCCTextBox);
            this.Controls.Add(this.nHACUNGCAPDataGridView);
            this.Name = "FormNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private QLShoplaptopDataSetTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView nHACUNGCAPDataGridView;
        private System.Windows.Forms.TextBox maNCCTextBox;
        private System.Windows.Forms.TextBox tenNCCTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
    }
}