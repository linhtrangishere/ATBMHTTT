﻿namespace PHANHE1.QLTrucTiep
{
    partial class ThongTinNhanVienQLTT
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
            this.panelThongTinNhanVienQLTT = new System.Windows.Forms.Panel();
            this.labelThongTinNhanVienQLTT = new System.Windows.Forms.Label();
            this.panelChildFormTTNV = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinNhanVienQLTT = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaNhanVien = new System.Windows.Forms.Label();
            this.comboBoxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.panelThongTinNhanVienQLTT.SuspendLayout();
            this.panelChildFormTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinNhanVienQLTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinNhanVienQLTT
            // 
            this.panelThongTinNhanVienQLTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinNhanVienQLTT.Controls.Add(this.labelThongTinNhanVienQLTT);
            this.panelThongTinNhanVienQLTT.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinNhanVienQLTT.Name = "panelThongTinNhanVienQLTT";
            this.panelThongTinNhanVienQLTT.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinNhanVienQLTT.TabIndex = 0;
            this.panelThongTinNhanVienQLTT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinNhanVienQLTT
            // 
            this.labelThongTinNhanVienQLTT.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinNhanVienQLTT.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinNhanVienQLTT.Name = "labelThongTinNhanVienQLTT";
            this.labelThongTinNhanVienQLTT.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinNhanVienQLTT.TabIndex = 0;
            this.labelThongTinNhanVienQLTT.Text = "Thông tin nhân viên";
            this.labelThongTinNhanVienQLTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTNV
            // 
            this.panelChildFormTTNV.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTNV.Controls.Add(this.comboBoxMaNhanVien);
            this.panelChildFormTTNV.Controls.Add(this.dataGridViewThongTinNhanVienQLTT);
            this.panelChildFormTTNV.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTNV.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTNV.Controls.Add(this.labelNhapMaNhanVien);
            this.panelChildFormTTNV.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTNV.Name = "panelChildFormTTNV";
            this.panelChildFormTTNV.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTNV.TabIndex = 1;
            // 
            // dataGridViewThongTinNhanVienQLTT
            // 
            this.dataGridViewThongTinNhanVienQLTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinNhanVienQLTT.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinNhanVienQLTT.Name = "dataGridViewThongTinNhanVienQLTT";
            this.dataGridViewThongTinNhanVienQLTT.RowHeadersWidth = 51;
            this.dataGridViewThongTinNhanVienQLTT.RowTemplate.Height = 24;
            this.dataGridViewThongTinNhanVienQLTT.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinNhanVienQLTT.TabIndex = 57;
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
            this.buttonXemTatCa.Click += new System.EventHandler(this.buttonXemTatCa_Click);
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
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
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
            // comboBoxMaNhanVien
            // 
            this.comboBoxMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaNhanVien.FormattingEnabled = true;
            this.comboBoxMaNhanVien.Location = new System.Drawing.Point(152, 281);
            this.comboBoxMaNhanVien.Name = "comboBoxMaNhanVien";
            this.comboBoxMaNhanVien.Size = new System.Drawing.Size(300, 49);
            this.comboBoxMaNhanVien.TabIndex = 61;
            // 
            // ThongTinNhanVienQLTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTNV);
            this.Controls.Add(this.panelThongTinNhanVienQLTT);
            this.Name = "ThongTinNhanVienQLTT";
            this.Text = "ThongTinNhanVienQLTT";
            this.Load += new System.EventHandler(this.ThongTinNhanVienQLTT_Load);
            this.panelThongTinNhanVienQLTT.ResumeLayout(false);
            this.panelChildFormTTNV.ResumeLayout(false);
            this.panelChildFormTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinNhanVienQLTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinNhanVienQLTT;
        private System.Windows.Forms.Panel panelChildFormTTNV;
        private System.Windows.Forms.Label labelThongTinNhanVienQLTT;
        private System.Windows.Forms.Label labelNhapMaNhanVien;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewThongTinNhanVienQLTT;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.ComboBox comboBoxMaNhanVien;
    }
}