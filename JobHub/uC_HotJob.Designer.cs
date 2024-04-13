namespace JobHub
{
    partial class uC_HotJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uC_HotJob));
            this.pnContain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJobName = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNumberOfCandidates = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumberOfViews = new System.Windows.Forms.Label();
            this.btnApply = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picViews = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnField = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViews)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContain
            // 
            this.pnContain.BorderColor = System.Drawing.Color.DarkGray;
            this.pnContain.BorderRadius = 10;
            this.pnContain.BorderThickness = 2;
            this.pnContain.Controls.Add(this.guna2Panel1);
            this.pnContain.Controls.Add(this.label1);
            this.pnContain.Controls.Add(this.btnField);
            this.pnContain.Controls.Add(this.lblJobName);
            this.pnContain.Controls.Add(this.pbAvatar);
            this.pnContain.Controls.Add(this.lblNumberOfCandidates);
            this.pnContain.Controls.Add(this.lblTitle);
            this.pnContain.Controls.Add(this.lblNumberOfViews);
            this.pnContain.Controls.Add(this.btnApply);
            this.pnContain.Controls.Add(this.guna2PictureBox1);
            this.pnContain.Controls.Add(this.picViews);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Margin = new System.Windows.Forms.Padding(0);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(355, 330);
            this.pnContain.TabIndex = 1;
            this.pnContain.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoEllipsis = true;
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblJobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.lblJobName.Location = new System.Drawing.Point(168, 20);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(170, 139);
            this.lblJobName.TabIndex = 33;
            this.lblJobName.Text = "Tên Công Việc";
            this.lblJobName.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderRadius = 5;
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.FillColor = System.Drawing.SystemColors.Control;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(7, 9);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(150, 150);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 32;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lblNumberOfCandidates
            // 
            this.lblNumberOfCandidates.AutoSize = true;
            this.lblNumberOfCandidates.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCandidates.Location = new System.Drawing.Point(132, 167);
            this.lblNumberOfCandidates.Name = "lblNumberOfCandidates";
            this.lblNumberOfCandidates.Size = new System.Drawing.Size(32, 17);
            this.lblNumberOfCandidates.TabIndex = 27;
            this.lblNumberOfCandidates.Text = "46K";
            this.lblNumberOfCandidates.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 199);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 20);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Lĩnh Vực";
            this.lblTitle.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lblNumberOfViews
            // 
            this.lblNumberOfViews.AutoSize = true;
            this.lblNumberOfViews.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfViews.Location = new System.Drawing.Point(44, 167);
            this.lblNumberOfViews.Name = "lblNumberOfViews";
            this.lblNumberOfViews.Size = new System.Drawing.Size(24, 17);
            this.lblNumberOfViews.TabIndex = 23;
            this.lblNumberOfViews.Text = "1K";
            this.lblNumberOfViews.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // btnApply
            // 
            this.btnApply.Animated = true;
            this.btnApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(191)))), ((int)(((byte)(199)))));
            this.btnApply.BorderRadius = 10;
            this.btnApply.BorderThickness = 2;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnApply.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(136)))));
            this.btnApply.HoverState.FillColor = System.Drawing.Color.White;
            this.btnApply.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(121)))), ((int)(((byte)(136)))));
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApply.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnApply.Location = new System.Drawing.Point(13, 279);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(313, 35);
            this.btnApply.TabIndex = 31;
            this.btnApply.Text = "Ứng Tuyển";
            this.btnApply.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(108, 167);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(22, 16);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 26;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // picViews
            // 
            this.picViews.Image = ((System.Drawing.Image)(resources.GetObject("picViews.Image")));
            this.picViews.ImageRotate = 0F;
            this.picViews.Location = new System.Drawing.Point(15, 165);
            this.picViews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picViews.Name = "picViews";
            this.picViews.Size = new System.Drawing.Size(27, 20);
            this.picViews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViews.TabIndex = 22;
            this.picViews.TabStop = false;
            this.picViews.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 17;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this;
            // 
            // btnField
            // 
            this.btnField.Animated = true;
            this.btnField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            this.btnField.BorderRadius = 10;
            this.btnField.BorderThickness = 2;
            this.btnField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnField.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnField.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnField.FillColor = System.Drawing.Color.White;
            this.btnField.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            this.btnField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            this.btnField.HoverState.FillColor = System.Drawing.Color.White;
            this.btnField.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            this.btnField.Image = ((System.Drawing.Image)(resources.GetObject("btnField.Image")));
            this.btnField.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnField.ImageSize = new System.Drawing.Size(15, 15);
            this.btnField.Location = new System.Drawing.Point(13, 221);
            this.btnField.Margin = new System.Windows.Forms.Padding(2);
            this.btnField.Name = "btnField";
            this.btnField.Size = new System.Drawing.Size(145, 37);
            this.btnField.TabIndex = 34;
            this.btnField.Text = "Kinh tế";
            this.btnField.TextOffset = new System.Drawing.Point(15, 0);
            this.btnField.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lương";
            this.label1.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalary.Location = new System.Drawing.Point(6, 5);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(128, 24);
            this.lblSalary.TabIndex = 52;
            this.lblSalary.Text = "20-25 Triệu";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalary.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lblSalary);
            this.guna2Panel1.Location = new System.Drawing.Point(187, 222);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(137, 37);
            this.guna2Panel1.TabIndex = 53;
            this.guna2Panel1.Click += new System.EventHandler(this.pnContain_Click);
            // 
            // uC_HotJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Name = "uC_HotJob";
            this.Size = new System.Drawing.Size(355, 330);
            this.pnContain.ResumeLayout(false);
            this.pnContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViews)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnContain;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picViews;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public System.Windows.Forms.Label lblJobName;
        public Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
        public System.Windows.Forms.Label lblNumberOfCandidates;
        public System.Windows.Forms.Label lblNumberOfViews;
        public Guna.UI2.WinForms.Guna2Button btnApply;
        public Guna.UI2.WinForms.Guna2Button btnField;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label lblSalary;
    }
}
