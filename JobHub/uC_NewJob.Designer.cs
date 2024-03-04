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
            this.lblNameJob = new System.Windows.Forms.Label();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoSize = true;
            this.lblNameJob.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameJob.Location = new System.Drawing.Point(94, 14);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(126, 19);
            this.lblNameJob.TabIndex = 1;
            this.lblNameJob.Text = "Tên Công Việc";
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNameCompany.Location = new System.Drawing.Point(94, 43);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(93, 21);
            this.lblNameCompany.TabIndex = 2;
            this.lblNameCompany.Text = "Tên Công Ty";
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
            this.btnDetail.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(82)))), ((int)(((byte)(72)))));
            this.btnDetail.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDetail.Location = new System.Drawing.Point(227, 16);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(115, 45);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "Chi Tiết";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(76, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // uC_NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblNameCompany);
            this.Controls.Add(this.lblNameJob);
            this.Controls.Add(this.guna2PictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.Name = "uC_NewJob";
            this.Size = new System.Drawing.Size(358, 74);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblNameJob;
        private System.Windows.Forms.Label lblNameCompany;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
    }
}
