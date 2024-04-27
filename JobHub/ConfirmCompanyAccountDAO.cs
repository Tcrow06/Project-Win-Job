using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class ConfirmCompanyAccountDAO
    {
        DBConection db = new DBConection();
        public ConfirmCompanyAccountDAO() { }

        public void Accept(int idCompany)
        {
            string sql = $@"update Account set accountStatus = 1 
                            where idAccount = {idCompany}";
            db.ThucThi(sql);
        }
        public void NoAccept(int idCompany)
        {
            string sql = $@"delete from Account
                            where idAccount ={idCompany}";
            string sql_1 = $@"delete from Company
                            where idCompany ={idCompany}";
            db.ThucThi(sql);
            db.ExcuteNoMess(sql_1);   
        }
        public SqlDataReader LoadAllList()
        {
            string sql = $@"select * from Company join Account on Company.idCompany = Account.idAccount
                            where Account.accountType = 1 and Account.accountStatus = 0 ";
            return db.loadData(sql);
        }
    }
}
