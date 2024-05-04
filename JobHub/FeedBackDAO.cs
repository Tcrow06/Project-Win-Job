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
            foreach (string item in partsList)
            {
                if(item != "")
                {
                    string item_path = func.SaveImage(item);
                    func.loadImageFeedBack(item_path, fpn, picImage, partsList);
                }     
            }
            return partsList;
        }

        public void Send(FeedBack feedBack)
        {
            string cmd = $@"INSERT INTO JobEvaluate (idCandidate, idJob, description, star, image)
                            VALUES ('{feedBack.IdCandidate}', '{feedBack.IdJob}', N'{feedBack.Des}', '{feedBack.Start}', N'{feedBack.Image}')";
            func.Insert(cmd);
        }
    }
}
