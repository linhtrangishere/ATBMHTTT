namespace PHANHE1.NhanSu
{
    partial class ChinhSuaPhongBanNS
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
            this.panelThemPhanCongTP = new System.Windows.Forms.Panel();
            this.comboBoxMaPhongBan = new System.Windows.Forms.ComboBox();
            this.comboBoxTruongPhong = new System.Windows.Forms.ComboBox();
            this.textBoxTenPhongBan = new System.Windows.Forms.TextBox();
            this.labelTenPhongBan = new System.Windows.Forms.Label();
            this.labelTruongPhong = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.dataGridViewThemPhongBanNS = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.labelMaPhongBan = new System.Windows.Forms.Label();
            this.panelThemPhanCongTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemPhongBanNS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThemPhanCongTP
            // 
            this.panelThemPhanCongTP.BackColor = System.Drawing.Color.White;
            this.panelThemPhanCongTP.Controls.Add(this.comboBoxMaPhongBan);
            this.panelThemPhanCongTP.Controls.Add(this.comboBoxTruongPhong);
            this.panelThemPhanCongTP.Controls.Add(this.textBoxTenPhongBan);
            this.panelThemPhanCongTP.Controls.Add(this.labelTenPhongBan);
            this.panelThemPhanCongTP.Controls.Add(this.labelTruongPhong);
            this.panelThemPhanCongTP.Controls.Add(this.buttonQuayLai);
            this.panelThemPhanCongTP.Controls.Add(this.dataGridViewThemPhongBanNS);
            this.panelThemPhanCongTP.Controls.Add(this.buttonXemTatCa);
            this.panelThemPhanCongTP.Controls.Add(this.buttonCapNhat);
            this.panelThemPhanCongTP.Controls.Add(this.labelMaPhongBan);
            this.panelThemPhanCongTP.Location = new System.Drawing.Point(-1, -9);
            this.panelThemPhanCongTP.Name = "panelThemPhanCongTP";
            this.panelThemPhanCongTP.Size = new System.Drawing.Size(935, 750);
            this.panelThemPhanCongTP.TabIndex = 3;
            // 
            // comboBoxMaPhongBan
            // 
            this.comboBoxMaPhongBan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxMaPhongBan.FormattingEnabled = true;
            this.comboBoxMaPhongBan.Location = new System.Drawing.Point(371, 64);
            this.comboBoxMaPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaPhongBan.Name = "comboBoxMaPhongBan";
            this.comboBoxMaPhongBan.Size = new System.Drawing.Size(300, 49);
            this.comboBoxMaPhongBan.TabIndex = 80;
            // 
            // comboBoxTruongPhong
            // 
            this.comboBoxTruongPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxTruongPhong.FormattingEnabled = true;
            this.comboBoxTruongPhong.Location = new System.Drawing.Point(371, 232);
            this.comboBoxTruongPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTruongPhong.Name = "comboBoxTruongPhong";
            this.comboBoxTruongPhong.Size = new System.Drawing.Size(300, 49);
            this.comboBoxTruongPhong.TabIndex = 79;
            // 
            // textBoxTenPhongBan
            // 
            this.textBoxTenPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenPhongBan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenPhongBan.Location = new System.Drawing.Point(371, 147);
            this.textBoxTenPhongBan.Multiline = true;
            this.textBoxTenPhongBan.Name = "textBoxTenPhongBan";
            this.textBoxTenPhongBan.Size = new System.Drawing.Size(440, 50);
            this.textBoxTenPhongBan.TabIndex = 78;
            // 
            // labelTenPhongBan
            // 
            this.labelTenPhongBan.AutoSize = true;
            this.labelTenPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenPhongBan.Location = new System.Drawing.Point(131, 147);
            this.labelTenPhongBan.Name = "labelTenPhongBan";
            this.labelTenPhongBan.Size = new System.Drawing.Size(223, 41);
            this.labelTenPhongBan.TabIndex = 76;
            this.labelTenPhongBan.Text = "Tên phòng ban";
            // 
            // labelTruongPhong
            // 
            this.labelTruongPhong.AutoSize = true;
            this.labelTruongPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTruongPhong.Location = new System.Drawing.Point(131, 232);
            this.labelTruongPhong.Name = "labelTruongPhong";
            this.labelTruongPhong.Size = new System.Drawing.Size(214, 41);
            this.labelTruongPhong.TabIndex = 74;
            this.labelTruongPhong.Text = "Trưởng phòng";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQuayLai.Location = new System.Drawing.Point(666, 350);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 69;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // dataGridViewThemPhongBanNS
            // 
            this.dataGridViewThemPhongBanNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThemPhongBanNS.Location = new System.Drawing.Point(0, 447);
            this.dataGridViewThemPhongBanNS.Name = "dataGridViewThemPhongBanNS";
            this.dataGridViewThemPhongBanNS.RowHeadersWidth = 51;
            this.dataGridViewThemPhongBanNS.RowTemplate.Height = 24;
            this.dataGridViewThemPhongBanNS.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThemPhongBanNS.TabIndex = 68;
            // 
            // buttonXemTatCa
            // 
            this.buttonXemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXemTatCa.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXemTatCa.Location = new System.Drawing.Point(342, 350);
            this.buttonXemTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXemTatCa.Name = "buttonXemTatCa";
            this.buttonXemTatCa.Size = new System.Drawing.Size(250, 70);
            this.buttonXemTatCa.TabIndex = 67;
            this.buttonXemTatCa.Text = "Xem tất cả";
            this.buttonXemTatCa.UseVisualStyleBackColor = false;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapNhat.Location = new System.Drawing.Point(66, 350);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(200, 70);
            this.buttonCapNhat.TabIndex = 66;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            // 
            // labelMaPhongBan
            // 
            this.labelMaPhongBan.AutoSize = true;
            this.labelMaPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaPhongBan.Location = new System.Drawing.Point(131, 72);
            this.labelMaPhongBan.Name = "labelMaPhongBan";
            this.labelMaPhongBan.Size = new System.Drawing.Size(219, 41);
            this.labelMaPhongBan.TabIndex = 64;
            this.labelMaPhongBan.Text = "Mã phòng ban";
            // 
            // ChinhSuaPhongBanNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 733);
            this.Controls.Add(this.panelThemPhanCongTP);
            this.Name = "ChinhSuaPhongBanNS";
            this.Text = "ChinhSuaPhongBanNS";
            this.panelThemPhanCongTP.ResumeLayout(false);
            this.panelThemPhanCongTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemPhongBanNS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemPhanCongTP;
        private System.Windows.Forms.ComboBox comboBoxTruongPhong;
        private System.Windows.Forms.TextBox textBoxTenPhongBan;
        private System.Windows.Forms.Label labelTenPhongBan;
        private System.Windows.Forms.Label labelTruongPhong;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.DataGridView dataGridViewThemPhongBanNS;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Label labelMaPhongBan;
        private System.Windows.Forms.ComboBox comboBoxMaPhongBan;
    }
}