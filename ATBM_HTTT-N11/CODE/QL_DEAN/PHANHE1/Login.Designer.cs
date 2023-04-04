namespace PHANHE1
{
    partial class Login
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelDangNhapHeThong = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelDangNhapHeThong);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -8);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(1069, 130);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            // 
            // labelDangNhapHeThong
            // 
            this.labelDangNhapHeThong.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDangNhapHeThong.Location = new System.Drawing.Point(382, 41);
            this.labelDangNhapHeThong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDangNhapHeThong.Name = "labelDangNhapHeThong";
            this.labelDangNhapHeThong.Size = new System.Drawing.Size(338, 41);
            this.labelDangNhapHeThong.TabIndex = 0;
            this.labelDangNhapHeThong.Text = "Đăng nhập hệ thống";
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonThoat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(632, 587);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(150, 57);
            this.buttonThoat.TabIndex = 13;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTaiKhoan.Location = new System.Drawing.Point(314, 246);
            this.labelTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(123, 32);
            this.labelTaiKhoan.TabIndex = 14;
            this.labelTaiKhoan.Text = "Tài khoản";
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(314, 289);
            this.textBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTaiKhoan.Multiline = true;
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(473, 48);
            this.textBoxTaiKhoan.TabIndex = 15;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(314, 378);
            this.labelMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(121, 32);
            this.labelMatKhau.TabIndex = 16;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(314, 421);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMatKhau.Multiline = true;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '*';
            this.textBoxMatKhau.Size = new System.Drawing.Size(473, 50);
            this.textBoxMatKhau.TabIndex = 17;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangNhap.Location = new System.Drawing.Point(314, 587);
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(150, 57);
            this.buttonDangNhap.TabIndex = 18;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1066, 794);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.textBoxTaiKhoan);
            this.Controls.Add(this.labelTaiKhoan);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonThoat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelDangNhapHeThong;
        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.TextBox textBoxTaiKhoan;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
    }
}