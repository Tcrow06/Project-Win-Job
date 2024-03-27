namespace JobHub
{
    partial class FUserInfo
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUserInfo));
            this.lblJobName = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblNavName = new System.Windows.Forms.Label();
            this.lblSubPhoneNumber = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSubLink = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSubAdd = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSubEmail = new System.Windows.Forms.Label();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtLatName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblJobName
            // 
            this.guna2Transition1.SetDecoration(this.lblJobName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(322, 11);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(369, 40);
            this.lblJobName.TabIndex = 16;
            this.lblJobName.Text = "Cài đặt thông tin cá  nhân";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderRadius = 8;
            this.txtFirstName.BorderThickness = 0;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtFirstName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(46, 190);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "Họ";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(97, 35);
            this.txtFirstName.TabIndex = 17;
            this.txtFirstName.Click += new System.EventHandler(this.txtName_Click);
            this.txtFirstName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            // 
            // guna2Separator1
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Location = new System.Drawing.Point(46, 221);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(97, 10);
            this.guna2Separator1.TabIndex = 18;
            // 
            // lblNavName
            // 
            this.lblNavName.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblNavName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNavName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavName.Location = new System.Drawing.Point(46, 162);
            this.lblNavName.Name = "lblNavName";
            this.lblNavName.Size = new System.Drawing.Size(70, 25);
            this.lblNavName.TabIndex = 19;
            this.lblNavName.Text = "Họ Tên";
            this.lblNavName.Visible = false;
            // 
            // lblSubPhoneNumber
            // 
            this.lblSubPhoneNumber.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblSubPhoneNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSubPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubPhoneNumber.Location = new System.Drawing.Point(46, 283);
            this.lblSubPhoneNumber.Name = "lblSubPhoneNumber";
            this.lblSubPhoneNumber.Size = new System.Drawing.Size(122, 25);
            this.lblSubPhoneNumber.TabIndex = 22;
            this.lblSubPhoneNumber.Text = "Số điện thoại";
            this.lblSubPhoneNumber.Visible = false;
            // 
            // guna2Separator2
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator2.Location = new System.Drawing.Point(46, 342);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(286, 10);
            this.guna2Separator2.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderRadius = 8;
            this.txtPhoneNumber.BorderThickness = 0;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtPhoneNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(46, 311);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "Nhập số điện thoại";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(286, 35);
            this.txtPhoneNumber.TabIndex = 20;
            this.txtPhoneNumber.Click += new System.EventHandler(this.txtPhoneNumber_Click);
            this.txtPhoneNumber.MouseLeave += new System.EventHandler(this.txtPhoneNumber_MouseLeave);
            // 
            // lblSubLink
            // 
            this.lblSubLink.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblSubLink, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSubLink.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubLink.Location = new System.Drawing.Point(579, 162);
            this.lblSubLink.Name = "lblSubLink";
            this.lblSubLink.Size = new System.Drawing.Size(46, 25);
            this.lblSubLink.TabIndex = 25;
            this.lblSubLink.Text = "Link";
            this.lblSubLink.Visible = false;
            // 
            // guna2Separator3
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator3.Location = new System.Drawing.Point(579, 221);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(286, 10);
            this.guna2Separator3.TabIndex = 24;
            // 
            // txtLink
            // 
            this.txtLink.BorderRadius = 8;
            this.txtLink.BorderThickness = 0;
            this.txtLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtLink, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtLink.DefaultText = "";
            this.txtLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLink.Location = new System.Drawing.Point(579, 190);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLink.Name = "txtLink";
            this.txtLink.PasswordChar = '\0';
            this.txtLink.PlaceholderText = "Link ";
            this.txtLink.SelectedText = "";
            this.txtLink.Size = new System.Drawing.Size(286, 35);
            this.txtLink.TabIndex = 23;
            this.txtLink.Click += new System.EventHandler(this.lblLink_Click);
            this.txtLink.MouseLeave += new System.EventHandler(this.txtLink_MouseLeave);
            // 
            // lblSubAdd
            // 
            this.lblSubAdd.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblSubAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSubAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubAdd.Location = new System.Drawing.Point(579, 283);
            this.lblSubAdd.Name = "lblSubAdd";
            this.lblSubAdd.Size = new System.Drawing.Size(67, 25);
            this.lblSubAdd.TabIndex = 28;
            this.lblSubAdd.Text = "Địa chỉ";
            this.lblSubAdd.Visible = false;
            // 
            // guna2Separator4
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator4.Location = new System.Drawing.Point(579, 342);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(286, 10);
            this.guna2Separator4.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.BorderThickness = 0;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(579, 311);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Nhập địa chỉ";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(286, 35);
            this.txtAddress.TabIndex = 26;
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            this.txtAddress.MouseLeave += new System.EventHandler(this.txtAddress_MouseLeave);
            // 
            // lblSubEmail
            // 
            this.lblSubEmail.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblSubEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSubEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubEmail.Location = new System.Drawing.Point(41, 406);
            this.lblSubEmail.Name = "lblSubEmail";
            this.lblSubEmail.Size = new System.Drawing.Size(56, 25);
            this.lblSubEmail.TabIndex = 31;
            this.lblSubEmail.Text = "Email";
            this.lblSubEmail.Visible = false;
            // 
            // guna2Separator5
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator5.Location = new System.Drawing.Point(41, 465);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(286, 10);
            this.guna2Separator5.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.BorderThickness = 0;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(41, 434);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Nhập email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(286, 35);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // guna2Transition1
            // 
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
            // guna2Separator6
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator6.Location = new System.Drawing.Point(152, 221);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(175, 10);
            this.guna2Separator6.TabIndex = 40;
            // 
            // txtLatName
            // 
            this.txtLatName.BorderRadius = 8;
            this.txtLatName.BorderThickness = 0;
            this.txtLatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtLatName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtLatName.DefaultText = "";
            this.txtLatName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLatName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLatName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLatName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLatName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLatName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLatName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLatName.Location = new System.Drawing.Point(152, 190);
            this.txtLatName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLatName.Name = "txtLatName";
            this.txtLatName.PasswordChar = '\0';
            this.txtLatName.PlaceholderText = "Tên";
            this.txtLatName.SelectedText = "";
            this.txtLatName.Size = new System.Drawing.Size(175, 35);
            this.txtLatName.TabIndex = 39;
            // 
            // FUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 694);
            this.Controls.Add(this.guna2Separator6);
            this.Controls.Add(this.txtLatName);
            this.Controls.Add(this.lblSubEmail);
            this.Controls.Add(this.guna2Separator5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSubAdd);
            this.Controls.Add(this.guna2Separator4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblSubLink);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblSubPhoneNumber);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblNavName);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblJobName);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblNavName;
        private System.Windows.Forms.Label lblSubPhoneNumber;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblSubLink;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2TextBox txtLink;
        private System.Windows.Forms.Label lblSubAdd;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label lblSubEmail;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private Guna.UI2.WinForms.Guna2TextBox txtLatName;
    }
}