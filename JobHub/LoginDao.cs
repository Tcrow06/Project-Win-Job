using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            where accountEmail = '{txtAcc}' AND accountPass = '{txtPass}'";
            DataTable dt = db.CheckExists(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                account.Id = int.Parse(row["idAccount"].ToString());
                account.Type = int.Parse(row["accountType"].ToString());
                account.Status = int.Parse(row["accountStatus"].ToString()) ;
                return account;
            }
            return null;
        }

    }
}
