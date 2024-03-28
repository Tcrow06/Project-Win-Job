using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class CompanyDetail
    {
        private int id;
        private string name;
        private string avatar;
        private string address;
        private string phone;
        private string description;
        private string email;
        private string link;
        private string size;
         


        public CompanyDetail()
        {
        }

        public CompanyDetail(int id, string nsame, string avatar, string address
            , string phone, string description, string email, string link, string size)
        {
            this.Id = id;
            this.Name = name;
            this.Avatar = avatar;
            this.Address = address;
            this.Phone = phone;
            this.Description = description;
            this.email = email;
            this.Link = link;
            this.Size = size;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Description { get => description; set => description = value; }
        public string Email { get => email; set => email = value; }
        public string Link { get => link; set => link = value; }
        public string Size { get => size; set => size = value; }
    }
}
