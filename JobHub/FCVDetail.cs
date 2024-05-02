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
                lblEmail, lblAddress, lblSkill, lblInfEdu, pnExperience, picAvatarCV, dt);



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
            
            setLocation(lblIntroduce.Location.X, lblIntroduce.Location.Y + lblIntroduce.Height + 5, pnCall);
            setLocation(pnCall.Location.X, pnCall.Location.Y + pnCall.Height + 5, pnEducation);
            setLocation(pnEducation.Location.X, pnEducation.Location.Y + 5 + pnEducation.Height, pnSkill);
            setLocation(pnSkill.Location.X, pnSkill.Location.Y + 5 + pnSkill.Height, pnControl);
            this.Size = new Size(500, pnControl.Location.Y + 100);
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

        private void updateCV(string path)
        {
            try
            {
                string absoluteImagePath = Path.Combine(Application.StartupPath, "..\\..\\", path);
                if (File.Exists(absoluteImagePath))
                {
                    Image img = Image.FromFile(absoluteImagePath);
                    picAvatarCV.Image = img;
                    string cmd_update = $@"update CV
                                   set CV.CVAvatar = N'{path}'
                                   from CV
                                   inner join Candidate on CV.idCandidate = Candidate.idCandidate
                                   where CV.idCV = {this.idCV} and Candidate.idCandidate = {this.idCandidate}";
                    detailCVDAO.Update(cmd_update);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tập tin ảnh.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SelectImageButton()
        {

            string path = detailCVDAO.SelectImageButton(Application.StartupPath, "Resources");
            if (path != null)
            {
                updateCV(path);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }

        private void picLoadImage_Click(object sender, EventArgs e)
        {
            SelectImageButton();
        }
    }
}
