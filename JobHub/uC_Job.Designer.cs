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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPositon = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.lblNameJob = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lblPositon);
            this.guna2Panel1.Controls.Add(this.lblSalary);
            this.guna2Panel1.Controls.Add(this.lblNameCompany);
            this.guna2Panel1.Controls.Add(this.lblNameJob);
            this.guna2Panel1.Controls.Add(this.picLogo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(317, 104);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            this.guna2Panel1.DoubleClick += new System.EventHandler(this.guna2Panel1_DoubleClick);
            // 
            // lblPositon
            // 
            this.lblPositon.AutoSize = true;
            this.lblPositon.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPositon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPositon.Location = new System.Drawing.Point(162, 70);
            this.lblPositon.Name = "lblPositon";
            this.lblPositon.Size = new System.Drawing.Size(115, 25);
            this.lblPositon.TabIndex = 4;
            this.lblPositon.Text = "Hồ Chí Minh";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalary.Location = new System.Drawing.Point(17, 70);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(106, 25);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "20-25 Triệu";
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNameCompany.Location = new System.Drawing.Point(95, 39);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(182, 25);
            this.lblNameCompany.TabIndex = 2;
            this.lblNameCompany.Text = "Công ty cổ phần FPT";
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoEllipsis = true;
            this.lblNameJob.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameJob.Location = new System.Drawing.Point(96, 12);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(119, 25);
            this.lblNameJob.TabIndex = 1;
            this.lblNameJob.Text = "BackEnd Java";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.Control;
            this.picLogo.BorderRadius = 8;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(17, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(63, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // uC_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "uC_Job";
            this.Size = new System.Drawing.Size(317, 104);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2PictureBox picLogo;
        public System.Windows.Forms.Label lblSalary;
        public System.Windows.Forms.Label lblNameCompany;
        public System.Windows.Forms.Label lblNameJob;
        public System.Windows.Forms.Label lblPositon;
    }
}
