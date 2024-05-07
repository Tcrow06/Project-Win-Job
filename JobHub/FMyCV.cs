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
using Guna.UI2.WinForms;

namespace JobHub
{
    public partial class FMyCV : Form
    {
        CVDAO CVDAO = new CVDAO();
        Function function = new Function(); 
        private MyCV myCV = new MyCV();
        

        private int idImageCV = -1;
        private int id = -1;

        public int Id { get => id; set => id = value; }

        public FMyCV()
        {
            InitializeComponent();
        }

        public FMyCV(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void FMyCV_Load(object sender, EventArgs e)
        {
            LoadForm(); 
        }
        public void LoadForm()
        {
            if (this.Id != -1)
            {
                myCV.LoadCreateCV(this, pnContainCV, lblNameCandidate, picAvatar, pnContainImageCV);
                myCV.LoadImageCV(this.Id, pnContainImageCV, pnContainCV);
            }
        }
        

        private void btnMakeCV_Click(object sender, EventArgs e)
        {
            FCreatCV make = new FCreatCV(this.Id);
            this.Hide();
            make.ShowDialog();
            this.Show();
            LoadForm(); 
        }

        private void btnLoadPDFCV_Click(object sender, EventArgs e)
        {
            idImageCV = myCV.GetIdBeforeSaveNew();
            string destinationFilePath = function.SelectImage();
            if (destinationFilePath != null)
            {
                string nameImage = function.SaveImage(destinationFilePath);
                if (destinationFilePath != null && destinationFilePath != "")
                {
                    if(myCV.InsertInfoIntoUC(nameImage, pnContainImageCV, idImageCV, 
                        nameImage, Id,pnContainCV))
                        myCV.AddImageCVIntoDB(nameImage, this.Id, idImageCV, nameImage);
                }
            }

        }
        private void picLoadImage_Click(object sender, EventArgs e)
        {
            string pathImage = function.SelectImage();
            Guna2PictureBox pb = new Guna2PictureBox();
            if (function.InsertImage(pathImage, pb) != null)
            {
                picAvatar.Image = pb.Image;
                string nameImage = function.SaveImage(pathImage);
                myCV.UpdateImageCandidate(nameImage, this.Id);
            }
        }

    }
}
