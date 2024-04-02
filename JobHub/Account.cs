using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class Account
    {
        private string user;
        private string pass;
        private int id;
        private int type;
        public Account() { }
        public Account(string user, string pass, int id, int type)
        {
            this.User = user;
            this.Pass = pass;
            this.Id = id;
            this.Type = type;
        }

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Id { get => id; set => id = value; }
        public int Type { get => type; set => type = value; }
    }
}
