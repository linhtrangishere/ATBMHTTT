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
            this.panelXoaUser = new System.Windows.Forms.Panel();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxXoaUser = new System.Windows.Forms.TextBox();
            this.labelXoaUsers = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.panelXoaUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelXoaUser
            // 
            this.panelXoaUser.Controls.Add(this.buttonXoa);
            this.panelXoaUser.Controls.Add(this.textBoxXoaUser);
            this.panelXoaUser.Controls.Add(this.labelXoaUsers);
            this.panelXoaUser.Controls.Add(this.buttonQuayLai);
            this.panelXoaUser.Location = new System.Drawing.Point(0, -10);
            this.panelXoaUser.Name = "panelXoaUser";
            this.panelXoaUser.Size = new System.Drawing.Size(935, 600);
            this.panelXoaUser.TabIndex = 0;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.Location = new System.Drawing.Point(152, 360);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(200, 70);
            this.buttonXoa.TabIndex = 22;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // textBoxXoaUser
            // 
            this.textBoxXoaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxXoaUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxXoaUser.Location = new System.Drawing.Point(152, 223);
            this.textBoxXoaUser.Multiline = true;
            this.textBoxXoaUser.Name = "textBoxXoaUser";
            this.textBoxXoaUser.Size = new System.Drawing.Size(630, 50);
            this.textBoxXoaUser.TabIndex = 21;
            // 
            // labelXoaUsers
            // 
            this.labelXoaUsers.AutoSize = true;
            this.labelXoaUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelXoaUsers.Location = new System.Drawing.Point(152, 170);
            this.labelXoaUsers.Name = "labelXoaUsers";
            this.labelXoaUsers.Size = new System.Drawing.Size(139, 41);
            this.labelXoaUsers.TabIndex = 20;
            this.labelXoaUsers.Text = "Xóa user";
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
            // XoaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.panelXoaUser);
            this.Name = "XoaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaUser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelXoaUser.ResumeLayout(false);
            this.panelXoaUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelXoaUser;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.TextBox textBoxXoaUser;
        private System.Windows.Forms.Label labelXoaUsers;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}

