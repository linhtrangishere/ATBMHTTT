namespace PHANHE1.NhanSu
{
    partial class XoaPhongBanNS
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
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.dataGridViewXoaPhongBanNS = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.labelMaPhongBan = new System.Windows.Forms.Label();
            this.panelThemPhanCongTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaPhongBanNS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThemPhanCongTP
            // 
            this.panelThemPhanCongTP.BackColor = System.Drawing.Color.White;
            this.panelThemPhanCongTP.Controls.Add(this.comboBoxPhongBan);
            this.panelThemPhanCongTP.Controls.Add(this.buttonQuayLai);
            this.panelThemPhanCongTP.Controls.Add(this.dataGridViewXoaPhongBanNS);
            this.panelThemPhanCongTP.Controls.Add(this.buttonXemTatCa);
            this.panelThemPhanCongTP.Controls.Add(this.buttonXoa);
            this.panelThemPhanCongTP.Controls.Add(this.labelMaPhongBan);
            this.panelThemPhanCongTP.Location = new System.Drawing.Point(-1, -9);
            this.panelThemPhanCongTP.Name = "panelThemPhanCongTP";
            this.panelThemPhanCongTP.Size = new System.Drawing.Size(935, 750);
            this.panelThemPhanCongTP.TabIndex = 3;
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(415, 160);
            this.comboBoxPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(300, 49);
            this.comboBoxPhongBan.TabIndex = 79;
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
            // dataGridViewXoaPhongBanNS
            // 
            this.dataGridViewXoaPhongBanNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXoaPhongBanNS.Location = new System.Drawing.Point(0, 447);
            this.dataGridViewXoaPhongBanNS.Name = "dataGridViewXoaPhongBanNS";
            this.dataGridViewXoaPhongBanNS.RowHeadersWidth = 51;
            this.dataGridViewXoaPhongBanNS.RowTemplate.Height = 24;
            this.dataGridViewXoaPhongBanNS.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewXoaPhongBanNS.TabIndex = 68;
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
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.Location = new System.Drawing.Point(66, 350);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(200, 70);
            this.buttonXoa.TabIndex = 66;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            // 
            // labelMaPhongBan
            // 
            this.labelMaPhongBan.AutoSize = true;
            this.labelMaPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaPhongBan.Location = new System.Drawing.Point(175, 160);
            this.labelMaPhongBan.Name = "labelMaPhongBan";
            this.labelMaPhongBan.Size = new System.Drawing.Size(219, 41);
            this.labelMaPhongBan.TabIndex = 64;
            this.labelMaPhongBan.Text = "Mã phòng ban";
            // 
            // XoaPhongBanNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 733);
            this.Controls.Add(this.panelThemPhanCongTP);
            this.Name = "XoaPhongBanNS";
            this.Text = "XoaPhongBanNS";
            this.panelThemPhanCongTP.ResumeLayout(false);
            this.panelThemPhanCongTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaPhongBanNS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemPhanCongTP;
        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.DataGridView dataGridViewXoaPhongBanNS;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label labelMaPhongBan;
    }
}