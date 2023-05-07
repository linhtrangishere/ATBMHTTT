namespace PHANHE1.TruongPhong
{
    partial class ThongTinPhanCongTP
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
            this.labelThongTinPhanCongTP = new System.Windows.Forms.Label();
            this.panelChildFormTTPC = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinPhanCongTP = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaDeAn = new System.Windows.Forms.Label();
            this.comboBoxMaDeAn = new System.Windows.Forms.ComboBox();
            this.panelThongTinPhanCongTC.SuspendLayout();
            this.panelChildFormTTPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhanCongTP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinPhanCongTC
            // 
            this.panelThongTinPhanCongTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinPhanCongTC.Controls.Add(this.labelThongTinPhanCongTP);
            this.panelThongTinPhanCongTC.Location = new System.Drawing.Point(-1, -6);
            this.panelThongTinPhanCongTC.Name = "panelThongTinPhanCongTC";
            this.panelThongTinPhanCongTC.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinPhanCongTC.TabIndex = 4;
            // 
            // labelThongTinPhanCongTP
            // 
            this.labelThongTinPhanCongTP.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhanCongTP.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinPhanCongTP.Name = "labelThongTinPhanCongTP";
            this.labelThongTinPhanCongTP.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinPhanCongTP.TabIndex = 0;
            this.labelThongTinPhanCongTP.Text = "Thông tin phân công";
            this.labelThongTinPhanCongTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTPC
            // 
            this.panelChildFormTTPC.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTPC.Controls.Add(this.comboBoxMaDeAn);
            this.panelChildFormTTPC.Controls.Add(this.dataGridViewThongTinPhanCongTP);
            this.panelChildFormTTPC.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTPC.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTPC.Controls.Add(this.labelNhapMaDeAn);
            this.panelChildFormTTPC.Location = new System.Drawing.Point(-1, 124);
            this.panelChildFormTTPC.Name = "panelChildFormTTPC";
            this.panelChildFormTTPC.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTPC.TabIndex = 5;
            // 
            // dataGridViewThongTinPhanCongTP
            // 
            this.dataGridViewThongTinPhanCongTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinPhanCongTP.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinPhanCongTP.Name = "dataGridViewThongTinPhanCongTP";
            this.dataGridViewThongTinPhanCongTP.RowHeadersWidth = 51;
            this.dataGridViewThongTinPhanCongTP.RowTemplate.Height = 24;
            this.dataGridViewThongTinPhanCongTP.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinPhanCongTP.TabIndex = 57;
            this.dataGridViewThongTinPhanCongTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTinPhanCongTP_CellContentClick);
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
            this.comboBoxMaDeAn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxMaDeAn.FormattingEnabled = true;
            this.comboBoxMaDeAn.Location = new System.Drawing.Point(152, 281);
            this.comboBoxMaDeAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaDeAn.Name = "comboBoxMaDeAn";
            this.comboBoxMaDeAn.Size = new System.Drawing.Size(293, 49);
            this.comboBoxMaDeAn.TabIndex = 62;
            this.comboBoxMaDeAn.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaDeAn_SelectedIndexChanged);
            // 
            // ThongTinPhanCongTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelThongTinPhanCongTC);
            this.Controls.Add(this.panelChildFormTTPC);
            this.Name = "ThongTinPhanCongTP";
            this.Text = "ThongTinPhanCongTP";
            this.Load += new System.EventHandler(this.ThongTinPhanCongTP_Load);
            this.panelThongTinPhanCongTC.ResumeLayout(false);
            this.panelChildFormTTPC.ResumeLayout(false);
            this.panelChildFormTTPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinPhanCongTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinPhanCongTC;
        private System.Windows.Forms.Label labelThongTinPhanCongTP;
        private System.Windows.Forms.Panel panelChildFormTTPC;
        private System.Windows.Forms.DataGridView dataGridViewThongTinPhanCongTP;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Label labelNhapMaDeAn;
        private System.Windows.Forms.ComboBox comboBoxMaDeAn;
    }
}