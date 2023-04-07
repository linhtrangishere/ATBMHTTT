namespace PHANHE1
{
    partial class XemDanhSachView
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
            this.panelXemDanhSachView = new System.Windows.Forms.Panel();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.dataGridViewXemDanhSachView = new System.Windows.Forms.DataGridView();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTenView = new System.Windows.Forms.TextBox();
            this.labelTenView = new System.Windows.Forms.Label();
            this.panelXemDanhSachView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDanhSachView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelXemDanhSachView
            // 
            this.panelXemDanhSachView.BackColor = System.Drawing.Color.White;
            this.panelXemDanhSachView.Controls.Add(this.buttonXemTatCa);
            this.panelXemDanhSachView.Controls.Add(this.dataGridViewXemDanhSachView);
            this.panelXemDanhSachView.Controls.Add(this.buttonTimKiem);
            this.panelXemDanhSachView.Controls.Add(this.textBoxTenView);
            this.panelXemDanhSachView.Controls.Add(this.labelTenView);
            this.panelXemDanhSachView.Location = new System.Drawing.Point(0, -10);
            this.panelXemDanhSachView.Name = "panelXemDanhSachView";
            this.panelXemDanhSachView.Size = new System.Drawing.Size(935, 690);
            this.panelXemDanhSachView.TabIndex = 2;
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
            this.buttonXemTatCa.Click += new System.EventHandler(this.buttonXemTatCa_Click);
            // 
            // dataGridViewXemDanhSachView
            // 
            this.dataGridViewXemDanhSachView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemDanhSachView.Location = new System.Drawing.Point(0, 332);
            this.dataGridViewXemDanhSachView.Name = "dataGridViewXemDanhSachView";
            this.dataGridViewXemDanhSachView.RowHeadersWidth = 51;
            this.dataGridViewXemDanhSachView.RowTemplate.Height = 24;
            this.dataGridViewXemDanhSachView.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewXemDanhSachView.TabIndex = 13;
            this.dataGridViewXemDanhSachView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXemDanhSachView_CellContentClick);
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
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTenView
            // 
            this.textBoxTenView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenView.Location = new System.Drawing.Point(110, 96);
            this.textBoxTenView.Multiline = true;
            this.textBoxTenView.Name = "textBoxTenView";
            this.textBoxTenView.Size = new System.Drawing.Size(331, 50);
            this.textBoxTenView.TabIndex = 9;
            this.textBoxTenView.TextChanged += new System.EventHandler(this.textBoxTenView_TextChanged);
            // 
            // labelTenView
            // 
            this.labelTenView.AutoSize = true;
            this.labelTenView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenView.Location = new System.Drawing.Point(110, 50);
            this.labelTenView.Name = "labelTenView";
            this.labelTenView.Size = new System.Drawing.Size(131, 41);
            this.labelTenView.TabIndex = 8;
            this.labelTenView.Text = "Tên view";
            // 
            // XemDanhSachView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelXemDanhSachView);
            this.Name = "XemDanhSachView";
            this.Text = "XemDanhSachView";
            this.panelXemDanhSachView.ResumeLayout(false);
            this.panelXemDanhSachView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDanhSachView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelXemDanhSachView;
        private System.Windows.Forms.DataGridView dataGridViewXemDanhSachView;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTenView;
        private System.Windows.Forms.Label labelTenView;
        private System.Windows.Forms.Button buttonXemTatCa;
    }
}