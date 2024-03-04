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
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void Fmain_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesing()
        {
            jobSubMenuPanel.Visible = false;
            CVSubMenuPanel.Visible = false;
            companySubMenuPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if(jobSubMenuPanel.Visible==true)
            {
                jobSubMenuPanel.Visible = false;
            }

            if(CVSubMenuPanel.Visible==true)
            {
                CVSubMenuPanel.Visible = false;
            }

            if(companySubMenuPanel.Visible==true)
            {
                companySubMenuPanel.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void JobBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(jobSubMenuPanel);
        }

        private void CVBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(CVSubMenuPanel);
        }

        private void companyBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(companySubMenuPanel);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int imageNumber = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }
            bannerPictureBox.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void jobHubProfileMiniPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEconomy_Click(object sender, EventArgs e)
        {

        }

        private void bannerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
