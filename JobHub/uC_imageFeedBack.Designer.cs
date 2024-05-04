namespace JobHub
{
    partial class uC_imageFeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uC_imageFeedBack));
            this.picImageFeedBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDeleteImage = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImageFeedBack)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageFeedBack
            // 
            this.picImageFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageFeedBack.ImageRotate = 0F;
            this.picImageFeedBack.Location = new System.Drawing.Point(0, 0);
            this.picImageFeedBack.Name = "picImageFeedBack";
            this.picImageFeedBack.Size = new System.Drawing.Size(91, 78);
            this.picImageFeedBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageFeedBack.TabIndex = 0;
            this.picImageFeedBack.TabStop = false;
            this.picImageFeedBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picImageFeedBack_MouseDown);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteImage.FillColor = System.Drawing.Color.White;
            this.btnDeleteImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteImage.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteImage.Image")));
            this.btnDeleteImage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteImage.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDeleteImage.Location = new System.Drawing.Point(23, 23);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(65, 29);
            this.btnDeleteImage.TabIndex = 1;
            this.btnDeleteImage.Text = "Xóa";
            this.btnDeleteImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteImage.TextOffset = new System.Drawing.Point(3, 0);
            this.btnDeleteImage.Visible = false;
            // 
            // uC_imageFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.picImageFeedBack);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Name = "uC_imageFeedBack";
            this.Size = new System.Drawing.Size(91, 78);
            ((System.ComponentModel.ISupportInitialize)(this.picImageFeedBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox picImageFeedBack;
        public Guna.UI2.WinForms.Guna2Button btnDeleteImage;
    }
}
