namespace PHANHE1.TruongDeAn
{
    partial class ThongTinPhongBanTDA
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
            this.panelThongTinPhongBanTDA = new System.Windows.Forms.Panel();
            this.labelThongTinPhongBanTDA = new System.Windows.Forms.Label();
            this.panelChildFormTTPB = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinPhongBanTDA = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaPhongBan = new System.Windows.Forms.Label();
            this.comboBoxMaPhongBan = new System.Windows.Forms.ComboBox();
            this.panelThongTinPhongBanTDA.SuspendLayout();
            this.panelChildFormTTPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhongBanTDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinPhongBanTDA
            // 
            this.panelThongTinPhongBanTDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinPhongBanTDA.Controls.Add(this.labelThongTinPhongBanTDA);
            this.panelThongTinPhongBanTDA.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinPhongBanTDA.Name = "panelThongTinPhongBanTDA";
            this.panelThongTinPhongBanTDA.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinPhongBanTDA.TabIndex = 0;
            this.panelThongTinPhongBanTDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinPhongBanTDA
            // 
            this.labelThongTinPhongBanTDA.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhongBanTDA.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinPhongBanTDA.Name = "labelThongTinPhongBanTDA";
            this.labelThongTinPhongBanTDA.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinPhongBanTDA.TabIndex = 0;
            this.labelThongTinPhongBanTDA.Text = "Thông tin phòng ban";
            this.labelThongTinPhongBanTDA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTPB
            // 
            this.panelChildFormTTPB.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTPB.Controls.Add(this.comboBoxMaPhongBan);
            this.panelChildFormTTPB.Controls.Add(this.dataGridViewThongTinPhongBanTDA);
            this.panelChildFormTTPB.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTPB.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTPB.Controls.Add(this.labelNhapMaPhongBan);
            this.panelChildFormTTPB.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTPB.Name = "panelChildFormTTPB";
            this.panelChildFormTTPB.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTPB.TabIndex = 1;
            // 
            // dataGridViewThongTinPhongBanTDA
            // 
            this.dataGridViewThongTinPhongBanTDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinPhongBanTDA.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinPhongBanTDA.Name = "dataGridViewThongTinPhongBanTDA";
            this.dataGridViewThongTinPhongBanTDA.RowHeadersWidth = 51;
            this.dataGridViewThongTinPhongBanTDA.RowTemplate.Height = 24;
            this.dataGridViewThongTinPhongBanTDA.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinPhongBanTDA.TabIndex = 57;
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
            this.comboBoxMaPhongBan.TabIndex = 60;
            // 
            // ThongTinPhongBanTDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTPB);
            this.Controls.Add(this.panelThongTinPhongBanTDA);
            this.Name = "ThongTinPhongBanTDA";
            this.Text = "ThongTinPhongBanTDA";
            this.Load += new System.EventHandler(this.ThongTinPhongBanTDA_Load);
            this.panelThongTinPhongBanTDA.ResumeLayout(false);
            this.panelChildFormTTPB.ResumeLayout(false);
            this.panelChildFormTTPB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhongBanTDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinPhongBanTDA;
        private System.Windows.Forms.Panel panelChildFormTTPB;
        private System.Windows.Forms.Label labelThongTinPhongBanTDA;
        private System.Windows.Forms.Label labelNhapMaPhongBan;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewThongTinPhongBanTDA;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.ComboBox comboBoxMaPhongBan;
    }
}