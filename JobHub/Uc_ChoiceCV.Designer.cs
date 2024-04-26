namespace JobHub
{
    partial class Uc_ChoiceCV
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
            this.pnChoiceCV = new Guna.UI2.WinForms.Guna2Panel();
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.lblView = new System.Windows.Forms.Label();
            this.lblCVName = new System.Windows.Forms.Label();
            this.pnChoiceCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChoiceCV
            // 
            this.pnChoiceCV.BackColor = System.Drawing.Color.White;
            this.pnChoiceCV.BorderColor = System.Drawing.Color.Silver;
            this.pnChoiceCV.BorderRadius = 5;
            this.pnChoiceCV.BorderThickness = 2;
            this.pnChoiceCV.Controls.Add(this.btn);
            this.pnChoiceCV.Controls.Add(this.lblView);
            this.pnChoiceCV.Controls.Add(this.lblCVName);
            this.pnChoiceCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnChoiceCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChoiceCV.Location = new System.Drawing.Point(0, 0);
            this.pnChoiceCV.Name = "pnChoiceCV";
            this.pnChoiceCV.Size = new System.Drawing.Size(723, 40);
            this.pnChoiceCV.TabIndex = 0;
            this.pnChoiceCV.Click += new System.EventHandler(this.pnChoiceCV_Click);
            this.pnChoiceCV.MouseEnter += new System.EventHandler(this.UCChoiceCV_MouseHover);
            this.pnChoiceCV.MouseLeave += new System.EventHandler(this.UCChoiceCV_MouseLeave);
            // 
            // btn
            // 
            this.btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btn.BorderRadius = 5;
            this.btn.BorderThickness = 1;
            this.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(598, 7);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(106, 24);
            this.btn.TabIndex = 2;
            this.btn.Text = "Chọn CV";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            this.btn.MouseLeave += new System.EventHandler(this.UCChoiceCV_MouseLeave);
            this.btn.MouseHover += new System.EventHandler(this.UCChoiceCV_MouseHover);
            // 
            // lblView
            // 
            this.lblView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.lblView.Location = new System.Drawing.Point(186, 10);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(47, 16);
            this.lblView.TabIndex = 1;
            this.lblView.Text = "Xem";
            this.lblView.Click += new System.EventHandler(this.pnChoiceCV_Click);
            this.lblView.MouseLeave += new System.EventHandler(this.UCChoiceCV_MouseLeave);
            this.lblView.MouseHover += new System.EventHandler(this.UCChoiceCV_MouseHover);
            // 
            // lblCVName
            // 
            this.lblCVName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCVName.Location = new System.Drawing.Point(17, 9);
            this.lblCVName.Name = "lblCVName";
            this.lblCVName.Size = new System.Drawing.Size(138, 23);
            this.lblCVName.TabIndex = 0;
            this.lblCVName.Text = "Tên CV đã lưu";
            this.lblCVName.Click += new System.EventHandler(this.pnChoiceCV_Click);
            this.lblCVName.MouseLeave += new System.EventHandler(this.UCChoiceCV_MouseLeave);
            this.lblCVName.MouseHover += new System.EventHandler(this.UCChoiceCV_MouseHover);
            // 
            // Uc_ChoiceCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnChoiceCV);
            this.Name = "Uc_ChoiceCV";
            this.Size = new System.Drawing.Size(723, 40);
            this.pnChoiceCV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblView;
        public Guna.UI2.WinForms.Guna2Panel pnChoiceCV;
        private Guna.UI2.WinForms.Guna2Button btn;
        public System.Windows.Forms.Label lblCVName;
    }
}
