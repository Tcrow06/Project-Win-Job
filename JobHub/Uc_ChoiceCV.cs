using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class Uc_ChoiceCV : UserControl
    {
        public event EventHandler clickUC;
        public event EventHandler clickBtn;
        public Uc_ChoiceCV()
        {
            InitializeComponent();
            lblView.Visible = false;
            btn.Visible = false;
        }

        private void UCChoiceCV_MouseHover(object sender, EventArgs e)
        {
            lblView.Visible = true;
            btn.Visible = true;
            pnChoiceCV.BorderColor = Color.FromArgb(0, 139, 0);
        }

        private void UCChoiceCV_MouseLeave(object sender, EventArgs e)
        {
            lblView.Visible = false ;
            btn.Visible = false;
            pnChoiceCV.BorderColor = Color.Silver;
        }

        private void pnChoiceCV_Click(object sender, EventArgs e)
        {
            clickUC?.Invoke(this,e);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            clickBtn?.Invoke(this, e);
        }
    }
}
