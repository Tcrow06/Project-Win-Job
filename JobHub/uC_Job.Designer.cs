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
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
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
            this.guna2Panel1.Controls.Add(this.btnDetail);
            this.guna2Panel1.Controls.Add(this.lblNameJob);
            this.guna2Panel1.Controls.Add(this.picLogo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 170);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDetail
            // 
            this.btnDetail.Animated = true;
            this.btnDetail.BorderColor = System.Drawing.Color.White;
            this.btnDetail.BorderRadius = 8;
            this.btnDetail.BorderThickness = 2;
            this.btnDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.btnDetail.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(8)))), ((int)(((byte)(160)))));
            this.btnDetail.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(8)))), ((int)(((byte)(160)))));
            this.btnDetail.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnDetail.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDetail.Location = new System.Drawing.Point(10, 130);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(158, 29);
            this.btnDetail.TabIndex = 16;
            this.btnDetail.Text = "Chi Tiết";
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoSize = true;
            this.lblNameJob.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameJob.Location = new System.Drawing.Point(14, 97);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(109, 19);
            this.lblNameJob.TabIndex = 15;
            this.lblNameJob.Text = "TTS BackEnd";
            // 
            // picLogo
            // 
            this.picLogo.BorderRadius = 10;
            this.picLogo.FillColor = System.Drawing.SystemColors.Control;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(12, 11);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(158, 77);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            // 
            // uC_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "uC_Job";
            this.Size = new System.Drawing.Size(180, 170);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private System.Windows.Forms.Label lblNameJob;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
    }
}
