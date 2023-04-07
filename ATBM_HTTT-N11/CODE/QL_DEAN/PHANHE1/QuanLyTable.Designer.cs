namespace PHANHE1
{
    partial class QuanLyTable
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
            this.panelQuanLyTable = new System.Windows.Forms.Panel();
            this.panelThemTable = new System.Windows.Forms.Panel();
            this.buttonTaoTable = new System.Windows.Forms.Button();
            this.dataGridViewQuanLyTable = new System.Windows.Forms.DataGridView();
            this.panelQuanLyTable.SuspendLayout();
            this.panelThemTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuanLyTable
            // 
            this.panelQuanLyTable.BackColor = System.Drawing.Color.White;
            this.panelQuanLyTable.Controls.Add(this.panelThemTable);
            this.panelQuanLyTable.Controls.Add(this.dataGridViewQuanLyTable);
            this.panelQuanLyTable.Location = new System.Drawing.Point(0, -10);
            this.panelQuanLyTable.Name = "panelQuanLyTable";
            this.panelQuanLyTable.Size = new System.Drawing.Size(935, 690);
            this.panelQuanLyTable.TabIndex = 2;
            this.panelQuanLyTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuanLyUser_Paint);
            // 
            // panelThemTable
            // 
            this.panelThemTable.Controls.Add(this.buttonTaoTable);
            this.panelThemTable.Location = new System.Drawing.Point(0, 100);
            this.panelThemTable.Name = "panelThemTable";
            this.panelThemTable.Size = new System.Drawing.Size(935, 150);
            this.panelThemTable.TabIndex = 18;
            // 
            // buttonTaoTable
            // 
            this.buttonTaoTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonTaoTable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaoTable.Location = new System.Drawing.Point(350, 28);
            this.buttonTaoTable.Name = "buttonTaoTable";
            this.buttonTaoTable.Size = new System.Drawing.Size(232, 94);
            this.buttonTaoTable.TabIndex = 19;
            this.buttonTaoTable.Text = "Tạo table";
            this.buttonTaoTable.UseVisualStyleBackColor = false;
            this.buttonTaoTable.Click += new System.EventHandler(this.buttonTaoUser_Click);
            // 
            // dataGridViewQuanLyTable
            // 
            this.dataGridViewQuanLyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyTable.Location = new System.Drawing.Point(0, 337);
            this.dataGridViewQuanLyTable.Name = "dataGridViewQuanLyTable";
            this.dataGridViewQuanLyTable.RowHeadersWidth = 51;
            this.dataGridViewQuanLyTable.RowTemplate.Height = 24;
            this.dataGridViewQuanLyTable.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewQuanLyTable.TabIndex = 14;
            // 
            // QuanLyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelQuanLyTable);
            this.Name = "QuanLyTable";
            this.Text = "QuanLyTable";
            this.panelQuanLyTable.ResumeLayout(false);
            this.panelThemTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyTable;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyTable;
        private System.Windows.Forms.Panel panelThemTable;
        private System.Windows.Forms.Button buttonTaoTable;
    }
}