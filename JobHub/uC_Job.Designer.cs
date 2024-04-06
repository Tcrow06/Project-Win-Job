namespace JobHub
{
    partial class uC_Job
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uC_Job));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucJob = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJobAddress = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ucJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ucJob
            // 
            this.ucJob.BorderColor = System.Drawing.Color.Silver;
            this.ucJob.BorderRadius = 10;
            this.ucJob.BorderThickness = 2;
            this.ucJob.Controls.Add(this.lblJobAddress);
            this.ucJob.Controls.Add(this.lblSalary);
            this.ucJob.Controls.Add(this.lblCompanyName);
            this.ucJob.Controls.Add(this.lblJobName);
            this.ucJob.Controls.Add(this.pbAvatar);
            this.ucJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucJob.Location = new System.Drawing.Point(0, 0);
            this.ucJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucJob.Name = "ucJob";
            this.ucJob.Size = new System.Drawing.Size(282, 83);
            this.ucJob.TabIndex = 0;
            this.ucJob.Click += new System.EventHandler(this.ucJob_Click);
            // 
            // lblJobAddress
            // 
            this.lblJobAddress.AutoSize = true;
            this.lblJobAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJobAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJobAddress.Location = new System.Drawing.Point(144, 56);
            this.lblJobAddress.Name = "lblJobAddress";
            this.lblJobAddress.Size = new System.Drawing.Size(95, 20);
            this.lblJobAddress.TabIndex = 4;
            this.lblJobAddress.Text = "Hồ Chí Minh";
            this.lblJobAddress.Click += new System.EventHandler(this.ucJob_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalary.Location = new System.Drawing.Point(15, 56);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(85, 20);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "20-25 Triệu";
            this.lblSalary.Click += new System.EventHandler(this.ucJob_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoEllipsis = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCompanyName.Location = new System.Drawing.Point(84, 31);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(162, 20);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Công ty cổ phần FPT";
            this.lblCompanyName.Click += new System.EventHandler(this.lblNameCompany_Click);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoEllipsis = true;
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(85, 10);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(106, 20);
            this.lblJobName.TabIndex = 1;
            this.lblJobName.Text = "BackEnd Java";
            this.lblJobName.Click += new System.EventHandler(this.ucJob_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.pbAvatar.BorderRadius = 8;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(15, 10);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(56, 44);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.ucJob_Click);
            // 
            // uC_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucJob);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "uC_Job";
            this.Size = new System.Drawing.Size(282, 83);
            this.ucJob.ResumeLayout(false);
            this.ucJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Panel ucJob;
        public Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
        public System.Windows.Forms.Label lblSalary;
        public System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Label lblJobName;
        public System.Windows.Forms.Label lblJobAddress;
    }
}
