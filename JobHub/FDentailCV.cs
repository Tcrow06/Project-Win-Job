using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FCv : Form
    {
        public FCv()
        {
            InitializeComponent();
        }

        private void setLocation(int x, int y, Control ctrl)
        {
            ctrl.Location = new Point(x, y);
        }

        private void setSize(int width, int height, Control control)
        {
            control.Width = width;
            control.Height = height;
        }

        private void setSize(int height, Control control)
        {
            control.Height = height;
        }
        private void cv_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 600);
            setLocation(lblIntroduce.Location.X, lblIntroduce.Location.Y + lblIntroduce.Height + 5, pnCall);
            setLocation(pnCall.Location.X, pnCall.Location.Y + pnCall.Height + 5, pnEducation);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
