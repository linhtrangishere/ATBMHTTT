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
            this.panelThemRole = new System.Windows.Forms.Panel();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxNhapTenRole = new System.Windows.Forms.TextBox();
            this.labelNhapTenRole = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.panelThemRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThemRole
            // 
            this.panelThemRole.Controls.Add(this.buttonThem);
            this.panelThemRole.Controls.Add(this.textBoxNhapTenRole);
            this.panelThemRole.Controls.Add(this.labelNhapTenRole);
            this.panelThemRole.Controls.Add(this.buttonQuayLai);
            this.panelThemRole.Location = new System.Drawing.Point(0, -10);
            this.panelThemRole.Name = "panelThemRole";
            this.panelThemRole.Size = new System.Drawing.Size(935, 600);
            this.panelThemRole.TabIndex = 0;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.Location = new System.Drawing.Point(152, 360);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(200, 70);
            this.buttonThem.TabIndex = 22;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxNhapTenRole
            // 
            this.textBoxNhapTenRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhapTenRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhapTenRole.Location = new System.Drawing.Point(152, 223);
            this.textBoxNhapTenRole.Multiline = true;
            this.textBoxNhapTenRole.Name = "textBoxNhapTenRole";
            this.textBoxNhapTenRole.Size = new System.Drawing.Size(630, 50);
            this.textBoxNhapTenRole.TabIndex = 21;
            // 
            // labelNhapTenRole
            // 
            this.labelNhapTenRole.AutoSize = true;
            this.labelNhapTenRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhapTenRole.Location = new System.Drawing.Point(152, 170);
            this.labelNhapTenRole.Name = "labelNhapTenRole";
            this.labelNhapTenRole.Size = new System.Drawing.Size(212, 41);
            this.labelNhapTenRole.TabIndex = 20;
            this.labelNhapTenRole.Text = "Nhập tên role";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(582, 360);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 19;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // ThemRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.panelThemRole);
            this.Name = "ThemRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemRole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelThemRole.ResumeLayout(false);
            this.panelThemRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemRole;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxNhapTenRole;
        private System.Windows.Forms.Label labelNhapTenRole;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}

