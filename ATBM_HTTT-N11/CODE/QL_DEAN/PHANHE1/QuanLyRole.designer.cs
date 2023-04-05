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
            this.dataGridViewQuanLyRole = new System.Windows.Forms.DataGridView();
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaRole = new System.Windows.Forms.Button();
            this.buttonTaoRole = new System.Windows.Forms.Button();
            this.buttonXoaRole = new System.Windows.Forms.Button();
            this.panelQuanLyRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyRole)).BeginInit();
            this.panelThemXoaSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuanLyRole
            // 
            this.panelQuanLyRole.BackColor = System.Drawing.Color.White;
            this.panelQuanLyRole.Controls.Add(this.panelThemXoaSua);
            this.panelQuanLyRole.Controls.Add(this.dataGridViewQuanLyRole);
            this.panelQuanLyRole.Location = new System.Drawing.Point(0, -10);
            this.panelQuanLyRole.Name = "panelQuanLyRole";
            this.panelQuanLyRole.Size = new System.Drawing.Size(935, 690);
            this.panelQuanLyRole.TabIndex = 2;
            // 
            // dataGridViewQuanLyRole
            // 
            this.dataGridViewQuanLyRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyRole.Location = new System.Drawing.Point(0, 337);
            this.dataGridViewQuanLyRole.Name = "dataGridViewQuanLyRole";
            this.dataGridViewQuanLyRole.RowHeadersWidth = 51;
            this.dataGridViewQuanLyRole.RowTemplate.Height = 24;
            this.dataGridViewQuanLyRole.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewQuanLyRole.TabIndex = 14;
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaRole);
            this.panelThemXoaSua.Controls.Add(this.buttonTaoRole);
            this.panelThemXoaSua.Controls.Add(this.buttonXoaRole);
            this.panelThemXoaSua.Location = new System.Drawing.Point(0, 100);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(935, 150);
            this.panelThemXoaSua.TabIndex = 18;
            // 
            // buttonChinhSuaRole
            // 
            this.buttonChinhSuaRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaRole.Location = new System.Drawing.Point(651, 28);
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
            this.buttonXoaRole.Name = "buttonXoaRole";
            this.buttonXoaRole.Size = new System.Drawing.Size(232, 94);
            this.buttonXoaRole.TabIndex = 18;
            this.buttonXoaRole.Text = "Xóa role";
            this.buttonXoaRole.UseVisualStyleBackColor = false;
            // 
            // QuanLyRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelQuanLyRole);
            this.Name = "QuanLyRole";
            this.Text = "QuanLyRole";
            this.panelQuanLyRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyRole)).EndInit();
            this.panelThemXoaSua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyRole;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyRole;
        private System.Windows.Forms.Panel panelThemXoaSua;
        private System.Windows.Forms.Button buttonChinhSuaRole;
        private System.Windows.Forms.Button buttonTaoRole;
        private System.Windows.Forms.Button buttonXoaRole;
    }
}