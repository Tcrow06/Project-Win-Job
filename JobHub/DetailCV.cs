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
        private string jobName;
        private string nameUser;
        private string CVAvatar;
        private string aboutMe;
        private string phoneNumber;
        private string email;
        private string address;
        private string education;
        private string skill;
        private string experience;

        public DetailCV(int id, string jobName, string nameUser, string cVAvatar, string aboutMe, string phoneNumber, string email, string address, string education, string skill, string experience)
        {
            Id = id;
            JobName = jobName ?? throw new ArgumentNullException(nameof(jobName));
            NameUser = nameUser ?? throw new ArgumentNullException(nameof(nameUser));
            CVAvatar = cVAvatar ?? throw new ArgumentNullException(nameof(cVAvatar));
            AboutMe = aboutMe ?? throw new ArgumentNullException(nameof(aboutMe));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Education = education ?? throw new ArgumentNullException(nameof(education));
            Skill = skill ?? throw new ArgumentNullException(nameof(skill));
            Experience = experience ?? throw new ArgumentNullException(nameof(experience));
        }

        public DetailCV(int id, string jobName, string nameUser, string aboutMe)
        {
            this.Id = id;
            this.JobName = jobName ?? throw new ArgumentNullException(nameof(jobName));
            this.NameUser = nameUser ?? throw new ArgumentNullException(nameof(nameUser));
            this.AboutMe = aboutMe ?? throw new ArgumentNullException(nameof(aboutMe));
        }

        public int Id { get => id; set => id = value; }
        public string JobName { get => jobName; set => jobName = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string CVAvatar1 { get => CVAvatar; set => CVAvatar = value; }
        public string AboutMe { get => aboutMe; set => aboutMe = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Education { get => education; set => education = value; }
        public string Skill { get => skill; set => skill = value; }
        public string Experience { get => experience; set => experience = value; }
    }
}
