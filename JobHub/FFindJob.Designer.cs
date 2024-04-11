namespace JobHub
{
    partial class FJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJob));
            this.pnJob = new System.Windows.Forms.FlowLayoutPanel();
            this.cboExperience = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboSalary = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboAddress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubLogo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLogo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTechnique = new Guna.UI2.WinForms.Guna2Button();
            this.btnEconomy = new Guna.UI2.WinForms.Guna2Button();
            this.btnIT = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnContain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnSubContain = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_NewJob5 = new JobHub.uC_NewJob();
            this.flpnContain = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_NewJob3 = new JobHub.uC_NewJob();
            this.uC_NewJob1 = new JobHub.uC_NewJob();
            this.uC_NewJob2 = new JobHub.uC_NewJob();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSeeAll = new System.Windows.Forms.Label();
            this.lblNewJob = new System.Windows.Forms.Label();
            this.pnHotFob = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_SlideJob1 = new JobHub.uC_SlideJob();
            this.cboIndustryGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnContain.SuspendLayout();
            this.pnSubContain.SuspendLayout();
            this.flpnContain.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnHotFob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnJob
            // 
            this.pnJob.AutoScroll = true;
            this.pnJob.Location = new System.Drawing.Point(11, 293);
            this.pnJob.Margin = new System.Windows.Forms.Padding(2);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(863, 351);
            this.pnJob.TabIndex = 39;
            // 
            // cboExperience
            // 
            this.cboExperience.BackColor = System.Drawing.Color.Transparent;
            this.cboExperience.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(233)))));
            this.cboExperience.BorderRadius = 9;
            this.cboExperience.BorderThickness = 2;
            this.cboExperience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExperience.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboExperience.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboExperience.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboExperience.ItemHeight = 22;
            this.cboExperience.Items.AddRange(new object[] {
            "Tất cả kinh nghiệm",
            "Không yêu cầu kinh nghiệm",
            "Dưới 1 năm",
            "1 năm",
            "2 năm",
            "3 năm",
            "Trên 3 năm"});
            this.cboExperience.Location = new System.Drawing.Point(630, 192);
            this.cboExperience.Margin = new System.Windows.Forms.Padding(2);
            this.cboExperience.Name = "cboExperience";
            this.cboExperience.Size = new System.Drawing.Size(226, 28);
            this.cboExperience.StartIndex = 0;
            this.cboExperience.TabIndex = 36;
            this.cboExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboExperience.SelectedIndexChanged += new System.EventHandler(this.SelectUcFilter);
            // 
            // cboSalary
            // 
            this.cboSalary.BackColor = System.Drawing.Color.Transparent;
            this.cboSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(162)))), ((int)(((byte)(4)))));
            this.cboSalary.BorderRadius = 9;
            this.cboSalary.BorderThickness = 2;
            this.cboSalary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalary.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSalary.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSalary.ItemHeight = 22;
            this.cboSalary.Items.AddRange(new object[] {
            "Tất cả mức lương",
            "3 - 5 triệu",
            "6 - 10 triệu",
            "11 - 15 triệu",
            "Trên 15 triệu",
            "Thỏa thuận"});
            this.cboSalary.Location = new System.Drawing.Point(322, 192);
            this.cboSalary.Margin = new System.Windows.Forms.Padding(2);
            this.cboSalary.Name = "cboSalary";
            this.cboSalary.Size = new System.Drawing.Size(204, 28);
            this.cboSalary.StartIndex = 0;
            this.cboSalary.TabIndex = 35;
            this.cboSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboSalary.SelectedIndexChanged += new System.EventHandler(this.SelectUcFilter);
            // 
            // cboAddress
            // 
            this.cboAddress.BackColor = System.Drawing.Color.Transparent;
            this.cboAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.cboAddress.BorderRadius = 9;
            this.cboAddress.BorderThickness = 2;
            this.cboAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboAddress.ItemHeight = 22;
            this.cboAddress.Items.AddRange(new object[] {
            "Tất cả tỉnh/thành phố",
            "TP. Hồ Chí Minh",
            "An Giang",
            "Bà Rịa-Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên - Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cboAddress.Location = new System.Drawing.Point(14, 192);
            this.cboAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(204, 28);
            this.cboAddress.StartIndex = 0;
            this.cboAddress.TabIndex = 34;
            this.cboAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboAddress.SelectedIndexChanged += new System.EventHandler(this.SelectUcFilter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 67);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 32);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Lĩnh Vực";
            // 
            // lblSubLogo
            // 
            this.lblSubLogo.AutoSize = false;
            this.lblSubLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubLogo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.lblSubLogo.Location = new System.Drawing.Point(702, 36);
            this.lblSubLogo.Margin = new System.Windows.Forms.Padding(2);
            this.lblSubLogo.Name = "lblSubLogo";
            this.lblSubLogo.Size = new System.Drawing.Size(67, 22);
            this.lblSubLogo.TabIndex = 25;
            this.lblSubLogo.Text = "@job_hub";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = false;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(688, 8);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(82, 32);
            this.lblLogo.TabIndex = 26;
            this.lblLogo.Text = "JobHub";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtSearch.Location = new System.Drawing.Point(4, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập nội dung tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(678, 47);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.SelectUcFilter);
            // 
            // btnTechnique
            // 
            this.btnTechnique.Animated = true;
            this.btnTechnique.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.btnTechnique.BorderRadius = 10;
            this.btnTechnique.BorderThickness = 2;
            this.btnTechnique.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnTechnique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTechnique.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTechnique.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTechnique.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTechnique.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTechnique.FillColor = System.Drawing.Color.White;
            this.btnTechnique.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnTechnique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.btnTechnique.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(70)))), ((int)(((byte)(225)))));
            this.btnTechnique.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTechnique.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(70)))), ((int)(((byte)(225)))));
            this.btnTechnique.Image = ((System.Drawing.Image)(resources.GetObject("btnTechnique.Image")));
            this.btnTechnique.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnTechnique.ImageSize = new System.Drawing.Size(15, 15);
            this.btnTechnique.Location = new System.Drawing.Point(430, 101);
            this.btnTechnique.Margin = new System.Windows.Forms.Padding(2);
            this.btnTechnique.Name = "btnTechnique";
            this.btnTechnique.Size = new System.Drawing.Size(145, 37);
            this.btnTechnique.TabIndex = 33;
            this.btnTechnique.Text = "Kỹ thuật";
            this.btnTechnique.Click += new System.EventHandler(this.SelectUcFilter);
            // 
            // btnEconomy
            // 
            this.btnEconomy.Animated = true;
            this.btnEconomy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            this.btnEconomy.BorderRadius = 10;
            this.btnEconomy.BorderThickness = 2;
            this.btnEconomy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnEconomy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEconomy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEconomy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEconomy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEconomy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEconomy.FillColor = System.Drawing.Color.White;
            this.btnEconomy.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEconomy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            this.btnEconomy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            this.btnEconomy.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEconomy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            this.btnEconomy.Image = ((System.Drawing.Image)(resources.GetObject("btnEconomy.Image")));
            this.btnEconomy.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btnEconomy.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEconomy.Location = new System.Drawing.Point(210, 101);
            this.btnEconomy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Size = new System.Drawing.Size(145, 37);
            this.btnEconomy.TabIndex = 31;
            this.btnEconomy.Text = "Kinh tế";
            this.btnEconomy.Click += new System.EventHandler(this.SelectUcFilter);
            // 
            // btnIT
            // 
            this.btnIT.Animated = true;
            this.btnIT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(71)))), ((int)(((byte)(175)))));
            this.btnIT.BorderRadius = 10;
            this.btnIT.BorderThickness = 2;
            this.btnIT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIT.FillColor = System.Drawing.Color.White;
            this.btnIT.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(71)))), ((int)(((byte)(175)))));
            this.btnIT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(8)))), ((int)(((byte)(160)))));
            this.btnIT.HoverState.FillColor = System.Drawing.Color.White;
            this.btnIT.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(8)))), ((int)(((byte)(160)))));
            this.btnIT.Image = ((System.Drawing.Image)(resources.GetObject("btnIT.Image")));
            this.btnIT.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnIT.ImageSize = new System.Drawing.Size(15, 15);
            this.btnIT.Location = new System.Drawing.Point(11, 101);
            this.btnIT.Margin = new System.Windows.Forms.Padding(2);
            this.btnIT.Name = "btnIT";
            this.btnIT.Size = new System.Drawing.Size(145, 37);
            this.btnIT.TabIndex = 30;
            this.btnIT.Text = "Công nghệ";
            this.btnIT.Click += new System.EventHandler(this.SelectUcFilter);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 152);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(79, 29);
            this.guna2HtmlLabel1.TabIndex = 40;
            this.guna2HtmlLabel1.Text = "Lọc";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(785, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 42);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 41;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // pnContain
            // 
            this.pnContain.Controls.Add(this.pnSubContain);
            this.pnContain.Controls.Add(this.pnHotFob);
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnContain.Location = new System.Drawing.Point(894, 0);
            this.pnContain.Margin = new System.Windows.Forms.Padding(2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(322, 660);
            this.pnContain.TabIndex = 42;
            // 
            // pnSubContain
            // 
            this.pnSubContain.BorderColor = System.Drawing.Color.Silver;
            this.pnSubContain.BorderRadius = 10;
            this.pnSubContain.BorderThickness = 2;
            this.pnSubContain.Controls.Add(this.uC_NewJob5);
            this.pnSubContain.Controls.Add(this.flpnContain);
            this.pnSubContain.Controls.Add(this.guna2Panel2);
            this.pnSubContain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubContain.Location = new System.Drawing.Point(0, 356);
            this.pnSubContain.Margin = new System.Windows.Forms.Padding(2);
            this.pnSubContain.Name = "pnSubContain";
            this.pnSubContain.Size = new System.Drawing.Size(322, 290);
            this.pnSubContain.TabIndex = 1;
            // 
            // uC_NewJob5
            // 
            this.uC_NewJob5.BackColor = System.Drawing.Color.White;
            this.uC_NewJob5.Location = new System.Drawing.Point(10, 292);
            this.uC_NewJob5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 19);
            this.uC_NewJob5.Name = "uC_NewJob5";
            this.uC_NewJob5.Size = new System.Drawing.Size(271, 65);
            this.uC_NewJob5.TabIndex = 8;
            // 
            // flpnContain
            // 
            this.flpnContain.AutoScroll = true;
            this.flpnContain.Controls.Add(this.uC_NewJob3);
            this.flpnContain.Controls.Add(this.uC_NewJob1);
            this.flpnContain.Controls.Add(this.uC_NewJob2);
            this.flpnContain.Location = new System.Drawing.Point(6, 46);
            this.flpnContain.Margin = new System.Windows.Forms.Padding(2);
            this.flpnContain.Name = "flpnContain";
            this.flpnContain.Size = new System.Drawing.Size(298, 228);
            this.flpnContain.TabIndex = 6;
            // 
            // uC_NewJob3
            // 
            this.uC_NewJob3.BackColor = System.Drawing.Color.White;
            this.uC_NewJob3.Location = new System.Drawing.Point(3, 2);
            this.uC_NewJob3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.uC_NewJob3.Name = "uC_NewJob3";
            this.uC_NewJob3.Size = new System.Drawing.Size(289, 59);
            this.uC_NewJob3.TabIndex = 2;
            // 
            // uC_NewJob1
            // 
            this.uC_NewJob1.BackColor = System.Drawing.Color.White;
            this.uC_NewJob1.Location = new System.Drawing.Point(3, 80);
            this.uC_NewJob1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.uC_NewJob1.Name = "uC_NewJob1";
            this.uC_NewJob1.Size = new System.Drawing.Size(289, 59);
            this.uC_NewJob1.TabIndex = 3;
            // 
            // uC_NewJob2
            // 
            this.uC_NewJob2.BackColor = System.Drawing.Color.White;
            this.uC_NewJob2.Location = new System.Drawing.Point(3, 158);
            this.uC_NewJob2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.uC_NewJob2.Name = "uC_NewJob2";
            this.uC_NewJob2.Size = new System.Drawing.Size(289, 59);
            this.uC_NewJob2.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lblSeeAll);
            this.guna2Panel2.Controls.Add(this.lblNewJob);
            this.guna2Panel2.Location = new System.Drawing.Point(7, 7);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(278, 33);
            this.guna2Panel2.TabIndex = 5;
            // 
            // lblSeeAll
            // 
            this.lblSeeAll.AutoSize = true;
            this.lblSeeAll.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSeeAll.Location = new System.Drawing.Point(218, 11);
            this.lblSeeAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeeAll.Name = "lblSeeAll";
            this.lblSeeAll.Size = new System.Drawing.Size(49, 19);
            this.lblSeeAll.TabIndex = 1;
            this.lblSeeAll.Text = "See All";
            // 
            // lblNewJob
            // 
            this.lblNewJob.AutoSize = true;
            this.lblNewJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJob.Location = new System.Drawing.Point(6, 8);
            this.lblNewJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewJob.Name = "lblNewJob";
            this.lblNewJob.Size = new System.Drawing.Size(93, 20);
            this.lblNewJob.TabIndex = 0;
            this.lblNewJob.Text = "What\'s New";
            // 
            // pnHotFob
            // 
            this.pnHotFob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnHotFob.Controls.Add(this.uC_SlideJob1);
            this.pnHotFob.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHotFob.Location = new System.Drawing.Point(0, 0);
            this.pnHotFob.Margin = new System.Windows.Forms.Padding(2);
            this.pnHotFob.Name = "pnHotFob";
            this.pnHotFob.Size = new System.Drawing.Size(322, 356);
            this.pnHotFob.TabIndex = 0;
            // 
            // uC_SlideJob1
            // 
            this.uC_SlideJob1.BackColor = System.Drawing.Color.White;
            this.uC_SlideJob1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_SlideJob1.IdCompany = 0;
            this.uC_SlideJob1.IdJob = 0;
            this.uC_SlideJob1.Location = new System.Drawing.Point(0, 0);
            this.uC_SlideJob1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_SlideJob1.Name = "uC_SlideJob1";
            this.uC_SlideJob1.Size = new System.Drawing.Size(322, 340);
            this.uC_SlideJob1.TabIndex = 0;
            // 
            // cboIndustryGroup
            // 
            this.cboIndustryGroup.BackColor = System.Drawing.Color.Transparent;
            this.cboIndustryGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.cboIndustryGroup.BorderRadius = 9;
            this.cboIndustryGroup.BorderThickness = 2;
            this.cboIndustryGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIndustryGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIndustryGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIndustryGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIndustryGroup.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboIndustryGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboIndustryGroup.ItemHeight = 29;
            this.cboIndustryGroup.Items.AddRange(new object[] {
            "Tất cả các ngành",
            "Sản xuất và chế biến",
            "Kiến trúc và xây dựng",
            "Kinh tế",
            "Công nghệ",
            "Kỹ thuật",
            "Luật - nhân văn",
            "Nghệ thuật - thẩm mỹ - đồ họa",
            "Báo chí - khoa học xã hội",
            "Khoa học cơ bản",
            "Sư phạm",
            "Ngôn ngữ",
            "Nông - lâm - ngư nghiệp"});
            this.cboIndustryGroup.Location = new System.Drawing.Point(630, 101);
            this.cboIndustryGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cboIndustryGroup.Name = "cboIndustryGroup";
            this.cboIndustryGroup.Size = new System.Drawing.Size(220, 35);
            this.cboIndustryGroup.StartIndex = 0;
            this.cboIndustryGroup.TabIndex = 43;
            this.cboIndustryGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboIndustryGroup.SelectedIndexChanged += new System.EventHandler(this.cboIndustryGroup_SelectedIndexChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 286);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(880, 365);
            this.guna2Panel1.TabIndex = 0;
            // 
            // FJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 660);
            this.Controls.Add(this.cboIndustryGroup);
            this.Controls.Add(this.pnContain);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pnJob);
            this.Controls.Add(this.cboExperience);
            this.Controls.Add(this.cboSalary);
            this.Controls.Add(this.cboAddress);
            this.Controls.Add(this.btnTechnique);
            this.Controls.Add(this.btnEconomy);
            this.Controls.Add(this.btnIT);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubLogo);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Việc Làm";
            this.Load += new System.EventHandler(this.FJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnContain.ResumeLayout(false);
            this.pnSubContain.ResumeLayout(false);
            this.flpnContain.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.pnHotFob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnJob;
        private Guna.UI2.WinForms.Guna2ComboBox cboExperience;
        private Guna.UI2.WinForms.Guna2ComboBox cboSalary;
        private Guna.UI2.WinForms.Guna2ComboBox cboAddress;
        private Guna.UI2.WinForms.Guna2Button btnTechnique;
        private Guna.UI2.WinForms.Guna2Button btnEconomy;
        private Guna.UI2.WinForms.Guna2Button btnIT;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnContain;
        private Guna.UI2.WinForms.Guna2Panel pnSubContain;
        private System.Windows.Forms.FlowLayoutPanel flpnContain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblSeeAll;
        private System.Windows.Forms.Label lblNewJob;
        private Guna.UI2.WinForms.Guna2Panel pnHotFob;
        private uC_NewJob uC_NewJob5;
        private Guna.UI2.WinForms.Guna2ComboBox cboIndustryGroup;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private uC_NewJob uC_NewJob3;
        private uC_NewJob uC_NewJob1;
        private uC_NewJob uC_NewJob2;
        private uC_SlideJob uC_SlideJob1;
    }
}

