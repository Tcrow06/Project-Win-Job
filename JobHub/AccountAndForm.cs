using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class AccountAndForm
    {
        private FJobParent form;
        private Account account;

        public AccountAndForm() { }
        public AccountAndForm(FJobParent form, Account account)
        {
            this.Form = form;
            this.Account = account;
        }

        public FJobParent Form { get => form; set => form = value; }
        public Account Account { get => account; set => account = value; }
    }
}
