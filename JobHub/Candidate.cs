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
    public class Candidate : User
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
        private CandidateDAO cdd = new CandidateDAO();

        public Candidate() { }
      
        public bool Gender { get => gender; set => gender = value; }
        public DateTime Birth { get => birth; set => birth = value; }
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
        public Candidate(string firstName, string lastName, string email)
        {
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.Email = email ?? throw new ArgumentNullException(nameof(email));
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

        public Candidate(int id, string firstName, string lastName, string phone, string email, bool gender, DateTime birth, string address, string avatar)
        {
            if (checkEmail(email) && checkPhone(phone) && firstName.Length > 0 && lastName.Length > 0
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
                this.Avatar = avatar;
            }
        }

        public Candidate GetInfoCandidate(int idCandidate)
        {
            Candidate cd = new Candidate();
            SqlDataReader dr = cdd.GetInfoCandidate(idCandidate);
            try
            {
                if (dr.Read())
                {
                    cd.LastName = dr["candidateLastName"].ToString();
                    cd.FirstName = dr["candidateFirstName"].ToString();
                    cd.FullName = cd.LastName + " " + cd.FirstName;
                    cd.Avatar = dr["candidateAvatar"] != DBNull.Value && dr["candidateAvatar"].ToString().Length > 0 ? dr["candidateAvatar"].ToString() : "user.png";
                    cd.Email = dr["candidateEmail"].ToString();
                    cd.Address = dr["candidateAddress"].ToString();
                }
            }
            catch { }
            return cd;
        }
        public bool CheckAllNotNull()
        {
            if(this.Email.Length > 0&&!checkEmail(this.Email)) {
                MessageBox.Show("Sai định dạng email");
                return false;
            }
            else if (this.lastName.Length == 0)
            {
                MessageBox.Show("Họ không được để trống");
                return false;
            }
            else if (this.firstName.Length == 0)
            {
                MessageBox.Show("Tên không được để trống");
                return false;
            }
            return true;
        }
        public void AddCandidate()
        {
            cdd.AddCandidate(this);
        }
        public void InsertInfoRegister( Account account)
        {
            this.Email= account.Email;
            this.Id = account.Id;   
        }
        public void ApplyJob(int idJob, int idCan, int idCv)
        {
            cdd.ApplyJob(idJob, idCan, idCv);
        }
        public void UnApplyJob(int idJob, int idCan)
        {
            cdd.UnApplyJob(idJob, idCan);
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
