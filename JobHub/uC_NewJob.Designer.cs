namespace JobHub
{
    partial class uC_NewJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uC_NewJob));
            this.pnContain = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.btnDetail);
            this.pnContain.Controls.Add(this.lblCompanyName);
            this.pnContain.Controls.Add(this.lblJobName);
            this.pnContain.Controls.Add(this.pbAvatar);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.FillColor = System.Drawing.Color.White;
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnContain.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnContain.Size = new System.Drawing.Size(289, 59);
            this.pnContain.TabIndex = 0;
            this.pnContain.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BorderRadius = 10;
            this.btnDetail.BorderThickness = 2;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.White;
            this.btnDetail.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(72)))));
            this.btnDetail.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDetail.Location = new System.Drawing.Point(187, 16);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(94, 30);
            this.btnDetail.TabIndex = 7;
            this.btnDetail.Text = "Chi Tiết";
            this.btnDetail.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoEllipsis = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCompanyName.Location = new System.Drawing.Point(74, 31);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(84, 19);
            this.lblCompanyName.TabIndex = 6;
            this.lblCompanyName.Text = "Tên Công Ty";
            this.lblCompanyName.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoEllipsis = true;
            this.lblJobName.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(73, 10);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(112, 17);
            this.lblJobName.TabIndex = 5;
            this.lblJobName.Text = "Tên Công Việc";
            this.lblJobName.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderRadius = 10;
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(7, 5);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(62, 48);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 4;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // uC_NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 16);
            this.Name = "uC_NewJob";
            this.Size = new System.Drawing.Size(289, 59);
            this.pnContain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnContain;
        public Guna.UI2.WinForms.Guna2Button btnDetail;
        public System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Label lblJobName;
        public Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
    }
}
