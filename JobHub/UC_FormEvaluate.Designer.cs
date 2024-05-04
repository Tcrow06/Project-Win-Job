namespace JobHub
{
    partial class UC_FormEvaluate
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
            this.flpnEvaluate = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uc_Evaluate1 = new JobHub.uc_Evaluate();
            this.uc_Evaluate2 = new JobHub.uc_Evaluate();
            this.uC_EvaluateInfo1 = new JobHub.UC_EvaluateInfo();
            this.flpnEvaluate.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnEvaluate
            // 
            this.flpnEvaluate.AutoScroll = true;
            this.flpnEvaluate.Controls.Add(this.flowLayoutPanel1);
            this.flpnEvaluate.Controls.Add(this.uC_EvaluateInfo1);
            this.flpnEvaluate.Controls.Add(this.flowLayoutPanel2);
            this.flpnEvaluate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnEvaluate.Location = new System.Drawing.Point(0, 0);
            this.flpnEvaluate.Name = "flpnEvaluate";
            this.flpnEvaluate.Size = new System.Drawing.Size(945, 260);
            this.flpnEvaluate.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.uc_Evaluate1);
            this.flowLayoutPanel2.Controls.Add(this.uc_Evaluate2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 81);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(876, 240);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // uc_Evaluate1
            // 
            this.uc_Evaluate1.BackColor = System.Drawing.Color.White;
            this.uc_Evaluate1.Location = new System.Drawing.Point(3, 3);
            this.uc_Evaluate1.Name = "uc_Evaluate1";
            this.uc_Evaluate1.Size = new System.Drawing.Size(870, 114);
            this.uc_Evaluate1.TabIndex = 0;
            // 
            // uc_Evaluate2
            // 
            this.uc_Evaluate2.BackColor = System.Drawing.Color.White;
            this.uc_Evaluate2.Location = new System.Drawing.Point(3, 123);
            this.uc_Evaluate2.Name = "uc_Evaluate2";
            this.uc_Evaluate2.Size = new System.Drawing.Size(870, 114);
            this.uc_Evaluate2.TabIndex = 1;
            // 
            // uC_EvaluateInfo1
            // 
            this.uC_EvaluateInfo1.Location = new System.Drawing.Point(9, 3);
            this.uC_EvaluateInfo1.Name = "uC_EvaluateInfo1";
            this.uC_EvaluateInfo1.Size = new System.Drawing.Size(905, 72);
            this.uC_EvaluateInfo1.TabIndex = 34;
            // 
            // UC_FormEvaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpnEvaluate);
            this.Name = "UC_FormEvaluate";
            this.Size = new System.Drawing.Size(945, 260);
            this.flpnEvaluate.ResumeLayout(false);
            this.flpnEvaluate.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.FlowLayoutPanel flpnEvaluate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private uc_Evaluate uc_Evaluate1;
        private uc_Evaluate uc_Evaluate2;
        private UC_EvaluateInfo uC_EvaluateInfo1;
    }
}
