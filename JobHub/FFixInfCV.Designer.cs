namespace JobHub
{
    partial class FFixInfCV
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.uC_MakeCV1 = new JobHub.uC_MakeCV();
            this.uC_MakeCV2 = new JobHub.uC_MakeCV();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(126)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(8, 675);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(710, 33);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Lưu";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // uC_MakeCV1
            // 
            this.uC_MakeCV1.BackColor = System.Drawing.Color.White;
            this.uC_MakeCV1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_MakeCV1.Location = new System.Drawing.Point(0, 0);
            this.uC_MakeCV1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_MakeCV1.Name = "uC_MakeCV1";
            this.uC_MakeCV1.Size = new System.Drawing.Size(1149, 1002);
            this.uC_MakeCV1.TabIndex = 26;
            // 
            // uC_MakeCV2
            // 
            this.uC_MakeCV2.BackColor = System.Drawing.Color.White;
            this.uC_MakeCV2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_MakeCV2.Location = new System.Drawing.Point(0, 0);
            this.uC_MakeCV2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.uC_MakeCV2.Name = "uC_MakeCV2";
            this.uC_MakeCV2.Size = new System.Drawing.Size(766, 669);
            this.uC_MakeCV2.TabIndex = 26;
            // 
            // FFixInfCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 713);
            this.Controls.Add(this.uC_MakeCV2);
            this.Controls.Add(this.guna2Button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FFixInfCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFixInfCV";
            this.Load += new System.EventHandler(this.FFixInfCV_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private uC_MakeCV uC_MakeCV1;
        private uC_MakeCV uC_MakeCV2;
    }
}