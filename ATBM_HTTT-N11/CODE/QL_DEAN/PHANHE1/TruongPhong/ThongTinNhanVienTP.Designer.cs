namespace PHANHE1.TruongPhong
{
    partial class ThongTinNhanVienTP
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
            this.panelThongTinDeAnQLTT = new System.Windows.Forms.Panel();
            this.labelThongTinNhanVienTP = new System.Windows.Forms.Label();
            this.panelChildFormTTNV = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinNhanVienTP = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaDeAn = new System.Windows.Forms.Label();
            this.comboBoxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.panelThongTinDeAnQLTT.SuspendLayout();
            this.panelChildFormTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinNhanVienTP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinDeAnQLTT
            // 
            this.panelThongTinDeAnQLTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinDeAnQLTT.Controls.Add(this.labelThongTinNhanVienTP);
            this.panelThongTinDeAnQLTT.Location = new System.Drawing.Point(-1, -6);
            this.panelThongTinDeAnQLTT.Name = "panelThongTinDeAnQLTT";
            this.panelThongTinDeAnQLTT.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinDeAnQLTT.TabIndex = 6;
            // 
            // labelThongTinNhanVienTP
            // 
            this.labelThongTinNhanVienTP.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinNhanVienTP.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinNhanVienTP.Name = "labelThongTinNhanVienTP";
            this.labelThongTinNhanVienTP.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinNhanVienTP.TabIndex = 0;
            this.labelThongTinNhanVienTP.Text = "Thông tin nhân viên";
            this.labelThongTinNhanVienTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTNV
            // 
            this.panelChildFormTTNV.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTNV.Controls.Add(this.comboBoxMaNhanVien);
            this.panelChildFormTTNV.Controls.Add(this.dataGridViewThongTinNhanVienTP);
            this.panelChildFormTTNV.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTNV.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTNV.Controls.Add(this.labelNhapMaDeAn);
            this.panelChildFormTTNV.Location = new System.Drawing.Point(-1, 124);
            this.panelChildFormTTNV.Name = "panelChildFormTTNV";
            this.panelChildFormTTNV.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTNV.TabIndex = 7;
            // 
            // dataGridViewThongTinNhanVienTP
            // 
            this.dataGridViewThongTinNhanVienTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinNhanVienTP.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinNhanVienTP.Name = "dataGridViewThongTinNhanVienTP";
            this.dataGridViewThongTinNhanVienTP.RowHeadersWidth = 51;
            this.dataGridViewThongTinNhanVienTP.RowTemplate.Height = 24;
            this.dataGridViewThongTinNhanVienTP.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinNhanVienTP.TabIndex = 57;
            this.dataGridViewThongTinNhanVienTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTinNhanVienTP_CellContentClick);
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
            this.labelNhapMaDeAn.Size = new System.Drawing.Size(285, 41);
            this.labelNhapMaDeAn.TabIndex = 0;
            this.labelNhapMaDeAn.Text = "Nhập mã nhân viên";
            // 
            // comboBoxMaNhanVien
            // 
            this.comboBoxMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxMaNhanVien.FormattingEnabled = true;
            this.comboBoxMaNhanVien.Location = new System.Drawing.Point(152, 281);
            this.comboBoxMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaNhanVien.Name = "comboBoxMaNhanVien";
            this.comboBoxMaNhanVien.Size = new System.Drawing.Size(293, 49);
            this.comboBoxMaNhanVien.TabIndex = 63;
            this.comboBoxMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaNhanVien_SelectedIndexChanged);
            // 
            // ThongTinNhanVienTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelThongTinDeAnQLTT);
            this.Controls.Add(this.panelChildFormTTNV);
            this.Name = "ThongTinNhanVienTP";
            this.Text = "ThongTinNhanVienTP";
            this.Load += new System.EventHandler(this.ThongTinNhanVienTP_Load);
            this.panelThongTinDeAnQLTT.ResumeLayout(false);
            this.panelChildFormTTNV.ResumeLayout(false);
            this.panelChildFormTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinNhanVienTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinDeAnQLTT;
        private System.Windows.Forms.Label labelThongTinNhanVienTP;
        private System.Windows.Forms.Panel panelChildFormTTNV;
        private System.Windows.Forms.DataGridView dataGridViewThongTinNhanVienTP;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Label labelNhapMaDeAn;
        private System.Windows.Forms.ComboBox comboBoxMaNhanVien;
    }
}