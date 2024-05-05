using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class uc_FollowCV : UserControl
    {
        public event EventHandler Sumbit_Click;
        public event EventHandler Remove_Click;
        public event EventHandler ucCV_Click;
        public event EventHandler clickPbUC;
        public event EventHandler btnFollowClick;
        private FormHandler handler = new FormHandler();
        private Function function = new Function();
        private Company company = new Company();
        public uc_FollowCV()
        {
            InitializeComponent();
        }


        private void btnSumbit_Click(object sender, EventArgs e)
        {
            Sumbit_Click?.Invoke(sender, EventArgs.Empty);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove_Click?.Invoke(sender, EventArgs.Empty);
        }

        public uc_FollowCV InsertInfoAndEventIntoUcFollowCV(DataRow dr, int CVTye)
        {
            uc_FollowCV uc_FollowCV = new uc_FollowCV();
            if (CVTye == 0) {
                uC_CV uc_cv = uc_CV.LoadInfoIntoUC_CV(dr);
                uc_FollowCV.pnLocalCV.Controls.Add(uc_cv);
                uc_cv.Dock = DockStyle.Fill;
                uc_FollowCV.pnLocalCV.BringToFront();
                uc_cv.pbSelectMainCV.Visible = false;
                uc_cv.OpenForm += (sender, e) =>
                {

                    int idCandiate = Int32.Parse(dr["idCandidate"].ToString());
                    int idCV = Int32.Parse(dr["idCV"].ToString()); 
                    handler.OpenFormCVDetailNotEdit(idCandiate, idCV);
                };
            }
            else
            {
                string imageName = dr["image"].ToString();
                function.InsertImage(imageName, uc_FollowCV.pbCV);
                uc_FollowCV.pbCV.BringToFront();
                uc_FollowCV.clickPbUC += (sender, e) =>
                {
                    FShowImage fShowImage = new FShowImage(Path.GetFileName(imageName));
                    fShowImage.ShowDialog();
                };
            }
            uc_FollowCV.btnRemove.Visible = false;
            uc_FollowCV.btnSumbit.Visible = false;
            uc_FollowCV.btnFollow.Visible = true;
            return uc_FollowCV;

        }
        public void LoadCVDetails(object sender, EventArgs e, int idCV, int idCandidate, int CVType)
        {
            FormHandler handler = new FormHandler();
            if (CVType == 0)
            {
                handler.OpenNewForm(idCandidate, idCV);
            }
            else
            {
                handler.OpenImage(idCV);
            }
        }

        private void uc_CV_Click(object sender, EventArgs e)
        {
            ucCV_Click?.Invoke(sender,e );
        }

        private void pbCV_Click(object sender, EventArgs e)
        {
            clickPbUC?.Invoke(sender, e);
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            btnFollowClick?.Invoke(sender, e);
        }
        public void FollowClick(string text, int idCompany, int idCV, int CVType)
        {
            if(text =="Đã theo dõi")
            {
                DialogResult retults = MessageBox.Show("Xác nhận hủy theo dõi!", "Xác nhận", 
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(retults == DialogResult.OK)
                {
                    company.UnFollowCV(idCV, CVType);
                }

            }
            else if(text =="Theo dõi")
            {
                company.FollowCV(idCompany, idCV, CVType);
            }
        }
        private void CheckFollowStatus()
        {
        }
    }
}
