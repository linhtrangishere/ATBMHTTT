﻿namespace PHANHE1
{
    partial class QuanLyUser
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
            this.panelQuanLyUser = new System.Windows.Forms.Panel();
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaUser = new System.Windows.Forms.Button();
            this.buttonTaoUser = new System.Windows.Forms.Button();
            this.buttonXoaUser = new System.Windows.Forms.Button();
            this.panelQuanLyUser.SuspendLayout();
            this.panelThemXoaSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuanLyUser
            // 
            this.panelQuanLyUser.BackColor = System.Drawing.Color.White;
            this.panelQuanLyUser.Controls.Add(this.panelThemXoaSua);
            this.panelQuanLyUser.Location = new System.Drawing.Point(0, -10);
            this.panelQuanLyUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQuanLyUser.Name = "panelQuanLyUser";
            this.panelQuanLyUser.Size = new System.Drawing.Size(935, 690);
            this.panelQuanLyUser.TabIndex = 2;
            this.panelQuanLyUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuanLyUser_Paint);
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaUser);
            this.panelThemXoaSua.Controls.Add(this.buttonTaoUser);
            this.panelThemXoaSua.Controls.Add(this.buttonXoaUser);
            this.panelThemXoaSua.Location = new System.Drawing.Point(0, 180);
            this.panelThemXoaSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(935, 150);
            this.panelThemXoaSua.TabIndex = 19;
            // 
            // buttonChinhSuaUser
            // 
            this.buttonChinhSuaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaUser.Location = new System.Drawing.Point(651, 28);
            this.buttonChinhSuaUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChinhSuaUser.Name = "buttonChinhSuaUser";
            this.buttonChinhSuaUser.Size = new System.Drawing.Size(232, 94);
            this.buttonChinhSuaUser.TabIndex = 20;
            this.buttonChinhSuaUser.Text = "Chỉnh sửa user";
            this.buttonChinhSuaUser.UseVisualStyleBackColor = false;
            this.buttonChinhSuaUser.Click += new System.EventHandler(this.buttonChinhSuaUser_Click_1);
            // 
            // buttonTaoUser
            // 
            this.buttonTaoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonTaoUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaoUser.Location = new System.Drawing.Point(51, 28);
            this.buttonTaoUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTaoUser.Name = "buttonTaoUser";
            this.buttonTaoUser.Size = new System.Drawing.Size(232, 94);
            this.buttonTaoUser.TabIndex = 19;
            this.buttonTaoUser.Text = "Tạo user";
            this.buttonTaoUser.UseVisualStyleBackColor = false;
            this.buttonTaoUser.Click += new System.EventHandler(this.buttonTaoUser_Click_1);
            // 
            // buttonXoaUser
            // 
            this.buttonXoaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXoaUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonXoaUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoaUser.Location = new System.Drawing.Point(349, 28);
            this.buttonXoaUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaUser.Name = "buttonXoaUser";
            this.buttonXoaUser.Size = new System.Drawing.Size(232, 94);
            this.buttonXoaUser.TabIndex = 18;
            this.buttonXoaUser.Text = "Xóa user";
            this.buttonXoaUser.UseVisualStyleBackColor = false;
            this.buttonXoaUser.Click += new System.EventHandler(this.buttonXoaUser_Click_1);
            // 
            // QuanLyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelQuanLyUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyUser";
            this.Text = "QuanLyUser";
            this.Load += new System.EventHandler(this.QuanLyUser_Load);
            this.panelQuanLyUser.ResumeLayout(false);
            this.panelThemXoaSua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyUser;
        private System.Windows.Forms.Panel panelThemXoaSua;
        private System.Windows.Forms.Button buttonChinhSuaUser;
        private System.Windows.Forms.Button buttonTaoUser;
        private System.Windows.Forms.Button buttonXoaUser;
    }
}