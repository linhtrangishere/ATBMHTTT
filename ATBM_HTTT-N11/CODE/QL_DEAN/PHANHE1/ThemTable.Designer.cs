namespace PHANHE1
{
    partial class ThemTable
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelThemBang = new System.Windows.Forms.Label();
            this.labelTenBang = new System.Windows.Forms.Label();
            this.textBoxTenBang = new System.Windows.Forms.TextBox();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.labelKieuDuLieu = new System.Windows.Forms.Label();
            this.labelTenCot = new System.Windows.Forms.Label();
            this.panelThemTable = new System.Windows.Forms.Panel();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonTaoBang = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewThemTable = new System.Windows.Forms.DataGridView();
            this.tenCot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.textBoxTenCot = new System.Windows.Forms.TextBox();
            this.textBoxDataType = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.panelThemTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelThemBang);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1425, 160);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // labelThemBang
            // 
            this.labelThemBang.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThemBang.Location = new System.Drawing.Point(610, 50);
            this.labelThemBang.Name = "labelThemBang";
            this.labelThemBang.Size = new System.Drawing.Size(300, 50);
            this.labelThemBang.TabIndex = 0;
            this.labelThemBang.Text = "Thêm bảng";
            this.labelThemBang.Click += new System.EventHandler(this.labelThemBang_Click);
            // 
            // labelTenBang
            // 
            this.labelTenBang.AutoSize = true;
            this.labelTenBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenBang.Location = new System.Drawing.Point(210, 195);
            this.labelTenBang.Name = "labelTenBang";
            this.labelTenBang.Size = new System.Drawing.Size(147, 41);
            this.labelTenBang.TabIndex = 14;
            this.labelTenBang.Text = "Tên bảng";
            // 
            // textBoxTenBang
            // 
            this.textBoxTenBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenBang.Location = new System.Drawing.Point(217, 252);
            this.textBoxTenBang.Multiline = true;
            this.textBoxTenBang.Name = "textBoxTenBang";
            this.textBoxTenBang.Size = new System.Drawing.Size(400, 50);
            this.textBoxTenBang.TabIndex = 15;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelKhoa.Location = new System.Drawing.Point(833, 367);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(89, 41);
            this.labelKhoa.TabIndex = 30;
            this.labelKhoa.Text = "Khóa";
            // 
            // labelKieuDuLieu
            // 
            this.labelKieuDuLieu.AutoSize = true;
            this.labelKieuDuLieu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelKieuDuLieu.Location = new System.Drawing.Point(219, 364);
            this.labelKieuDuLieu.Name = "labelKieuDuLieu";
            this.labelKieuDuLieu.Size = new System.Drawing.Size(187, 41);
            this.labelKieuDuLieu.TabIndex = 29;
            this.labelKieuDuLieu.Text = "Kiểu dữ liệu";
            // 
            // labelTenCot
            // 
            this.labelTenCot.AutoSize = true;
            this.labelTenCot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenCot.Location = new System.Drawing.Point(833, 198);
            this.labelTenCot.Name = "labelTenCot";
            this.labelTenCot.Size = new System.Drawing.Size(119, 41);
            this.labelTenCot.TabIndex = 28;
            this.labelTenCot.Text = "Tên cột";
            // 
            // panelThemTable
            // 
            this.panelThemTable.Controls.Add(this.buttonHuy);
            this.panelThemTable.Controls.Add(this.buttonTaoBang);
            this.panelThemTable.Controls.Add(this.buttonThem);
            this.panelThemTable.Location = new System.Drawing.Point(0, 500);
            this.panelThemTable.Name = "panelThemTable";
            this.panelThemTable.Size = new System.Drawing.Size(1425, 110);
            this.panelThemTable.TabIndex = 37;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonHuy.Location = new System.Drawing.Point(1100, 18);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(200, 70);
            this.buttonHuy.TabIndex = 39;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonTaoBang
            // 
            this.buttonTaoBang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonTaoBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaoBang.Location = new System.Drawing.Point(600, 17);
            this.buttonTaoBang.Name = "buttonTaoBang";
            this.buttonTaoBang.Size = new System.Drawing.Size(200, 70);
            this.buttonTaoBang.TabIndex = 38;
            this.buttonTaoBang.Text = "Tạo bảng";
            this.buttonTaoBang.UseVisualStyleBackColor = false;
            this.buttonTaoBang.Click += new System.EventHandler(this.buttonTaoBang_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.Location = new System.Drawing.Point(100, 18);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(200, 70);
            this.buttonThem.TabIndex = 37;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewThemTable
            // 
            this.dataGridViewThemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThemTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewThemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenCot,
            this.dataType,
            this.primaryKey});
            this.dataGridViewThemTable.Location = new System.Drawing.Point(0, 630);
            this.dataGridViewThemTable.Name = "dataGridViewThemTable";
            this.dataGridViewThemTable.RowHeadersWidth = 51;
            this.dataGridViewThemTable.RowTemplate.Height = 24;
            this.dataGridViewThemTable.Size = new System.Drawing.Size(1425, 350);
            this.dataGridViewThemTable.TabIndex = 36;
            // 
            // tenCot
            // 
            this.tenCot.HeaderText = "Tên Cột";
            this.tenCot.MinimumWidth = 6;
            this.tenCot.Name = "tenCot";
            // 
            // dataType
            // 
            this.dataType.HeaderText = "Kiểu dữ liệu";
            this.dataType.MinimumWidth = 6;
            this.dataType.Name = "dataType";
            // 
            // primaryKey
            // 
            this.primaryKey.HeaderText = "Khóa";
            this.primaryKey.MinimumWidth = 6;
            this.primaryKey.Name = "primaryKey";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox.Location = new System.Drawing.Point(928, 380);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 38;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBoxTenCot
            // 
            this.textBoxTenCot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenCot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenCot.Location = new System.Drawing.Point(840, 252);
            this.textBoxTenCot.Multiline = true;
            this.textBoxTenCot.Name = "textBoxTenCot";
            this.textBoxTenCot.Size = new System.Drawing.Size(400, 50);
            this.textBoxTenCot.TabIndex = 41;
            // 
            // textBoxDataType
            // 
            this.textBoxDataType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDataType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDataType.Location = new System.Drawing.Point(217, 425);
            this.textBoxDataType.Multiline = true;
            this.textBoxDataType.Name = "textBoxDataType";
            this.textBoxDataType.Size = new System.Drawing.Size(400, 50);
            this.textBoxDataType.TabIndex = 42;
            // 
            // ThemTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.textBoxDataType);
            this.Controls.Add(this.textBoxTenCot);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.panelThemTable);
            this.Controls.Add(this.dataGridViewThemTable);
            this.Controls.Add(this.labelKhoa);
            this.Controls.Add(this.labelKieuDuLieu);
            this.Controls.Add(this.labelTenCot);
            this.Controls.Add(this.textBoxTenBang);
            this.Controls.Add(this.labelTenBang);
            this.Controls.Add(this.groupBox);
            this.Name = "ThemTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.panelThemTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelThemBang;
        private System.Windows.Forms.Label labelTenBang;
        private System.Windows.Forms.TextBox textBoxTenBang;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.Label labelKieuDuLieu;
        private System.Windows.Forms.Label labelTenCot;
        private System.Windows.Forms.Panel panelThemTable;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonTaoBang;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewThemTable;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox textBoxTenCot;
        private System.Windows.Forms.TextBox textBoxDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryKey;
    }
}

