namespace PHANHE1
{
    partial class XemDanhSachTable
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
            this.panelXemDanhSachTable = new System.Windows.Forms.Panel();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.dataGridViewXemDanhSachTable = new System.Windows.Forms.DataGridView();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTenTable = new System.Windows.Forms.TextBox();
            this.labelTenTable = new System.Windows.Forms.Label();
            this.panelXemDanhSachTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDanhSachTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelXemDanhSachTable
            // 
            this.panelXemDanhSachTable.BackColor = System.Drawing.Color.White;
            this.panelXemDanhSachTable.Controls.Add(this.buttonXemTatCa);
            this.panelXemDanhSachTable.Controls.Add(this.dataGridViewXemDanhSachTable);
            this.panelXemDanhSachTable.Controls.Add(this.buttonTimKiem);
            this.panelXemDanhSachTable.Controls.Add(this.textBoxTenTable);
            this.panelXemDanhSachTable.Controls.Add(this.labelTenTable);
            this.panelXemDanhSachTable.Location = new System.Drawing.Point(0, -10);
            this.panelXemDanhSachTable.Name = "panelXemDanhSachTable";
            this.panelXemDanhSachTable.Size = new System.Drawing.Size(935, 690);
            this.panelXemDanhSachTable.TabIndex = 2;
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
            // dataGridViewXemDanhSachTable
            // 
            this.dataGridViewXemDanhSachTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemDanhSachTable.Location = new System.Drawing.Point(0, 332);
            this.dataGridViewXemDanhSachTable.Name = "dataGridViewXemDanhSachTable";
            this.dataGridViewXemDanhSachTable.RowHeadersWidth = 51;
            this.dataGridViewXemDanhSachTable.RowTemplate.Height = 24;
            this.dataGridViewXemDanhSachTable.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewXemDanhSachTable.TabIndex = 13;
            this.dataGridViewXemDanhSachTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXemDanhSachTable_CellContentClick);
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
            // textBoxTenTable
            // 
            this.textBoxTenTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenTable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenTable.Location = new System.Drawing.Point(110, 96);
            this.textBoxTenTable.Multiline = true;
            this.textBoxTenTable.Name = "textBoxTenTable";
            this.textBoxTenTable.Size = new System.Drawing.Size(331, 50);
            this.textBoxTenTable.TabIndex = 9;
            this.textBoxTenTable.TextChanged += new System.EventHandler(this.textBoxTenTable_TextChanged);
            // 
            // labelTenTable
            // 
            this.labelTenTable.AutoSize = true;
            this.labelTenTable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenTable.Location = new System.Drawing.Point(110, 50);
            this.labelTenTable.Name = "labelTenTable";
            this.labelTenTable.Size = new System.Drawing.Size(138, 41);
            this.labelTenTable.TabIndex = 8;
            this.labelTenTable.Text = "Tên table";
            // 
            // XemDanhSachTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelXemDanhSachTable);
            this.Name = "XemDanhSachTable";
            this.Text = "XemDanhSachTable";
            this.Load += new System.EventHandler(this.XemDanhSachTable_Load);
            this.panelXemDanhSachTable.ResumeLayout(false);
            this.panelXemDanhSachTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDanhSachTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelXemDanhSachTable;
        private System.Windows.Forms.DataGridView dataGridViewXemDanhSachTable;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTenTable;
        private System.Windows.Forms.Label labelTenTable;
        private System.Windows.Forms.Button buttonXemTatCa;
    }
}