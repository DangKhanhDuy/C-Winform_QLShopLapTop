namespace GUI
{
    partial class FormKhoHang
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
            this.kHOHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHOHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.kHOHANGTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.KHOHANGTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kHOHANGDataGridView
            // 
            this.kHOHANGDataGridView.AutoGenerateColumns = false;
            this.kHOHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHOHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kHOHANGDataGridView.DataSource = this.kHOHANGBindingSource;
            this.kHOHANGDataGridView.Location = new System.Drawing.Point(150, 36);
            this.kHOHANGDataGridView.Name = "kHOHANGDataGridView";
            this.kHOHANGDataGridView.RowTemplate.Height = 24;
            this.kHOHANGDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kHOHANGDataGridView.Size = new System.Drawing.Size(752, 422);
            this.kHOHANGDataGridView.TabIndex = 1;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(1027, 100);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(125, 59);
            this.btn_lammoi.TabIndex = 2;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(1027, 220);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(125, 59);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa sản phẩm trong kho";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.Location = new System.Drawing.Point(1027, 341);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.Size = new System.Drawing.Size(125, 59);
            this.btn_xuatexcel.TabIndex = 2;
            this.btn_xuatexcel.Text = "Xuất Excel";
            this.btn_xuatexcel.UseVisualStyleBackColor = true;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKho";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKho";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaSP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenSP";
            this.dataGridViewTextBoxColumn3.HeaderText = "TenSP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLuongTon";
            this.dataGridViewTextBoxColumn4.HeaderText = "SoLuongTon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgayNhap";
            this.dataGridViewTextBoxColumn5.HeaderText = "NgayNhap";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // kHOHANGBindingSource
            // 
            this.kHOHANGBindingSource.DataMember = "KHOHANG";
            this.kHOHANGBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // qLShoplaptopDataSet
            // 
            this.qLShoplaptopDataSet.DataSetName = "QLShoplaptopDataSet";
            this.qLShoplaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOHANGTableAdapter
            // 
            this.kHOHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHITIETHOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOHANGTableAdapter = this.kHOHANGTableAdapter;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 614);
            this.Controls.Add(this.btn_xuatexcel);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.kHOHANGDataGridView);
            this.Name = "FormKhoHang";
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.FormKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource kHOHANGBindingSource;
        private QLShoplaptopDataSetTableAdapters.KHOHANGTableAdapter kHOHANGTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kHOHANGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xuatexcel;
    }
}