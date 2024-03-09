using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FCV : Form
    {

        private uc_CVInfor selectedUC;
        public FCV()
        {
            InitializeComponent();
            btnDelete.Click += btnDelete_Click;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uc_CVInfor cvInfor = new uc_CVInfor();
            flowLayoutPanel1.Controls.Add(cvInfor);
            cvInfor.selectUc += uc_CVInfor_click;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu CV thành công", "Success");
            this.Close();
            Fmain fmain = new Fmain();
            fmain.Show();
        }

        private void FCV_Load(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is uc_CVInfor ucCVInforControl)
                {
                    ucCVInforControl.selectUc += uc_CVInfor_click;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUC != null)
            {
                flowLayoutPanel1.Controls.Remove(selectedUC);
                selectedUC.Dispose();
                selectedUC = null;
            }
        }
        private void uc_CVInfor_click(object sender, EventArgs e)
        {
            if(selectedUC != null)
            {
                selectedUC.SetBackgroundColor(Color.Transparent);
            }
            selectedUC = (uc_CVInfor)sender;
            selectedUC.BackColor = Color.LightGreen;
        }

    }
}
