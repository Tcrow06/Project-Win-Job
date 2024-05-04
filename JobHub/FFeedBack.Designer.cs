namespace JobHub
{
    partial class FFeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFeedBack));
            this.pnTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnFeedBack = new Guna.UI2.WinForms.Guna2Panel();
            this.fpnContainImage = new System.Windows.Forms.FlowLayoutPanel();
            this.picLoadImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtFeedBack = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.rsFeedBack = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRSFeedBack = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.pnFeedBack.SuspendLayout();
            this.fpnContainImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lblSend);
            this.pnTitle.Controls.Add(this.lblName);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(587, 42);
            this.pnTitle.TabIndex = 0;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSend.Location = new System.Drawing.Point(540, 11);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(35, 21);
            this.lblSend.TabIndex = 1;
            this.lblSend.Text = "Gửi";
            this.lblSend.Click += new System.EventHandler(this.lblSend_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Đánh giá công ty";
            // 
            // pnFeedBack
            // 
            this.pnFeedBack.Controls.Add(this.fpnContainImage);
            this.pnFeedBack.Controls.Add(this.txtFeedBack);
            this.pnFeedBack.Controls.Add(this.guna2Separator1);
            this.pnFeedBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFeedBack.Location = new System.Drawing.Point(0, 42);
            this.pnFeedBack.Name = "pnFeedBack";
            this.pnFeedBack.Size = new System.Drawing.Size(587, 227);
            this.pnFeedBack.TabIndex = 1;
            // 
            // fpnContainImage
            // 
            this.fpnContainImage.AutoScroll = true;
            this.fpnContainImage.Controls.Add(this.picLoadImage);
            this.fpnContainImage.Location = new System.Drawing.Point(3, 123);
            this.fpnContainImage.Name = "fpnContainImage";
            this.fpnContainImage.Size = new System.Drawing.Size(581, 100);
            this.fpnContainImage.TabIndex = 2;
            // 
            // picLoadImage
            // 
            this.picLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("picLoadImage.Image")));
            this.picLoadImage.ImageRotate = 0F;
            this.picLoadImage.Location = new System.Drawing.Point(3, 3);
            this.picLoadImage.Name = "picLoadImage";
            this.picLoadImage.Size = new System.Drawing.Size(29, 32);
            this.picLoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoadImage.TabIndex = 0;
            this.picLoadImage.TabStop = false;
            this.picLoadImage.Click += new System.EventHandler(this.picLoadImage_Click);
            // 
            // txtFeedBack
            // 
            this.txtFeedBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFeedBack.DefaultText = "";
            this.txtFeedBack.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFeedBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFeedBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFeedBack.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFeedBack.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFeedBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFeedBack.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFeedBack.Location = new System.Drawing.Point(0, 7);
            this.txtFeedBack.Name = "txtFeedBack";
            this.txtFeedBack.PasswordChar = '\0';
            this.txtFeedBack.PlaceholderText = "Nhập đánh giá tại đây";
            this.txtFeedBack.SelectedText = "";
            this.txtFeedBack.Size = new System.Drawing.Size(584, 110);
            this.txtFeedBack.TabIndex = 1;
            this.txtFeedBack.TextOffset = new System.Drawing.Point(-5, -28);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, -3);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(585, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // rsFeedBack
            // 
            this.rsFeedBack.Location = new System.Drawing.Point(187, 280);
            this.rsFeedBack.Name = "rsFeedBack";
            this.rsFeedBack.RatingColor = System.Drawing.Color.Yellow;
            this.rsFeedBack.Size = new System.Drawing.Size(120, 28);
            this.rsFeedBack.TabIndex = 2;
            this.rsFeedBack.ValueChanged += new System.EventHandler(this.rsFeedBack_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng quan";
            // 
            // lbRSFeedBack
            // 
            this.lbRSFeedBack.AutoSize = true;
            this.lbRSFeedBack.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRSFeedBack.Location = new System.Drawing.Point(373, 288);
            this.lbRSFeedBack.Name = "lbRSFeedBack";
            this.lbRSFeedBack.Size = new System.Drawing.Size(56, 15);
            this.lbRSFeedBack.TabIndex = 3;
            this.lbRSFeedBack.Text = "Rất tốt";
            this.lbRSFeedBack.Visible = false;
            // 
            // FFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 320);
            this.Controls.Add(this.lbRSFeedBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rsFeedBack);
            this.Controls.Add(this.pnFeedBack);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFeedBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFeedBack";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnFeedBack.ResumeLayout(false);
            this.fpnContainImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnTitle;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Panel pnFeedBack;
        private System.Windows.Forms.FlowLayoutPanel fpnContainImage;
        private Guna.UI2.WinForms.Guna2TextBox txtFeedBack;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2RatingStar rsFeedBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRSFeedBack;
        private Guna.UI2.WinForms.Guna2PictureBox picLoadImage;
    }
}