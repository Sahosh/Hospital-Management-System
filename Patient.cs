using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Patient
    {
        private string firstName;
        private string lastName;
        private string iD;
        private string emailAddress;
        private string password;
        private string mobileNo;
        private string bloodGroup;
        private DateTime dateOfBirth;
        private string sex;
        private string address;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ID { get => iD; set => iD = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Password { get => password; set => password = value; }
        public string MobileNo { get => mobileNo; set => mobileNo = value; }
        public string BloodGroup { get => bloodGroup; set => bloodGroup = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
    }
}
