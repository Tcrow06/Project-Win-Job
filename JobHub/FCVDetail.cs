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
        DetailCVDAO detailCVDAO = new DetailCVDAO();

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
            DataTable dt = detailCVDAO.ReadData(query);
            detailCVDAO.WriteData(lblFirstName, lblLastName, lblJobName, lblIntroduce, lblPhoneNumber,
                lblEmail, lblAddress, lblSkill, lblInfEdu, pnExperience, dt);
            
            
            
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
            FCVDetail_Load(sender, e);
            this.Show();
        }
    }
}
