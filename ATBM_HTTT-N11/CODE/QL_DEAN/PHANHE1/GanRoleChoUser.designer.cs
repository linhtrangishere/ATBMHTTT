namespace PHANHE1
{
    partial class GanRoleChoUser
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
            this.panelGanRoleChoUser = new System.Windows.Forms.Panel();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonGan = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.panelGanRoleChoUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGanRoleChoUser
            // 
            this.panelGanRoleChoUser.Controls.Add(this.comboBoxUserName);
            this.panelGanRoleChoUser.Controls.Add(this.comboBoxRole);
            this.panelGanRoleChoUser.Controls.Add(this.buttonGan);
            this.panelGanRoleChoUser.Controls.Add(this.labelRole);
            this.panelGanRoleChoUser.Controls.Add(this.labelUsername);
            this.panelGanRoleChoUser.Controls.Add(this.buttonQuayLai);
            this.panelGanRoleChoUser.Location = new System.Drawing.Point(0, -10);
            this.panelGanRoleChoUser.Name = "panelGanRoleChoUser";
            this.panelGanRoleChoUser.Size = new System.Drawing.Size(935, 600);
            this.panelGanRoleChoUser.TabIndex = 0;
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(152, 150);
            this.comboBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(631, 49);
            this.comboBoxUserName.TabIndex = 26;
            this.comboBoxUserName.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserName_SelectedIndexChanged);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(152, 310);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(631, 49);
            this.comboBoxRole.TabIndex = 25;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // buttonGan
            // 
            this.buttonGan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonGan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonGan.Location = new System.Drawing.Point(152, 435);
            this.buttonGan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGan.Name = "buttonGan";
            this.buttonGan.Size = new System.Drawing.Size(200, 70);
            this.buttonGan.TabIndex = 24;
            this.buttonGan.Text = "Gán";
            this.buttonGan.UseVisualStyleBackColor = false;
            this.buttonGan.Click += new System.EventHandler(this.buttonGan_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelRole.Location = new System.Drawing.Point(152, 257);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(80, 41);
            this.labelRole.TabIndex = 23;
            this.labelRole.Text = "Role";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUsername.Location = new System.Drawing.Point(152, 95);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(158, 41);
            this.labelUsername.TabIndex = 22;
            this.labelUsername.Text = "Username";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(583, 435);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 21;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // GanRoleChoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.panelGanRoleChoUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GanRoleChoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GanRoleChoUser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGanRoleChoUser.ResumeLayout(false);
            this.panelGanRoleChoUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGanRoleChoUser;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonGan;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}

