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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnSumbit = new Guna.UI2.WinForms.Guna2Button();
            this.btnFollow = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.uC_CV1 = new JobHub.uC_CV();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnRemove);
            this.guna2Panel1.Controls.Add(this.btnSumbit);
            this.guna2Panel1.Controls.Add(this.btnFollow);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.uC_CV1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(305, 271);
            this.guna2Panel1.TabIndex = 0;
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
            // uC_CV1
            // 
            this.uC_CV1.BackColor = System.Drawing.Color.White;
            this.uC_CV1.Location = new System.Drawing.Point(6, 9);
            this.uC_CV1.Margin = new System.Windows.Forms.Padding(13, 12, 6, 6);
            this.uC_CV1.Name = "uC_CV1";
            this.uC_CV1.Size = new System.Drawing.Size(293, 190);
            this.uC_CV1.TabIndex = 0;
            // 
            // uc_FollowCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "uc_FollowCV";
            this.Size = new System.Drawing.Size(305, 271);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public uC_CV uC_CV1;
        public Guna.UI2.WinForms.Guna2Button btnFollow;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2Button btnRemove;
        public Guna.UI2.WinForms.Guna2Button btnSumbit;
    }
}
