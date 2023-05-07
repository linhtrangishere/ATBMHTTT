namespace PHANHE1.NhanSu
{
    partial class QuanLyNhanVienNS
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
            this.panelQuanLyNhanVienNS = new System.Windows.Forms.Panel();
            this.labelQuanLyNhanVienNS = new System.Windows.Forms.Label();
            this.panelChildFormQuanLyNV = new System.Windows.Forms.Panel();
            this.panelThemChinhSua = new System.Windows.Forms.Panel();
            this.buttonThemNhanVien = new System.Windows.Forms.Button();
            this.buttonChinhSuaNhanVien = new System.Windows.Forms.Button();
            this.panelQuanLyNhanVienNS.SuspendLayout();
            this.panelChildFormQuanLyNV.SuspendLayout();
            this.panelThemChinhSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuanLyNhanVienNS
            // 
            this.panelQuanLyNhanVienNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelQuanLyNhanVienNS.Controls.Add(this.labelQuanLyNhanVienNS);
            this.panelQuanLyNhanVienNS.Location = new System.Drawing.Point(-1, -6);
            this.panelQuanLyNhanVienNS.Name = "panelQuanLyNhanVienNS";
            this.panelQuanLyNhanVienNS.Size = new System.Drawing.Size(935, 130);
            this.panelQuanLyNhanVienNS.TabIndex = 2;
            // 
            // labelQuanLyNhanVienNS
            // 
            this.labelQuanLyNhanVienNS.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQuanLyNhanVienNS.Location = new System.Drawing.Point(0, 10);
            this.labelQuanLyNhanVienNS.Name = "labelQuanLyNhanVienNS";
            this.labelQuanLyNhanVienNS.Size = new System.Drawing.Size(935, 120);
            this.labelQuanLyNhanVienNS.TabIndex = 0;
            this.labelQuanLyNhanVienNS.Text = "Quản lý nhân viên";
            this.labelQuanLyNhanVienNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormQuanLyNV
            // 
            this.panelChildFormQuanLyNV.BackColor = System.Drawing.Color.White;
            this.panelChildFormQuanLyNV.Controls.Add(this.panelThemChinhSua);
            this.panelChildFormQuanLyNV.Location = new System.Drawing.Point(-1, 124);
            this.panelChildFormQuanLyNV.Name = "panelChildFormQuanLyNV";
            this.panelChildFormQuanLyNV.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormQuanLyNV.TabIndex = 3;
            // 
            // panelThemChinhSua
            // 
            this.panelThemChinhSua.Controls.Add(this.buttonThemNhanVien);
            this.panelThemChinhSua.Controls.Add(this.buttonChinhSuaNhanVien);
            this.panelThemChinhSua.Location = new System.Drawing.Point(0, 250);
            this.panelThemChinhSua.Name = "panelThemChinhSua";
            this.panelThemChinhSua.Size = new System.Drawing.Size(935, 100);
            this.panelThemChinhSua.TabIndex = 0;
            // 
            // buttonThemNhanVien
            // 
            this.buttonThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThemNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThemNhanVien.Location = new System.Drawing.Point(60, 15);
            this.buttonThemNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemNhanVien.Name = "buttonThemNhanVien";
            this.buttonThemNhanVien.Size = new System.Drawing.Size(300, 70);
            this.buttonThemNhanVien.TabIndex = 58;
            this.buttonThemNhanVien.Text = "Thêm nhân viên";
            this.buttonThemNhanVien.UseVisualStyleBackColor = false;
            this.buttonThemNhanVien.Click += new System.EventHandler(this.buttonThemNhanVien_Click);
            // 
            // buttonChinhSuaNhanVien
            // 
            this.buttonChinhSuaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaNhanVien.Location = new System.Drawing.Point(530, 15);
            this.buttonChinhSuaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChinhSuaNhanVien.Name = "buttonChinhSuaNhanVien";
            this.buttonChinhSuaNhanVien.Size = new System.Drawing.Size(350, 70);
            this.buttonChinhSuaNhanVien.TabIndex = 57;
            this.buttonChinhSuaNhanVien.Text = "Chỉnh sửa nhân viên";
            this.buttonChinhSuaNhanVien.UseVisualStyleBackColor = false;
            this.buttonChinhSuaNhanVien.Click += new System.EventHandler(this.buttonChinhSuaNhanVien_Click);
            // 
            // QuanLyNhanVienNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelQuanLyNhanVienNS);
            this.Controls.Add(this.panelChildFormQuanLyNV);
            this.Name = "QuanLyNhanVienNS";
            this.Text = "QuanLyNhanVienNS";
            this.Load += new System.EventHandler(this.QuanLyNhanVienNS_Load);
            this.panelQuanLyNhanVienNS.ResumeLayout(false);
            this.panelChildFormQuanLyNV.ResumeLayout(false);
            this.panelThemChinhSua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyNhanVienNS;
        private System.Windows.Forms.Label labelQuanLyNhanVienNS;
        private System.Windows.Forms.Panel panelChildFormQuanLyNV;
        private System.Windows.Forms.Panel panelThemChinhSua;
        private System.Windows.Forms.Button buttonThemNhanVien;
        private System.Windows.Forms.Button buttonChinhSuaNhanVien;
    }
}