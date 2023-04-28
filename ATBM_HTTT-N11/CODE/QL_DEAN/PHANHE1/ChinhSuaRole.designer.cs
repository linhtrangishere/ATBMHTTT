namespace PHANHE1
{
    partial class ChinhSuaRole
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
            this.panelChinhSuaRole = new System.Windows.Forms.Panel();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.panelChinhSuaRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChinhSuaRole
            // 
            this.panelChinhSuaRole.Controls.Add(this.buttonCapNhat);
            this.panelChinhSuaRole.Controls.Add(this.textBoxMatKhau);
            this.panelChinhSuaRole.Controls.Add(this.labelMatKhau);
            this.panelChinhSuaRole.Controls.Add(this.textBoxRole);
            this.panelChinhSuaRole.Controls.Add(this.labelRole);
            this.panelChinhSuaRole.Controls.Add(this.buttonQuayLai);
            this.panelChinhSuaRole.Location = new System.Drawing.Point(0, -10);
            this.panelChinhSuaRole.Name = "panelChinhSuaRole";
            this.panelChinhSuaRole.Size = new System.Drawing.Size(935, 600);
            this.panelChinhSuaRole.TabIndex = 0;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapNhat.Location = new System.Drawing.Point(150, 440);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(200, 70);
            this.buttonCapNhat.TabIndex = 24;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click_1);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(150, 305);
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
            this.labelMatKhau.Location = new System.Drawing.Point(150, 252);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(152, 41);
            this.labelMatKhau.TabIndex = 22;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // textBoxRole
            // 
            this.textBoxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxRole.Location = new System.Drawing.Point(150, 143);
            this.textBoxRole.Multiline = true;
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(630, 50);
            this.textBoxRole.TabIndex = 21;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelRole.Location = new System.Drawing.Point(150, 90);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(80, 41);
            this.labelRole.TabIndex = 20;
            this.labelRole.Text = "Role";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(580, 440);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 19;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // ChinhSuaRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.panelChinhSuaRole);
            this.Name = "ChinhSuaRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChinhSuaRole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelChinhSuaRole.ResumeLayout(false);
            this.panelChinhSuaRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChinhSuaRole;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}

