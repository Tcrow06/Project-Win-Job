using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class EditCompanyDao
    {
        DBConection db = new DBConection();
        public void AddCompany(EditCompany company)
        {
            string sql = $@"UPDATE Company
                                        SET companyPhone='{company.Phone}',companyDescription=N'{company.Description}',companyLink='{company.Link}',companySize='{company.Size}'
                                            WHERE idCompany={company.ID}";

            db.ExcuteNoMess(sql);
        }

        public void AddImage(EditCompany company)
        {
            string sql = $@"UPDATE Company
                          SET companyImagePath = N'{company.ListCompanyImage}' WHERE idCompany={company.ID} ";

            db.ExcuteNoMess(sql);
        }

        public void AddOtherImage(EditCompany company)
        {
            string sql = $@"UPDATE Company
                          SET companyImagePath = companyImagePath + ' + ' + N'{company.ListCompanyImage}' WHERE idCompany={company.ID} ";

            db.ExcuteNoMess(sql);
        }

        public void AddAvatar(EditCompany company)
        {
            string sql = $@"UPDATE Company
                          SET companyAvatar =  N'{company.Avatar}' WHERE idCompany={company.ID} ";

            db.ExcuteNoMess(sql);
        }

        public void DeleteImage(EditCompany company)
        {
            string sql = $@"UPDATE Company
                            SET companyImagePath=REPLACE(companyImagePath,N'{company.ListCompanyImage} +',N'')
                                WHERE idCompany={company.ID} ";

            db.ExcuteNoMess(sql);
        }

        public void DeleteOtherImage(EditCompany company)
        {
            string sql = $@"UPDATE Company
                            SET companyImagePath=REPLACE(companyImagePath,N'+ {company.ListCompanyImage}',N'')
                                WHERE idCompany={company.ID} ";

            db.ExcuteNoMess(sql);
        }

        public void DeleteOnlyImage(EditCompany company)
        {
            string sql = $@"UPDATE Company
                            SET companyImagePath=REPLACE(companyImagePath,N'{company.ListCompanyImage}',N'')
                                WHERE idCompany={company.ID} ";

            db.ExcuteNoMess(sql);
        }


    }
}
