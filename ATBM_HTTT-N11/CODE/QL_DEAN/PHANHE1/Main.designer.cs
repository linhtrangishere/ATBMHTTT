﻿namespace PHANHE1
{
    partial class Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonQuanLyQuyen = new System.Windows.Forms.Button();
            this.buttonQuanLyObjects = new System.Windows.Forms.Button();
            this.buttonThongTinQuyen = new System.Windows.Forms.Button();
            this.buttonThongTinObjects = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.labelNguyenVanA = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelMenu.Controls.Add(this.buttonDangXuat);
            this.panelMenu.Controls.Add(this.buttonQuanLyQuyen);
            this.panelMenu.Controls.Add(this.buttonQuanLyObjects);
            this.panelMenu.Controls.Add(this.buttonThongTinQuyen);
            this.panelMenu.Controls.Add(this.buttonThongTinObjects);
            this.panelMenu.Controls.Add(this.panelUsername);
            this.panelMenu.Location = new System.Drawing.Point(0, -10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(337, 990);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonDangXuat.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangXuat.Location = new System.Drawing.Point(-5, 784);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(352, 94);
            this.buttonDangXuat.TabIndex = 16;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonQuanLyQuyen
            // 
            this.buttonQuanLyQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonQuanLyQuyen.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQuanLyQuyen.Location = new System.Drawing.Point(-5, 649);
            this.buttonQuanLyQuyen.Name = "buttonQuanLyQuyen";
            this.buttonQuanLyQuyen.Size = new System.Drawing.Size(352, 94);
            this.buttonQuanLyQuyen.TabIndex = 15;
            this.buttonQuanLyQuyen.Text = "Quản lý quyền";
            this.buttonQuanLyQuyen.UseVisualStyleBackColor = false;
            this.buttonQuanLyQuyen.Click += new System.EventHandler(this.buttonQuanLyQuyen_Click);
            // 
            // buttonQuanLyObjects
            // 
            this.buttonQuanLyObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonQuanLyObjects.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQuanLyObjects.Location = new System.Drawing.Point(-5, 514);
            this.buttonQuanLyObjects.Name = "buttonQuanLyObjects";
            this.buttonQuanLyObjects.Size = new System.Drawing.Size(352, 94);
            this.buttonQuanLyObjects.TabIndex = 14;
            this.buttonQuanLyObjects.Text = "Quản lý objects";
            this.buttonQuanLyObjects.UseVisualStyleBackColor = false;
            this.buttonQuanLyObjects.Click += new System.EventHandler(this.buttonQuanLyObjects_Click);
            // 
            // buttonThongTinQuyen
            // 
            this.buttonThongTinQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThongTinQuyen.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThongTinQuyen.Location = new System.Drawing.Point(-5, 379);
            this.buttonThongTinQuyen.Name = "buttonThongTinQuyen";
            this.buttonThongTinQuyen.Size = new System.Drawing.Size(352, 94);
            this.buttonThongTinQuyen.TabIndex = 13;
            this.buttonThongTinQuyen.Text = "Thông tin quyền";
            this.buttonThongTinQuyen.UseVisualStyleBackColor = false;
            this.buttonThongTinQuyen.Click += new System.EventHandler(this.buttonThongTinQuyen_Click);
            // 
            // buttonThongTinObjects
            // 
            this.buttonThongTinObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThongTinObjects.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongTinObjects.Location = new System.Drawing.Point(-5, 244);
            this.buttonThongTinObjects.Name = "buttonThongTinObjects";
            this.buttonThongTinObjects.Size = new System.Drawing.Size(352, 94);
            this.buttonThongTinObjects.TabIndex = 12;
            this.buttonThongTinObjects.Text = "Thông tin objects\r\n";
            this.buttonThongTinObjects.UseVisualStyleBackColor = false;
            this.buttonThongTinObjects.Click += new System.EventHandler(this.buttonThongTinObjects_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.labelNguyenVanA);
            this.panelUsername.Controls.Add(this.labelAdmin);
            this.panelUsername.Location = new System.Drawing.Point(0, 0);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(337, 160);
            this.panelUsername.TabIndex = 0;
            this.panelUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsername_Paint);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelAdmin.Location = new System.Drawing.Point(98, 23);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(128, 45);
            this.labelAdmin.TabIndex = 2;
            this.labelAdmin.Text = "ADMIN";
            this.labelAdmin.Click += new System.EventHandler(this.labelAdmin_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelChildForm.Location = new System.Drawing.Point(338, -10);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1085, 990);
            this.panelChildForm.TabIndex = 1;
            // 
            // labelNguyenVanA
            // 
            this.labelNguyenVanA.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNguyenVanA.Location = new System.Drawing.Point(0, 93);
            this.labelNguyenVanA.Name = "labelNguyenVanA";
            this.labelNguyenVanA.Size = new System.Drawing.Size(337, 45);
            this.labelNguyenVanA.TabIndex = 3;
            this.labelNguyenVanA.Text = "Nguyễn Văn A";
            this.labelNguyenVanA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNguyenVanA.Click += new System.EventHandler(this.labelNguyenVanA_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Button buttonQuanLyQuyen;
        private System.Windows.Forms.Button buttonQuanLyObjects;
        private System.Windows.Forms.Button buttonThongTinQuyen;
        private System.Windows.Forms.Button buttonThongTinObjects;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label labelNguyenVanA;
    }
}