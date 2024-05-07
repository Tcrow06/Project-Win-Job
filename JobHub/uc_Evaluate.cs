using Guna.UI2.WinForms;
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
    public partial class uc_Evaluate : UserControl
    {
        private Function function = new Function();
        private Candidate can = new Candidate();  
        public uc_Evaluate()
        {
            InitializeComponent();
        }
        public uc_Evaluate LoadIntoIntoUC(SqlDataReader  dr)
        {
            uc_Evaluate uc = new uc_Evaluate();
            Candidate candidate = can.GetInfoCandidate(int.Parse(dr["idCandidate"].ToString()));
            uc.lblName.Text = candidate.FullName;
            
            function.InsertImage(candidate.Avatar, uc.pbAvatar);
            uc.lblComment.Text = dr["description"].ToString();
            uc.rsJob.Value = int.Parse(dr["star"].ToString());
            string listImage = dr["image"].ToString();
            if (listImage.Length > 0)
            {

                uc.pnPbEvaluate.Controls.Clear();
                string[] list = listImage.Split('+');
                foreach (string i in list)
                {
                    uc_PbEvaluate pbEvaluate = new uc_PbEvaluate();
                    function.InsertImage(i, pbEvaluate.pb);
                    uc.pnPbEvaluate.Controls.Add(pbEvaluate);
                    pbEvaluate.click += (sender, e) =>
                    {
                        pbEvaluate.LoadImage(i);
                    };
                }
            }

            return uc;

        }
    }
}
