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
                                            ,companyTaxCode, companyAddress ) values(
                                       {company.Id},'{company.Email}',N'{company.Name}',N'{company.BusinessLicense}',
                                       '{company.TaxCode}',N'{company.Address}')");

            db.ExcuteNoMess(sql);
        }


    }
}
