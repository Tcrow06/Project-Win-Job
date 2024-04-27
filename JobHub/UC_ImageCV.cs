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
    public partial class UC_ImageCV : UserControl
    {
        public event EventHandler clickUC;
        public event EventHandler deleteUC;
        public event EventHandler editUC;
        private string CVName;
        private int idCV;
        public UC_ImageCV()
        {
            InitializeComponent();
        }
        public UC_ImageCV(string CVName, int idCV)
        {
            this.CVName = CVName;
            this.idCV = idCV;
            InitializeComponent();
            
        }


        private void pbImage_Click(object sender, EventArgs e)
        {
            clickUC?.Invoke(sender, e);
        }

        private void pbEditName_Click(object sender, EventArgs e)
        {
            editUC?.Invoke(sender, e);
        }

        private void pbDeteleImage_Click(object sender, EventArgs e)
        {
            deleteUC?.Invoke(sender, e);
        }
    }
}
