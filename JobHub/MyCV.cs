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
        public void InsertInfoIntoUC(string imageName, FlowLayoutPanel pn, int idCV, string CVName)
        {
            UC_ImageCV uc = new UC_ImageCV(imageName, idCV);
            uc.lblCVName.Text = Path.GetFileNameWithoutExtension(CVName);
            Image im = function.InsertImage(imageName, uc.pbImage);
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
                cvDAO.DeleteImageCV(idCV);
                uc.Dispose();
                im.Dispose();
                string imagePath = function.getPathImage(nameImage);
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                    MessageBox.Show("Đã xóa tệp thành công.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    
        public void LoadImageCV(int idCandidate,FlowLayoutPanel pn)
        {
            pn.Controls.Clear();
            SqlDataReader dr = cvDAO.GetImageCV(idCandidate);
            while (dr.Read())
            {
                InsertInfoIntoUC(dr["image"].ToString().Trim(), pn,
                                    int.Parse(dr["idCV"].ToString().Trim()), dr["CVName"].ToString().Trim());
            }
            
        }
    }
}
