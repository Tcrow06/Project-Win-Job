﻿using System;
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
        private string position;
        private string detail;
        private string requirement;
        private string benefit;
        private string category;
        public JobDetail()
        {

        }
        public JobDetail(int idJob, string nameJob, int idCompany, string salary, string position, 
            string detail, string requirement, string benefit, string category)
        {
            this.idJob = idJob;
            this.nameJob = nameJob;
            this.idCompany = idCompany;
            this.salary = salary;
            this.position = position;
            this.detail = detail;
            this.requirement = requirement;
            this.benefit = benefit;
            this.category = category;
        }

        public int IdJob { get => idJob; set => idJob = value; }
        public string NameJob { get => nameJob; set => nameJob = value; }
        public int IdCompany { get => idCompany; set => idCompany = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Detail { get => detail; set => detail = value; }
        public string Requirement { get => requirement; set => requirement = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public string Category { get => category; set => category = value; }
    }
}