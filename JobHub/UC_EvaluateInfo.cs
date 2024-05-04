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
    public partial class UC_EvaluateInfo : UserControl
    {
        public EventHandler clickBtn;
        public UC_EvaluateInfo()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            clickBtn?.Invoke(this, e);
        }
        public void LoadForm(int idCandidate, int idObject, int idType)
        {

        }
    }
}
