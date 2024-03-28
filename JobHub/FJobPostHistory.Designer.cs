namespace JobHub
{
    partial class FJobPostHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dgJobPostHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobPostHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(412, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(179, 36);
            this.lblAddress.TabIndex = 50;
            this.lblAddress.Text = "Lịch sử đăng việc";
            // 
            // dgJobPostHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgJobPostHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgJobPostHistory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgJobPostHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgJobPostHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJobPostHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgJobPostHistory.ColumnHeadersHeight = 40;
            this.dgJobPostHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgJobPostHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.JobName,
            this.Address,
            this.salary,
            this.MoreInfo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgJobPostHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgJobPostHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgJobPostHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            this.dgJobPostHistory.Location = new System.Drawing.Point(21, 60);
            this.dgJobPostHistory.Name = "dgJobPostHistory";
            this.dgJobPostHistory.ReadOnly = true;
            this.dgJobPostHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJobPostHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgJobPostHistory.RowHeadersVisible = false;
            this.dgJobPostHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.dgJobPostHistory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgJobPostHistory.RowTemplate.Height = 24;
            this.dgJobPostHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgJobPostHistory.Size = new System.Drawing.Size(1135, 494);
            this.dgJobPostHistory.TabIndex = 51;
            this.dgJobPostHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgJobPostHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgJobPostHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgJobPostHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgJobPostHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgJobPostHistory.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgJobPostHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(189)))), ((int)(((byte)(87)))));
            this.dgJobPostHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgJobPostHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgJobPostHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgJobPostHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgJobPostHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgJobPostHistory.ThemeStyle.HeaderStyle.Height = 40;
            this.dgJobPostHistory.ThemeStyle.ReadOnly = true;
            this.dgJobPostHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgJobPostHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgJobPostHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgJobPostHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgJobPostHistory.ThemeStyle.RowsStyle.Height = 24;
            this.dgJobPostHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgJobPostHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.HeaderText = "Ngày";
            this.date.MinimumWidth = 100;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 211;
            // 
            // JobName
            // 
            this.JobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JobName.HeaderText = "Tên công việc";
            this.JobName.MinimumWidth = 6;
            this.JobName.Name = "JobName";
            this.JobName.ReadOnly = true;
            this.JobName.Width = 350;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa điểm";
            this.Address.MinimumWidth = 150;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.HeaderText = "Lương";
            this.salary.MinimumWidth = 150;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // MoreInfo
            // 
            this.MoreInfo.HeaderText = "Xem thêm";
            this.MoreInfo.MinimumWidth = 150;
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.ReadOnly = true;
            // 
            // FJobPostHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 617);
            this.Controls.Add(this.dgJobPostHistory);
            this.Controls.Add(this.lblAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FJobPostHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FJobPostHistory";
            this.Load += new System.EventHandler(this.FJobPostHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJobPostHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2DataGridView dgJobPostHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoreInfo;
    }
}