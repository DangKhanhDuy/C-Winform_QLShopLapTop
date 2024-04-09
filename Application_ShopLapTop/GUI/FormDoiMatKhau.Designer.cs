namespace GUI
{
    partial class FormDoiMatKhau
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
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_tennguoidung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tentaikhoan = new ThietKeControls.TaiKhoanTextBox();
            this.txt_matkhaucu = new ThietKeControls.MatKhauTextBox();
            this.txt_matkhaumoi = new ThietKeControls.MatKhauTextBox();
            this.txt_nhaplaimatkhau = new ThietKeControls.MatKhauTextBox();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(396, 260);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(78, 57);
            this.btn_huy.TabIndex = 17;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Location = new System.Drawing.Point(247, 260);
            this.btn_doimatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(121, 57);
            this.btn_doimatkhau.TabIndex = 16;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Location = new System.Drawing.Point(46, 87);
            this.lbl_matkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(85, 17);
            this.lbl_matkhau.TabIndex = 13;
            this.lbl_matkhau.Text = "Mật khẩu cũ";
            // 
            // lbl_tennguoidung
            // 
            this.lbl_tennguoidung.AutoSize = true;
            this.lbl_tennguoidung.Location = new System.Drawing.Point(46, 31);
            this.lbl_tennguoidung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tennguoidung.Name = "lbl_tennguoidung";
            this.lbl_tennguoidung.Size = new System.Drawing.Size(95, 17);
            this.lbl_tennguoidung.TabIndex = 12;
            this.lbl_tennguoidung.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txt_tentaikhoan
            // 
            this.txt_tentaikhoan.Location = new System.Drawing.Point(247, 28);
            this.txt_tentaikhoan.Multiline = true;
            this.txt_tentaikhoan.Name = "txt_tentaikhoan";
            this.txt_tentaikhoan.Size = new System.Drawing.Size(227, 31);
            this.txt_tentaikhoan.TabIndex = 22;
            // 
            // txt_matkhaucu
            // 
            this.txt_matkhaucu.Location = new System.Drawing.Point(247, 84);
            this.txt_matkhaucu.Multiline = true;
            this.txt_matkhaucu.Name = "txt_matkhaucu";
            this.txt_matkhaucu.Size = new System.Drawing.Size(227, 31);
            this.txt_matkhaucu.TabIndex = 23;
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.Location = new System.Drawing.Point(247, 139);
            this.txt_matkhaumoi.Multiline = true;
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.Size = new System.Drawing.Size(227, 31);
            this.txt_matkhaumoi.TabIndex = 24;
            // 
            // txt_nhaplaimatkhau
            // 
            this.txt_nhaplaimatkhau.Location = new System.Drawing.Point(247, 197);
            this.txt_nhaplaimatkhau.Multiline = true;
            this.txt_nhaplaimatkhau.Name = "txt_nhaplaimatkhau";
            this.txt_nhaplaimatkhau.Size = new System.Drawing.Size(227, 31);
            this.txt_nhaplaimatkhau.TabIndex = 25;
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 344);
            this.Controls.Add(this.txt_nhaplaimatkhau);
            this.Controls.Add(this.txt_matkhaumoi);
            this.Controls.Add(this.txt_matkhaucu);
            this.Controls.Add(this.txt_tentaikhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_doimatkhau);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.lbl_tennguoidung);
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_tennguoidung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ThietKeControls.TaiKhoanTextBox txt_tentaikhoan;
        private ThietKeControls.MatKhauTextBox txt_matkhaucu;
        private ThietKeControls.MatKhauTextBox txt_matkhaumoi;
        private ThietKeControls.MatKhauTextBox txt_nhaplaimatkhau;
    }
}