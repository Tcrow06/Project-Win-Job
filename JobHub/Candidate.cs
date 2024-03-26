using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class Candidate
    {
        private int id; //Fk
        private string name;
        private string phone;
        private string email;
        private string gender;
        private string link;
        private DateTime birth;
        private string avatar;
        private string address;

        public Candidate() { }
        public Candidate(int id, string name, string phone, string email,
            string gender, string link, DateTime birth, string avatar, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Gender = gender;
            this.Link = link;
            this.Birth = birth;
            this.Avatar = avatar;
            this.Address = address;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Link { get => link; set => link = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Address { get => address; set => address = value; }
    }
}
