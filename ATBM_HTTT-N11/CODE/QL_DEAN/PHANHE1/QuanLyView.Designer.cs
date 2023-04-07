namespace PHANHE1
{
    partial class QuanLyView
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
            this.panelQuanLyView = new System.Windows.Forms.Panel();
            this.panelThemView = new System.Windows.Forms.Panel();
            this.buttonTaoView = new System.Windows.Forms.Button();
            this.dataGridViewQuanLyView = new System.Windows.Forms.DataGridView();
            this.panelQuanLyView.SuspendLayout();
            this.panelThemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuanLyView
            // 
            this.panelQuanLyView.BackColor = System.Drawing.Color.White;
            this.panelQuanLyView.Controls.Add(this.panelThemView);
            this.panelQuanLyView.Controls.Add(this.dataGridViewQuanLyView);
            this.panelQuanLyView.Location = new System.Drawing.Point(0, -10);
            this.panelQuanLyView.Name = "panelQuanLyView";
            this.panelQuanLyView.Size = new System.Drawing.Size(935, 690);
            this.panelQuanLyView.TabIndex = 2;
            this.panelQuanLyView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuanLyUser_Paint);
            // 
            // panelThemView
            // 
            this.panelThemView.Controls.Add(this.buttonTaoView);
            this.panelThemView.Location = new System.Drawing.Point(0, 100);
            this.panelThemView.Name = "panelThemView";
            this.panelThemView.Size = new System.Drawing.Size(935, 150);
            this.panelThemView.TabIndex = 18;
            // 
            // buttonTaoView
            // 
            this.buttonTaoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonTaoView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaoView.Location = new System.Drawing.Point(350, 28);
            this.buttonTaoView.Name = "buttonTaoView";
            this.buttonTaoView.Size = new System.Drawing.Size(232, 94);
            this.buttonTaoView.TabIndex = 19;
            this.buttonTaoView.Text = "Tạo view";
            this.buttonTaoView.UseVisualStyleBackColor = false;
            this.buttonTaoView.Click += new System.EventHandler(this.buttonTaoUser_Click);
            // 
            // dataGridViewQuanLyView
            // 
            this.dataGridViewQuanLyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyView.Location = new System.Drawing.Point(0, 337);
            this.dataGridViewQuanLyView.Name = "dataGridViewQuanLyView";
            this.dataGridViewQuanLyView.RowHeadersWidth = 51;
            this.dataGridViewQuanLyView.RowTemplate.Height = 24;
            this.dataGridViewQuanLyView.Size = new System.Drawing.Size(935, 350);
            this.dataGridViewQuanLyView.TabIndex = 14;
            // 
            // QuanLyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 673);
            this.Controls.Add(this.panelQuanLyView);
            this.Name = "QuanLyView";
            this.Text = "QuanLyView";
            this.panelQuanLyView.ResumeLayout(false);
            this.panelThemView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyView;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyView;
        private System.Windows.Forms.Panel panelThemView;
        private System.Windows.Forms.Button buttonTaoView;
    }
}