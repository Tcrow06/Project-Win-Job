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
    public partial class uc_JobDetail : UserControl
    {
        private int count = 0;
        public uc_JobDetail()
        {
            InitializeComponent();
        }

        private void ptbSave_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {   
                ptbSave.Image = Properties.Resources.heartChuaLuu;
            }
            else
            {
                ptbSave.Image = Properties.Resources.heartDaLuu;
            }
        }
    }
}
