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
        public FCV()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu CV thành công", "Success");
            this.Close();
            Fmain fmain = new Fmain();
            fmain.Show();
        }

        private void dateEndedu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
