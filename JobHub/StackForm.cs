using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class StackForm
    {
        Stack<AccountAndForm> accounts;

        public StackForm(Stack<AccountAndForm> accounts)
        {
            this.Accounts = accounts;
        }

        public Stack<AccountAndForm> Accounts { get => accounts; set => accounts = value; }
        

        public void LoadForm()
        {
            for(int i= Accounts.Count-1; i>0; i--)
            {
               AccountAndForm fjp = accounts.Pop();
               fjp.Form.ReLoadForm(fjp.Account);
               accounts.Push(fjp);
            }
        }
    }
}
