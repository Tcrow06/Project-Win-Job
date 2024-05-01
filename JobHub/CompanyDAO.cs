using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class CompanyDAO
    {
        DBConection db = new DBConection();
        public void AddCompany(Company company)
        {
            string sql = string.Format($@"insert into Company(idCompany,companyEmail,companyName,companyBusinessLicense
                                            ,companyTaxCode, companyAddress,companyLeaderName ) values(
                                       {company.Id},'{company.Email}',N'{company.Name}',N'{company.BusinessLicense}',
                                       '{company.TaxCode}',N'{company.Address}',N'{company.LeaderName}')");

            db.ExcuteNoMess(sql);
        }
        public void FollowCV(int idCompany, int idCV, int CVType)
        {
            string sql = string.Format($@"insert into FollowedCV(idCompany, idCV, CVType) values ( {idCompany},{idCV},{CVType})");
            db.ThucThi(sql);
        }
        public void UnFollowCV(int idCV, int CVType)
        {
            string sql = string.Format($@"delete from FollowedCV where idCV = {idCV} and CVType = {CVType}");
            db.ThucThi(sql);
        }



    }
}
