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
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaQuyen = new System.Windows.Forms.Button();
            this.buttonCapQuyen = new System.Windows.Forms.Button();
            this.buttonThuHoiQuyen = new System.Windows.Forms.Button();
            this.dataGridViewQuanLyQuyenRole = new System.Windows.Forms.DataGridView();
            this.panelQuanLyQuyenRole.SuspendLayout();
            this.panelThemXoaSua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyQuyenRole)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuanLyQuyenRole
            // 
            this.panelQuanLyQuyenRole.BackColor = System.Drawing.Color.White;
            this.panelQuanLyQuyenRole.Controls.Add(this.panelThemXoaSua);
            this.panelQuanLyQuyenRole.Controls.Add(this.dataGridViewQuanLyQuyenRole);
            this.panelQuanLyQuyenRole.Location = new System.Drawing.Point(0, -8);
            this.panelQuanLyQuyenRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelQuanLyQuyenRole.Name = "panelQuanLyQuyenRole";
            this.panelQuanLyQuyenRole.Size = new System.Drawing.Size(701, 561);
            this.panelQuanLyQuyenRole.TabIndex = 2;
            this.panelQuanLyQuyenRole.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuanLyQuyenRole_Paint);
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaQuyen);
            this.panelThemXoaSua.Controls.Add(this.buttonCapQuyen);
            this.panelThemXoaSua.Controls.Add(this.buttonThuHoiQuyen);
            this.panelThemXoaSua.Location = new System.Drawing.Point(0, 81);
            this.panelThemXoaSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(701, 122);
            this.panelThemXoaSua.TabIndex = 18;
            // 
            // buttonChinhSuaQuyen
            // 
            this.buttonChinhSuaQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaQuyen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaQuyen.Location = new System.Drawing.Point(482, 23);
            this.buttonChinhSuaQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChinhSuaQuyen.Name = "buttonChinhSuaQuyen";
            this.buttonChinhSuaQuyen.Size = new System.Drawing.Size(188, 76);
            this.buttonChinhSuaQuyen.TabIndex = 20;
            this.buttonChinhSuaQuyen.Text = "Chỉnh sửa quyền";
            this.buttonChinhSuaQuyen.UseVisualStyleBackColor = false;
            this.buttonChinhSuaQuyen.Click += new System.EventHandler(this.buttonChinhSuaQuyen_Click);
            // 
            // buttonCapQuyen
            // 
            this.buttonCapQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonCapQuyen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapQuyen.Location = new System.Drawing.Point(32, 23);
            this.buttonCapQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCapQuyen.Name = "buttonCapQuyen";
            this.buttonCapQuyen.Size = new System.Drawing.Size(174, 76);
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
            this.buttonThuHoiQuyen.Location = new System.Drawing.Point(256, 23);
            this.buttonThuHoiQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThuHoiQuyen.Name = "buttonThuHoiQuyen";
            this.buttonThuHoiQuyen.Size = new System.Drawing.Size(174, 76);
            this.buttonThuHoiQuyen.TabIndex = 18;
            this.buttonThuHoiQuyen.Text = "Thu hồi quyền";
            this.buttonThuHoiQuyen.UseVisualStyleBackColor = false;
            this.buttonThuHoiQuyen.Click += new System.EventHandler(this.buttonThuHoiQuyen_Click);
            // 
            // dataGridViewQuanLyQuyenRole
            // 
            this.dataGridViewQuanLyQuyenRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyQuyenRole.Location = new System.Drawing.Point(0, 274);
            this.dataGridViewQuanLyQuyenRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewQuanLyQuyenRole.Name = "dataGridViewQuanLyQuyenRole";
            this.dataGridViewQuanLyQuyenRole.RowHeadersWidth = 51;
            this.dataGridViewQuanLyQuyenRole.RowTemplate.Height = 24;
            this.dataGridViewQuanLyQuyenRole.Size = new System.Drawing.Size(701, 284);
            this.dataGridViewQuanLyQuyenRole.TabIndex = 14;
            this.dataGridViewQuanLyQuyenRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyQuyenRole_CellContentClick);
            // 
            // QuanLyQuyenRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 547);
            this.Controls.Add(this.panelQuanLyQuyenRole);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyQuyenRole";
            this.Text = "QuanLyQuyenRole";
            this.Load += new System.EventHandler(this.QuanLyQuyenRole_Load);
            this.panelQuanLyQuyenRole.ResumeLayout(false);
            this.panelThemXoaSua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyQuyenRole)).EndInit();
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