using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobHub
{
    public class User
    {
        private int id;
        private string email;
        private string phone;
        private string avatar;
        private string link;
        private string address;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Link { get => link; set => link = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Address { get => address; set => address = value; }

        public bool checkEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
            return regex.IsMatch(email);
        }
    }
}
