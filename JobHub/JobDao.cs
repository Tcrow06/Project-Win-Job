using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    class JobDao
    {
        DBConection dbc = new DBConection();

        public void Them(Job A)
        {
            string sqlStr = string.Format("INSERT INTO Job(nameJob,idCompany,salary,position,dentail,requirement,benefit,category) VALUES (N'{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", A.NameJob, 1, A.Salary,A.Position, A.Detail, A.Requirement, A.Benefit, A.Category);
            dbc.ThucThi(sqlStr);
        }

    }
}
