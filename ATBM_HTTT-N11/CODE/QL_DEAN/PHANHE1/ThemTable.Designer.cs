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
            this.panelThemBang = new System.Windows.Forms.Panel();
            this.textBoxDataType = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.textBoxTenCot = new System.Windows.Forms.TextBox();
            this.dataGridViewThemTable = new System.Windows.Forms.DataGridView();
            this.tenCot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTenCot = new System.Windows.Forms.Label();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.labelKieuDuLieu = new System.Windows.Forms.Label();
            this.textBoxTenBang = new System.Windows.Forms.TextBox();
            this.labelTenBang = new System.Windows.Forms.Label();
            this.panelThemTable = new System.Windows.Forms.Panel();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonTaoBang = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelThemBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemTable)).BeginInit();
            this.panelThemTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThemBang
            // 
            this.panelThemBang.Controls.Add(this.textBoxDataType);
            this.panelThemBang.Controls.Add(this.checkBox);
            this.panelThemBang.Controls.Add(this.textBoxTenCot);
            this.panelThemBang.Controls.Add(this.dataGridViewThemTable);
            this.panelThemBang.Controls.Add(this.labelTenCot);
            this.panelThemBang.Controls.Add(this.labelKhoa);
            this.panelThemBang.Controls.Add(this.labelKieuDuLieu);
            this.panelThemBang.Controls.Add(this.textBoxTenBang);
            this.panelThemBang.Controls.Add(this.labelTenBang);
            this.panelThemBang.Controls.Add(this.panelThemTable);
            this.panelThemBang.Location = new System.Drawing.Point(0, -10);
            this.panelThemBang.Name = "panelThemBang";
            this.panelThemBang.Size = new System.Drawing.Size(935, 630);
            this.panelThemBang.TabIndex = 0;
            // 
            // textBoxDataType
            // 
            this.textBoxDataType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDataType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDataType.Location = new System.Drawing.Point(67, 209);
            this.textBoxDataType.Multiline = true;
            this.textBoxDataType.Name = "textBoxDataType";
            this.textBoxDataType.Size = new System.Drawing.Size(300, 50);
            this.textBoxDataType.TabIndex = 53;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox.Location = new System.Drawing.Point(648, 172);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 51;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // textBoxTenCot
            // 
            this.textBoxTenCot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenCot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenCot.Location = new System.Drawing.Point(560, 89);
            this.textBoxTenCot.Multiline = true;
            this.textBoxTenCot.Name = "textBoxTenCot";
            this.textBoxTenCot.Size = new System.Drawing.Size(300, 50);
            this.textBoxTenCot.TabIndex = 52;
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
            this.dataGridViewThemTable.Location = new System.Drawing.Point(0, 380);
            this.dataGridViewThemTable.Name = "dataGridViewThemTable";
            this.dataGridViewThemTable.RowHeadersWidth = 51;
            this.dataGridViewThemTable.RowTemplate.Height = 24;
            this.dataGridViewThemTable.Size = new System.Drawing.Size(935, 250);
            this.dataGridViewThemTable.TabIndex = 49;
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
            // labelTenCot
            // 
            this.labelTenCot.AutoSize = true;
            this.labelTenCot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenCot.Location = new System.Drawing.Point(553, 39);
            this.labelTenCot.Name = "labelTenCot";
            this.labelTenCot.Size = new System.Drawing.Size(119, 41);
            this.labelTenCot.TabIndex = 46;
            this.labelTenCot.Text = "Tên cột";
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelKhoa.Location = new System.Drawing.Point(553, 159);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(89, 41);
            this.labelKhoa.TabIndex = 48;
            this.labelKhoa.Text = "Khóa";
            // 
            // labelKieuDuLieu
            // 
            this.labelKieuDuLieu.AutoSize = true;
            this.labelKieuDuLieu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelKieuDuLieu.Location = new System.Drawing.Point(69, 159);
            this.labelKieuDuLieu.Name = "labelKieuDuLieu";
            this.labelKieuDuLieu.Size = new System.Drawing.Size(187, 41);
            this.labelKieuDuLieu.TabIndex = 47;
            this.labelKieuDuLieu.Text = "Kiểu dữ liệu";
            // 
            // textBoxTenBang
            // 
            this.textBoxTenBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenBang.Location = new System.Drawing.Point(67, 89);
            this.textBoxTenBang.Multiline = true;
            this.textBoxTenBang.Name = "textBoxTenBang";
            this.textBoxTenBang.Size = new System.Drawing.Size(300, 50);
            this.textBoxTenBang.TabIndex = 45;
            // 
            // labelTenBang
            // 
            this.labelTenBang.AutoSize = true;
            this.labelTenBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenBang.Location = new System.Drawing.Point(60, 39);
            this.labelTenBang.Name = "labelTenBang";
            this.labelTenBang.Size = new System.Drawing.Size(147, 41);
            this.labelTenBang.TabIndex = 44;
            this.labelTenBang.Text = "Tên bảng";
            // 
            // panelThemTable
            // 
            this.panelThemTable.Controls.Add(this.buttonQuayLai);
            this.panelThemTable.Controls.Add(this.buttonTaoBang);
            this.panelThemTable.Controls.Add(this.buttonThem);
            this.panelThemTable.Location = new System.Drawing.Point(0, 280);
            this.panelThemTable.Name = "panelThemTable";
            this.panelThemTable.Size = new System.Drawing.Size(935, 80);
            this.panelThemTable.TabIndex = 50;
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQuayLai.Location = new System.Drawing.Point(650, 5);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 39;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonTaoBang
            // 
            this.buttonTaoBang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonTaoBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaoBang.Location = new System.Drawing.Point(370, 5);
            this.buttonTaoBang.Name = "buttonTaoBang";
            this.buttonTaoBang.Size = new System.Drawing.Size(200, 70);
            this.buttonTaoBang.TabIndex = 38;
            this.buttonTaoBang.Text = "Tạo bảng";
            this.buttonTaoBang.UseVisualStyleBackColor = false;
            this.buttonTaoBang.Click += new System.EventHandler(this.buttonTaoBang_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.Location = new System.Drawing.Point(90, 5);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(200, 70);
            this.buttonThem.TabIndex = 37;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // ThemTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 613);
            this.Controls.Add(this.panelThemBang);
            this.Name = "ThemTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelThemBang.ResumeLayout(false);
            this.panelThemBang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemTable)).EndInit();
            this.panelThemTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemBang;
        private System.Windows.Forms.TextBox textBoxDataType;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox textBoxTenCot;
        private System.Windows.Forms.DataGridView dataGridViewThemTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryKey;
        private System.Windows.Forms.Label labelTenCot;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.Label labelKieuDuLieu;
        private System.Windows.Forms.TextBox textBoxTenBang;
        private System.Windows.Forms.Label labelTenBang;
        private System.Windows.Forms.Panel panelThemTable;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonTaoBang;
        private System.Windows.Forms.Button buttonThem;
    }
}

