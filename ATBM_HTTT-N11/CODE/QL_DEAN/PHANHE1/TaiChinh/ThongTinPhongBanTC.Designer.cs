namespace PHANHE1.TaiChinh
{
    partial class ThongTinPhongBanTC
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
            this.panelThongTinPhongBanTC = new System.Windows.Forms.Panel();
            this.labelThongTinPhongBanTC = new System.Windows.Forms.Label();
            this.panelChildFormTTPB = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinPhongBanTC = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxNhapMaPhongBan = new System.Windows.Forms.TextBox();
            this.labelNhapMaPhongBan = new System.Windows.Forms.Label();
            this.panelThongTinPhongBanTC.SuspendLayout();
            this.panelChildFormTTPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhongBanTC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinPhongBanTC
            // 
            this.panelThongTinPhongBanTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinPhongBanTC.Controls.Add(this.labelThongTinPhongBanTC);
            this.panelThongTinPhongBanTC.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinPhongBanTC.Name = "panelThongTinPhongBanTC";
            this.panelThongTinPhongBanTC.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinPhongBanTC.TabIndex = 0;
            this.panelThongTinPhongBanTC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinPhongBanTC
            // 
            this.labelThongTinPhongBanTC.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhongBanTC.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinPhongBanTC.Name = "labelThongTinPhongBanTC";
            this.labelThongTinPhongBanTC.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinPhongBanTC.TabIndex = 0;
            this.labelThongTinPhongBanTC.Text = "Thông tin phòng ban";
            this.labelThongTinPhongBanTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTPB
            // 
            this.panelChildFormTTPB.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTPB.Controls.Add(this.dataGridViewThongTinPhongBanTC);
            this.panelChildFormTTPB.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTPB.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTPB.Controls.Add(this.textBoxNhapMaPhongBan);
            this.panelChildFormTTPB.Controls.Add(this.labelNhapMaPhongBan);
            this.panelChildFormTTPB.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTPB.Name = "panelChildFormTTPB";
            this.panelChildFormTTPB.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTPB.TabIndex = 1;
            // 
            // dataGridViewThongTinPhongBanTC
            // 
            this.dataGridViewThongTinPhongBanTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinPhongBanTC.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinPhongBanTC.Name = "dataGridViewThongTinPhongBanTC";
            this.dataGridViewThongTinPhongBanTC.RowHeadersWidth = 51;
            this.dataGridViewThongTinPhongBanTC.RowTemplate.Height = 24;
            this.dataGridViewThongTinPhongBanTC.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinPhongBanTC.TabIndex = 57;
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
            // textBoxNhapMaPhongBan
            // 
            this.textBoxNhapMaPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhapMaPhongBan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhapMaPhongBan.Location = new System.Drawing.Point(152, 280);
            this.textBoxNhapMaPhongBan.Multiline = true;
            this.textBoxNhapMaPhongBan.Name = "textBoxNhapMaPhongBan";
            this.textBoxNhapMaPhongBan.Size = new System.Drawing.Size(300, 50);
            this.textBoxNhapMaPhongBan.TabIndex = 1;
            this.textBoxNhapMaPhongBan.TextChanged += new System.EventHandler(this.textBoxMaNV_TextChanged);
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
            // ThongTinPhongBanTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTPB);
            this.Controls.Add(this.panelThongTinPhongBanTC);
            this.Name = "ThongTinPhongBanTC";
            this.Text = "ThongTinPhongBanTC";
            this.panelThongTinPhongBanTC.ResumeLayout(false);
            this.panelChildFormTTPB.ResumeLayout(false);
            this.panelChildFormTTPB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhongBanTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinPhongBanTC;
        private System.Windows.Forms.Panel panelChildFormTTPB;
        private System.Windows.Forms.Label labelThongTinPhongBanTC;
        private System.Windows.Forms.TextBox textBoxNhapMaPhongBan;
        private System.Windows.Forms.Label labelNhapMaPhongBan;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewThongTinPhongBanTC;
        private System.Windows.Forms.Button buttonXemTatCa;
    }
}