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
            this.btnMainCV = new Guna.UI2.WinForms.Guna2Button();
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
            this.lblCVName.Location = new System.Drawing.Point(2, 138);
            this.lblCVName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCVName.Name = "lblCVName";
            this.lblCVName.Size = new System.Drawing.Size(83, 15);
            this.lblCVName.TabIndex = 5;
            this.lblCVName.Text = "Fullstack developer";
            // 
            // pbDeteleImage
            // 
            this.pbDeteleImage.Image = ((System.Drawing.Image)(resources.GetObject("pbDeteleImage.Image")));
            this.pbDeteleImage.ImageRotate = 0F;
            this.pbDeteleImage.Location = new System.Drawing.Point(118, 137);
            this.pbDeteleImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbDeteleImage.Name = "pbDeteleImage";
            this.pbDeteleImage.Size = new System.Drawing.Size(14, 15);
            this.pbDeteleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeteleImage.TabIndex = 7;
            this.pbDeteleImage.TabStop = false;
            this.pbDeteleImage.Click += new System.EventHandler(this.pbDeteleImage_Click);
            // 
            // pbEditName
            // 
            this.pbEditName.Image = ((System.Drawing.Image)(resources.GetObject("pbEditName.Image")));
            this.pbEditName.ImageRotate = 0F;
            this.pbEditName.Location = new System.Drawing.Point(85, 139);
            this.pbEditName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbEditName.Name = "pbEditName";
            this.pbEditName.Size = new System.Drawing.Size(11, 12);
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
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(138, 133);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
            // 
            // btnMainCV
            // 
            this.btnMainCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMainCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMainCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMainCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMainCV.FillColor = System.Drawing.Color.White;
            this.btnMainCV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMainCV.Image = ((System.Drawing.Image)(resources.GetObject("btnMainCV.Image")));
            this.btnMainCV.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMainCV.Location = new System.Drawing.Point(4, 65);
            this.btnMainCV.Name = "btnMainCV";
            this.btnMainCV.Size = new System.Drawing.Size(131, 29);
            this.btnMainCV.TabIndex = 16;
            this.btnMainCV.Text = "Đặt làm CV Chính";
            this.btnMainCV.Visible = false;
            // 
            // UC_ImageCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMainCV);
            this.Controls.Add(this.pbDeteleImage);
            this.Controls.Add(this.pbEditName);
            this.Controls.Add(this.lblCVName);
            this.Controls.Add(this.pbImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.Name = "UC_ImageCV";
            this.Size = new System.Drawing.Size(138, 158);
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
        public Guna.UI2.WinForms.Guna2Button btnMainCV;
    }
}
