namespace PHANHE1
{
    partial class XoaRole
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
            this.labelXoaRoles = new System.Windows.Forms.Label();
            this.textBoxXoaRole = new System.Windows.Forms.TextBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(559, 336);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(200, 70);
            this.buttonHuy.TabIndex = 13;
            this.buttonHuy.Text = "Quay lại";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // labelXoaRoles
            // 
            this.labelXoaRoles.AutoSize = true;
            this.labelXoaRoles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelXoaRoles.Location = new System.Drawing.Point(129, 146);
            this.labelXoaRoles.Name = "labelXoaRoles";
            this.labelXoaRoles.Size = new System.Drawing.Size(135, 41);
            this.labelXoaRoles.TabIndex = 14;
            this.labelXoaRoles.Text = "Xóa role";
            // 
            // textBoxXoaRole
            // 
            this.textBoxXoaRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxXoaRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxXoaRole.Location = new System.Drawing.Point(129, 199);
            this.textBoxXoaRole.Multiline = true;
            this.textBoxXoaRole.Name = "textBoxXoaRole";
            this.textBoxXoaRole.Size = new System.Drawing.Size(630, 50);
            this.textBoxXoaRole.TabIndex = 15;
            this.textBoxXoaRole.TextChanged += new System.EventHandler(this.textBoxNhapTenRole_TextChanged);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.Location = new System.Drawing.Point(129, 336);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(200, 70);
            this.buttonXoa.TabIndex = 18;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 630);
            this.panel1.TabIndex = 19;
            // 
            // XoaRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(914, 625);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.textBoxXoaRole);
            this.Controls.Add(this.labelXoaRoles);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.panel1);
            this.Name = "XoaRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaRole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelXoaRoles;
        private System.Windows.Forms.TextBox textBoxXoaRole;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Panel panel1;
    }
}

