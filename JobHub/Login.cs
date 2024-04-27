using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class Login
    {
        private LoginDao ld = new LoginDao();
        public Login() { }

        public bool CheckAccount(string txtAcc, string txtPass, Fmain fm)
        {
            fm.Account = ld.CheckAccount(txtAcc, txtPass);
            if (fm.Account == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(fm.Account.Type==1 &&  fm.Account.Status==0) {
                MessageBox.Show("Tài khoản theo diện công ty chưa được phía JobHub xác nhận! Vui lòng quay lại sau.", "Thông báo"
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fm.Account= null;
                return false;
            }else if(fm.Account.Type == 2)
            {
                FConfirmCompanyAccount fConfirmCompanyAccount = new FConfirmCompanyAccount();
                fConfirmCompanyAccount.ShowDialog();
                fm.Account = null;
                return false;
            }
            return true;
        }
        public void Register(Candidate can, Account account, FLogin log, string confirmPassword)
        {
            if (can.CheckAllNotNull() && account.CheckAllNotNull())
            {
                if (!account.CheckEmailExists(account.Email))
                {
                    if (account.Pass == confirmPassword)
                    {
                            account.AddAcount();
                            can.InsertInfoRegister(account);
                            can.AddCandidate();
                            log.pnRegister.Visible = false;
                            log.pnLogin.Visible = true;
                            log.pnLogin.BringToFront();
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
