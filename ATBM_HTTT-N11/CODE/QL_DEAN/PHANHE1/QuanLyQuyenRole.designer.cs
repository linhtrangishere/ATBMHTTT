namespace PHANHE1
{
    partial class QuanLyQuyenRole
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
            this.panelQuanLyQuyenRole = new System.Windows.Forms.Panel();
            this.dataGridViewQuanLyQuyenRole = new System.Windows.Forms.DataGridView();
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaQuyen = new System.Windows.Forms.Button();
            this.buttonCapQuyen = new System.Windows.Forms.Button();
            this.buttonThuHoiQuyen = new System.Windows.Forms.Button();
            this.panelQuanLyQuyenRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyQuyenRole)).BeginInit();
            this.panelThemXoaSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuanLyQuyenRole
            // 
            this.panelQuanLyQuyenRole.BackColor = System.Drawing.Color.White;
            this.panelQuanLyQuyenRole.Controls.Add(this.panelThemXoaSua);
            this.panelQuanLyQuyenRole.Controls.Add(this.dataGridViewQuanLyQuyenRole);
            this.panelQuanLyQuyenRole.Location = new System.Drawing.Point(0, -10);
            this.panelQuanLyQuyenRole.Name = "panelQuanLyQuyenRole";
            this.panelQuanLyQuyenRole.Size = new System.Drawing.Size(935, 690);
            this.panelQuanLyQuyenRole.TabIndex = 2;
            // 
            // dataGridViewQuanLyQuyenRole
            // 
            this.dataGridViewQuanLyQuyenRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyQuyenRole.Location = new System.Drawing.Point(0, 337);
            this.dataGridViewQuanLyQuyenRole.Name = "dataGridViewQuanLyQuyenRole";
            this.dataGridViewQuanLyQuyenRole.RowHeadersWidth = 51;
            this.dataGridViewQuanLyQuyenRole.RowTemplate.Height = 24;
            this.dataGridViewQuanLyQuyenRole.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewQuanLyQuyenRole.TabIndex = 14;
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaQuyen);
            this.panelThemXoaSua.Controls.Add(this.buttonCapQuyen);
            this.panelThemXoaSua.Controls.Add(this.buttonThuHoiQuyen);
            this.panelThemXoaSua.Location = new System.Drawing.Point(0, 100);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(935, 150);
            this.panelThemXoaSua.TabIndex = 18;
            // 
            // buttonChinhSuaQuyen
            // 
            this.buttonChinhSuaQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaQuyen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaQuyen.Location = new System.Drawing.Point(642, 28);
            this.buttonChinhSuaQuyen.Name = "buttonChinhSuaQuyen";
            this.buttonChinhSuaQuyen.Size = new System.Drawing.Size(250, 94);
            this.buttonChinhSuaQuyen.TabIndex = 20;
            this.buttonChinhSuaQuyen.Text = "Chỉnh sửa quyền";
            this.buttonChinhSuaQuyen.UseVisualStyleBackColor = false;
            this.buttonChinhSuaQuyen.Click += new System.EventHandler(this.buttonChinhSuaQuyen_Click);
            // 
            // buttonCapQuyen
            // 
            this.buttonCapQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonCapQuyen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapQuyen.Location = new System.Drawing.Point(42, 28);
            this.buttonCapQuyen.Name = "buttonCapQuyen";
            this.buttonCapQuyen.Size = new System.Drawing.Size(232, 94);
            this.buttonCapQuyen.TabIndex = 19;
            this.buttonCapQuyen.Text = "Cấp quyền";
            this.buttonCapQuyen.UseVisualStyleBackColor = false;
            this.buttonCapQuyen.Click += new System.EventHandler(this.buttonCapQuyen_Click);
            // 
            // buttonThuHoiQuyen
            // 
            this.buttonThuHoiQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThuHoiQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonThuHoiQuyen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThuHoiQuyen.Location = new System.Drawing.Point(342, 28);
            this.buttonThuHoiQuyen.Name = "buttonThuHoiQuyen";
            this.buttonThuHoiQuyen.Size = new System.Drawing.Size(232, 94);
            this.buttonThuHoiQuyen.TabIndex = 18;
            this.buttonThuHoiQuyen.Text = "Thu hồi quyền";
            this.buttonThuHoiQuyen.UseVisualStyleBackColor = false;
            this.buttonThuHoiQuyen.Click += new System.EventHandler(this.buttonThuHoiQuyen_Click);
            // 
            // QuanLyQuyenRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelQuanLyQuyenRole);
            this.Name = "QuanLyQuyenRole";
            this.Text = "QuanLyQuyenRole";
            this.panelQuanLyQuyenRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyQuyenRole)).EndInit();
            this.panelThemXoaSua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyQuyenRole;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyQuyenRole;
        private System.Windows.Forms.Panel panelThemXoaSua;
        private System.Windows.Forms.Button buttonChinhSuaQuyen;
        private System.Windows.Forms.Button buttonCapQuyen;
        private System.Windows.Forms.Button buttonThuHoiQuyen;
    }
}