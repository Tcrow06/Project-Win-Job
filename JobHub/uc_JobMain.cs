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
    public partial class uc_JobMain : UserControl
    {
        public event EventHandler loadJobClick;
        public uc_JobMain()
        {
            InitializeComponent();
        }
        protected virtual void OnJobDetailClick(EventArgs e)
        {
            loadJobClick?.Invoke(this, e);
        }
        public void LoadJobDetail(object sender, EventArgs e, int idJob, int idCompany, Fmain fm)
        {
            FJobDetails_Load(idJob, idCompany, fm);
        }
        private void FJobDetails_Load(int idJob, int idCp, Fmain fm)
        {
            FJobDetails job = new FJobDetails(idJob, idCp, fm);
            fm.HideChildForm();
            FormAndInfoCandidate fai = new FormAndInfoCandidate(job, idJob, idCp);
            fm.Forms.Push(fai);
            fm.loadForm(fai.Form);
        }
        public string HandleSalary(string x, string y)
        {
            if (x == "0" && y == "0") return "Thoả thuận";

            if (x == "0") return "Trên " + y + " triệu";

            return x + " - " + y + " triệu";

        }
    }
}
