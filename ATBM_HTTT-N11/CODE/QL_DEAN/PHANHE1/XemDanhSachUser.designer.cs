namespace PHANHE1
{
    partial class XemDanhSachUser
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
            this.panelXemDanhSachUser = new System.Windows.Forms.Panel();
            this.dataGridViewXemDanhSachUser = new System.Windows.Forms.DataGridView();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.panelXemDanhSachUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDanhSachUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelXemDanhSachUser
            // 
            this.panelXemDanhSachUser.BackColor = System.Drawing.Color.White;
            this.panelXemDanhSachUser.Controls.Add(this.buttonXemTatCa);
            this.panelXemDanhSachUser.Controls.Add(this.dataGridViewXemDanhSachUser);
            this.panelXemDanhSachUser.Controls.Add(this.buttonTimKiem);
            this.panelXemDanhSachUser.Controls.Add(this.textBoxUsername);
            this.panelXemDanhSachUser.Controls.Add(this.labelUsername);
            this.panelXemDanhSachUser.Location = new System.Drawing.Point(0, -10);
            this.panelXemDanhSachUser.Name = "panelXemDanhSachUser";
            this.panelXemDanhSachUser.Size = new System.Drawing.Size(935, 690);
            this.panelXemDanhSachUser.TabIndex = 2;
            // 
            // dataGridViewXemDanhSachUser
            // 
            this.dataGridViewXemDanhSachUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemDanhSachUser.Location = new System.Drawing.Point(0, 332);
            this.dataGridViewXemDanhSachUser.Name = "dataGridViewXemDanhSachUser";
            this.dataGridViewXemDanhSachUser.RowHeadersWidth = 51;
            this.dataGridViewXemDanhSachUser.RowTemplate.Height = 24;
            this.dataGridViewXemDanhSachUser.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewXemDanhSachUser.TabIndex = 13;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.buttonTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTimKiem.Location = new System.Drawing.Point(600, 83);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(200, 70);
            this.buttonTimKiem.TabIndex = 12;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxUsername.Location = new System.Drawing.Point(110, 96);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(331, 50);
            this.textBoxUsername.TabIndex = 9;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUsername.Location = new System.Drawing.Point(110, 50);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(152, 41);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // buttonXemTatCa
            // 
            this.buttonXemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.buttonXemTatCa.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonXemTatCa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXemTatCa.Location = new System.Drawing.Point(380, 230);
            this.buttonXemTatCa.Name = "buttonXemTatCa";
            this.buttonXemTatCa.Size = new System.Drawing.Size(200, 70);
            this.buttonXemTatCa.TabIndex = 14;
            this.buttonXemTatCa.Text = "Xem tất cả";
            this.buttonXemTatCa.UseVisualStyleBackColor = false;
            // 
            // XemDanhSachUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelXemDanhSachUser);
            this.Name = "XemDanhSachUser";
            this.Text = "XemDanhSachUser";
            this.panelXemDanhSachUser.ResumeLayout(false);
            this.panelXemDanhSachUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDanhSachUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelXemDanhSachUser;
        private System.Windows.Forms.DataGridView dataGridViewXemDanhSachUser;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonXemTatCa;
    }
}