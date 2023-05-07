namespace PHANHE1.TaiChinh
{
    partial class ThongTinDeAnTC
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
            this.panelThongTinDeAnTC = new System.Windows.Forms.Panel();
            this.labelThongTinDeAnTC = new System.Windows.Forms.Label();
            this.panelChildFormTTDA = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinDeAnTC = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelNhapMaDeAn = new System.Windows.Forms.Label();
            this.comboBoxMaDeAn = new System.Windows.Forms.ComboBox();
            this.panelThongTinDeAnTC.SuspendLayout();
            this.panelChildFormTTDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinDeAnTC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinDeAnTC
            // 
            this.panelThongTinDeAnTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinDeAnTC.Controls.Add(this.labelThongTinDeAnTC);
            this.panelThongTinDeAnTC.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinDeAnTC.Name = "panelThongTinDeAnTC";
            this.panelThongTinDeAnTC.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinDeAnTC.TabIndex = 0;
            this.panelThongTinDeAnTC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinDeAnTC
            // 
            this.labelThongTinDeAnTC.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinDeAnTC.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinDeAnTC.Name = "labelThongTinDeAnTC";
            this.labelThongTinDeAnTC.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinDeAnTC.TabIndex = 0;
            this.labelThongTinDeAnTC.Text = "Thông tin đề án";
            this.labelThongTinDeAnTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTDA
            // 
            this.panelChildFormTTDA.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTDA.Controls.Add(this.comboBoxMaDeAn);
            this.panelChildFormTTDA.Controls.Add(this.dataGridViewThongTinDeAnTC);
            this.panelChildFormTTDA.Controls.Add(this.buttonXemTatCa);
            this.panelChildFormTTDA.Controls.Add(this.buttonTimKiem);
            this.panelChildFormTTDA.Controls.Add(this.labelNhapMaDeAn);
            this.panelChildFormTTDA.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTDA.Name = "panelChildFormTTDA";
            this.panelChildFormTTDA.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTDA.TabIndex = 1;
            // 
            // dataGridViewThongTinDeAnTC
            // 
            this.dataGridViewThongTinDeAnTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinDeAnTC.Location = new System.Drawing.Point(0, 415);
            this.dataGridViewThongTinDeAnTC.Name = "dataGridViewThongTinDeAnTC";
            this.dataGridViewThongTinDeAnTC.RowHeadersWidth = 51;
            this.dataGridViewThongTinDeAnTC.RowTemplate.Height = 24;
            this.dataGridViewThongTinDeAnTC.Size = new System.Drawing.Size(935, 300);
            this.dataGridViewThongTinDeAnTC.TabIndex = 57;
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
            this.comboBoxMaDeAn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaDeAn.FormattingEnabled = true;
            this.comboBoxMaDeAn.Location = new System.Drawing.Point(152, 281);
            this.comboBoxMaDeAn.Name = "comboBoxMaDeAn";
            this.comboBoxMaDeAn.Size = new System.Drawing.Size(300, 49);
            this.comboBoxMaDeAn.TabIndex = 60;
            // 
            // ThongTinDeAnTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTDA);
            this.Controls.Add(this.panelThongTinDeAnTC);
            this.Name = "ThongTinDeAnTC";
            this.Text = "ThongTinDeAnTC";
            this.Load += new System.EventHandler(this.ThongTinDeAnTC_Load);
            this.panelThongTinDeAnTC.ResumeLayout(false);
            this.panelChildFormTTDA.ResumeLayout(false);
            this.panelChildFormTTDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinDeAnTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinDeAnTC;
        private System.Windows.Forms.Panel panelChildFormTTDA;
        private System.Windows.Forms.Label labelThongTinDeAnTC;
        private System.Windows.Forms.Label labelNhapMaDeAn;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewThongTinDeAnTC;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.ComboBox comboBoxMaDeAn;
    }
}