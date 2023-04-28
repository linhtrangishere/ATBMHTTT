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
            this.panelXoaRole = new System.Windows.Forms.Panel();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxXoaRole = new System.Windows.Forms.TextBox();
            this.labelXoaRoles = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.panelXoaRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelXoaRole
            // 
            this.panelXoaRole.Controls.Add(this.buttonXoa);
            this.panelXoaRole.Controls.Add(this.textBoxXoaRole);
            this.panelXoaRole.Controls.Add(this.labelXoaRoles);
            this.panelXoaRole.Controls.Add(this.buttonQuayLai);
            this.panelXoaRole.Location = new System.Drawing.Point(0, -10);
            this.panelXoaRole.Name = "panelXoaRole";
            this.panelXoaRole.Size = new System.Drawing.Size(935, 600);
            this.panelXoaRole.TabIndex = 0;
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
            // textBoxXoaRole
            // 
            this.textBoxXoaRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxXoaRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxXoaRole.Location = new System.Drawing.Point(152, 223);
            this.textBoxXoaRole.Multiline = true;
            this.textBoxXoaRole.Name = "textBoxXoaRole";
            this.textBoxXoaRole.Size = new System.Drawing.Size(630, 50);
            this.textBoxXoaRole.TabIndex = 21;
            // 
            // labelXoaRoles
            // 
            this.labelXoaRoles.AutoSize = true;
            this.labelXoaRoles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelXoaRoles.Location = new System.Drawing.Point(152, 170);
            this.labelXoaRoles.Name = "labelXoaRoles";
            this.labelXoaRoles.Size = new System.Drawing.Size(135, 41);
            this.labelXoaRoles.TabIndex = 20;
            this.labelXoaRoles.Text = "Xóa role";
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
            // XoaRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.panelXoaRole);
            this.Name = "XoaRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaRole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelXoaRole.ResumeLayout(false);
            this.panelXoaRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelXoaRole;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.TextBox textBoxXoaRole;
        private System.Windows.Forms.Label labelXoaRoles;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}

