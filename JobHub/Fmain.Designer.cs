﻿namespace JobHub
{
    partial class Fmain
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmain));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.pnControlBox = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnNav = new System.Windows.Forms.FlowLayoutPanel();
            this.pnSubNav3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCV = new Guna.UI2.WinForms.Guna2Button();
            this.btnWriteCV = new Guna.UI2.WinForms.Guna2Button();
            this.btnCvGuide = new Guna.UI2.WinForms.Guna2Button();
            this.pnSubNav1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnJob = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnSubNav2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCompany = new Guna.UI2.WinForms.Guna2Button();
            this.btnListCompany = new Guna.UI2.WinForms.Guna2Button();
            this.btnTopCompany = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pnControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnNav.SuspendLayout();
            this.pnSubNav3.SuspendLayout();
            this.pnSubNav1.SuspendLayout();
            this.pnSubNav2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // pnControlBox
            // 
            this.pnControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.pnControlBox.Controls.Add(this.txtSearch);
            this.pnControlBox.Controls.Add(this.label1);
            this.pnControlBox.Controls.Add(this.guna2PictureBox1);
            this.pnControlBox.Controls.Add(this.guna2ControlBox3);
            this.pnControlBox.Controls.Add(this.guna2ControlBox2);
            this.pnControlBox.Controls.Add(this.guna2ControlBox1);
            this.guna2Transition1.SetDecoration(this.pnControlBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControlBox.Location = new System.Drawing.Point(0, 0);
            this.pnControlBox.Name = "pnControlBox";
            this.pnControlBox.Size = new System.Drawing.Size(1303, 47);
            this.pnControlBox.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtSearch.Location = new System.Drawing.Point(849, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(286, 30);
            this.txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "JobHub";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(8, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(48, 41);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1142, 8);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1196, 8);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1250, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // pnNav
            // 
            this.pnNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.pnNav.Controls.Add(this.pnSubNav3);
            this.pnNav.Controls.Add(this.pnSubNav1);
            this.pnNav.Controls.Add(this.pnSubNav2);
            this.pnNav.Controls.Add(this.btnLogin);
            this.guna2Transition1.SetDecoration(this.pnNav, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNav.Location = new System.Drawing.Point(0, 47);
            this.pnNav.Name = "pnNav";
            this.pnNav.Size = new System.Drawing.Size(261, 792);
            this.pnNav.TabIndex = 2;
            // 
            // pnSubNav3
            // 
            this.pnSubNav3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.pnSubNav3.Controls.Add(this.btnCV);
            this.pnSubNav3.Controls.Add(this.btnWriteCV);
            this.pnSubNav3.Controls.Add(this.btnCvGuide);
            this.guna2Transition1.SetDecoration(this.pnSubNav3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnSubNav3.Location = new System.Drawing.Point(3, 3);
            this.pnSubNav3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.pnSubNav3.Name = "pnSubNav3";
            this.pnSubNav3.Size = new System.Drawing.Size(257, 158);
            this.pnSubNav3.TabIndex = 5;
            // 
            // btnCV
            // 
            this.btnCV.BackColor = System.Drawing.Color.Transparent;
            this.btnCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnCV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.btnCV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCV.ForeColor = System.Drawing.Color.White;
            this.btnCV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnCV.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCV.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnCV.Image = ((System.Drawing.Image)(resources.GetObject("btnCV.Image")));
            this.btnCV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCV.Location = new System.Drawing.Point(3, 3);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(252, 45);
            this.btnCV.TabIndex = 4;
            this.btnCV.Text = "Hồ sơ và cv";
            this.btnCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCV.TextOffset = new System.Drawing.Point(30, 0);
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnWriteCV
            // 
            this.btnWriteCV.BackColor = System.Drawing.Color.Transparent;
            this.btnWriteCV.BorderRadius = 8;
            this.btnWriteCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnWriteCV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnWriteCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWriteCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWriteCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWriteCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWriteCV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnWriteCV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteCV.ForeColor = System.Drawing.Color.White;
            this.btnWriteCV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnWriteCV.HoverState.FillColor = System.Drawing.Color.White;
            this.btnWriteCV.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnWriteCV.Image = ((System.Drawing.Image)(resources.GetObject("btnWriteCV.Image")));
            this.btnWriteCV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWriteCV.Location = new System.Drawing.Point(3, 54);
            this.btnWriteCV.Name = "btnWriteCV";
            this.btnWriteCV.Size = new System.Drawing.Size(257, 45);
            this.btnWriteCV.TabIndex = 5;
            this.btnWriteCV.Text = "Viết cv";
            this.btnWriteCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWriteCV.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // btnCvGuide
            // 
            this.btnCvGuide.BackColor = System.Drawing.Color.Transparent;
            this.btnCvGuide.BorderRadius = 8;
            this.btnCvGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnCvGuide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCvGuide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCvGuide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCvGuide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCvGuide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCvGuide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnCvGuide.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCvGuide.ForeColor = System.Drawing.Color.White;
            this.btnCvGuide.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnCvGuide.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCvGuide.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnCvGuide.Image = ((System.Drawing.Image)(resources.GetObject("btnCvGuide.Image")));
            this.btnCvGuide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCvGuide.Location = new System.Drawing.Point(3, 105);
            this.btnCvGuide.Name = "btnCvGuide";
            this.btnCvGuide.Size = new System.Drawing.Size(257, 45);
            this.btnCvGuide.TabIndex = 6;
            this.btnCvGuide.Text = "Cv guide";
            this.btnCvGuide.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCvGuide.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // pnSubNav1
            // 
            this.pnSubNav1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.pnSubNav1.Controls.Add(this.btnJob);
            this.pnSubNav1.Controls.Add(this.guna2Button1);
            this.pnSubNav1.Controls.Add(this.guna2Button2);
            this.guna2Transition1.SetDecoration(this.pnSubNav1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnSubNav1.Location = new System.Drawing.Point(3, 179);
            this.pnSubNav1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.pnSubNav1.Name = "pnSubNav1";
            this.pnSubNav1.Size = new System.Drawing.Size(257, 158);
            this.pnSubNav1.TabIndex = 3;
            // 
            // btnJob
            // 
            this.btnJob.BackColor = System.Drawing.Color.Transparent;
            this.btnJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnJob, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.btnJob.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJob.ForeColor = System.Drawing.Color.White;
            this.btnJob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnJob.HoverState.FillColor = System.Drawing.Color.White;
            this.btnJob.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnJob.Image = ((System.Drawing.Image)(resources.GetObject("btnJob.Image")));
            this.btnJob.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJob.Location = new System.Drawing.Point(3, 3);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(257, 45);
            this.btnJob.TabIndex = 4;
            this.btnJob.Text = "Việc làm";
            this.btnJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJob.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(3, 54);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(257, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Tìm việc";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(3, 105);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(257, 45);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Đăng việc";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // pnSubNav2
            // 
            this.pnSubNav2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.pnSubNav2.Controls.Add(this.btnCompany);
            this.pnSubNav2.Controls.Add(this.btnListCompany);
            this.pnSubNav2.Controls.Add(this.btnTopCompany);
            this.guna2Transition1.SetDecoration(this.pnSubNav2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnSubNav2.Location = new System.Drawing.Point(3, 355);
            this.pnSubNav2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.pnSubNav2.Name = "pnSubNav2";
            this.pnSubNav2.Size = new System.Drawing.Size(257, 158);
            this.pnSubNav2.TabIndex = 4;
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCompany.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompany.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompany.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.btnCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ForeColor = System.Drawing.Color.White;
            this.btnCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnCompany.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCompany.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnCompany.Image")));
            this.btnCompany.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompany.Location = new System.Drawing.Point(3, 3);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(257, 45);
            this.btnCompany.TabIndex = 4;
            this.btnCompany.Text = "công ty";
            this.btnCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompany.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // btnListCompany
            // 
            this.btnListCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnListCompany.BorderRadius = 8;
            this.btnListCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnListCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnListCompany.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListCompany.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListCompany.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnListCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCompany.ForeColor = System.Drawing.Color.White;
            this.btnListCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnListCompany.HoverState.FillColor = System.Drawing.Color.White;
            this.btnListCompany.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnListCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnListCompany.Image")));
            this.btnListCompany.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListCompany.Location = new System.Drawing.Point(3, 54);
            this.btnListCompany.Name = "btnListCompany";
            this.btnListCompany.Size = new System.Drawing.Size(257, 45);
            this.btnListCompany.TabIndex = 5;
            this.btnListCompany.Text = "List công ty";
            this.btnListCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListCompany.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // btnTopCompany
            // 
            this.btnTopCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnTopCompany.BorderRadius = 8;
            this.btnTopCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnTopCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnTopCompany.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopCompany.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopCompany.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnTopCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopCompany.ForeColor = System.Drawing.Color.White;
            this.btnTopCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnTopCompany.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTopCompany.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnTopCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnTopCompany.Image")));
            this.btnTopCompany.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTopCompany.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnTopCompany.Location = new System.Drawing.Point(3, 105);
            this.btnTopCompany.Name = "btnTopCompany";
            this.btnTopCompany.Size = new System.Drawing.Size(257, 45);
            this.btnTopCompany.TabIndex = 6;
            this.btnTopCompany.Text = "Top công ty";
            this.btnTopCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTopCompany.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(105)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnLogin.Location = new System.Drawing.Point(3, 740);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 212, 3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(257, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.TextOffset = new System.Drawing.Point(30, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1303, 839);
            this.Controls.Add(this.pnNav);
            this.Controls.Add(this.pnControlBox);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Fmain_Load);
            this.pnControlBox.ResumeLayout(false);
            this.pnControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnNav.ResumeLayout(false);
            this.pnSubNav3.ResumeLayout(false);
            this.pnSubNav1.ResumeLayout(false);
            this.pnSubNav2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnNav;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel pnSubNav1;
        private Guna.UI2.WinForms.Guna2Button btnJob;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel pnSubNav2;
        private Guna.UI2.WinForms.Guna2Button btnCompany;
        private Guna.UI2.WinForms.Guna2Button btnListCompany;
        private Guna.UI2.WinForms.Guna2Button btnTopCompany;
        private System.Windows.Forms.FlowLayoutPanel pnSubNav3;
        private Guna.UI2.WinForms.Guna2Button btnCV;
        private Guna.UI2.WinForms.Guna2Button btnWriteCV;
        private Guna.UI2.WinForms.Guna2Button btnCvGuide;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}