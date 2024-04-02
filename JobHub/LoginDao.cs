using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class LoginDao
    {
        private DBConection db = new DBConection();
        private Account account= new Account();

        public LoginDao() { }
        public Account CheckAccount(string txtAcc, string txtPass)
        {
            string sql = $@"select * from Account
                            where account = '{txtAcc}' AND accountPass = '{txtPass}'";
            DataTable dt = db.CheckAcount(sql);
            if (dt.Rows.Count > 0)
            {
                account.Id = int.Parse(dt.Rows[0][2].ToString());
                account.Type = int.Parse(dt.Rows[0][3].ToString());
                return account;
            }
            else return null;
        }

    }
}
