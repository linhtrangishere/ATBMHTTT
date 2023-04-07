namespace PHANHE1
{
    partial class ThongTinQuyenCuaUser
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
            this.panelThongTinQuyenCuaUser = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinQuyenCuaUser = new System.Windows.Forms.DataGridView();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxNhapTenUser = new System.Windows.Forms.TextBox();
            this.labelNhapTenUser = new System.Windows.Forms.Label();
            this.panelThongTinQuyenCuaUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinQuyenCuaUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTinQuyenCuaUser
            // 
            this.panelThongTinQuyenCuaUser.BackColor = System.Drawing.Color.White;
            this.panelThongTinQuyenCuaUser.Controls.Add(this.dataGridViewThongTinQuyenCuaUser);
            this.panelThongTinQuyenCuaUser.Controls.Add(this.buttonXemTatCa);
            this.panelThongTinQuyenCuaUser.Controls.Add(this.buttonTimKiem);
            this.panelThongTinQuyenCuaUser.Controls.Add(this.textBoxNhapTenUser);
            this.panelThongTinQuyenCuaUser.Controls.Add(this.labelNhapTenUser);
            this.panelThongTinQuyenCuaUser.Location = new System.Drawing.Point(0, -10);
            this.panelThongTinQuyenCuaUser.Name = "panelThongTinQuyenCuaUser";
            this.panelThongTinQuyenCuaUser.Size = new System.Drawing.Size(935, 690);
            this.panelThongTinQuyenCuaUser.TabIndex = 2;
            // 
            // dataGridViewThongTinQuyenCuaUser
            // 
            this.dataGridViewThongTinQuyenCuaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinQuyenCuaUser.Location = new System.Drawing.Point(0, 340);
            this.dataGridViewThongTinQuyenCuaUser.Name = "dataGridViewThongTinQuyenCuaUser";
            this.dataGridViewThongTinQuyenCuaUser.RowHeadersWidth = 51;
            this.dataGridViewThongTinQuyenCuaUser.RowTemplate.Height = 24;
            this.dataGridViewThongTinQuyenCuaUser.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewThongTinQuyenCuaUser.TabIndex = 14;
            this.dataGridViewThongTinQuyenCuaUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTinQuyenCuaUser_CellContentClick);
            // 
            // buttonXemTatCa
            // 
            this.buttonXemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.buttonXemTatCa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXemTatCa.Location = new System.Drawing.Point(240, 50);
            this.buttonXemTatCa.Name = "buttonXemTatCa";
            this.buttonXemTatCa.Size = new System.Drawing.Size(460, 70);
            this.buttonXemTatCa.TabIndex = 13;
            this.buttonXemTatCa.Text = "Xem tất cả";
            this.buttonXemTatCa.UseVisualStyleBackColor = false;
            this.buttonXemTatCa.Click += new System.EventHandler(this.buttonXemTatCa_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.buttonTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTimKiem.Location = new System.Drawing.Point(600, 220);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(200, 70);
            this.buttonTimKiem.TabIndex = 12;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxNhapTenUser
            // 
            this.textBoxNhapTenUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhapTenUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhapTenUser.Location = new System.Drawing.Point(75, 235);
            this.textBoxNhapTenUser.Multiline = true;
            this.textBoxNhapTenUser.Name = "textBoxNhapTenUser";
            this.textBoxNhapTenUser.Size = new System.Drawing.Size(331, 50);
            this.textBoxNhapTenUser.TabIndex = 11;
            this.textBoxNhapTenUser.TextChanged += new System.EventHandler(this.textBoxNhapTenUser_TextChanged);
            // 
            // labelNhapTenUser
            // 
            this.labelNhapTenUser.AutoSize = true;
            this.labelNhapTenUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhapTenUser.Location = new System.Drawing.Point(75, 190);
            this.labelNhapTenUser.Name = "labelNhapTenUser";
            this.labelNhapTenUser.Size = new System.Drawing.Size(205, 41);
            this.labelNhapTenUser.TabIndex = 10;
            this.labelNhapTenUser.Text = "Nhập tên user";
            // 
            // ThongTinQuyenCuaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelThongTinQuyenCuaUser);
            this.Name = "ThongTinQuyenCuaUser";
            this.Text = "ThongTinQuyenCuaUser";
            this.Load += new System.EventHandler(this.ThongTinQuyenCuaUser_Load);
            this.panelThongTinQuyenCuaUser.ResumeLayout(false);
            this.panelThongTinQuyenCuaUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinQuyenCuaUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTinQuyenCuaUser;
        private System.Windows.Forms.DataGridView dataGridViewThongTinQuyenCuaUser;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxNhapTenUser;
        private System.Windows.Forms.Label labelNhapTenUser;
    }
}