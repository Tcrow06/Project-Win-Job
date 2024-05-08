using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class ReLoadFormCandidate
    {
        public ReLoadFormCandidate() { }
        private FormAndInfoCandidate Reload(FormAndInfoCandidate form, Fmain fm)
        {
            if (form.Form.Name == "FJobDetails")
            {
                FJobDetails fjd  =new FJobDetails(form.IdJob, form.IdCompany, fm);
                FormAndInfoCandidate f = new FormAndInfoCandidate(fjd , form.IdJob, form.IdCompany);
                return f;
            }
            else if(form.Form.Name == "FCompanyDetails")
            {
                FCompanyDetails fcd = new FCompanyDetails(form.IdCompany, fm);
                return new FormAndInfoCandidate(fcd, form.IdJob, form.IdCompany);
            }
            else if ( form.Form.Name == "FJob")
            {
                return form;
            }

            if(fm.Account!= null)
            {
                if (fm.Account.Type == 0)
                    return new FormAndInfoCandidate(new FCharts(fm), -1, -1);
                else
                    return new FormAndInfoCandidate(new FMainCompany(), -1, -1);
            }
            return new FormAndInfoCandidate(new FCharts(fm), -1, -1);
        }
        public FormAndInfoCandidate ReLoadLogin(Fmain fm)
        {
            FormAndInfoCandidate form = fm.Forms.Pop();
            fm.Forms.Push(form);
            return Reload(form,fm);
        }
        public FormAndInfoCandidate ReLoadBack(Fmain fm)
        {
            FormAndInfoCandidate form= fm.Forms.Peek();
            return Reload(form, fm);
        }

    }
}
