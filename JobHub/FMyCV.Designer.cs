namespace JobHub
{
    partial class FMyCV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMyCV));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.picLoadImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNameCandidate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnMakeCV = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMakeCV = new Guna.UI2.WinForms.Guna2Button();
            this.pnContainCV = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLoadPDFCV = new Guna.UI2.WinForms.Guna2Button();
            this.pnContainImageCV = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMakeCV.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.picLoadImage);
            this.guna2Panel1.Controls.Add(this.lblNameCandidate);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.picAvatar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(247, 617);
            this.guna2Panel1.TabIndex = 0;
            // 
            // picLoadImage
            // 
            this.picLoadImage.BorderRadius = 8;
            this.picLoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("picLoadImage.Image")));
            this.picLoadImage.ImageRotate = 0F;
            this.picLoadImage.Location = new System.Drawing.Point(53, 62);
            this.picLoadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLoadImage.Name = "picLoadImage";
            this.picLoadImage.Size = new System.Drawing.Size(29, 26);
            this.picLoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoadImage.TabIndex = 12;
            this.picLoadImage.TabStop = false;
            this.picLoadImage.Click += new System.EventHandler(this.picLoadImage_Click);
            // 
            // lblNameCandidate
            // 
            this.lblNameCandidate.AutoSize = true;
            this.lblNameCandidate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCandidate.Location = new System.Drawing.Point(88, 31);
            this.lblNameCandidate.MaximumSize = new System.Drawing.Size(128, 0);
            this.lblNameCandidate.Name = "lblNameCandidate";
            this.lblNameCandidate.Size = new System.Drawing.Size(121, 23);
            this.lblNameCandidate.TabIndex = 2;
            this.lblNameCandidate.Text = "Lê Trường Sơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chào mừng trở lại,";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(3, 10);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(83, 78);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnMakeCV
            // 
            this.pnMakeCV.BorderColor = System.Drawing.Color.Silver;
            this.pnMakeCV.BorderThickness = 1;
            this.pnMakeCV.Controls.Add(this.btnMakeCV);
            this.pnMakeCV.Controls.Add(this.pnContainCV);
            this.pnMakeCV.Controls.Add(this.label3);
            this.pnMakeCV.Location = new System.Drawing.Point(257, 10);
            this.pnMakeCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMakeCV.Name = "pnMakeCV";
            this.pnMakeCV.Size = new System.Drawing.Size(705, 276);
            this.pnMakeCV.TabIndex = 1;
            // 
            // btnMakeCV
            // 
            this.btnMakeCV.BorderRadius = 15;
            this.btnMakeCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMakeCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMakeCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMakeCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMakeCV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.btnMakeCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMakeCV.ForeColor = System.Drawing.Color.White;
            this.btnMakeCV.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeCV.Image")));
            this.btnMakeCV.Location = new System.Drawing.Point(571, 4);
            this.btnMakeCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeCV.Name = "btnMakeCV";
            this.btnMakeCV.Size = new System.Drawing.Size(121, 36);
            this.btnMakeCV.TabIndex = 5;
            this.btnMakeCV.Text = "Tạo CV";
            this.btnMakeCV.Click += new System.EventHandler(this.btnMakeCV_Click);
            // 
            // pnContainCV
            // 
            this.pnContainCV.AutoScroll = true;
            this.pnContainCV.Location = new System.Drawing.Point(4, 48);
            this.pnContainCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainCV.Name = "pnContainCV";
            this.pnContainCV.Size = new System.Drawing.Size(689, 225);
            this.pnContainCV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.MaximumSize = new System.Drawing.Size(356, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "CV đã tạo trên JobHub";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.btnLoadPDFCV);
            this.guna2Panel2.Controls.Add(this.pnContainImageCV);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Location = new System.Drawing.Point(260, 332);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(705, 274);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnLoadPDFCV
            // 
            this.btnLoadPDFCV.BorderRadius = 15;
            this.btnLoadPDFCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadPDFCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadPDFCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadPDFCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadPDFCV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.btnLoadPDFCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadPDFCV.ForeColor = System.Drawing.Color.White;
            this.btnLoadPDFCV.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPDFCV.Image")));
            this.btnLoadPDFCV.Location = new System.Drawing.Point(571, 5);
            this.btnLoadPDFCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadPDFCV.Name = "btnLoadPDFCV";
            this.btnLoadPDFCV.Size = new System.Drawing.Size(121, 36);
            this.btnLoadPDFCV.TabIndex = 5;
            this.btnLoadPDFCV.Text = "Tải CV lên";
            this.btnLoadPDFCV.Click += new System.EventHandler(this.btnLoadPDFCV_Click);
            // 
            // pnContainImageCV
            // 
            this.pnContainImageCV.AutoScroll = true;
            this.pnContainImageCV.Location = new System.Drawing.Point(4, 48);
            this.pnContainImageCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainImageCV.Name = "pnContainImageCV";
            this.pnContainImageCV.Size = new System.Drawing.Size(689, 222);
            this.pnContainImageCV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.MaximumSize = new System.Drawing.Size(356, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "CV đã tải lên JobHub";
            // 
            // FMyCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 617);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnMakeCV);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMyCV";
            this.Text = "FMyCV";
            this.Load += new System.EventHandler(this.FMyCV_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMakeCV.ResumeLayout(false);
            this.pnMakeCV.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblNameCandidate;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Panel pnMakeCV;
        private System.Windows.Forms.FlowLayoutPanel pnContainCV;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnMakeCV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnLoadPDFCV;
        private System.Windows.Forms.FlowLayoutPanel pnContainImageCV;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox picLoadImage;
    }
}