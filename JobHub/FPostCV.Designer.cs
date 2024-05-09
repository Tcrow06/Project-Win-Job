namespace JobHub
{
    partial class FPostCV
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
            this.pnNav = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.fpnContainCV = new System.Windows.Forms.FlowLayoutPanel();
            this.pnNav.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNav
            // 
            this.pnNav.Controls.Add(this.guna2VSeparator1);
            this.pnNav.Controls.Add(this.label8);
            this.pnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNav.Location = new System.Drawing.Point(0, 0);
            this.pnNav.Name = "pnNav";
            this.pnNav.Size = new System.Drawing.Size(1048, 43);
            this.pnNav.TabIndex = 0;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2VSeparator1.FillThickness = 3;
            this.guna2VSeparator1.Location = new System.Drawing.Point(9, 9);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 28);
            this.guna2VSeparator1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 12);
            this.label8.MaximumSize = new System.Drawing.Size(400, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Danh sách CV ứng viên";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.fpnContainCV);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 43);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1048, 576);
            this.guna2Panel1.TabIndex = 1;
            // 
            // fpnContainCV
            // 
            this.fpnContainCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnContainCV.Location = new System.Drawing.Point(0, 0);
            this.fpnContainCV.Name = "fpnContainCV";
            this.fpnContainCV.Size = new System.Drawing.Size(1048, 576);
            this.fpnContainCV.TabIndex = 0;
            // 
            // FPostCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 619);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPostCV";
            this.Text = "FPostCV";
            this.pnNav.ResumeLayout(false);
            this.pnNav.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnNav;
        public System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnContainCV;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}