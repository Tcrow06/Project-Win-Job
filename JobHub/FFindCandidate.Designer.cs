namespace JobHub
{
    partial class FFindCandidate
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
            this.pnCV = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnCV
            // 
            this.pnCV.AutoScroll = true;
            this.pnCV.Location = new System.Drawing.Point(33, 85);
            this.pnCV.Margin = new System.Windows.Forms.Padding(2);
            this.pnCV.Name = "pnCV";
            this.pnCV.Size = new System.Drawing.Size(955, 513);
            this.pnCV.TabIndex = 52;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Location = new System.Drawing.Point(27, 78);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(973, 534);
            this.guna2Panel1.TabIndex = 44;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(354, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(263, 30);
            this.lbl.TabIndex = 55;
            this.lbl.Text = "Tổng hợp các CV top đầu";
            // 
            // FFindCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 636);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pnCV);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFindCandidate";
            this.Text = "FindCandidate";
            this.Load += new System.EventHandler(this.FindCandidate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnCV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbl;
    }
}