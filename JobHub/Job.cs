using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    class Job
    {
        private string nameJob;
        private int idCompany;
        private string salary;
        private string position;
        private string detail;
        private string requirement;
        private string benefit;
        private string category;

        public Job()
        {

        }


        public Job(string _nameJob,int _idCompany,string _salary,string _position,string _detail,string _requirement,string _benefit,string _category)
        {
            NameJob = _nameJob;
            IDCompany = _idCompany;
            Salary = _salary;
            Position = _position;
            Detail = _detail;
            Requirement = _requirement;
            Benefit = _benefit;
            Category = _category;
        }

        public string NameJob
        {
            get { return nameJob; }
            set { nameJob = value; }
        }
        public int IDCompany
        {
            get { return idCompany; }
            set { idCompany = value; }
        }

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        public string Requirement
        {
            get { return requirement; }
            set { requirement = value; }
        }

        public string Benefit
        {
            get { return benefit; }
            set { benefit = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}
