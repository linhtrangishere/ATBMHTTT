﻿namespace PHANHE1
{
    partial class ChinhSuaQuyenChoRole
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
            this.labelChinhSuaQuyenChoRole = new System.Windows.Forms.Label();
            this.labelTenRole = new System.Windows.Forms.Label();
            this.comboBoxCot = new System.Windows.Forms.ComboBox();
            this.comboBoxBang = new System.Windows.Forms.ComboBox();
            this.comboBoxQuyenMoi = new System.Windows.Forms.ComboBox();
            this.labelCot = new System.Windows.Forms.Label();
            this.labelBang = new System.Windows.Forms.Label();
            this.labelQuyenMoi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonXemTatCa = new System.Windows.Forms.Button();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.dataGridViewChinhSuaQuyenChoRole = new System.Windows.Forms.DataGridView();
            this.checkBoxWithGrantOption = new System.Windows.Forms.CheckBox();
            this.checkBoxCapTrenCot = new System.Windows.Forms.CheckBox();
            this.textBoxQuyenCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRoleName = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChinhSuaQuyenChoRole)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelChinhSuaQuyenChoRole);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -10);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(1425, 160);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // labelChinhSuaQuyenChoRole
            // 
            this.labelChinhSuaQuyenChoRole.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelChinhSuaQuyenChoRole.Location = new System.Drawing.Point(460, 50);
            this.labelChinhSuaQuyenChoRole.Name = "labelChinhSuaQuyenChoRole";
            this.labelChinhSuaQuyenChoRole.Size = new System.Drawing.Size(500, 50);
            this.labelChinhSuaQuyenChoRole.TabIndex = 0;
            this.labelChinhSuaQuyenChoRole.Text = "Chỉnh sửa quyền cho role";
            this.labelChinhSuaQuyenChoRole.Click += new System.EventHandler(this.labelChinhSuaQuyenChoRole_Click);
            // 
            // labelTenRole
            // 
            this.labelTenRole.AutoSize = true;
            this.labelTenRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenRole.Location = new System.Drawing.Point(75, 199);
            this.labelTenRole.Name = "labelTenRole";
            this.labelTenRole.Size = new System.Drawing.Size(130, 41);
            this.labelTenRole.TabIndex = 14;
            this.labelTenRole.Text = "Tên role";
            // 
            // comboBoxCot
            // 
            this.comboBoxCot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxCot.FormattingEnabled = true;
            this.comboBoxCot.Location = new System.Drawing.Point(600, 876);
            this.comboBoxCot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCot.Name = "comboBoxCot";
            this.comboBoxCot.Size = new System.Drawing.Size(400, 49);
            this.comboBoxCot.TabIndex = 33;
            // 
            // comboBoxBang
            // 
            this.comboBoxBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxBang.FormattingEnabled = true;
            this.comboBoxBang.Location = new System.Drawing.Point(600, 736);
            this.comboBoxBang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBang.Name = "comboBoxBang";
            this.comboBoxBang.Size = new System.Drawing.Size(400, 49);
            this.comboBoxBang.TabIndex = 32;
            this.comboBoxBang.SelectedIndexChanged += new System.EventHandler(this.comboBoxBang_SelectedIndexChanged);
            // 
            // comboBoxQuyenMoi
            // 
            this.comboBoxQuyenMoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxQuyenMoi.FormattingEnabled = true;
            this.comboBoxQuyenMoi.Location = new System.Drawing.Point(82, 876);
            this.comboBoxQuyenMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxQuyenMoi.Name = "comboBoxQuyenMoi";
            this.comboBoxQuyenMoi.Size = new System.Drawing.Size(400, 49);
            this.comboBoxQuyenMoi.TabIndex = 31;
            // 
            // labelCot
            // 
            this.labelCot.AutoSize = true;
            this.labelCot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelCot.Location = new System.Drawing.Point(600, 823);
            this.labelCot.Name = "labelCot";
            this.labelCot.Size = new System.Drawing.Size(67, 41);
            this.labelCot.TabIndex = 30;
            this.labelCot.Text = "Cột";
            // 
            // labelBang
            // 
            this.labelBang.AutoSize = true;
            this.labelBang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelBang.Location = new System.Drawing.Point(600, 683);
            this.labelBang.Name = "labelBang";
            this.labelBang.Size = new System.Drawing.Size(90, 41);
            this.labelBang.TabIndex = 29;
            this.labelBang.Text = "Bảng";
            // 
            // labelQuyenMoi
            // 
            this.labelQuyenMoi.AutoSize = true;
            this.labelQuyenMoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQuyenMoi.Location = new System.Drawing.Point(82, 823);
            this.labelQuyenMoi.Name = "labelQuyenMoi";
            this.labelQuyenMoi.Size = new System.Drawing.Size(172, 41);
            this.labelQuyenMoi.TabIndex = 28;
            this.labelQuyenMoi.Text = "Quyền mới";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonChon);
            this.panel1.Controls.Add(this.buttonXemTatCa);
            this.panel1.Controls.Add(this.buttonXem);
            this.panel1.Controls.Add(this.buttonCapNhat);
            this.panel1.Location = new System.Drawing.Point(1100, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 830);
            this.panel1.TabIndex = 37;
            // 
            // buttonChon
            // 
            this.buttonChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonChon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChon.Location = new System.Drawing.Point(40, 359);
            this.buttonChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(200, 70);
            this.buttonChon.TabIndex = 39;
            this.buttonChon.Text = "Chọn";
            this.buttonChon.UseVisualStyleBackColor = false;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click);
            // 
            // buttonXemTatCa
            // 
            this.buttonXemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonXemTatCa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXemTatCa.Location = new System.Drawing.Point(40, 190);
            this.buttonXemTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXemTatCa.Name = "buttonXemTatCa";
            this.buttonXemTatCa.Size = new System.Drawing.Size(200, 70);
            this.buttonXemTatCa.TabIndex = 38;
            this.buttonXemTatCa.Text = "Xem tất cả";
            this.buttonXemTatCa.UseVisualStyleBackColor = false;
            this.buttonXemTatCa.Click += new System.EventHandler(this.buttonXemTatCa_Click);
            // 
            // buttonXem
            // 
            this.buttonXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonXem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXem.Location = new System.Drawing.Point(40, 34);
            this.buttonXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(200, 70);
            this.buttonXem.TabIndex = 37;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = false;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhat.Location = new System.Drawing.Point(40, 601);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(200, 70);
            this.buttonCapNhat.TabIndex = 36;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // dataGridViewChinhSuaQuyenChoRole
            // 
            this.dataGridViewChinhSuaQuyenChoRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChinhSuaQuyenChoRole.Location = new System.Drawing.Point(0, 290);
            this.dataGridViewChinhSuaQuyenChoRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewChinhSuaQuyenChoRole.Name = "dataGridViewChinhSuaQuyenChoRole";
            this.dataGridViewChinhSuaQuyenChoRole.RowHeadersWidth = 51;
            this.dataGridViewChinhSuaQuyenChoRole.RowTemplate.Height = 24;
            this.dataGridViewChinhSuaQuyenChoRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewChinhSuaQuyenChoRole.Size = new System.Drawing.Size(1069, 350);
            this.dataGridViewChinhSuaQuyenChoRole.TabIndex = 36;
            //this.dataGridViewChinhSuaQuyenChoRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChinhSuaQuyenChoRole_CellContentClick_1);
            this.dataGridViewChinhSuaQuyenChoRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChinhSuaQuyenChoRole_CellClick);
            // 
            // checkBoxWithGrantOption
            // 
            this.checkBoxWithGrantOption.AutoSize = true;
            this.checkBoxWithGrantOption.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBoxWithGrantOption.Location = new System.Drawing.Point(716, 972);
            this.checkBoxWithGrantOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxWithGrantOption.Name = "checkBoxWithGrantOption";
            this.checkBoxWithGrantOption.Size = new System.Drawing.Size(284, 45);
            this.checkBoxWithGrantOption.TabIndex = 38;
            this.checkBoxWithGrantOption.Text = "With Grant Option";
            this.checkBoxWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // checkBoxCapTrenCot
            // 
            this.checkBoxCapTrenCot.AutoSize = true;
            this.checkBoxCapTrenCot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBoxCapTrenCot.Location = new System.Drawing.Point(90, 989);
            this.checkBoxCapTrenCot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCapTrenCot.Name = "checkBoxCapTrenCot";
            this.checkBoxCapTrenCot.Size = new System.Drawing.Size(293, 45);
            this.checkBoxCapTrenCot.TabIndex = 39;
            this.checkBoxCapTrenCot.Text = "Không cấp trên cột";
            this.checkBoxCapTrenCot.UseVisualStyleBackColor = true;
            this.checkBoxCapTrenCot.CheckedChanged += new System.EventHandler(this.checkBoxCapTrenCot_CheckedChanged);
            // 
            // textBoxQuyenCu
            // 
            this.textBoxQuyenCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuyenCu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxQuyenCu.Location = new System.Drawing.Point(82, 737);
            this.textBoxQuyenCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuyenCu.Multiline = true;
            this.textBoxQuyenCu.Name = "textBoxQuyenCu";
            this.textBoxQuyenCu.Size = new System.Drawing.Size(399, 50);
            this.textBoxQuyenCu.TabIndex = 40;
            this.textBoxQuyenCu.TextChanged += new System.EventHandler(this.textBoxQuyenCu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(83, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 41);
            this.label1.TabIndex = 41;
            this.label1.Text = "Quyền cũ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxRoleName
            // 
            this.comboBoxRoleName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxRoleName.FormattingEnabled = true;
            this.comboBoxRoleName.Location = new System.Drawing.Point(276, 199);
            this.comboBoxRoleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRoleName.Name = "comboBoxRoleName";
            this.comboBoxRoleName.Size = new System.Drawing.Size(400, 49);
            this.comboBoxRoleName.TabIndex = 42;
            // 
            // ChinhSuaQuyenChoRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1421, 1055);
            this.Controls.Add(this.comboBoxRoleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuyenCu);
            this.Controls.Add(this.checkBoxCapTrenCot);
            this.Controls.Add(this.checkBoxWithGrantOption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewChinhSuaQuyenChoRole);
            this.Controls.Add(this.comboBoxCot);
            this.Controls.Add(this.comboBoxBang);
            this.Controls.Add(this.comboBoxQuyenMoi);
            this.Controls.Add(this.labelCot);
            this.Controls.Add(this.labelBang);
            this.Controls.Add(this.labelQuyenMoi);
            this.Controls.Add(this.labelTenRole);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChinhSuaQuyenChoRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChinhSuaQuyenChoRole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChinhSuaQuyenChoRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelChinhSuaQuyenChoRole;
        private System.Windows.Forms.Label labelTenRole;
        private System.Windows.Forms.ComboBox comboBoxCot;
        private System.Windows.Forms.ComboBox comboBoxBang;
        private System.Windows.Forms.ComboBox comboBoxQuyenMoi;
        private System.Windows.Forms.Label labelCot;
        private System.Windows.Forms.Label labelBang;
        private System.Windows.Forms.Label labelQuyenMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Button buttonXemTatCa;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.DataGridView dataGridViewChinhSuaQuyenChoRole;
        private System.Windows.Forms.CheckBox checkBoxWithGrantOption;
        private System.Windows.Forms.CheckBox checkBoxCapTrenCot;
        private System.Windows.Forms.TextBox textBoxQuyenCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRoleName;
    }
}

