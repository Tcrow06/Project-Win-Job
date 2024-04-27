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
using PdfiumViewer;

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

        private DataTable LoadData(string cmd)
        {
            return CVDAO.ReadData(cmd);
            
        }

        public void WriteData(DataTable dataTable, FlowLayoutPanel fpn)
        {
            CVDAO.WriteData(dataTable, pnContainCV);
        }
        public void LoadImage(DataRow dr)
        {
            myCV.InsertInfoIntoUC(dr["image"].ToString().Trim(), pnContainImageCV, 
                                        int.Parse(dr["idCV"].ToString().Trim()), dr["CVName"].ToString().Trim());
        }
        public void WriteData(DataTable dataTable)
        {
            foreach(DataRow dr in dataTable.Rows)
            {
                LoadImage(dr);
            }
        }
        private void FMyCV_Load(object sender, EventArgs e)
        {
            LoadForm(); 
        }
        public void LoadForm()
        {
            if (this.Id != -1)
            {
                DataTable dt = LoadData($@"SELECT Candidate.idCandidate,Candidate.candidateFirstName, Candidate.candidateLastName, CV.jobName, CV.CVAvatar, CV.idCV
                            FROM Candidate
                            INNER JOIN CV ON CV.idCandidate = Candidate.idCandidate
                            where Candidate.idCandidate = {this.Id}");
                WriteData(dt, pnContainCV);
                myCV.LoadImageCV(this.Id, pnContainImageCV);
            }
        }

        private void btnMakeCV_Click(object sender, EventArgs e)
        {
            string cmd = $@"SELECT Candidate.idCandidate,Candidate.candidateFirstName, Candidate.candidateLastName, CV.jobName, CV.CVAvatar, CV.idCV
                            FROM Candidate
                            INNER JOIN CV ON CV.idCandidate = Candidate.idCandidate
                            where Candidate.idCandidate = {this.Id}";
            FMakeCV make = new FMakeCV(this.Id);
            this.Hide();
            make.ShowDialog();
            DataTable dt = CVDAO.ReadData(cmd);
            CVDAO.WriteData(dt, pnContainCV);
            this.Show();
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
                        nameImage))
                        myCV.AddImageCVIntoDB(nameImage, this.Id, idImageCV, nameImage);
                }
            }
        }
    }
}
