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
            this.panelQuanLyView.SuspendLayout();
            this.panelThemView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuanLyView
            // 
            this.panelQuanLyView.BackColor = System.Drawing.Color.White;
            this.panelQuanLyView.Controls.Add(this.panelThemView);
            this.panelQuanLyView.Location = new System.Drawing.Point(0, -8);
            this.panelQuanLyView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelQuanLyView.Name = "panelQuanLyView";
            this.panelQuanLyView.Size = new System.Drawing.Size(701, 561);
            this.panelQuanLyView.TabIndex = 2;
            this.panelQuanLyView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuanLyUser_Paint);
            // 
            // panelThemView
            // 
            this.panelThemView.Controls.Add(this.buttonTaoView);
            this.panelThemView.Location = new System.Drawing.Point(0, 81);
            this.panelThemView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThemView.Name = "panelThemView";
            this.panelThemView.Size = new System.Drawing.Size(701, 122);
            this.panelThemView.TabIndex = 18;
            // 
            // buttonTaoView
            // 
            this.buttonTaoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonTaoView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaoView.Location = new System.Drawing.Point(262, 23);
            this.buttonTaoView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTaoView.Name = "buttonTaoView";
            this.buttonTaoView.Size = new System.Drawing.Size(174, 76);
            this.buttonTaoView.TabIndex = 19;
            this.buttonTaoView.Text = "Tạo view";
            this.buttonTaoView.UseVisualStyleBackColor = false;
            this.buttonTaoView.Click += new System.EventHandler(this.buttonTaoUser_Click);
            // 
            // QuanLyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 547);
            this.Controls.Add(this.panelQuanLyView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyView";
            this.Text = "QuanLyView";
            this.panelQuanLyView.ResumeLayout(false);
            this.panelThemView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuanLyView;
        private System.Windows.Forms.Panel panelThemView;
        private System.Windows.Forms.Button buttonTaoView;
    }
}