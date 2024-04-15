using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class Candidate
    {
        private int id; //Fk
        private string firstName;
        private string lastName;
        private string fullName;
        private string phone;
        private string email;
        private bool gender;
        private string link;
        private DateTime birth;
        private string avatar;
        private string address;
        private CandidateDao cdd = new CandidateDao();

        public Candidate() { }
       

        public int Id { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Link { get => link; set => link = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Address { get => address; set => address = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public Candidate(int id)
        {
            this.Id = id;
        }

        public Candidate(int id, string firstName, string lastName, string phone, string email, bool gender, string link, DateTime birth, string avatar, string address)
        {
            this.Id = id;
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            this.Email = email ?? throw new ArgumentNullException(nameof(email));
            this.Gender = gender;
            this.Link = link ?? throw new ArgumentNullException(nameof(link));
            this.Birth = birth;
            this.Avatar = avatar ?? throw new ArgumentNullException(nameof(avatar));
            this.Address = address ?? throw new ArgumentNullException(nameof(address));
        }

        public bool checkEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
            return regex.IsMatch(email);
        }

        public bool checkPhone(string phone)
        {
            Regex regex = new Regex(@"^\d{10}$");
            return regex.IsMatch(phone);
        }
        public Candidate(int id, string firstName, string lastName, string phone, string email, bool gender, DateTime birth, string address)
        {
            if(checkEmail(email) && checkPhone(phone) && firstName.Length > 0 && lastName.Length > 0
                && address.Length > 0)
            {
                this.Phone = phone ?? throw new ArgumentNullException(nameof(phone));
                this.Email = email ?? throw new ArgumentNullException(nameof(email));
                this.Id = id;
                this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
                this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
                this.Gender = gender;
                this.Birth = birth;
                this.Address = address ?? throw new ArgumentNullException(nameof(address));
            }
        }
        public Candidate GetInfoCandidate(Account account)
        {
            Candidate cd = new Candidate();
            SqlDataReader dr = cdd.GetInfoCandidate(account.Id);
            if (dr.Read())
            {
                cd.LastName = dr["candidateLastName"].ToString();
                cd.FirstName = dr["candidateFirstName"].ToString();
                cd.FullName = cd.LastName + " " + cd.FirstName; 

            }
            return cd;
        }
        public void ApplyJob(int idJob, int idCan, int idCv)
        {
            cdd.ApplyJob(idJob, idCan, idCv);
        }
        public void UnApplyJob(int idJob, int idCan, int idCv)
        {
            cdd.UnApplyJob(idJob, idCan, idCv);
        }
        public void SavedJob(int idJob, int idCan)
        {
            cdd.SavedJob(idJob, idCan);
        }
        public void UnSavedJob(int idJob, int idCan)
        {
            cdd.UnSavedJob(idJob, idCan);
        }

        public void FollowedCompany(int idCan, int idCompany)
        {
            cdd.FollowedCompany(idCan, idCompany);
        }
        public void UnFollowedCompany(int idCan, int idCompany)
        {
            cdd.UnFollowedCompany(idCan, idCompany);
        }
        public bool CheckSaveStatus(int idJob, int idCan)
        {
            return cdd.CheckSaveStatus(idJob,idCan);
        }
        public bool CheckApplyStatus(int idJob, int idCan)
        {
            return cdd.CheckApplyStatus(idJob, idCan);
        }
        public bool CheckFollowStatus(int idCompany, int idCan)
        {
            return cdd.CheckFollowStatus(idCompany, idCan);
        }


    }
}
