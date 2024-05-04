using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JobHub
{
    internal class FeedBackDAO
    {
        Function func = new Function();
        public string PicImage()
        {
            return func.SelectImage();
        }

        public List<string> LoadImage(string path, FlowLayoutPanel fpn, Guna2PictureBox picImage)
        {
            string[] listPath = path.Split('+');
            List<string> partsList = new List<string>(listPath);
            List<string> list = new List<string>();
            foreach (string item in partsList)
            {
                if(item != "")
                {
                    string item_path = func.SaveImage(item);
                    list.Add(item_path);    
                    func.loadImageFeedBack(item_path, fpn, picImage, partsList);
                }     
            }
            return list;
        }

        public void SendJob(FeedBack feedBack)
        {
            string cmd = $@"INSERT INTO JobEvaluate (idCandidate, idJob, description, star, image)
                            VALUES ('{feedBack.IdCandidate}', '{feedBack.IdObject}', N'{feedBack.Des}', '{feedBack.Start}', N'{feedBack.Image}')";
            func.Insert(cmd);
        }
        public void SendCompany(FeedBack feedBack)
        {
            string cmd = $@"INSERT INTO CompanyEvaluate (idCandidate, idCompany, description, star, image)
                            VALUES ('{feedBack.IdCandidate}', '{feedBack.IdObject}', N'{feedBack.Des}', '{feedBack.Start}', N'{feedBack.Image}')";
            func.Insert(cmd);
        }
    }
}
