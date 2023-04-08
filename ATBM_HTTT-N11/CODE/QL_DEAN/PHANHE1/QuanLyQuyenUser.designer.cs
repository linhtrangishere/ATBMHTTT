namespace PHANHE1
{
    partial class QuanLyQuyenUser
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
            this.panelQuanLyQuyenUser = new System.Windows.Forms.Panel();
            this.panelThemXoaSua = new System.Windows.Forms.Panel();
            this.buttonChinhSuaQuyen = new System.Windows.Forms.Button();
            this.buttonGanRole = new System.Windows.Forms.Button();
            this.buttonCapQuyen = new System.Windows.Forms.Button();
            this.buttonThuHoiQuyen = new System.Windows.Forms.Button();
            this.dataGridViewQuanLyQuyenUser = new System.Windows.Forms.DataGridView();
            this.panelQuanLyQuyenUser.SuspendLayout();
            this.panelThemXoaSua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyQuyenUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuanLyQuyenUser
            // 
            this.panelQuanLyQuyenUser.BackColor = System.Drawing.Color.White;
            this.panelQuanLyQuyenUser.Controls.Add(this.panelThemXoaSua);
            this.panelQuanLyQuyenUser.Controls.Add(this.dataGridViewQuanLyQuyenUser);
            this.panelQuanLyQuyenUser.Location = new System.Drawing.Point(0, -8);
            this.panelQuanLyQuyenUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelQuanLyQuyenUser.Name = "panelQuanLyQuyenUser";
            this.panelQuanLyQuyenUser.Size = new System.Drawing.Size(701, 561);
            this.panelQuanLyQuyenUser.TabIndex = 2;
            // 
            // panelThemXoaSua
            // 
            this.panelThemXoaSua.Controls.Add(this.buttonChinhSuaQuyen);
            this.panelThemXoaSua.Controls.Add(this.buttonGanRole);
            this.panelThemXoaSua.Controls.Add(this.buttonCapQuyen);
            this.panelThemXoaSua.Controls.Add(this.buttonThuHoiQuyen);
            this.panelThemXoaSua.Location = new System.Drawing.Point(0, 41);
            this.panelThemXoaSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThemXoaSua.Name = "panelThemXoaSua";
            this.panelThemXoaSua.Size = new System.Drawing.Size(701, 219);
            this.panelThemXoaSua.TabIndex = 18;
            // 
            // buttonChinhSuaQuyen
            // 
            this.buttonChinhSuaQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonChinhSuaQuyen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChinhSuaQuyen.Location = new System.Drawing.Point(375, 122);
            this.buttonChinhSuaQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChinhSuaQuyen.Name = "buttonChinhSuaQuyen";
            this.buttonChinhSuaQuyen.Size = new System.Drawing.Size(188, 76);
            this.buttonChinhSuaQuyen.TabIndex = 21;
            this.buttonChinhSuaQuyen.Text = "Chỉnh sửa quyền";
            this.buttonChinhSuaQuyen.UseVisualStyleBackColor = false;
            this.buttonChinhSuaQuyen.Click += new System.EventHandler(this.buttonChinhSuaQuyen_Click);
            // 
            // buttonGanRole
            // 
            this.buttonGanRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonGanRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonGanRole.Location = new System.Drawing.Point(150, 122);
            this.buttonGanRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGanRole.Name = "buttonGanRole";
            this.buttonGanRole.Size = new System.Drawing.Size(174, 76);
            this.buttonGanRole.TabIndex = 20;
            this.buttonGanRole.Text = "Gán role";
            this.buttonGanRole.UseVisualStyleBackColor = false;
            this.buttonGanRole.Click += new System.EventHandler(this.buttonGanRole_Click);
            // 
            // buttonCapQuyen
            // 
            this.buttonCapQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonCapQuyen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapQuyen.Location = new System.Drawing.Point(150, 24);
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
            this.buttonThuHoiQuyen.Location = new System.Drawing.Point(375, 24);
            this.buttonThuHoiQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThuHoiQuyen.Name = "buttonThuHoiQuyen";
            this.buttonThuHoiQuyen.Size = new System.Drawing.Size(188, 76);
            this.buttonThuHoiQuyen.TabIndex = 18;
            this.buttonThuHoiQuyen.Text = "Thu hồi quyền";
            this.buttonThuHoiQuyen.UseVisualStyleBackColor = false;
            this.buttonThuHoiQuyen.Click += new System.EventHandler(this.buttonThuHoiQuyen_Click);
            // 
            // dataGridViewQuanLyQuyenUser
            // 
            this.dataGridViewQuanLyQuyenUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyQuyenUser.Location = new System.Drawing.Point(0, 274);
            this.dataGridViewQuanLyQuyenUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewQuanLyQuyenUser.Name = "dataGridViewQuanLyQuyenUser";
            this.dataGridViewQuanLyQuyenUser.RowHeadersWidth = 51;
            this.dataGridViewQuanLyQuyenUser.RowTemplate.Height = 24;
            this.dataGridViewQuanLyQuyenUser.Size = new System.Drawing.Size(701, 284);
            this.dataGridViewQuanLyQuyenUser.TabIndex = 14;
            this.dataGridViewQuanLyQuyenUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyQuyenUser_CellContentClick);
            // 
            // QuanLyQuyenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 547);
            this.Controls.Add(this.panelQuanLyQuyenUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyQuyenUser";
            this.Text = "QuanLyQuyenUser";
            this.Load += new System.EventHandler(this.QuanLyQuyenUser_Load);
            this.panelQuanLyQuyenUser.ResumeLayout(false);
            this.panelThemXoaSua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyQuyenUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyQuyenUser;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyQuyenUser;
        private System.Windows.Forms.Panel panelThemXoaSua;
        private System.Windows.Forms.Button buttonGanRole;
        private System.Windows.Forms.Button buttonCapQuyen;
        private System.Windows.Forms.Button buttonThuHoiQuyen;
        private System.Windows.Forms.Button buttonChinhSuaQuyen;
    }
}