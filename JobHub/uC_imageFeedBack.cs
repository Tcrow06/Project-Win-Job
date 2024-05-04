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
    public partial class uC_imageFeedBack : UserControl
    {
        private string path;
        public uC_imageFeedBack()
        {
            InitializeComponent();
        }

        public string Path { get => path; set => path = value; }

        private void picImageFeedBack_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                btnDeleteImage.Visible = true;
            }
            else
            {
                btnDeleteImage.Visible = false;
            }
        }
    }
}
