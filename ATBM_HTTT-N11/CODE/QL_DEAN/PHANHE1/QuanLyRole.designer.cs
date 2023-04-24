namespace PHANHE1
{
    partial class QuanLyRole
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
            this.panelQuanLyRole = new System.Windows.Forms.Panel();
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaRole = new System.Windows.Forms.Button();
            this.buttonTaoRole = new System.Windows.Forms.Button();
            this.buttonXoaRole = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelQuanLyRole.SuspendLayout();
            this.panelThemXoaSua.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuanLyRole
            // 
            this.panelQuanLyRole.BackColor = System.Drawing.Color.White;
            this.panelQuanLyRole.Controls.Add(this.panelChildForm);
            this.panelQuanLyRole.Location = new System.Drawing.Point(0, -10);
            this.panelQuanLyRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQuanLyRole.Name = "panelQuanLyRole";
            this.panelQuanLyRole.Size = new System.Drawing.Size(935, 690);
            this.panelQuanLyRole.TabIndex = 2;
            this.panelQuanLyRole.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuanLyRole_Paint);
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaRole);
            this.panelThemXoaSua.Controls.Add(this.buttonTaoRole);
            this.panelThemXoaSua.Controls.Add(this.buttonXoaRole);
            this.panelThemXoaSua.Location = new System.Drawing.Point(3, 131);
            this.panelThemXoaSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(935, 150);
            this.panelThemXoaSua.TabIndex = 18;
            // 
            // buttonChinhSuaRole
            // 
            this.buttonChinhSuaRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaRole.Location = new System.Drawing.Point(651, 28);
            this.buttonChinhSuaRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChinhSuaRole.Name = "buttonChinhSuaRole";
            this.buttonChinhSuaRole.Size = new System.Drawing.Size(232, 94);
            this.buttonChinhSuaRole.TabIndex = 20;
            this.buttonChinhSuaRole.Text = "Chỉnh sửa role";
            this.buttonChinhSuaRole.UseVisualStyleBackColor = false;
            this.buttonChinhSuaRole.Click += new System.EventHandler(this.buttonChinhSuaRole_Click);
            // 
            // buttonTaoRole
            // 
            this.buttonTaoRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonTaoRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaoRole.Location = new System.Drawing.Point(51, 28);
            this.buttonTaoRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTaoRole.Name = "buttonTaoRole";
            this.buttonTaoRole.Size = new System.Drawing.Size(232, 94);
            this.buttonTaoRole.TabIndex = 19;
            this.buttonTaoRole.Text = "Tạo role";
            this.buttonTaoRole.UseVisualStyleBackColor = false;
            this.buttonTaoRole.Click += new System.EventHandler(this.buttonTaoRole_Click);
            // 
            // buttonXoaRole
            // 
            this.buttonXoaRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonXoaRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonXoaRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoaRole.Location = new System.Drawing.Point(351, 28);
            this.buttonXoaRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaRole.Name = "buttonXoaRole";
            this.buttonXoaRole.Size = new System.Drawing.Size(232, 94);
            this.buttonXoaRole.TabIndex = 18;
            this.buttonXoaRole.Text = "Xóa role";
            this.buttonXoaRole.UseVisualStyleBackColor = false;
            this.buttonXoaRole.Click += new System.EventHandler(this.buttonXoaRole_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.panelThemXoaSua);
            this.panelChildForm.Location = new System.Drawing.Point(0, 15);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(932, 672);
            this.panelChildForm.TabIndex = 19;
            // 
            // QuanLyRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelQuanLyRole);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyRole";
            this.Text = "QuanLyRole";
            this.Load += new System.EventHandler(this.QuanLyRole_Load);
            this.panelQuanLyRole.ResumeLayout(false);
            this.panelThemXoaSua.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyRole;
        private System.Windows.Forms.Panel panelThemXoaSua;
        private System.Windows.Forms.Button buttonChinhSuaRole;
        private System.Windows.Forms.Button buttonTaoRole;
        private System.Windows.Forms.Button buttonXoaRole;
        private System.Windows.Forms.Panel panelChildForm;
    }
}