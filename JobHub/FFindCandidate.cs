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
    public partial class FFindCandidate : Form
    {
        private Fmain fm;
        private FindCandidate findCandidate = new FindCandidate();
        uc_FollowCV uc_FollowCV = new uc_FollowCV();    
        public FFindCandidate()
        {
            InitializeComponent();
        }
        public FFindCandidate(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void FindCandidate_Load(object sender, EventArgs e)
        {
            LoadUC_CV();
        }

        private void LoadUC_CV() {
            pnCV.Controls.Clear();  
            DataTable dt = findCandidate.GetUCCV();
            foreach (DataRow dr in dt.Rows) {
                int CVType = int.Parse(dr["CVType"].ToString());
                int idCV = int.Parse(dr["idCV"].ToString());
                DataTable dt1 = findCandidate.GetInfoCV(idCV, CVType);
                if(dt1.Rows.Count > 0)
                {
                    DataRow dr1 = dt1.Rows[0];
                    uc_FollowCV uc = uc_FollowCV.InsertInfoAndEventIntoUcFollowCV(dr1, CVType);
                    uc.btnFollow.Text = "Theo dõi";
                    uc.btnFollowClick += (sender, e) =>
                    {
                        uc.FollowClick(uc.btnFollow.Text, fm.Account.Id, idCV, CVType);
                        LoadUC_CV();
                    };
                    pnCV.Controls.Add(uc);
                }
            }

        }
        
    }
}
