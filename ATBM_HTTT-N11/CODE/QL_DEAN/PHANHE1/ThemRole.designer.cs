namespace PHANHE1
{
    partial class ThemRole
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
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelNhapTenRole = new System.Windows.Forms.Label();
            this.textBoxNhapTenRole = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelThemRole = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(563, 349);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(200, 70);
            this.buttonHuy.TabIndex = 13;
            this.buttonHuy.Text = "Quay lại";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // labelNhapTenRole
            // 
            this.labelNhapTenRole.AutoSize = true;
            this.labelNhapTenRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhapTenRole.Location = new System.Drawing.Point(133, 159);
            this.labelNhapTenRole.Name = "labelNhapTenRole";
            this.labelNhapTenRole.Size = new System.Drawing.Size(212, 41);
            this.labelNhapTenRole.TabIndex = 14;
            this.labelNhapTenRole.Text = "Nhập tên role";
            // 
            // textBoxNhapTenRole
            // 
            this.textBoxNhapTenRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhapTenRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhapTenRole.Location = new System.Drawing.Point(133, 212);
            this.textBoxNhapTenRole.Multiline = true;
            this.textBoxNhapTenRole.Name = "textBoxNhapTenRole";
            this.textBoxNhapTenRole.Size = new System.Drawing.Size(630, 50);
            this.textBoxNhapTenRole.TabIndex = 15;
            this.textBoxNhapTenRole.TextChanged += new System.EventHandler(this.textBoxNhapTenRole_TextChanged);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.Location = new System.Drawing.Point(133, 349);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(200, 70);
            this.buttonThem.TabIndex = 18;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panelThemRole
            // 
            this.panelThemRole.Location = new System.Drawing.Point(-2, -3);
            this.panelThemRole.Name = "panelThemRole";
            this.panelThemRole.Size = new System.Drawing.Size(916, 630);
            this.panelThemRole.TabIndex = 19;
            // 
            // ThemRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(914, 625);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxNhapTenRole);
            this.Controls.Add(this.labelNhapTenRole);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.panelThemRole);
            this.Name = "ThemRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemRole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelNhapTenRole;
        private System.Windows.Forms.TextBox textBoxNhapTenRole;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panelThemRole;
    }
}

