using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FCVDetail : Form
    {
        private int idCandidate;
        private int idCV;
        DBConection con = new DBConection();


        public FCVDetail()
        {
            InitializeComponent();
        }
        public FCVDetail(int idCanidate, int idCV)
        {
            InitializeComponent();
            this.idCandidate = idCanidate;
            this.idCV = idCV;
        }
        private void loadData()
        {
            string query = $@"SELECT Candidate.*, CV.*
                            FROM CV
                            INNER JOIN Candidate ON CV.idCandidate = Candidate.idCandidate
                            Where CV.idCV = {idCV}";
            SqlDataReader reader = con.loadData(query);
            if(reader.Read())
            {
                lblFirstName.Text = reader["candidateFirstName"].ToString();
                lblLastName.Text = reader["candidateLastName"].ToString();
                lblJobName.Text = reader["jobName"].ToString();
                lblIntroduce.Text = $@"Xin chào, tôi tên là {lblFirstName.Text} {lblLastName.Text}";
                lblPhoneNumber.Text = reader["candidatePhone"].ToString();
                lblEmail.Text = reader["candidateEmail"].ToString();
                lblAddress.Text = reader["candidateAddress"].ToString();
                lblSkill.Text = reader["Skill"].ToString();
                string s = reader["CVDescription"].ToString().Trim();
                string[] array = s.Split('+');
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] != "")
                    {
                        uC_JobDescription uC_JobDescription = new uC_JobDescription();
                        string[] subArray = array[i].Split('-');
                        uC_JobDescription.lblViewJob.Text = subArray[0];
                        string[] subArray1 = subArray[1].Split('>');
                        uC_JobDescription.lblSince.Text = subArray1[0];
                        if (i == array.Length - 1)
                        {
                            string[] sunArray2 = subArray1[1].Split('<');
                            uC_JobDescription.lblReviewJob.Text = sunArray2[0];
                            lblInfEdu.Text = sunArray2[1];
                        }
                        else
                        {
                            uC_JobDescription.lblReviewJob.Text = subArray1[1];
                        }
                        pnExperience.Controls.Add(uC_JobDescription);
                    } 
                }
            }
            
        }
        private void setLocation(int x, int y, Control ctrl)
        {
            ctrl.Location = new Point(x, y);
        }

        private void setSize(int width, int height, Control control)
        {
            control.Width = width;
            control.Height = height;
        }

        private void setSize(int height, Control control)
        {
            control.Height = height;
        }


        private void FCVDetail_Load(object sender, EventArgs e)
        {
            loadData();
            this.Size = new Size(500, 600);
            setLocation(lblIntroduce.Location.X, lblIntroduce.Location.Y + lblIntroduce.Height + 5, pnCall);
            setLocation(pnCall.Location.X, pnCall.Location.Y + pnCall.Height + 5, pnEducation);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            FFixInfCV fix = new FFixInfCV(this.idCV, this.idCandidate);
            this.Hide();
            fix.ShowDialog();
            this.Show();
        }
    }
}
