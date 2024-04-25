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

/*        private string name;
        private string gmail;
        private string password;
        private string repeatPassword;*/
        public Login() { }
/*        public Login(string name, string gmail, string password, string repeatPassword)
        {
            this.name = name;
            this.gmail = gmail;
            this.password = password;
            this.repeatPassword = repeatPassword;
        }*/
/*        public string Name { get => name; set => name = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string Password { get => password; set => password = value; }
        public string RepeatPassword { get => repeatPassword; set => repeatPassword = value; }*/

        public bool CheckAccount(string txtAcc, string txtPass, Fmain fm)
        {
            fm.Account = ld.CheckAccount(txtAcc, txtPass);
            if (fm.Account == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void Register(Candidate can, Account account, FLogin log)
        {
            if (can.CheckAllNotNull() && account.CheckAllNotNull())
            {
                if (!account.CheckEmailExists(account.Email))
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
                    MessageBox.Show("Email này đã tồn tại");
                }
            }

        }
    }
}
