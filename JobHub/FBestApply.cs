using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public partial class FBestApply : Form
    {
        Fmain fm;
        BestApplyDAO bestApplyDAO = new BestApplyDAO();
        public FBestApply()
        {
            InitializeComponent();
        }
        public FBestApply(Fmain fm)
        {
            InitializeComponent();
            this.fm = fm;
        }
        public DataTable ReadData()
        {
            string cmd = $@"select Job.*, Company.*
                             From Job
                             inner join Company ON Job.idCompany = Company.idCompany
                             where Company.idCompany = {fm.Account.Id}";
            DataTable dt = bestApplyDAO.ReadData(cmd);
            return dt;
        }

        public void LoadData(DataTable dt)
        {
            bestApplyDAO.LoadData(dt, pnJob, pnContainCV);
        }
        private void FBestApply_Load(object sender, EventArgs e)
        {
            DataTable dt = ReadData();
            LoadData(dt);
        }
    }
}
