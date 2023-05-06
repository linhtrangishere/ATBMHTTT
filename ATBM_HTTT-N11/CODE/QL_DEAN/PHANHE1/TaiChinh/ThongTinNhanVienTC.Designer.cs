namespace PHANHE1.TaiChinh
{
    partial class ThongTinNhanVienTC
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
            this.panelThongTinNhanVienTC = new System.Windows.Forms.Panel();
            this.labelThongTinNhanVienTC = new System.Windows.Forms.Label();
            this.panelChildFormTTNV = new System.Windows.Forms.Panel();
            this.panelXemChinhSua = new System.Windows.Forms.Panel();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonChinhSua = new System.Windows.Forms.Button();
            this.panelThongTinNhanVienTC.SuspendLayout();
            this.panelChildFormTTNV.SuspendLayout();
            this.panelXemChinhSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThongTinNhanVienTC
            // 
            this.panelThongTinNhanVienTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinNhanVienTC.Controls.Add(this.labelThongTinNhanVienTC);
            this.panelThongTinNhanVienTC.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinNhanVienTC.Name = "panelThongTinNhanVienTC";
            this.panelThongTinNhanVienTC.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinNhanVienTC.TabIndex = 0;
            this.panelThongTinNhanVienTC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinNhanVienTC
            // 
            this.labelThongTinNhanVienTC.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinNhanVienTC.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinNhanVienTC.Name = "labelThongTinNhanVienTC";
            this.labelThongTinNhanVienTC.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinNhanVienTC.TabIndex = 0;
            this.labelThongTinNhanVienTC.Text = "Thông tin nhân viên";
            this.labelThongTinNhanVienTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTNV
            // 
            this.panelChildFormTTNV.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTNV.Controls.Add(this.panelXemChinhSua);
            this.panelChildFormTTNV.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTNV.Name = "panelChildFormTTNV";
            this.panelChildFormTTNV.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTNV.TabIndex = 1;
            // 
            // panelXemChinhSua
            // 
            this.panelXemChinhSua.Controls.Add(this.buttonXemTatCa);
            this.panelXemChinhSua.Controls.Add(this.buttonChinhSua);
            this.panelXemChinhSua.Location = new System.Drawing.Point(0, 250);
            this.panelXemChinhSua.Name = "panelXemChinhSua";
            this.panelXemChinhSua.Size = new System.Drawing.Size(935, 100);
            this.panelXemChinhSua.TabIndex = 0;
            // 
            // buttonXemTatCa
            // 
            this.buttonXemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXemTatCa.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXemTatCa.Location = new System.Drawing.Point(140, 15);
            this.buttonXemTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXemTatCa.Name = "buttonXemTatCa";
            this.buttonXemTatCa.Size = new System.Drawing.Size(200, 70);
            this.buttonXemTatCa.TabIndex = 58;
            this.buttonXemTatCa.Text = "Xem";
            this.buttonXemTatCa.UseVisualStyleBackColor = false;
            this.buttonXemTatCa.Click += new System.EventHandler(this.buttonXemTatCa_Click);
            // 
            // buttonChinhSua
            // 
            this.buttonChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSua.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSua.Location = new System.Drawing.Point(540, 15);
            this.buttonChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChinhSua.Name = "buttonChinhSua";
            this.buttonChinhSua.Size = new System.Drawing.Size(250, 70);
            this.buttonChinhSua.TabIndex = 57;
            this.buttonChinhSua.Text = "Chỉnh sửa";
            this.buttonChinhSua.UseVisualStyleBackColor = false;
            this.buttonChinhSua.Click += new System.EventHandler(this.buttonChinhSua_Click);
            // 
            // ThongTinNhanVienTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTNV);
            this.Controls.Add(this.panelThongTinNhanVienTC);
            this.Name = "ThongTinNhanVienTC";
            this.Text = "ThongTinNhanVienTC";
            this.panelThongTinNhanVienTC.ResumeLayout(false);
            this.panelChildFormTTNV.ResumeLayout(false);
            this.panelXemChinhSua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinNhanVienTC;
        private System.Windows.Forms.Label labelThongTinNhanVienTC;
        private System.Windows.Forms.Panel panelChildFormTTNV;
        private System.Windows.Forms.Panel panelXemChinhSua;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonChinhSua;
    }
}