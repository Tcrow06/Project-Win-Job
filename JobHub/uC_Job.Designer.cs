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
            this.lblPositon = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.lblNameJob = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ucJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.ucJob.Controls.Add(this.lblPositon);
            this.ucJob.Controls.Add(this.lblSalary);
            this.ucJob.Controls.Add(this.lblNameCompany);
            this.ucJob.Controls.Add(this.lblNameJob);
            this.ucJob.Controls.Add(this.picLogo);
            this.ucJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucJob.Location = new System.Drawing.Point(0, 0);
            this.ucJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucJob.Name = "ucJob";
            this.ucJob.Size = new System.Drawing.Size(282, 83);
            this.ucJob.TabIndex = 0;
            this.ucJob.Click += new System.EventHandler(this.ucJob_Click);
            // 
            // lblPositon
            // 
            this.lblPositon.AutoSize = true;
            this.lblPositon.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPositon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPositon.Location = new System.Drawing.Point(144, 56);
            this.lblPositon.Name = "lblPositon";
            this.lblPositon.Size = new System.Drawing.Size(95, 20);
            this.lblPositon.TabIndex = 4;
            this.lblPositon.Text = "Hồ Chí Minh";
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
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoEllipsis = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNameCompany.Location = new System.Drawing.Point(84, 31);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(150, 20);
            this.lblNameCompany.TabIndex = 2;
            this.lblNameCompany.Text = "Công ty cổ phần FPT";
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoEllipsis = true;
            this.lblNameJob.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameJob.Location = new System.Drawing.Point(85, 10);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(106, 20);
            this.lblNameJob.TabIndex = 1;
            this.lblNameJob.Text = "BackEnd Java";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.Control;
            this.picLogo.BorderRadius = 8;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(15, 10);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(56, 44);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Panel ucJob;
        public Guna.UI2.WinForms.Guna2PictureBox picLogo;
        public System.Windows.Forms.Label lblSalary;
        public System.Windows.Forms.Label lblNameCompany;
        public System.Windows.Forms.Label lblNameJob;
        public System.Windows.Forms.Label lblPositon;
    }
}
