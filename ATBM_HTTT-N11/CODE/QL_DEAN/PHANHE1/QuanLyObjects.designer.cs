namespace PHANHE1
{
    partial class QuanLyObjects
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelUserRole = new System.Windows.Forms.Panel();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonRole = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.panelUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Location = new System.Drawing.Point(0, 150);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(935, 682);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panelUserRole
            // 
            this.panelUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelUserRole.Controls.Add(this.buttonView);
            this.panelUserRole.Controls.Add(this.buttonTable);
            this.panelUserRole.Controls.Add(this.buttonRole);
            this.panelUserRole.Controls.Add(this.buttonUser);
            this.panelUserRole.Location = new System.Drawing.Point(0, -10);
            this.panelUserRole.Name = "panelUserRole";
            this.panelUserRole.Size = new System.Drawing.Size(935, 160);
            this.panelUserRole.TabIndex = 24;
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonView.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonView.Location = new System.Drawing.Point(715, 33);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(195, 94);
            this.buttonView.TabIndex = 9;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonTable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTable.Location = new System.Drawing.Point(485, 33);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(195, 94);
            this.buttonTable.TabIndex = 8;
            this.buttonTable.Text = "Table";
            this.buttonTable.UseVisualStyleBackColor = false;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonRole
            // 
            this.buttonRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonRole.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRole.Location = new System.Drawing.Point(255, 33);
            this.buttonRole.Name = "buttonRole";
            this.buttonRole.Size = new System.Drawing.Size(195, 94);
            this.buttonRole.TabIndex = 7;
            this.buttonRole.Text = "Role";
            this.buttonRole.UseVisualStyleBackColor = false;
            this.buttonRole.Click += new System.EventHandler(this.buttonRole_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonUser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUser.Location = new System.Drawing.Point(25, 33);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(195, 94);
            this.buttonUser.TabIndex = 6;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // QuanLyObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 833);
            this.Controls.Add(this.panelUserRole);
            this.Controls.Add(this.panelChildForm);
            this.Name = "QuanLyObjects";
            this.Text = "QuanLyUserRole";
            this.Load += new System.EventHandler(this.QuanLyObjects_Load);
            this.panelUserRole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelUserRole;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonRole;
        private System.Windows.Forms.Button buttonUser;
    }
}