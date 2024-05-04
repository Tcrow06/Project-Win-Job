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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFeedBack));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.rsFeedBack = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRSFeedBack = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.fpnContainImage = new System.Windows.Forms.FlowLayoutPanel();
            this.picLoadImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnFeedBack = new Guna.UI2.WinForms.Guna2Panel();
            this.txtFeedBack = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.picSend = new Guna.UI2.WinForms.Guna2PictureBox();
            this.fpnContainImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).BeginInit();
            this.pnFeedBack.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, -3);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(585, 10);
            this.guna2Separator1.TabIndex = 0;
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
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.guna2ControlBox1);
            this.pnTitle.Controls.Add(this.lblName);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(587, 42);
            this.pnTitle.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 8;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(549, 7);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 26);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // picSend
            // 
            this.picSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSend.Image = ((System.Drawing.Image)(resources.GetObject("picSend.Image")));
            this.picSend.ImageRotate = 0F;
            this.picSend.Location = new System.Drawing.Point(524, 282);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(33, 26);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSend.TabIndex = 4;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click);
            // 
            // FFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 320);
            this.Controls.Add(this.picSend);
            this.Controls.Add(this.lbRSFeedBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rsFeedBack);
            this.Controls.Add(this.pnFeedBack);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFeedBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFeedBack";
            this.fpnContainImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).EndInit();
            this.pnFeedBack.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lbRSFeedBack;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RatingStar rsFeedBack;
        private Guna.UI2.WinForms.Guna2Panel pnFeedBack;
        private System.Windows.Forms.FlowLayoutPanel fpnContainImage;
        private Guna.UI2.WinForms.Guna2PictureBox picLoadImage;
        private Guna.UI2.WinForms.Guna2TextBox txtFeedBack;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel pnTitle;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picSend;
    }
}