using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FFollowedCV : Form
    {
        private FollowedCV followedCV = new FollowedCV();
        uc_FollowCV uc_FollowCV = new uc_FollowCV();
        private Fmain fm;
        private Candidate can = new Candidate();    
        private FormHandler handler = new FormHandler();
        DBConection con = new DBConection();    
        PostCV postCV = new PostCV();   
        public FFollowedCV()
        {
            InitializeComponent();
        }
        public FFollowedCV(Fmain fm)
        {
            this.fm = fm;
            InitializeComponent();
        }
        private void FFollowedCV_Load(object sender, EventArgs e)
        {
            LoadFollowedCV();
        }

        private void LoadFollowedCV()
        {
            DataTable dt = followedCV.LoadFollowedCV(fm.Account.Id);
            flpn.Controls.Clear();  
            foreach (DataRow dr in dt.Rows)
            {
                /*                int CVType = int.Parse(dr["CVType"].ToString());
                                int idCV = int.Parse(dr["idCV"].ToString());
                                DataTable dt1 = followedCV.GetInfoCV(idCV,CVType);
                                if(dt1.Rows.Count > 0)
                                {
                                    DataRow dr1 = dt1.Rows[0];
                                    uc_FollowCV uc = uc_FollowCV.InsertInfoAndEventIntoUcFollowCV(dr1, CVType);
                                    uc.btnFollow.Text = "Đã theo dõi";
                                    uc.btnFollowClick += (sender, e) =>
                                    {
                                        uc.FollowClick(uc.btnFollow.Text, -1, idCV, CVType);
                                        LoadFollowedCV();
                                    };
                                    flpn.Controls.Add(uc);
                                }*/
                int idCandidate = int.Parse(dr["idCandidate"].ToString());
                uC_PostCV postCV = new uC_PostCV();
                Candidate candidate = can.GetInfoCandidate(idCandidate);
                postCV.lblKN.Text = dr["des"].ToString();
                postCV.lblOffer.Text = dr["salaryOffer"].ToString();
                postCV.btnName.Text = candidate.FullName;
                postCV.btnEmail.Text = candidate.Email;
                postCV.btnJob.Text = dr["jobName"].ToString();
                string sql = $@"select* from CVReady where idCandidate = {idCandidate}";
                //MessageBox.Show(sql);
                DataTable dr1 = con.ExcutionReadData(sql);
                int idCV = Int32.Parse(dr1.Rows[0]["idCV"].ToString());
                postCV.guna2Panel2.Click += (sender, e) => {
                    /*                    int idCandiate = Int32.Parse(dr["idCandidate"].ToString());*/

                    handler.OpenFormCVDetailNotEdit(idCandidate, idCV);
                };
                postCV.btnFlow.Text = " Đã theo dõi ";
                
                flpn.Controls.Add(postCV);
            }
        }
    }
}
