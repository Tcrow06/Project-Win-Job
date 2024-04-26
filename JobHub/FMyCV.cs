using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PdfiumViewer;

namespace JobHub
{
    public partial class FMyCV : Form
    {
        DBConection con = new DBConection();
        CVDAO CVDAO = new CVDAO();

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

        public void LoadImage(string destinationFilePath)
        {
            Guna2PictureBox pic = new Guna2PictureBox();
            pic.Size = new Size(127, 124);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = Image.FromFile(Path.Combine(Application.StartupPath, "..\\..\\", destinationFilePath));
            pnContainImageCV.Controls.Add(pic);
        }
        public void WriteData(DataTable dataTable)
        {
            foreach(DataRow dr in dataTable.Rows)
            {
                LoadImage(dr["image"].ToString().Trim());
            }
        }
        private void FMyCV_Load(object sender, EventArgs e)
        {
            if(this.Id != -1)
            {
                DataTable dt = LoadData($@"SELECT Candidate.idCandidate,Candidate.candidateFirstName, Candidate.candidateLastName, CV.jobName, CV.CVAvatar, CV.idCV
                            FROM Candidate
                            INNER JOIN CV ON CV.idCandidate = Candidate.idCandidate
                            where Candidate.idCandidate = {this.Id}");
                WriteData(dt, pnContainCV);
                DataTable dt_1 =LoadData($@"SELECT ImageCV.image
                            FROM ImageCV
                            INNER JOIN Candidate ON ImageCV.idCandidate = Candidate.idCandidate
                            where Candidate.idCandidate = {this.Id}");
                WriteData(dt_1);
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
            string cmd_select = $@"select max(idImageCV)
                                   from ImageCV";
            DataTable dt = CVDAO.ReadData(cmd_select);
            if (dt == null)
            {
                idImageCV = 0;
            }
            else
            {
                idImageCV = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
            }
            string destinationFilePath = CVDAO.SelectImageButton(Application.StartupPath, "image");
            if(destinationFilePath != null && destinationFilePath != "")
            {
                string cmd_insert = $@"insert into ImageCV (image, idCandidate, idImageCV)
                                 values (N'{destinationFilePath}', {this.Id}, {idImageCV})";

                CVDAO.Insert(cmd_insert);
                LoadImage(destinationFilePath);
            }
        }
    }
}
