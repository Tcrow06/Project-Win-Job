namespace JobHub
{
    partial class uC_JobDescription
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReviewJob = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.lblViewJob = new System.Windows.Forms.Label();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lblReviewJob);
            this.guna2Panel4.Controls.Add(this.lblSince);
            this.guna2Panel4.Controls.Add(this.lblViewJob);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(444, 140);
            this.guna2Panel4.TabIndex = 11;
            // 
            // lblReviewJob
            // 
            this.lblReviewJob.AutoSize = true;
            this.lblReviewJob.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewJob.ForeColor = System.Drawing.Color.Gray;
            this.lblReviewJob.Location = new System.Drawing.Point(14, 50);
            this.lblReviewJob.MaximumSize = new System.Drawing.Size(440, 0);
            this.lblReviewJob.Name = "lblReviewJob";
            this.lblReviewJob.Size = new System.Drawing.Size(160, 28);
            this.lblReviewJob.TabIndex = 5;
            this.lblReviewJob.Text = "Làm gì ở vị trí đó";
            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince.ForeColor = System.Drawing.Color.Gray;
            this.lblSince.Location = new System.Drawing.Point(304, 8);
            this.lblSince.MaximumSize = new System.Drawing.Size(238, 0);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(129, 28);
            this.lblSince.TabIndex = 4;
            this.lblSince.Text = "2020-present";
            // 
            // lblViewJob
            // 
            this.lblViewJob.AutoSize = true;
            this.lblViewJob.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewJob.ForeColor = System.Drawing.Color.Black;
            this.lblViewJob.Location = new System.Drawing.Point(13, 8);
            this.lblViewJob.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblViewJob.Name = "lblViewJob";
            this.lblViewJob.Size = new System.Drawing.Size(138, 32);
            this.lblViewJob.TabIndex = 3;
            this.lblViewJob.Text = "Làm ở vị trí";
            // 
            // uC_JobDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel4);
            this.Name = "uC_JobDescription";
            this.Size = new System.Drawing.Size(444, 140);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        public System.Windows.Forms.Label lblReviewJob;
        public System.Windows.Forms.Label lblSince;
        public System.Windows.Forms.Label lblViewJob;
    }
}
