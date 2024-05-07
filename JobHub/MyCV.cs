using Guna.UI2.WinForms;
using JobHub.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace JobHub
{
    public class MyCV
    {
        private CVDAO cvDAO = new CVDAO();
        Function function = new Function();
        public int GetIdBeforeSaveNew()
        {
            DataTable dt = cvDAO.GetIdBeforeSaveNew();
            int idImageCV;
            if (dt.Rows[0][0].ToString().Length == 0)
            {
                idImageCV = 0;
            }
            else
            {
                idImageCV = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
            }
            return idImageCV;
        }
        public void AddImageCVIntoDB(string imageName, int idCandiate, int idCV, string CVName)
        {
            cvDAO.AddImageCVIntoDB(imageName, idCandiate, idCV, CVName);
        }
        public bool InsertInfoIntoUC(string imageName, FlowLayoutPanel pn, int idCV, string CVName, int idCandidate, FlowLayoutPanel flpn)
        {
            UC_ImageCV uc = new UC_ImageCV(imageName, idCV);
            uc.pbSelectMainCV.Click += (sender, e) =>
            {
                function.DeleteMainCV(idCandidate);
                function.SetMainCV(idCandidate, idCV, 1);
                foreach (UC_ImageCV item in pn.Controls)
                {
                    item.pbSelectMainCV.Image = Resources.star;
                }
                foreach (uC_CV item in flpn.Controls)
                {
                    item.pbSelectMainCV.Image = Resources.star;
                }
                uc.pbSelectMainCV.Image = Properties.Resources.star__1_;
                MessageBox.Show("Đặt thành công");
            };
            uc.lblCVName.Text = Path.GetFileNameWithoutExtension(CVName);
            Image im = function.InsertImage(imageName, uc.pbImage);
            if (im !=null)
            {
                uc.deleteUC += (sender, e) =>
                {
                    DeleteImageCV(idCV, uc, imageName, im);
                };
                uc.clickUC += (sender, e) =>
                {
                    FShowImage fShowImage = new FShowImage(Path.GetFileName(imageName));
                    fShowImage.ShowDialog();
                };
                uc.editUC += (sender, e) =>
                {
                    EditCVName(idCV, uc.lblCVName.Text, uc);
                };
                pn.Controls.Add(uc);
                return true;
            }
            return false;
        }
        private void EditCVName(int idCV, string CVName, UC_ImageCV uc)
        {
            FEditName fEdit = new FEditName(idCV, CVName);
            fEdit.ShowDialog();
            uc.lblCVName.Text = fEdit.txtCVName.Text;
        }
        private void DeleteImageCV(int idCV, UC_ImageCV uc, string nameImage, Image im)
        {
            DialogResult results = MessageBox.Show("Bạn có chắn chắn xóa", "Thông báo",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (results == DialogResult.OK)
            {
                try
                {
                    uc.Dispose();
                    im.Dispose();
                    string imagePath = function.getPathImage(nameImage);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                        MessageBox.Show("Đã xóa tệp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cvDAO.DeleteImageCV(idCV);
                }
                catch
                {

                }
            }
        }
        public void LoadCreateCV(FMyCV fMyCV,FlowLayoutPanel fpn ,Label lblNameCandidate,Guna2CirclePictureBox picAvatar, FlowLayoutPanel pn)
        {
            DataTable dt = cvDAO.GetCreateCV(fMyCV.Id);
            FormHandler handler = new FormHandler();
            fpn.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                lblNameCandidate.Text = dr["candidateFirstName"].ToString().Trim() + " " + dr["candidateLastName"].ToString().Trim();

                uC_CV uC_CV = new uC_CV();
                uC_CV.pbDeteleCV.Visible = true;
                uC_CV.lblLastName.Text = dr["candidateFirstName"].ToString();
                uC_CV.lblFirstName.Text = dr["candidateLastName"].ToString();
                uC_CV.lblJobName.Text = dr["jobName"].ToString();

                uC_CV.lblIntroduce.Text = $@"Xin chào, tôi tên là {uC_CV.lblLastName.Text} {uC_CV.lblFirstName.Text}";
                int idCV = int.Parse(dr["idCV"].ToString());
                uC_CV.pbSelectMainCV.Click += (sender, e) =>
                {
                    int idCandidate = int.Parse(dr["idCandidate"].ToString());
                    function.DeleteMainCV(idCandidate);
                    foreach (uC_CV item in fpn.Controls)
                    {
                        item.pbSelectMainCV.Image = Resources.star;
                    }
                    foreach (UC_ImageCV item in pn.Controls)
                    {
                        item.pbSelectMainCV.Image = Resources.star;
                    }
                    function.SetMainCV(idCandidate, idCV, 0);
                    uC_CV.pbSelectMainCV.Image = Properties.Resources.star__1_;
                    MessageBox.Show("Đặt thành công");
                };
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

                if (dr["candidateAvatar"] == DBNull.Value || dr["candidateAvatar"].ToString().Trim().Length == 0)
                {
                    picAvatar.Image = Resources.ưqd;
                }
                else
                {

                    Guna2PictureBox pb = new Guna2PictureBox();
                    function.InsertImage(dr["candidateAvatar"].ToString().Trim(), pb);
                    picAvatar.Image = pb.Image;
                }
                uC_CV.OpenForm += (sender, e) =>
                {
                    int idCandiate = Int32.Parse(dr["idCandidate"].ToString());
                    handler.OpenNewForm(idCandiate, idCV);
                    fMyCV.LoadForm();
                };
                uC_CV.deleteUC += (sender, e) =>
                {
                    cvDAO.DeleteCreateCV(idCV);
                    MessageBox.Show("Đã xóa tệp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fMyCV.LoadForm();

                };
                fpn.Controls.Add(uC_CV);
            }

        }

        public void LoadImageCV(int idCandidate,FlowLayoutPanel pn, FlowLayoutPanel flpn)
        {
            pn.Controls.Clear();
            SqlDataReader dr = cvDAO.GetImageCV(idCandidate);
            while (dr.Read())
            {
                InsertInfoIntoUC(dr["image"].ToString().Trim(), pn,
                                    int.Parse(dr["idCV"].ToString().Trim()), dr["CVName"].ToString().Trim(), int.Parse(dr["idCandidate"].ToString().Trim()), flpn);
            }
            
        }

        public void UpdateImageCandidate(string nameImage, int idCandidate)
        {
            cvDAO.UpdateImageCandidate(nameImage, idCandidate); 
        }
    }
}
