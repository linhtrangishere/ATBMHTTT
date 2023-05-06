namespace PHANHE1.NhanSu
{
    partial class ThongTinPhanCongNS
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
            this.panelThongTinPhanCongTC = new System.Windows.Forms.Panel();
            this.labelThongTinPhanCongNS = new System.Windows.Forms.Label();
            this.panelChildFormTTPC = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinPhanCongNS = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxNhapMaDeAn = new System.Windows.Forms.TextBox();
            this.labelNhapMaDeAn = new System.Windows.Forms.Label();
            this.panelThongTinPhanCongTC.SuspendLayout();
            this.panelChildFormTTPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhanCongNS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinPhanCongTC
            // 
            this.panelThongTinPhanCongTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinPhanCongTC.Controls.Add(this.labelThongTinPhanCongNS);
            this.panelThongTinPhanCongTC.Location = new System.Drawing.Point(-1, -6);
            this.panelThongTinPhanCongTC.Name = "panelThongTinPhanCongTC";
            this.panelThongTinPhanCongTC.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinPhanCongTC.TabIndex = 6;
            // 
            // labelThongTinPhanCongNS
            // 
            this.labelThongTinPhanCongNS.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhanCongNS.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinPhanCongNS.Name = "labelThongTinPhanCongNS";
            this.labelThongTinPhanCongNS.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinPhanCongNS.TabIndex = 0;
            this.labelThongTinPhanCongNS.Text = "Thông tin phân công";
            this.labelThongTinPhanCongNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTPC
            // 
            this.panelChildFormTTPC.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTPC.Controls.Add(this.dataGridViewThongTinPhanCongNS);
            this.panelChildFormTTPC.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTPC.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTPC.Controls.Add(this.textBoxNhapMaDeAn);
            this.panelChildFormTTPC.Controls.Add(this.labelNhapMaDeAn);
            this.panelChildFormTTPC.Location = new System.Drawing.Point(-1, 124);
            this.panelChildFormTTPC.Name = "panelChildFormTTPC";
            this.panelChildFormTTPC.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTPC.TabIndex = 7;
            // 
            // dataGridViewThongTinPhanCongNS
            // 
            this.dataGridViewThongTinPhanCongNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinPhanCongNS.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinPhanCongNS.Name = "dataGridViewThongTinPhanCongNS";
            this.dataGridViewThongTinPhanCongNS.RowHeadersWidth = 51;
            this.dataGridViewThongTinPhanCongNS.RowTemplate.Height = 24;
            this.dataGridViewThongTinPhanCongNS.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinPhanCongNS.TabIndex = 57;
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
            // textBoxNhapMaDeAn
            // 
            this.textBoxNhapMaDeAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhapMaDeAn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhapMaDeAn.Location = new System.Drawing.Point(152, 280);
            this.textBoxNhapMaDeAn.Multiline = true;
            this.textBoxNhapMaDeAn.Name = "textBoxNhapMaDeAn";
            this.textBoxNhapMaDeAn.Size = new System.Drawing.Size(300, 50);
            this.textBoxNhapMaDeAn.TabIndex = 1;
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
            // ThongTinPhanCongNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelThongTinPhanCongTC);
            this.Controls.Add(this.panelChildFormTTPC);
            this.Name = "ThongTinPhanCongNS";
            this.Text = "ThongTinPhanCongNS";
            this.panelThongTinPhanCongTC.ResumeLayout(false);
            this.panelChildFormTTPC.ResumeLayout(false);
            this.panelChildFormTTPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhanCongNS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinPhanCongTC;
        private System.Windows.Forms.Label labelThongTinPhanCongNS;
        private System.Windows.Forms.Panel panelChildFormTTPC;
        private System.Windows.Forms.DataGridView dataGridViewThongTinPhanCongNS;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxNhapMaDeAn;
        private System.Windows.Forms.Label labelNhapMaDeAn;
    }
}