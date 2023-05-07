namespace PHANHE1.TruongPhong
{
    partial class ThongTinDeAnTP
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
            this.labelThongTinDeAnTP = new System.Windows.Forms.Label();
            this.panelChildFormTTDA = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinDeAnTP = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaDeAn = new System.Windows.Forms.Label();
            this.comboBoxMaDeAn = new System.Windows.Forms.ComboBox();
            this.panelThongTinDeAnQLTT.SuspendLayout();
            this.panelChildFormTTDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinDeAnTP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinDeAnQLTT
            // 
            this.panelThongTinDeAnQLTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinDeAnQLTT.Controls.Add(this.labelThongTinDeAnTP);
            this.panelThongTinDeAnQLTT.Location = new System.Drawing.Point(-1, -6);
            this.panelThongTinDeAnQLTT.Name = "panelThongTinDeAnQLTT";
            this.panelThongTinDeAnQLTT.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinDeAnQLTT.TabIndex = 4;
            // 
            // labelThongTinDeAnTP
            // 
            this.labelThongTinDeAnTP.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinDeAnTP.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinDeAnTP.Name = "labelThongTinDeAnTP";
            this.labelThongTinDeAnTP.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinDeAnTP.TabIndex = 0;
            this.labelThongTinDeAnTP.Text = "Thông tin đề án";
            this.labelThongTinDeAnTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTDA
            // 
            this.panelChildFormTTDA.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTDA.Controls.Add(this.comboBoxMaDeAn);
            this.panelChildFormTTDA.Controls.Add(this.dataGridViewThongTinDeAnTP);
            this.panelChildFormTTDA.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTDA.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTDA.Controls.Add(this.labelNhapMaDeAn);
            this.panelChildFormTTDA.Location = new System.Drawing.Point(-1, 124);
            this.panelChildFormTTDA.Name = "panelChildFormTTDA";
            this.panelChildFormTTDA.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTDA.TabIndex = 5;
            // 
            // dataGridViewThongTinDeAnTP
            // 
            this.dataGridViewThongTinDeAnTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinDeAnTP.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinDeAnTP.Name = "dataGridViewThongTinDeAnTP";
            this.dataGridViewThongTinDeAnTP.RowHeadersWidth = 51;
            this.dataGridViewThongTinDeAnTP.RowTemplate.Height = 24;
            this.dataGridViewThongTinDeAnTP.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinDeAnTP.TabIndex = 57;
            this.dataGridViewThongTinDeAnTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTinDeAnTP_CellContentClick);
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
            this.comboBoxMaDeAn.TabIndex = 63;
            this.comboBoxMaDeAn.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaDeAn_SelectedIndexChanged);
            // 
            // ThongTinDeAnTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelThongTinDeAnQLTT);
            this.Controls.Add(this.panelChildFormTTDA);
            this.Name = "ThongTinDeAnTP";
            this.Text = "ThongTinDeAnTP";
            this.Load += new System.EventHandler(this.ThongTinDeAnTP_Load);
            this.panelThongTinDeAnQLTT.ResumeLayout(false);
            this.panelChildFormTTDA.ResumeLayout(false);
            this.panelChildFormTTDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinDeAnTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinDeAnQLTT;
        private System.Windows.Forms.Label labelThongTinDeAnTP;
        private System.Windows.Forms.Panel panelChildFormTTDA;
        private System.Windows.Forms.DataGridView dataGridViewThongTinDeAnTP;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Label labelNhapMaDeAn;
        private System.Windows.Forms.ComboBox comboBoxMaDeAn;
    }
}