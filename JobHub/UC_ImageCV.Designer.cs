namespace JobHub
{
    partial class UC_ImageCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ImageCV));
            this.lblCVName = new System.Windows.Forms.Label();
            this.pbDeteleImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbEditName = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeteleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCVName
            // 
            this.lblCVName.AutoEllipsis = true;
            this.lblCVName.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblCVName.ForeColor = System.Drawing.Color.Black;
            this.lblCVName.Location = new System.Drawing.Point(3, 170);
            this.lblCVName.Name = "lblCVName";
            this.lblCVName.Size = new System.Drawing.Size(111, 19);
            this.lblCVName.TabIndex = 5;
            this.lblCVName.Text = "Fullstack developer";
            // 
            // pbDeteleImage
            // 
            this.pbDeteleImage.Image = ((System.Drawing.Image)(resources.GetObject("pbDeteleImage.Image")));
            this.pbDeteleImage.ImageRotate = 0F;
            this.pbDeteleImage.Location = new System.Drawing.Point(158, 169);
            this.pbDeteleImage.Name = "pbDeteleImage";
            this.pbDeteleImage.Size = new System.Drawing.Size(18, 18);
            this.pbDeteleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeteleImage.TabIndex = 7;
            this.pbDeteleImage.TabStop = false;
            this.pbDeteleImage.Click += new System.EventHandler(this.pbDeteleImage_Click);
            // 
            // pbEditName
            // 
            this.pbEditName.Image = ((System.Drawing.Image)(resources.GetObject("pbEditName.Image")));
            this.pbEditName.ImageRotate = 0F;
            this.pbEditName.Location = new System.Drawing.Point(113, 171);
            this.pbEditName.Name = "pbEditName";
            this.pbEditName.Size = new System.Drawing.Size(15, 15);
            this.pbEditName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditName.TabIndex = 6;
            this.pbEditName.TabStop = false;
            this.pbEditName.Click += new System.EventHandler(this.pbEditName_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(184, 163);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // UC_ImageCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbDeteleImage);
            this.Controls.Add(this.pbEditName);
            this.Controls.Add(this.lblCVName);
            this.Controls.Add(this.pbImage);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.Name = "UC_ImageCV";
            this.Size = new System.Drawing.Size(184, 195);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeteleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pbImage;
        public System.Windows.Forms.Label lblCVName;
        public Guna.UI2.WinForms.Guna2PictureBox pbEditName;
        public Guna.UI2.WinForms.Guna2PictureBox pbDeteleImage;
    }
}
