﻿namespace PHANHE1
{
    partial class ChinhSuaUser
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
            this.panelChinhSuaUser = new System.Windows.Forms.Panel();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.panelChinhSuaUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChinhSuaUser
            // 
            this.panelChinhSuaUser.Controls.Add(this.buttonCapNhat);
            this.panelChinhSuaUser.Controls.Add(this.textBoxMatKhau);
            this.panelChinhSuaUser.Controls.Add(this.labelMatKhau);
            this.panelChinhSuaUser.Controls.Add(this.textBoxTaiKhoan);
            this.panelChinhSuaUser.Controls.Add(this.labelTaiKhoan);
            this.panelChinhSuaUser.Controls.Add(this.buttonQuayLai);
            this.panelChinhSuaUser.Location = new System.Drawing.Point(0, -10);
            this.panelChinhSuaUser.Name = "panelChinhSuaUser";
            this.panelChinhSuaUser.Size = new System.Drawing.Size(935, 600);
            this.panelChinhSuaUser.TabIndex = 0;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapNhat.Location = new System.Drawing.Point(150, 414);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(200, 70);
            this.buttonCapNhat.TabIndex = 24;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(150, 309);
            this.textBoxMatKhau.Multiline = true;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '*';
            this.textBoxMatKhau.Size = new System.Drawing.Size(630, 50);
            this.textBoxMatKhau.TabIndex = 23;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(150, 256);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(152, 41);
            this.labelMatKhau.TabIndex = 22;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(150, 169);
            this.textBoxTaiKhoan.Multiline = true;
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(630, 50);
            this.textBoxTaiKhoan.TabIndex = 21;
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTaiKhoan.Location = new System.Drawing.Point(150, 116);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(153, 41);
            this.labelTaiKhoan.TabIndex = 20;
            this.labelTaiKhoan.Text = "Tài khoản";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(580, 414);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 19;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // ChinhSuaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.panelChinhSuaUser);
            this.Name = "ChinhSuaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChinhSuaUser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelChinhSuaUser.ResumeLayout(false);
            this.panelChinhSuaUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChinhSuaUser;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox textBoxTaiKhoan;
        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}

