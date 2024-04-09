namespace GUI
{
    partial class FormDangNhap
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
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Location = new System.Drawing.Point(76, 437);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(132, 45);
            this.btn_dangnhap.TabIndex = 15;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(76, 391);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 1);
            this.panel2.TabIndex = 14;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.White;
            this.txt_matkhau.HideSelection = false;
            this.txt_matkhau.Location = new System.Drawing.Point(131, 361);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(239, 23);
            this.txt_matkhau.TabIndex = 13;
            this.txt_matkhau.TabStop = false;
            this.txt_matkhau.Text = "Mật khẩu";
            this.txt_matkhau.UseSystemPasswordChar = true;
            this.txt_matkhau.Click += new System.EventHandler(this.txt_matkhau_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(75, 304);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 1);
            this.panel1.TabIndex = 11;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_taikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.ForeColor = System.Drawing.Color.White;
            this.txt_taikhoan.HideSelection = false;
            this.txt_taikhoan.Location = new System.Drawing.Point(129, 273);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(239, 23);
            this.txt_taikhoan.TabIndex = 10;
            this.txt_taikhoan.TabStop = false;
            this.txt_taikhoan.Text = "Tài khoản";
            this.txt_taikhoan.Click += new System.EventHandler(this.txt_taikhoan_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_huybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huybo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huybo.Location = new System.Drawing.Point(263, 437);
            this.btn_huybo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(119, 45);
            this.btn_huybo.TabIndex = 15;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.UseVisualStyleBackColor = false;
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(75, 347);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.username;
            this.pictureBox2.Location = new System.Drawing.Point(73, 260);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._11zon_cropped;
            this.pictureBox1.Location = new System.Drawing.Point(131, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(458, 538);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_huybo;

    }
}