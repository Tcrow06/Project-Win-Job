using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class Company : User
    {
        private CompanyDAO companyDAO = new CompanyDAO();
        private string name;
        private string leaderName;
        private string taxCode;
        private string description;
        private string size;
        private string businessLicense;
        private List<string> listCompanyImage;
        
        public Company()
        {

        }
        public Company(string email, string name, string leaderName, string businessLicense, string taxCode, string Address)
        {
            this.Email = email;
            this.Name = name;
            this.LeaderName = leaderName;
            this.BusinessLicense = businessLicense;
            this.TaxCode = taxCode;
            this.Address = Address;
        }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Size { get => size; set => size = value; }
        public List<string> ListCompanyImage { get => listCompanyImage; set => listCompanyImage = value; }
        public string LeaderName { get => leaderName; set => leaderName = value; }
        public string TaxCode { get => taxCode; set => taxCode = value; }
        public string BusinessLicense { get => businessLicense; set => businessLicense = value; }

        public bool CheckAllNotNull()
        {

            if (this.Email.Length > 0 && !checkEmail(this.Email))
            {
                MessageBox.Show("Sai định dạng email");
                return false;
            }
            else if (this.Name.Length == 0)
            {
                MessageBox.Show("Tên công ty không được để trống");
                return false;
            }
            else if (this.leaderName.Length == 0)
            {
                MessageBox.Show("Tên người lãnh đạo không được để trống");
                return false;
            }
            else if (this.businessLicense.Length == 0)
            {
                MessageBox.Show("Giaasy phép kinh doanh không được để trống");
                return false;
            }
            else if (this.businessLicense.Length == 0)
            {
                MessageBox.Show("Giấy phép kinh doanh không được để trống");
                return false;
            }
            else if (this.taxCode.Length == 0)
            {
                MessageBox.Show("Mã số thuế không được để trống");
                return false;
            }
            else if (this.Address.Length == 0)
            {
                MessageBox.Show("địa chỉ không được để trống");
                return false;
            }
            return true;
        }
        public void AddCompany()
        {
            companyDAO.AddCompany(this);
        }
    }
    
}
