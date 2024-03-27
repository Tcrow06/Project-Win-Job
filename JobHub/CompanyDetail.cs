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
        private string description;
        private string address;
        private string link;
        private string size;

        public CompanyDetail()
        {
        }

        public CompanyDetail(int id, string name, string description, string address, string link, string size)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.address = address;
            this.link = link;
            this.size = size;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Address { get => address; set => address = value; }
        public string Link { get => link; set => link = value; }
        public string Size { get => size; set => size = value; }
    }
}
