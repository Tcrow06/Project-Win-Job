using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class PostCV
    {
        Function func = new Function();
        Candidate can = new Candidate();
        DBConection con = new DBConection();
        private FormHandler handler = new FormHandler();
        Function function = new Function(); 
        public DataTable ReadData(string cmd)
        {
            return func.ReadData(cmd);
        }

        public void WriteCV(DataTable dt, FlowLayoutPanel fpnContainCV, Fmain fm)
        {
            foreach(DataRow dr in dt.Rows)
            {
                int idCandidate = int.Parse(dr["idCandidate"].ToString());
                uC_PostCV postCV = new uC_PostCV();
                Candidate candidate = can.GetInfoCandidate(idCandidate);
                postCV.lblKN.Text = dr["des"].ToString();
                postCV.lblOffer.Text = dr["salaryOffer"].ToString();
                postCV.btnName.Text = candidate.FullName;
                postCV.btnEmail.Text = candidate.Email;
                postCV.btnJob.Text = dr["jobName"].ToString();
                string sql = $@"select* from CVReady where idCandidate = {idCandidate}";
                Guna2PictureBox im = new Guna2PictureBox();
                function.InsertImage(candidate.Avatar, im);
                //MessageBox.Show(sql);
                postCV.pbAvatar.Image = im.Image;
                DataTable dr1 = con.ExcutionReadData(sql);
                int idCV = Int32.Parse(dr1.Rows[0]["idCV"].ToString());
                postCV.guna2Panel2.Click += (sender, e) => {
/*                    int idCandiate = Int32.Parse(dr["idCandidate"].ToString());*/
                    
                    handler.OpenFormCVDetailNotEdit(idCandidate, idCV);
                };
                postCV.btnFlow.Click += (sender, e) => {
                    postCV.btnFlow.Text = "Đã theo dõi";
                    string sql1 = $@"insert into FollowedCV(idCandidate, idCompany) values({idCandidate}, {fm.Account.Id})";
                    con.ExcuteNoMess(sql1);
                };
                fpnContainCV.Controls.Add(postCV);

            }
        }
    }
}
