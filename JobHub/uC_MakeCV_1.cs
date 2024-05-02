using Guna.UI2.WinForms;
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
    public partial class uC_MakeCV_1 : UserControl
    {
        public event EventHandler Done;
        public event EventHandler SetColor;
        Panel[] listPanel = new Panel[4];
        Guna2Separator[] listSep = new Guna2Separator[4];
        Guna2RadioButton[] listRDO = new Guna2RadioButton[4];
        public uC_MakeCV_1()
        {
            InitializeComponent();
        }

        private void showPanel(Panel panel)
        {

            for (int i = 0; i < 4; i++)
            {

                if (listPanel[i] == panel)
                {
                    continue;
                }
                listPanel[i].SendToBack();
            }
            panel.BringToFront();
        }

        private void setCol(Panel panel)
        {
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                if (listPanel[i] == panel)
                {
                    index = i;
                }
                listRDO[i].Checked = false;
                listSep[i].FillColor = Color.FromArgb(193, 200, 207);
            }
            for(int i = 0; i <= index; ++i)
            {
                listRDO[i].Checked = true;
                listSep[i].FillColor = Color.FromArgb(142, 202, 239);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            showPanel(pnContailKN);
            setCol(pnContailKN);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Done?.Invoke(this, EventArgs.Empty);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            showPanel(pnEducations);
            setCol(pnEducations);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            showPanel(pnSkills);
            setCol(pnSkills);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            showPanel(pnContailKN);
            setCol(pnContailKN);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            showPanel(pnEducations);
            setCol(pnEducations);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            showPanel(pnContact);
            setCol(pnContact);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            SetColor?.Invoke(this, EventArgs.Empty);
            pnContainMenu.BackColor = Color.FromArgb(54, 54, 54);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            SetColor?.Invoke(this, EventArgs.Empty);
            pnContainMenu.BackColor = Color.FromArgb(42, 120, 171);
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            SetColor?.Invoke(this, EventArgs.Empty);
            pnContainMenu.BackColor = Color.FromArgb(142, 202, 239);
        }

        private void uC_MakeCV_1_Load(object sender, EventArgs e)
        {

            listPanel[0] = pnContact;
            listPanel[1] = pnContailKN;
            listPanel[2] = pnEducations;
            listPanel[3] = pnSkills;

            listRDO[0] = rdoContact;
            listRDO[1] = rdoKN;
            listRDO[2] = rdoEducation;
            listRDO[3] = rdoSkill;

            listSep[0] = contact;
            listSep[1] = kn;
            listSep[2] = education;
            listSep[3] = gnSkill;

            showPanel(pnContact);
            setCol(pnContact);
        }
        public void EventTextChange(Label lb, Guna2TextBox txt)
        {
            lb.Text = txt.Text.Trim();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            EventTextChange(lblFirstName, txtFirstName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            EventTextChange(lblLastName, txtLastName);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            EventTextChange(lblPhoneNumber, txtPhoneNumber);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            EventTextChange(lblAddress, txtAddress);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            EventTextChange(lblEmail, txtEmail);
        }

        private void txtSkills_TextChanged(object sender, EventArgs e)
        {
            EventTextChange(lblSkill, txtSkills);
        }
    }
}
