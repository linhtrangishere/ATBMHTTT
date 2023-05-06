namespace PHANHE1.NhanSu
{
    partial class QuanLyPhongBanNS
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
            this.panelQuanLyPhanCong = new System.Windows.Forms.Panel();
            this.labelQuanLyPhongBan = new System.Windows.Forms.Label();
            this.panelChildFormQuanLyPhongBanNS = new System.Windows.Forms.Panel();
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaPhongBan = new System.Windows.Forms.Button();
            this.buttonXoaPhongBan = new System.Windows.Forms.Button();
            this.buttonThemPhongBan = new System.Windows.Forms.Button();
            this.panelQuanLyPhanCong.SuspendLayout();
            this.panelChildFormQuanLyPhongBanNS.SuspendLayout();
            this.panelThemXoaSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuanLyPhanCong
            // 
            this.panelQuanLyPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelQuanLyPhanCong.Controls.Add(this.labelQuanLyPhongBan);
            this.panelQuanLyPhanCong.Location = new System.Drawing.Point(-1, -6);
            this.panelQuanLyPhanCong.Name = "panelQuanLyPhanCong";
            this.panelQuanLyPhanCong.Size = new System.Drawing.Size(935, 130);
            this.panelQuanLyPhanCong.TabIndex = 4;
            // 
            // labelQuanLyPhongBan
            // 
            this.labelQuanLyPhongBan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQuanLyPhongBan.Location = new System.Drawing.Point(0, 7);
            this.labelQuanLyPhongBan.Name = "labelQuanLyPhongBan";
            this.labelQuanLyPhongBan.Size = new System.Drawing.Size(935, 120);
            this.labelQuanLyPhongBan.TabIndex = 0;
            this.labelQuanLyPhongBan.Text = "Quản lý phòng ban";
            this.labelQuanLyPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormQuanLyPhongBanNS
            // 
            this.panelChildFormQuanLyPhongBanNS.BackColor = System.Drawing.Color.White;
            this.panelChildFormQuanLyPhongBanNS.Controls.Add(this.panelThemXoaSua);
            this.panelChildFormQuanLyPhongBanNS.Location = new System.Drawing.Point(-1, 124);
            this.panelChildFormQuanLyPhongBanNS.Name = "panelChildFormQuanLyPhongBanNS";
            this.panelChildFormQuanLyPhongBanNS.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormQuanLyPhongBanNS.TabIndex = 5;
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaPhongBan);
            this.panelThemXoaSua.Controls.Add(this.buttonXoaPhongBan);
            this.panelThemXoaSua.Controls.Add(this.buttonThemPhongBan);
            this.panelThemXoaSua.Location = new System.Drawing.Point(300, 0);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(335, 715);
            this.panelThemXoaSua.TabIndex = 0;
            // 
            // buttonChinhSuaPhongBan
            // 
            this.buttonChinhSuaPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaPhongBan.Location = new System.Drawing.Point(42, 472);
            this.buttonChinhSuaPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChinhSuaPhongBan.Name = "buttonChinhSuaPhongBan";
            this.buttonChinhSuaPhongBan.Size = new System.Drawing.Size(250, 102);
            this.buttonChinhSuaPhongBan.TabIndex = 60;
            this.buttonChinhSuaPhongBan.Text = "Chỉnh sửa phòng ban";
            this.buttonChinhSuaPhongBan.UseVisualStyleBackColor = false;
            this.buttonChinhSuaPhongBan.Click += new System.EventHandler(this.buttonChinhSuaPhongBan_Click);
            // 
            // buttonXoaPhongBan
            // 
            this.buttonXoaPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXoaPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoaPhongBan.Location = new System.Drawing.Point(42, 322);
            this.buttonXoaPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaPhongBan.Name = "buttonXoaPhongBan";
            this.buttonXoaPhongBan.Size = new System.Drawing.Size(250, 102);
            this.buttonXoaPhongBan.TabIndex = 59;
            this.buttonXoaPhongBan.Text = "Xóa phòng ban";
            this.buttonXoaPhongBan.UseVisualStyleBackColor = false;
            this.buttonXoaPhongBan.Click += new System.EventHandler(this.buttonXoaPhongBan_Click);
            // 
            // buttonThemPhongBan
            // 
            this.buttonThemPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThemPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThemPhongBan.Location = new System.Drawing.Point(42, 172);
            this.buttonThemPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemPhongBan.Name = "buttonThemPhongBan";
            this.buttonThemPhongBan.Size = new System.Drawing.Size(250, 102);
            this.buttonThemPhongBan.TabIndex = 58;
            this.buttonThemPhongBan.Text = "Thêm phòng ban";
            this.buttonThemPhongBan.UseVisualStyleBackColor = false;
            this.buttonThemPhongBan.Click += new System.EventHandler(this.buttonThemPhongBan_Click);
            // 
            // QuanLyPhongBanNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelQuanLyPhanCong);
            this.Controls.Add(this.panelChildFormQuanLyPhongBanNS);
            this.Name = "QuanLyPhongBanNS";
            this.Text = "QuanLyPhongBanNS";
            this.Load += new System.EventHandler(this.QuanLyPhongBanNS_Load);
            this.panelQuanLyPhanCong.ResumeLayout(false);
            this.panelChildFormQuanLyPhongBanNS.ResumeLayout(false);
            this.panelThemXoaSua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyPhanCong;
        private System.Windows.Forms.Label labelQuanLyPhongBan;
        private System.Windows.Forms.Panel panelChildFormQuanLyPhongBanNS;
        private System.Windows.Forms.Panel panelThemXoaSua;
        private System.Windows.Forms.Button buttonChinhSuaPhongBan;
        private System.Windows.Forms.Button buttonXoaPhongBan;
        private System.Windows.Forms.Button buttonThemPhongBan;
    }
}