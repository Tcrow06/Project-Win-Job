using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class uc_PbEvaluate : UserControl
    {
        public EventHandler click;
        public uc_PbEvaluate()
        {
            InitializeComponent();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            click?.Invoke(sender, e);
        }
        public void LoadImage(string imageName)
        {
            FShowImage f = new FShowImage(imageName);
            f.ShowDialog();
        }
    }
}
