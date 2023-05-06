namespace PHANHE1.TruongDeAn
{
    partial class ThongTinDeAnTDA
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
            this.panelThongTinDeAnTDA = new System.Windows.Forms.Panel();
            this.labelThongTinDeAnTDA = new System.Windows.Forms.Label();
            this.panelChildFormTTDA = new System.Windows.Forms.Panel();
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaDeAn = new System.Windows.Forms.Button();
            this.buttonXoaDeAn = new System.Windows.Forms.Button();
            this.buttonThemDeAn = new System.Windows.Forms.Button();
            this.panelThongTinDeAnTDA.SuspendLayout();
            this.panelChildFormTTDA.SuspendLayout();
            this.panelThemXoaSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThongTinDeAnTDA
            // 
            this.panelThongTinDeAnTDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelThongTinDeAnTDA.Controls.Add(this.labelThongTinDeAnTDA);
            this.panelThongTinDeAnTDA.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinDeAnTDA.Name = "panelThongTinDeAnTDA";
            this.panelThongTinDeAnTDA.Size = new System.Drawing.Size(935, 130);
            this.panelThongTinDeAnTDA.TabIndex = 0;
            this.panelThongTinDeAnTDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThongTinCaNhanQLTT_Paint);
            // 
            // labelThongTinDeAnTDA
            // 
            this.labelThongTinDeAnTDA.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinDeAnTDA.Location = new System.Drawing.Point(0, 10);
            this.labelThongTinDeAnTDA.Name = "labelThongTinDeAnTDA";
            this.labelThongTinDeAnTDA.Size = new System.Drawing.Size(935, 120);
            this.labelThongTinDeAnTDA.TabIndex = 0;
            this.labelThongTinDeAnTDA.Text = "Thông tin đề án";
            this.labelThongTinDeAnTDA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildFormTTDA
            // 
            this.panelChildFormTTDA.BackColor = System.Drawing.Color.White;
            this.panelChildFormTTDA.Controls.Add(this.panelThemXoaSua);
            this.panelChildFormTTDA.Location = new System.Drawing.Point(0, 120);
            this.panelChildFormTTDA.Name = "panelChildFormTTDA";
            this.panelChildFormTTDA.Size = new System.Drawing.Size(935, 715);
            this.panelChildFormTTDA.TabIndex = 1;
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaDeAn);
            this.panelThemXoaSua.Controls.Add(this.buttonXoaDeAn);
            this.panelThemXoaSua.Controls.Add(this.buttonThemDeAn);
            this.panelThemXoaSua.Location = new System.Drawing.Point(300, 0);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(335, 715);
            this.panelThemXoaSua.TabIndex = 0;
            // 
            // buttonChinhSuaDeAn
            // 
            this.buttonChinhSuaDeAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaDeAn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaDeAn.Location = new System.Drawing.Point(42, 472);
            this.buttonChinhSuaDeAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChinhSuaDeAn.Name = "buttonChinhSuaDeAn";
            this.buttonChinhSuaDeAn.Size = new System.Drawing.Size(250, 70);
            this.buttonChinhSuaDeAn.TabIndex = 60;
            this.buttonChinhSuaDeAn.Text = "Chỉnh sửa đề án";
            this.buttonChinhSuaDeAn.UseVisualStyleBackColor = false;
            this.buttonChinhSuaDeAn.Click += new System.EventHandler(this.buttonChinhSuaDeAn_Click);
            // 
            // buttonXoaDeAn
            // 
            this.buttonXoaDeAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXoaDeAn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoaDeAn.Location = new System.Drawing.Point(42, 322);
            this.buttonXoaDeAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaDeAn.Name = "buttonXoaDeAn";
            this.buttonXoaDeAn.Size = new System.Drawing.Size(250, 70);
            this.buttonXoaDeAn.TabIndex = 59;
            this.buttonXoaDeAn.Text = "Xóa đề án";
            this.buttonXoaDeAn.UseVisualStyleBackColor = false;
            this.buttonXoaDeAn.Click += new System.EventHandler(this.buttonXoaDeAn_Click);
            // 
            // buttonThemDeAn
            // 
            this.buttonThemDeAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThemDeAn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThemDeAn.Location = new System.Drawing.Point(42, 172);
            this.buttonThemDeAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemDeAn.Name = "buttonThemDeAn";
            this.buttonThemDeAn.Size = new System.Drawing.Size(250, 70);
            this.buttonThemDeAn.TabIndex = 58;
            this.buttonThemDeAn.Text = "Thêm đề án";
            this.buttonThemDeAn.UseVisualStyleBackColor = false;
            this.buttonThemDeAn.Click += new System.EventHandler(this.buttonThemDeAn_Click);
            // 
            // ThongTinDeAnTDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelChildFormTTDA);
            this.Controls.Add(this.panelThongTinDeAnTDA);
            this.Name = "ThongTinDeAnTDA";
            this.Text = "ThongTinDeAnTDA";
            this.Load += new System.EventHandler(this.ThongTinDeAnTDA_Load);
            this.panelThongTinDeAnTDA.ResumeLayout(false);
            this.panelChildFormTTDA.ResumeLayout(false);
            this.panelThemXoaSua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinDeAnTDA;
        private System.Windows.Forms.Panel panelChildFormTTDA;
        private System.Windows.Forms.Label labelThongTinDeAnTDA;
        private System.Windows.Forms.Panel panelThemXoaSua;
        private System.Windows.Forms.Button buttonChinhSuaDeAn;
        private System.Windows.Forms.Button buttonXoaDeAn;
        private System.Windows.Forms.Button buttonThemDeAn;
    }
}