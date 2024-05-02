using JobHub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class uC_CV : UserControl
    {
        public EventHandler OpenForm;
        private FormHandler handler = new FormHandler();
        public uC_CV()
        {
            InitializeComponent();
        }

        private void uC_CV_Click(object sender, EventArgs e)
        {
            OpenForm?.Invoke(sender, e);
        }
        public uC_CV LoadInfoIntoUC_CV(DataRow dr)
        {
            uC_CV uC_CV = new uC_CV();
            uC_CV.lblLastName.Text = dr["candidateFirstName"].ToString();
            uC_CV.lblFirstName.Text = dr["candidateLastName"].ToString();
            uC_CV.lblJobName.Text = dr["jobName"].ToString();

            uC_CV.lblIntroduce.Text = $@"Xin chào, tôi tên là {uC_CV.lblLastName.Text} {uC_CV.lblFirstName.Text}";

            if (dr["CVAvatar"].ToString().Trim() == "")
            {
                uC_CV.picAvatarCV.Image = Resources.ưqd;
                  
            }
            else
            {
                string absoluteImagePath = Path.Combine(Application.StartupPath, "..\\..\\", dr["CVAvatar"].ToString().Trim());
                using (Image image = Image.FromFile(absoluteImagePath))
                {
                    uC_CV.picAvatarCV.Image = new Bitmap(image);
                }
            }
            
            //MessageBox.Show(uC_CV.lblLastName.Text = dr["candidateFirstName"].ToString());
            return uC_CV;
        }
        public void OpenNewForm(object sender, EventArgs e, int idCandiate, int idCV)
        {
            handler.OpenNewForm(idCandiate, idCV);
        }
    }
}
