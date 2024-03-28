using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    public class JobDetail
    {
        private int idJob;
        private string nameJob;
        private int idCompany;
        private string salary;
        private string address;
        private string description;
        private string experience;
        private string requirement;
        private string benefit;
        private string category;
        private DateTime postDate;
        private DateTime registerDead;
        public JobDetail()
        {

        }

        public JobDetail(int idJob, string nameJob, int idCompany, string salary,
            string address, string description, string experience, string requirement, string benefit, string category, DateTime postDate, DateTime registerDead)
        {
            this.idJob = idJob;
            this.nameJob = nameJob;
            this.idCompany = idCompany;
            this.salary = salary;
            this.address = address;
            this.description = description;
            this.experience = experience;
            this.requirement = requirement;
            this.benefit = benefit;
            this.category = category;
            this.PostDate = postDate;
            this.RegisterDead = registerDead;
        }

        public int IdJob { get => idJob; set => idJob = value; }
        public string NameJob { get => nameJob; set => nameJob = value; }
        public int IdCompany { get => idCompany; set => idCompany = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Address { get => address; set => address = value; }
        public string Description { get => description; set => description = value; }
        public string Requirement { get => requirement; set => requirement = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public string Category { get => category; set => category = value; }
        public string Experience { get => experience; set => experience = value; }
        public DateTime PostDate { get => postDate; set => postDate = value; }
        public DateTime RegisterDead { get => registerDead; set => registerDead = value; }
    }
}
