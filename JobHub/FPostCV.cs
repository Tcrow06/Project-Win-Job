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
    public partial class FPostCV : Form
    {
        PostCV cv = new PostCV();
        Fmain fm;
        public FPostCV()
        {
            InitializeComponent();
        }

        public FPostCV(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
            LoadData();
        }

        public void LoadData()
        {
            string cmd = "select InputJob.des, InputJob.salaryOffer,InputJob.jobName, Candidate.* from InputJob inner join Candidate on Candidate.idCandidate = InputJob.idCandidate";
            DataTable dt = cv.ReadData(cmd);
            cv.WriteCV(dt, fpnContainCV, fm);
        }
    }
}
