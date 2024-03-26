using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class CandidateDao
    {
        private DBConection db = new DBConection();
        public CandidateDao() { }
        
        public void Apply(int idJob, int idCan, int idCv)
        {
            string sql = string.Format($"insert into CVApplied(idJob, idCan, idCV) values ({idJob}, {idCan}, {idCv})"); 
            db.ThucThi(sql);
        }

    }
}
