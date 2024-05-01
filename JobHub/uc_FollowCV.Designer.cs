namespace JobHub
{
    partial class uc_FollowCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_FollowCV));
            this.pnCV = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnSumbit = new Guna.UI2.WinForms.Guna2Button();
            this.btnFollow = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbCV = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnLocalCV = new System.Windows.Forms.Panel();
            this.uc_CV = new JobHub.uC_CV();
            this.pnCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCV
            // 
            this.pnCV.BackColor = System.Drawing.Color.White;
            this.pnCV.BorderColor = System.Drawing.Color.LightGray;
            this.pnCV.BorderRadius = 10;
            this.pnCV.BorderThickness = 2;
            this.pnCV.Controls.Add(this.btnRemove);
            this.pnCV.Controls.Add(this.btnSumbit);
            this.pnCV.Controls.Add(this.btnFollow);
            this.pnCV.Controls.Add(this.guna2PictureBox1);
            this.pnCV.Controls.Add(this.pbCV);
            this.pnCV.Controls.Add(this.pnLocalCV);
            this.pnCV.Controls.Add(this.uc_CV);
            this.pnCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCV.Location = new System.Drawing.Point(0, 0);
            this.pnCV.Name = "pnCV";
            this.pnCV.Size = new System.Drawing.Size(305, 271);
            this.pnCV.TabIndex = 0;
            this.pnCV.Click += new System.EventHandler(this.uc_CV_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderRadius = 10;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(155, 216);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 45);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Loại";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSumbit
            // 
            this.btnSumbit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSumbit.BorderRadius = 10;
            this.btnSumbit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSumbit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSumbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSumbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSumbit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnSumbit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbit.ForeColor = System.Drawing.Color.White;
            this.btnSumbit.Location = new System.Drawing.Point(13, 216);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(136, 45);
            this.btnSumbit.TabIndex = 2;
            this.btnSumbit.Text = "Chấp nhận";
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // btnFollow
            // 
            this.btnFollow.BorderColor = System.Drawing.Color.Transparent;
            this.btnFollow.BorderRadius = 10;
            this.btnFollow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFollow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFollow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFollow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFollow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnFollow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFollow.ForeColor = System.Drawing.Color.White;
            this.btnFollow.Location = new System.Drawing.Point(13, 216);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(278, 45);
            this.btnFollow.TabIndex = 1;
            this.btnFollow.Text = "Theo dõi";
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 207);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(278, 3);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pbCV
            // 
            this.pbCV.Image = ((System.Drawing.Image)(resources.GetObject("pbCV.Image")));
            this.pbCV.ImageRotate = 0F;
            this.pbCV.Location = new System.Drawing.Point(6, 9);
            this.pbCV.Name = "pbCV";
            this.pbCV.Size = new System.Drawing.Size(293, 190);
            this.pbCV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCV.TabIndex = 4;
            this.pbCV.TabStop = false;
            this.pbCV.Click += new System.EventHandler(this.pbCV_Click);
            // 
            // pnLocalCV
            // 
            this.pnLocalCV.Location = new System.Drawing.Point(6, 9);
            this.pnLocalCV.Name = "pnLocalCV";
            this.pnLocalCV.Size = new System.Drawing.Size(294, 194);
            this.pnLocalCV.TabIndex = 5;
            // 
            // uc_CV
            // 
            this.uc_CV.BackColor = System.Drawing.Color.White;
            this.uc_CV.Location = new System.Drawing.Point(6, 9);
            this.uc_CV.Margin = new System.Windows.Forms.Padding(13, 12, 6, 6);
            this.uc_CV.Name = "uc_CV";
            this.uc_CV.Size = new System.Drawing.Size(293, 190);
            this.uc_CV.TabIndex = 0;
            this.uc_CV.Click += new System.EventHandler(this.uc_CV_Click);
            // 
            // uc_FollowCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnCV);
            this.Name = "uc_FollowCV";
            this.Size = new System.Drawing.Size(305, 271);
            this.pnCV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel pnCV;
        public uC_CV uc_CV;
        public Guna.UI2.WinForms.Guna2Button btnFollow;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2Button btnRemove;
        public Guna.UI2.WinForms.Guna2Button btnSumbit;
        public Guna.UI2.WinForms.Guna2PictureBox pbCV;
        public System.Windows.Forms.Panel pnLocalCV;
    }
}
