using Guna.UI2.WinForms;
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
        public event EventHandler deleteUC;
        private Function function = new Function(); 
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
            if (dr["CVAvatar"] == DBNull.Value || dr["CVAvatar"].ToString().Trim().Length == 0)
            {
                uC_CV.picAvatarCV.Image = Resources.ưqd;
            }
            else
            {
                Guna2PictureBox pb = new Guna2PictureBox();
                function.InsertImage(dr["CVAvatar"].ToString().Trim(), pb);
                uC_CV.picAvatarCV.Image = pb.Image;
            }

            return uC_CV;
        }
        public void OpenNewForm(object sender, EventArgs e, int idCandiate, int idCV)
        {
            handler.OpenNewForm(idCandiate, idCV);
        }

        private void pbDeteleCV_Click(object sender, EventArgs e)
        {
            deleteUC?.Invoke(sender, e);
        }
    }
}
