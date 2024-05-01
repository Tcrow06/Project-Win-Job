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
    public partial class FFollowedCV : Form
    {
        private FollowedCV followedCV = new FollowedCV();
        uc_FollowCV uc_FollowCV = new uc_FollowCV();
        private Fmain fm;
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
                int CVType = int.Parse(dr["CVType"].ToString());
                int idCV = int.Parse(dr["idCV"].ToString());
                DataTable dt1 = followedCV.GetInfoCV(idCV,CVType);
                DataRow dr1 = dt1.Rows[0];
                uc_FollowCV uc =  uc_FollowCV.InsertInfoAndEventIntoUcFollowCV(dr1, CVType);
                uc.btnFollow.Text = "Đã theo dõi";
                uc.btnFollowClick += (sender, e) =>
                {
                    uc.FollowClick(uc.btnFollow.Text, -1, idCV, CVType);
                    LoadFollowedCV();
                };
                flpn.Controls.Add(uc);  
            }
        }
    }
}
