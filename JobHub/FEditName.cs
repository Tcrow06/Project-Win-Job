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
    public partial class FEditName : Form
    {
        private int idCV;
        private string CVname;
        private EditName editName = new EditName();
        public FEditName()
        {
            InitializeComponent();
        }
        public FEditName(int idCV, string CVname)
        {
            InitializeComponent();
            this.idCV = idCV;
            this.CVname = CVname;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCVName.Text.Length>0)
            {
                editName.UpdateCVName(txtCVName.Text, idCV);
                this.Close();   
            }
            else
            {
                MessageBox.Show("Tên CV không được để trống");
            }
        }

        private void FEditName_Load(object sender, EventArgs e)
        {
            txtCVName.Text = CVname;
        }
    }
}
