namespace JobHub
{
    partial class FAppliedCV
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpnAppliedCV = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfAppliedCV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lblAddress);
            this.guna2Panel1.Location = new System.Drawing.Point(368, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(293, 47);
            this.guna2Panel1.TabIndex = 54;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(8, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(281, 28);
            this.lblAddress.TabIndex = 50;
            this.lblAddress.Text = "Các công việc đã ứng tuyển";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.flpnAppliedCV);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 139);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1016, 372);
            this.guna2Panel2.TabIndex = 62;
            // 
            // flpnAppliedCV
            // 
            this.flpnAppliedCV.AutoScroll = true;
            this.flpnAppliedCV.Location = new System.Drawing.Point(3, 3);
            this.flpnAppliedCV.Name = "flpnAppliedCV";
            this.flpnAppliedCV.Size = new System.Drawing.Size(1009, 366);
            this.flpnAppliedCV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.Location = new System.Drawing.Point(114, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "việc làm đã ứng tuyển";
            // 
            // lblNumberOfAppliedCV
            // 
            this.lblNumberOfAppliedCV.BackColor = System.Drawing.Color.White;
            this.lblNumberOfAppliedCV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAppliedCV.Location = new System.Drawing.Point(95, 94);
            this.lblNumberOfAppliedCV.Margin = new System.Windows.Forms.Padding(1);
            this.lblNumberOfAppliedCV.Name = "lblNumberOfAppliedCV";
            this.lblNumberOfAppliedCV.Size = new System.Drawing.Size(24, 25);
            this.lblNumberOfAppliedCV.TabIndex = 60;
            this.lblNumberOfAppliedCV.Text = "1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Danh sách ";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(5, 123);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1016, 10);
            this.guna2Separator1.TabIndex = 58;
            // 
            // FAppliedCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 527);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberOfAppliedCV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAppliedCV";
            this.Text = "FAppliedJob";
            this.Load += new System.EventHandler(this.FAppliedJob_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.FlowLayoutPanel flpnAppliedCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfAppliedCV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}