namespace PHANHE1
{
    partial class XoaUser
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
            this.labelXoaUsers = new System.Windows.Forms.Label();
            this.textBoxXoaUser = new System.Windows.Forms.TextBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panelXoaUser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(561, 307);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(200, 70);
            this.buttonHuy.TabIndex = 13;
            this.buttonHuy.Text = "Quay lại";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // labelXoaUsers
            // 
            this.labelXoaUsers.AutoSize = true;
            this.labelXoaUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelXoaUsers.Location = new System.Drawing.Point(131, 117);
            this.labelXoaUsers.Name = "labelXoaUsers";
            this.labelXoaUsers.Size = new System.Drawing.Size(139, 41);
            this.labelXoaUsers.TabIndex = 14;
            this.labelXoaUsers.Text = "Xóa user";
            // 
            // textBoxXoaUser
            // 
            this.textBoxXoaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxXoaUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxXoaUser.Location = new System.Drawing.Point(131, 170);
            this.textBoxXoaUser.Multiline = true;
            this.textBoxXoaUser.Name = "textBoxXoaUser";
            this.textBoxXoaUser.Size = new System.Drawing.Size(630, 50);
            this.textBoxXoaUser.TabIndex = 15;
            this.textBoxXoaUser.TextChanged += new System.EventHandler(this.textBoxNhapTenRole_TextChanged);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.Location = new System.Drawing.Point(131, 307);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(200, 70);
            this.buttonXoa.TabIndex = 18;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panelXoaUser
            // 
            this.panelXoaUser.Location = new System.Drawing.Point(0, -2);
            this.panelXoaUser.Name = "panelXoaUser";
            this.panelXoaUser.Size = new System.Drawing.Size(916, 630);
            this.panelXoaUser.TabIndex = 19;
            // 
            // XoaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(914, 625);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.textBoxXoaUser);
            this.Controls.Add(this.labelXoaUsers);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.panelXoaUser);
            this.Name = "XoaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaUser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelXoaUsers;
        private System.Windows.Forms.TextBox textBoxXoaUser;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Panel panelXoaUser;
    }
}

