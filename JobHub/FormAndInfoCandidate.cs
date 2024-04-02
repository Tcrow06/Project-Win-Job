using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class FormAndInfoCandidate
    {
        private Form form;
        private int idJob;
        private int idCompany;

        public FormAndInfoCandidate(Form form, int idJob, int idCompany)
        {
            this.Form = form;
            this.IdJob = idJob;
            this.IdCompany = idCompany;
        }
        public FormAndInfoCandidate()
        {
        }
        public FormAndInfoCandidate(Form form)
        {
            this.Form = form;
        }

        public Form Form { get => form; set => form = value; }
        public int IdJob { get => idJob; set => idJob = value; }
        public int IdCompany { get => idCompany; set => idCompany = value; }
    }
}
