using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMIPSS_Final_Project.Model
{
    internal class Student
    {
        private String lastName;
        private String firstName;
        private String middleName;

        private String village;
        private String atoll;
        private String poBoxNo;

        private ParentGuardian father;
        private ParentGuardian mother;
        private ParentGuardian guardian;

        private String phoneNumber;
        private String email;
        private Gender sex;
        private int age;
        private DateOnly dob;
        private String hospitalNumber;
        private String ssn;
        private String grade;
        private String primaryLanguage;

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string Village { get => village; set => village = value; }
        public string Atoll { get => atoll; set => atoll = value; }
        public string PoBoxNo { get => poBoxNo; set => poBoxNo = value; }
        internal ParentGuardian Father { get => father; set => father = value; }
        internal ParentGuardian Mother { get => mother; set => mother = value; }
        internal ParentGuardian Guardian { get => guardian; set => guardian = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        internal Gender Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public DateOnly Dob { get => dob; set => dob = value; }
        public string HospitalNumber { get => hospitalNumber; set => hospitalNumber = value; }
        public string Ssn { get => ssn; set => ssn = value; }
        public string Grade { get => grade; set => grade = value; }
        public string PrimaryLanguage { get => primaryLanguage; set => primaryLanguage = value; }

        public enum Gender
        {
            Male,
            Female,
            Other
        }

        public Gender parseSex(String stringValue)
        {
            if (Enum.TryParse<Gender>(stringValue, true, out sex))
            {
                return sex;
            }
            else
            {
                Console.WriteLine("ERROR: Failed to parse gender.");
                return Gender.Other;
            }
        }

        public void save()
        {
            Console.WriteLine("Student Details:" + JsonConvert.SerializeObject(this));
            Console.WriteLine("Gender: " + sex.ToString());
            father.save();
            mother.save();
            if(guardian != null) guardian.save();
        }
    }
}
