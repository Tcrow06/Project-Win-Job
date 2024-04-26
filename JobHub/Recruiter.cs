using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class Recruiter
    {
        public void Register(Company company, Account account, FRecruiter fRecruiter, string confirmPassword)
        {
            if (company.CheckAllNotNull() && account.CheckAllNotNull())
            {
                if (!account.CheckEmailExists(account.Email))
                {
                    if (account.Pass == confirmPassword)
                    {
                        account.AddAcount();
                        company.Id = account.Id;
                        company.AddCompany();
                        fRecruiter.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email này đã tồn tại");
                }
            }

        }
       




    }
}
