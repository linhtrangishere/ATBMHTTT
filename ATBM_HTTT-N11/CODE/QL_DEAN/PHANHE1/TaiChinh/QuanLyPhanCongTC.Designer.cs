﻿namespace PHANHE1.TaiChinh
{
    partial class QuanLyPhanCongTC
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
            this.panelQuanLyPhanCongTC = new System.Windows.Forms.Panel();
            this.labelQuanLyPhanCongTC = new System.Windows.Forms.Label();
            this.panelChildFormQLPC = new System.Windows.Forms.Panel();
            this.dataGridViewQuanLyPhanCongTC = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxNhapMaNhanVien = new System.Windows.Forms.TextBox();
            this.labelNhapMaNhanVien = new System.Windows.Forms.Label();
            this.panelQuanLyPhanCongTC.SuspendLayout();
            this.panelChildFormQLPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyPhanCongTC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuanLyPhanCongTC
            // 
            this.panelQuanLyPhanCongTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelQuanLyPhanCongTC.Controls.Add(this.labelQuanLyPhanCongTC);
            this.panelQuanLyPhanCongTC.Location = new System.Drawing.Point(0, -10);
            this.panelQuanLyPhanCongTC.Name = "panelQuanLyPhanCongTC";
            this.panelQuanLyPhanCongTC.Size = new System.Drawing.Size(935, 130);
            this.panelQuanLyPhanCongTC.TabIndex = 0;
            this.panelQuanLyPhanCongTC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelQuanLyPhanCongTC
            // 
            this.labelQuanLyPhanCongTC.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQuanLyPhanCongTC.Location = new System.Drawing.Point(0, 10);
            this.labelQuanLyPhanCongTC.Name = "labelQuanLyPhanCongTC";
            this.labelQuanLyPhanCongTC.Size = new System.Drawing.Size(935, 120);
            this.labelQuanLyPhanCongTC.TabIndex = 0;
            this.labelQuanLyPhanCongTC.Text = "Quản lý phân công";
            this.labelQuanLyPhanCongTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormQLPC
            // 
            this.panelChildFormQLPC.BackColor = System.Drawing.Color.White;
            this.panelChildFormQLPC.Controls.Add(this.dataGridViewQuanLyPhanCongTC);
            this.panelChildFormQLPC.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormQLPC.Controls.Add(this.buttonTimKiem);
            this.panelChildFormQLPC.Controls.Add(this.textBoxNhapMaNhanVien);
            this.panelChildFormQLPC.Controls.Add(this.labelNhapMaNhanVien);
            this.panelChildFormQLPC.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormQLPC.Name = "panelChildFormQLPC";
            this.panelChildFormQLPC.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormQLPC.TabIndex = 1;
            // 
            // dataGridViewQuanLyPhanCongTC
            // 
            this.dataGridViewQuanLyPhanCongTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyPhanCongTC.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewQuanLyPhanCongTC.Name = "dataGridViewQuanLyPhanCongTC";
            this.dataGridViewQuanLyPhanCongTC.RowHeadersWidth = 51;
            this.dataGridViewQuanLyPhanCongTC.RowTemplate.Height = 24;
            this.dataGridViewQuanLyPhanCongTC.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewQuanLyPhanCongTC.TabIndex = 57;
            // 
            // buttonXemTatCa
            // 
            this.buttonXemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.buttonXemTatCa.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXemTatCa.Location = new System.Drawing.Point(340, 80);
            this.buttonXemTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXemTatCa.Name = "buttonXemTatCa";
            this.buttonXemTatCa.Size = new System.Drawing.Size(250, 70);
            this.buttonXemTatCa.TabIndex = 56;
            this.buttonXemTatCa.Text = "Xem tất cả";
            this.buttonXemTatCa.UseVisualStyleBackColor = false;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTimKiem.Location = new System.Drawing.Point(540, 260);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(250, 70);
            this.buttonTimKiem.TabIndex = 55;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // textBoxNhapMaNhanVien
            // 
            this.textBoxNhapMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhapMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhapMaNhanVien.Location = new System.Drawing.Point(152, 280);
            this.textBoxNhapMaNhanVien.Multiline = true;
            this.textBoxNhapMaNhanVien.Name = "textBoxNhapMaNhanVien";
            this.textBoxNhapMaNhanVien.Size = new System.Drawing.Size(300, 50);
            this.textBoxNhapMaNhanVien.TabIndex = 1;
            this.textBoxNhapMaNhanVien.TextChanged += new System.EventHandler(this.textBoxMaNV_TextChanged);
            // 
            // labelNhapMaNhanVien
            // 
            this.labelNhapMaNhanVien.AutoSize = true;
            this.labelNhapMaNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhapMaNhanVien.Location = new System.Drawing.Point(145, 230);
            this.labelNhapMaNhanVien.Name = "labelNhapMaNhanVien";
            this.labelNhapMaNhanVien.Size = new System.Drawing.Size(285, 41);
            this.labelNhapMaNhanVien.TabIndex = 0;
            this.labelNhapMaNhanVien.Text = "Nhập mã nhân viên";
            // 
            // QuanLyPhanCongTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormQLPC);
            this.Controls.Add(this.panelQuanLyPhanCongTC);
            this.Name = "QuanLyPhanCongTC";
            this.Text = "QuanLyPhanCongTC";
            this.panelQuanLyPhanCongTC.ResumeLayout(false);
            this.panelChildFormQLPC.ResumeLayout(false);
            this.panelChildFormQLPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyPhanCongTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyPhanCongTC;
        private System.Windows.Forms.Panel panelChildFormQLPC;
        private System.Windows.Forms.Label labelQuanLyPhanCongTC;
        private System.Windows.Forms.TextBox textBoxNhapMaNhanVien;
        private System.Windows.Forms.Label labelNhapMaNhanVien;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyPhanCongTC;
        private System.Windows.Forms.Button buttonXemTatCa;
    }
}