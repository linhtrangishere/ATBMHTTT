﻿namespace PHANHE1.QLTrucTiep
{
    partial class ThongTinPhongBanQLTT
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
            this.panelThongTinPhongBanQLTT = new System.Windows.Forms.Panel();
            this.labelThongTinPhongBanQLTT = new System.Windows.Forms.Label();
            this.panelChildFormTTPB = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinPhongBanQLTT = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaPhongBan = new System.Windows.Forms.Label();
            this.comboBoxMaPhongBan = new System.Windows.Forms.ComboBox();
            this.panelThongTinPhongBanQLTT.SuspendLayout();
            this.panelChildFormTTPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhongBanQLTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinPhongBanQLTT
            // 
            this.panelThongTinPhongBanQLTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinPhongBanQLTT.Controls.Add(this.labelThongTinPhongBanQLTT);
            this.panelThongTinPhongBanQLTT.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinPhongBanQLTT.Name = "panelThongTinPhongBanQLTT";
            this.panelThongTinPhongBanQLTT.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinPhongBanQLTT.TabIndex = 0;
            this.panelThongTinPhongBanQLTT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinPhongBanQLTT
            // 
            this.labelThongTinPhongBanQLTT.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhongBanQLTT.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinPhongBanQLTT.Name = "labelThongTinPhongBanQLTT";
            this.labelThongTinPhongBanQLTT.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinPhongBanQLTT.TabIndex = 0;
            this.labelThongTinPhongBanQLTT.Text = "Thông tin phòng ban";
            this.labelThongTinPhongBanQLTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTPB
            // 
            this.panelChildFormTTPB.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTPB.Controls.Add(this.comboBoxMaPhongBan);
            this.panelChildFormTTPB.Controls.Add(this.dataGridViewThongTinPhongBanQLTT);
            this.panelChildFormTTPB.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTPB.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTPB.Controls.Add(this.labelNhapMaPhongBan);
            this.panelChildFormTTPB.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTPB.Name = "panelChildFormTTPB";
            this.panelChildFormTTPB.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTPB.TabIndex = 1;
            // 
            // dataGridViewThongTinPhongBanQLTT
            // 
            this.dataGridViewThongTinPhongBanQLTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinPhongBanQLTT.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinPhongBanQLTT.Name = "dataGridViewThongTinPhongBanQLTT";
            this.dataGridViewThongTinPhongBanQLTT.RowHeadersWidth = 51;
            this.dataGridViewThongTinPhongBanQLTT.RowTemplate.Height = 24;
            this.dataGridViewThongTinPhongBanQLTT.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinPhongBanQLTT.TabIndex = 57;
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
            // labelNhapMaPhongBan
            // 
            this.labelNhapMaPhongBan.AutoSize = true;
            this.labelNhapMaPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhapMaPhongBan.Location = new System.Drawing.Point(145, 230);
            this.labelNhapMaPhongBan.Name = "labelNhapMaPhongBan";
            this.labelNhapMaPhongBan.Size = new System.Drawing.Size(300, 41);
            this.labelNhapMaPhongBan.TabIndex = 0;
            this.labelNhapMaPhongBan.Text = "Nhập mã phòng ban";
            // 
            // comboBoxMaPhongBan
            // 
            this.comboBoxMaPhongBan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaPhongBan.FormattingEnabled = true;
            this.comboBoxMaPhongBan.Location = new System.Drawing.Point(152, 281);
            this.comboBoxMaPhongBan.Name = "comboBoxMaPhongBan";
            this.comboBoxMaPhongBan.Size = new System.Drawing.Size(300, 49);
            this.comboBoxMaPhongBan.TabIndex = 58;
            // 
            // ThongTinPhongBanQLTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTPB);
            this.Controls.Add(this.panelThongTinPhongBanQLTT);
            this.Name = "ThongTinPhongBanQLTT";
            this.Text = "ThongTinPhongBanQLTT";
            this.Load += new System.EventHandler(this.ThongTinPhongBanQLTT_Load);
            this.panelThongTinPhongBanQLTT.ResumeLayout(false);
            this.panelChildFormTTPB.ResumeLayout(false);
            this.panelChildFormTTPB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhongBanQLTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinPhongBanQLTT;
        private System.Windows.Forms.Panel panelChildFormTTPB;
        private System.Windows.Forms.Label labelThongTinPhongBanQLTT;
        private System.Windows.Forms.Label labelNhapMaPhongBan;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewThongTinPhongBanQLTT;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.ComboBox comboBoxMaPhongBan;
    }
}