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
    public partial class FFeedBack : Form
    {
        FeedBackDAO feedBackDAO = new FeedBackDAO();
        private int idCandidate;
        private int idJob;
        private string path;
        private List<string> list;
        public int IdCandidate { get => idCandidate; set => idCandidate = value; }
        public int IdJob { get => idJob; set => idJob = value; }

        public FFeedBack()
        {
            InitializeComponent();
        }
        public FFeedBack(int idCandidate, int idJob)
        {
            InitializeComponent();
            this.idCandidate = idCandidate;
            this.idJob = idJob;
        }

        private void picLoadImage_Click(object sender, EventArgs e)
        {
            path = feedBackDAO.PicImage();
            if (path != null)
            {
                list = feedBackDAO.LoadImage(path, fpnContainImage, picLoadImage);
                picLoadImage.Visible = false;          
            }
        }

        private void rsFeedBack_ValueChanged(object sender, EventArgs e)
        {
            lbRSFeedBack.Visible = true;
            if (rsFeedBack.Value == 1 || rsFeedBack.Value == 1.5f)
            {
                lbRSFeedBack.Text = "Tệ";
                rsFeedBack.Value = 1;
                lbRSFeedBack.ForeColor = Color.Red;
            }
            else if(rsFeedBack.Value == 2 || rsFeedBack.Value == 2.5f)
            {
                lbRSFeedBack.Text = "Chưa tốt";
                rsFeedBack.Value = 2;
                lbRSFeedBack.ForeColor = Color.Orange;
            }
            else if( rsFeedBack.Value == 3 || rsFeedBack.Value == 3.5f)
            {
                lbRSFeedBack.Text = "Bình thường";
                rsFeedBack.Value = 3;
                lbRSFeedBack.ForeColor = Color.Black;
            }
            else if (rsFeedBack.Value == 4 || rsFeedBack.Value == 4.5f)
            {
                lbRSFeedBack.Text = "Tốt";
                rsFeedBack.Value = 4;
                lbRSFeedBack.ForeColor = Color.Green;
            }
            else
            {
                lbRSFeedBack.Text = "Rất tốt";
                rsFeedBack.Value = 5;
                lbRSFeedBack.ForeColor = Color.Green;
            }
        }

        private void lblSend_Click(object sender, EventArgs e)
        {  
            if (txtFeedBack.Text.Trim() == "" && path.Trim() == "") 
            {
                MessageBox.Show("Bạn chưa nhập đánh giá");
                return;
            }
            else
            {
                path = "";
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == list.Count - 1)
                    {
                        path += list[i];
                    }
                    else
                    {
                        path += list[i] + "+";
                    }
                }
                if(list.Count < 1)
                {
                    FeedBack feedBack = new FeedBack(this.idCandidate, this.idJob, txtFeedBack.Text.Trim(), int.Parse(rsFeedBack.Value.ToString()), "");
                    feedBackDAO.Send(feedBack);

                }

                else if(txtFeedBack.Text.Trim() == "")
                {
                    FeedBack feedBack = new FeedBack(this.idCandidate, this.idJob, "", int.Parse(rsFeedBack.Value.ToString()), path);
                    feedBackDAO.Send(feedBack);

                }
                else if(txtFeedBack.Text.Trim() != "" && path != "")
                {
                    FeedBack feedBack = new FeedBack(this.idCandidate, this.idJob, txtFeedBack.Text.Trim(), int.Parse(rsFeedBack.Value.ToString()), path);
                    feedBackDAO.Send(feedBack);
                }
            }
        }
    }
}
