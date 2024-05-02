using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHub
{
    internal class DetailCV
    {
        private int id;
        private int idCandidate;
        private string jobName;
        private string firstName;
        private string lastName;
        private string CVAvatar = "";
        private string aboutMe;
        private string phoneNumber;
        private string email;
        private string address;
        private string skill;
        private string experience;
        private string education;

        public DetailCV(int id, int idCandidate, string jobName, string skill, string experience, string education)
        {
            this.Id = id;
            this.IdCandidate = idCandidate;
            this.JobName = jobName ?? throw new ArgumentNullException(nameof(jobName));
            this.Skill = skill ?? throw new ArgumentException(nameof(email));
            this.Experience = experience ?? throw new ArgumentException(nameof(experience));
            this.Education = education ?? throw new ArgumentNullException(nameof(education));
        }
        public DetailCV(int id, string jobName, string firstName, string lastName, string cVAvatar, string phoneNumber, string email, string address, string skill, string experience)
        {
            Id = id;
            JobName = jobName ?? throw new ArgumentNullException(nameof(jobName));
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            CVAvatar = cVAvatar ?? throw new ArgumentNullException(nameof(cVAvatar));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Skill = skill ?? throw new ArgumentNullException(nameof(skill));
            Experience = experience ?? throw new ArgumentNullException(nameof(experience));
        }

        public int Id { get => id; set => id = value; }
        public string JobName { get => jobName; set => jobName = value; }
        public string CVAvatar1 { get => CVAvatar; set => CVAvatar = value; }
        public string AboutMe { get => aboutMe; set => aboutMe = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Skill { get => skill; set => skill = value; }
        public string Experience { get => experience; set => experience = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int IdCandidate { get => idCandidate; set => idCandidate = value; }
        public string Education { get => education; set => education = value; }
    }
}
