﻿namespace PHANHE1.TruongDeAn
{
    partial class ThongTinPhanCongTDA
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
            this.panelThongTinPhanCongTDA = new System.Windows.Forms.Panel();
            this.labelThongTinPhanCongTDA = new System.Windows.Forms.Label();
            this.panelChildFormTTPC = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinPhanCongTDA = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaDeAn = new System.Windows.Forms.Label();
            this.comboBoxMaDeAn = new System.Windows.Forms.ComboBox();
            this.panelThongTinPhanCongTDA.SuspendLayout();
            this.panelChildFormTTPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhanCongTDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinPhanCongTDA
            // 
            this.panelThongTinPhanCongTDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinPhanCongTDA.Controls.Add(this.labelThongTinPhanCongTDA);
            this.panelThongTinPhanCongTDA.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinPhanCongTDA.Name = "panelThongTinPhanCongTDA";
            this.panelThongTinPhanCongTDA.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinPhanCongTDA.TabIndex = 0;
            this.panelThongTinPhanCongTDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinPhanCongTDA
            // 
            this.labelThongTinPhanCongTDA.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhanCongTDA.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinPhanCongTDA.Name = "labelThongTinPhanCongTDA";
            this.labelThongTinPhanCongTDA.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinPhanCongTDA.TabIndex = 0;
            this.labelThongTinPhanCongTDA.Text = "Thông tin phân công";
            this.labelThongTinPhanCongTDA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTPC
            // 
            this.panelChildFormTTPC.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTPC.Controls.Add(this.comboBoxMaDeAn);
            this.panelChildFormTTPC.Controls.Add(this.dataGridViewThongTinPhanCongTDA);
            this.panelChildFormTTPC.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTPC.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTPC.Controls.Add(this.labelNhapMaDeAn);
            this.panelChildFormTTPC.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTPC.Name = "panelChildFormTTPC";
            this.panelChildFormTTPC.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTPC.TabIndex = 1;
            // 
            // dataGridViewThongTinPhanCongTDA
            // 
            this.dataGridViewThongTinPhanCongTDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinPhanCongTDA.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinPhanCongTDA.Name = "dataGridViewThongTinPhanCongTDA";
            this.dataGridViewThongTinPhanCongTDA.RowHeadersWidth = 51;
            this.dataGridViewThongTinPhanCongTDA.RowTemplate.Height = 24;
            this.dataGridViewThongTinPhanCongTDA.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinPhanCongTDA.TabIndex = 57;
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
            // labelNhapMaDeAn
            // 
            this.labelNhapMaDeAn.AutoSize = true;
            this.labelNhapMaDeAn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhapMaDeAn.Location = new System.Drawing.Point(145, 230);
            this.labelNhapMaDeAn.Name = "labelNhapMaDeAn";
            this.labelNhapMaDeAn.Size = new System.Drawing.Size(227, 41);
            this.labelNhapMaDeAn.TabIndex = 0;
            this.labelNhapMaDeAn.Text = "Nhập mã đề án";
            // 
            // comboBoxMaDeAn
            // 
            this.comboBoxMaDeAn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaDeAn.FormattingEnabled = true;
            this.comboBoxMaDeAn.Location = new System.Drawing.Point(152, 281);
            this.comboBoxMaDeAn.Name = "comboBoxMaDeAn";
            this.comboBoxMaDeAn.Size = new System.Drawing.Size(300, 49);
            this.comboBoxMaDeAn.TabIndex = 62;
            // 
            // ThongTinPhanCongTDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTPC);
            this.Controls.Add(this.panelThongTinPhanCongTDA);
            this.Name = "ThongTinPhanCongTDA";
            this.Text = "ThongTinPhanCongTDA";
            this.Load += new System.EventHandler(this.ThongTinPhanCongTDA_Load);
            this.panelThongTinPhanCongTDA.ResumeLayout(false);
            this.panelChildFormTTPC.ResumeLayout(false);
            this.panelChildFormTTPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhanCongTDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinPhanCongTDA;
        private System.Windows.Forms.Panel panelChildFormTTPC;
        private System.Windows.Forms.Label labelThongTinPhanCongTDA;
        private System.Windows.Forms.Label labelNhapMaDeAn;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewThongTinPhanCongTDA;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.ComboBox comboBoxMaDeAn;
    }
}