﻿namespace JobHub
{
    partial class uc_Evaluate
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
            this.lblName = new System.Windows.Forms.Label();
            this.rsJob = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblComment = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pnPbEvaluate = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(53, 2);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 12);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "TRƯỜNG SƠN";
            // 
            // rsJob
            // 
            this.rsJob.BorderColor = System.Drawing.Color.Red;
            this.rsJob.BorderThickness = 1;
            this.rsJob.Location = new System.Drawing.Point(56, 18);
            this.rsJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rsJob.Name = "rsJob";
            this.rsJob.RatingColor = System.Drawing.Color.Red;
            this.rsJob.ReadOnly = true;
            this.rsJob.Size = new System.Drawing.Size(74, 23);
            this.rsJob.TabIndex = 29;
            // 
            // lblComment
            // 
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblComment.ForeColor = System.Drawing.Color.Black;
            this.lblComment.Location = new System.Drawing.Point(4, 43);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(524, 35);
            this.lblComment.TabIndex = 32;
            this.lblComment.Text = "Công việc phù hợp với ứng viên mới ra trường, lương hợp lý, shjkashjasdjhkasdhjkg" +
    "asdhkjasdhjkasdhgjasdgjhasdhjgasghj gasdghasgdhgj ashgdhjagshjd";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Black;
            this.guna2VSeparator1.Location = new System.Drawing.Point(532, 2);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(8, 77);
            this.guna2VSeparator1.TabIndex = 33;
            // 
            // pnPbEvaluate
            // 
            this.pnPbEvaluate.AutoScroll = true;
            this.pnPbEvaluate.Location = new System.Drawing.Point(540, 2);
            this.pnPbEvaluate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnPbEvaluate.Name = "pnPbEvaluate";
            this.pnPbEvaluate.Size = new System.Drawing.Size(119, 76);
            this.pnPbEvaluate.TabIndex = 35;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.Location = new System.Drawing.Point(2, 81);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(657, 6);
            this.guna2Separator1.TabIndex = 38;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::JobHub.Properties.Resources.profile_desktop__1_;
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(7, 2);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(38, 41);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 39;
            this.pbAvatar.TabStop = false;
            // 
            // uc_Evaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.pnPbEvaluate);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.rsJob);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_Evaluate";
            this.Size = new System.Drawing.Size(664, 93);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblComment;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2RatingStar rsJob;
        public System.Windows.Forms.FlowLayoutPanel pnPbEvaluate;
        private Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
    }
}