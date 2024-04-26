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
    public class Account
    {
        private AccountDao accountDao = new AccountDao();
        private Candidate myCandidate;
        //private Candidate myCandidate1;
        private string email;
        private string pass;
        private int id;
        private int type;

        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Id { get => id; set => id = value; }
        public int Type { get => type; set => type = value; }
        public Candidate MyCandidate { get => myCandidate; set => myCandidate = value; }

        public Account() { }
        public Account(string email, string pass, int id, int type)
        {
            this.Email = email;
            this.Pass = pass;
            this.Id = id;
            this.Type = type;
            
        }
        public Account(string email, string pass, Candidate candidate)
        {
            this.Email = email;
            this.Pass = pass;
            this.MyCandidate = candidate;
            this.Type = 0;
        }

        public Account(string email, string pass)
        {
            this.Email = email;
            this.Pass = pass;
        }


        public bool CheckEmailExists(string email)
        {
            DataTable dt = accountDao.CheckEmailExists(email);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void AddAcount()
        {
            accountDao.AddAcount(this);

        }
        public bool CheckAllNotNull()
        {
            if (this.email.Length == 0)
            {
                MessageBox.Show("Email không được để trống");
                return false;

            }else if(this.pass.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return false;
            }
            return true;
        }
    }
}
