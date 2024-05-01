namespace JobHub
{
    partial class uc_JobDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_JobDetail));
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.btnApply = new Guna.UI2.WinForms.Guna2Button();
            this.pnluc = new Guna.UI2.WinForms.Guna2Panel();
            this.ptbSave = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblJobAddress = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnluc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalary.Location = new System.Drawing.Point(837, 13);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(85, 20);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "20-25 Triệu";
            this.lblSalary.Click += new System.EventHandler(this.uc_JobDetail_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCompanyName.Location = new System.Drawing.Point(118, 52);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(171, 23);
            this.lblCompanyName.TabIndex = 7;
            this.lblCompanyName.Text = "Công ty cổ phần FPT";
            this.lblCompanyName.Click += new System.EventHandler(this.uc_JobDetail_Click);
            // 
            // lblJobName
            // 
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblJobName.Location = new System.Drawing.Point(117, 13);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(450, 35);
            this.lblJobName.TabIndex = 6;
            this.lblJobName.Text = "BackEnd Java";
            this.lblJobName.Click += new System.EventHandler(this.uc_JobDetail_Click);
            // 
            // btnApply
            // 
            this.btnApply.BorderRadius = 5;
            this.btnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(747, 61);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(124, 35);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Ứng tuyển";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnluc
            // 
            this.pnluc.BackColor = System.Drawing.Color.White;
            this.pnluc.BorderColor = System.Drawing.Color.Silver;
            this.pnluc.BorderRadius = 10;
            this.pnluc.BorderThickness = 2;
            this.pnluc.Controls.Add(this.ptbSave);
            this.pnluc.Controls.Add(this.btnApply);
            this.pnluc.Controls.Add(this.lblJobAddress);
            this.pnluc.Controls.Add(this.lblSalary);
            this.pnluc.Controls.Add(this.lblCompanyName);
            this.pnluc.Controls.Add(this.lblJobName);
            this.pnluc.Controls.Add(this.pbAvatar);
            this.pnluc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnluc.Location = new System.Drawing.Point(0, 0);
            this.pnluc.Margin = new System.Windows.Forms.Padding(5);
            this.pnluc.Name = "pnluc";
            this.pnluc.Size = new System.Drawing.Size(950, 126);
            this.pnluc.TabIndex = 14;
            this.pnluc.Click += new System.EventHandler(this.uc_JobDetail_Click);
            // 
            // ptbSave
            // 
            this.ptbSave.Image = global::JobHub.Properties.Resources.heartChuaLuu;
            this.ptbSave.ImageRotate = 0F;
            this.ptbSave.Location = new System.Drawing.Point(885, 62);
            this.ptbSave.Name = "ptbSave";
            this.ptbSave.Size = new System.Drawing.Size(46, 35);
            this.ptbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSave.TabIndex = 14;
            this.ptbSave.TabStop = false;
            this.ptbSave.Click += new System.EventHandler(this.ptbSave_Click);
            // 
            // lblJobAddress
            // 
            this.lblJobAddress.AutoSize = true;
            this.lblJobAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.lblJobAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJobAddress.Location = new System.Drawing.Point(121, 80);
            this.lblJobAddress.Name = "lblJobAddress";
            this.lblJobAddress.Size = new System.Drawing.Size(95, 20);
            this.lblJobAddress.TabIndex = 9;
            this.lblJobAddress.Text = "Hồ Chí Minh";
            this.lblJobAddress.Click += new System.EventHandler(this.uc_JobDetail_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(15, 12);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(90, 90);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 5;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.uc_JobDetail_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // uc_JobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnluc);
            this.Name = "uc_JobDetail";
            this.Size = new System.Drawing.Size(950, 126);
            this.pnluc.ResumeLayout(false);
            this.pnluc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnluc;
        public System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Label lblJobName;
        public Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
        public System.Windows.Forms.Label lblJobAddress;
        public System.Windows.Forms.Label lblSalary;
        public Guna.UI2.WinForms.Guna2PictureBox ptbSave;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2Button btnApply;
    }
}
