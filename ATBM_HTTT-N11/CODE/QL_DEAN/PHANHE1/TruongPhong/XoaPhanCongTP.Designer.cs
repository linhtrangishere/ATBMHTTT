namespace PHANHE1.TruongPhong
{
    partial class XoaPhanCongTP
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
            this.panelXoaPhanCongTP = new System.Windows.Forms.Panel();
            this.comboBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.labelMaDA = new System.Windows.Forms.Label();
            this.comboBoxDeAn = new System.Windows.Forms.ComboBox();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.dataGridViewThemThongTinDeAnTDA = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.labelMaNhanVien = new System.Windows.Forms.Label();
            this.panelXoaPhanCongTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemThongTinDeAnTDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelXoaPhanCongTP
            // 
            this.panelXoaPhanCongTP.BackColor = System.Drawing.Color.White;
            this.panelXoaPhanCongTP.Controls.Add(this.comboBoxNhanVien);
            this.panelXoaPhanCongTP.Controls.Add(this.labelMaDA);
            this.panelXoaPhanCongTP.Controls.Add(this.comboBoxDeAn);
            this.panelXoaPhanCongTP.Controls.Add(this.buttonQuayLai);
            this.panelXoaPhanCongTP.Controls.Add(this.dataGridViewThemThongTinDeAnTDA);
            this.panelXoaPhanCongTP.Controls.Add(this.buttonXemTatCa);
            this.panelXoaPhanCongTP.Controls.Add(this.buttonXoa);
            this.panelXoaPhanCongTP.Controls.Add(this.labelMaNhanVien);
            this.panelXoaPhanCongTP.Location = new System.Drawing.Point(-1, -9);
            this.panelXoaPhanCongTP.Name = "panelXoaPhanCongTP";
            this.panelXoaPhanCongTP.Size = new System.Drawing.Size(935, 750);
            this.panelXoaPhanCongTP.TabIndex = 2;
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(430, 111);
            this.comboBoxNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(300, 49);
            this.comboBoxNhanVien.TabIndex = 77;
            this.comboBoxNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxNhanVien_SelectedIndexChanged);
            // 
            // labelMaDA
            // 
            this.labelMaDA.AutoSize = true;
            this.labelMaDA.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaDA.Location = new System.Drawing.Point(190, 189);
            this.labelMaDA.Name = "labelMaDA";
            this.labelMaDA.Size = new System.Drawing.Size(146, 41);
            this.labelMaDA.TabIndex = 76;
            this.labelMaDA.Text = "Mã đề án";
            // 
            // comboBoxDeAn
            // 
            this.comboBoxDeAn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxDeAn.FormattingEnabled = true;
            this.comboBoxDeAn.Location = new System.Drawing.Point(430, 186);
            this.comboBoxDeAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDeAn.Name = "comboBoxDeAn";
            this.comboBoxDeAn.Size = new System.Drawing.Size(300, 49);
            this.comboBoxDeAn.TabIndex = 73;
            this.comboBoxDeAn.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeAn_SelectedIndexChanged);
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
            // dataGridViewThemThongTinDeAnTDA
            // 
            this.dataGridViewThemThongTinDeAnTDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThemThongTinDeAnTDA.Location = new System.Drawing.Point(0, 447);
            this.dataGridViewThemThongTinDeAnTDA.Name = "dataGridViewThemThongTinDeAnTDA";
            this.dataGridViewThemThongTinDeAnTDA.RowHeadersWidth = 51;
            this.dataGridViewThemThongTinDeAnTDA.RowTemplate.Height = 24;
            this.dataGridViewThemThongTinDeAnTDA.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThemThongTinDeAnTDA.TabIndex = 68;
            this.dataGridViewThemThongTinDeAnTDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThemThongTinDeAnTDA_CellContentClick);
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
            this.buttonXemTatCa.Click += new System.EventHandler(this.buttonXemTatCa_Click);
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
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // labelMaNhanVien
            // 
            this.labelMaNhanVien.AutoSize = true;
            this.labelMaNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaNhanVien.Location = new System.Drawing.Point(190, 114);
            this.labelMaNhanVien.Name = "labelMaNhanVien";
            this.labelMaNhanVien.Size = new System.Drawing.Size(204, 41);
            this.labelMaNhanVien.TabIndex = 64;
            this.labelMaNhanVien.Text = "Mã nhân viên";
            // 
            // XoaPhanCongTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 733);
            this.Controls.Add(this.panelXoaPhanCongTP);
            this.Name = "XoaPhanCongTP";
            this.Text = "XoaPhanCongTP";
            this.Load += new System.EventHandler(this.XoaPhanCongTP_Load);
            this.panelXoaPhanCongTP.ResumeLayout(false);
            this.panelXoaPhanCongTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemThongTinDeAnTDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelXoaPhanCongTP;
        private System.Windows.Forms.Label labelMaDA;
        private System.Windows.Forms.ComboBox comboBoxDeAn;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.DataGridView dataGridViewThemThongTinDeAnTDA;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label labelMaNhanVien;
        private System.Windows.Forms.ComboBox comboBoxNhanVien;
    }
}