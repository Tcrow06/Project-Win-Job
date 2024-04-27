using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class EditNameDAO
    {
        public EditNameDAO() { }   
        DBConection db = new DBConection();
        public void UpdateCVName(string CVName, int idCV)
        {
            string sql = $@"update ImageCV set CVName = N'{CVName}' where idCV = {idCV}";
            db.ExcuteNoMess(sql);
        }

    }
}
