using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JobHub
{
    internal class ConfirmCompanyAccount
    {
        ConfirmCompanyAccountDAO dao = new ConfirmCompanyAccountDAO();
        private CompanyDetail companyDetail = new CompanyDetail();
        Image companyImage = Properties.Resources.enterprise;
        Image file = Properties.Resources.checklist__1_;
        Image delete = Properties.Resources.detele;
        Image accpet = Properties.Resources.accept;
        public ConfirmCompanyAccount() { }

        public void LoadAllList(DataGridView dgv)
        {
            dgv.Rows.Clear();
            SqlDataReader dr =  dao.LoadAllList();
            while (dr.Read())
            {
                Company company = companyDetail.GetInfoCompanyDetail(dr);
                dgv.Rows.Add(companyImage, company.Name, file, accpet, delete,company.Id);
            }
        }

        public void Accept(int idCompany)
        {
            dao.Accept(idCompany);
        }
        public void NoAccept(int idCompany)
        {
            dao.NoAccept(idCompany);    
        }
        public void ShowBusinessLicense(int idCompany)
        {
            Company company = companyDetail.GetInfoCompanyDetail(idCompany);
            string imageName = company.BusinessLicense;
            FShowImage fShowImage = new FShowImage(imageName);
            fShowImage.ShowDialog();
        }

    }
}
