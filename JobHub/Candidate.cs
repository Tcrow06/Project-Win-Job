using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    public class Candidate
    {
        private int id; //Fk
        private string lastName;
        private string firstName;
        private string fullName;
        private string phone;
        private string email;
        private string gender;
        private string link;
        private DateTime birth;
        private string avatar;
        private string address;
        private CandidateDao cdd = new CandidateDao();

        public Candidate() { }
        public Candidate(int id, string first,string lastName, string phone, string email,
            string gender, string link, DateTime birth, string avatar, string address)
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Phone = phone;
            this.Email = email;
            this.Gender = gender;
            this.Link = link;
            this.Birth = birth;
            this.Avatar = avatar;
            this.Address = address;
        }

        public int Id { get => id; set => id = value; }
        //blic string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Link { get => link; set => link = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Address { get => address; set => address = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public Candidate(int id)
        {
            this.Id = id;
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
