using Newtonsoft.Json;
using RMIPSS_Final_Project.Forms;
using RMIPSS_Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMIPSS_Final_Project.Services
{
    internal class ReferralFormMapper
    {

        public Boolean mapDetails(String parameter)
        {
            ReferralForm referralForm = new ReferralForm();

            // Deserialize the JSON string into a dynamic object
            dynamic jsonObject = JsonConvert.DeserializeObject(parameter);

            Student student = new Student();
            student.LastName = jsonObject.lastName;
            student.FirstName = jsonObject.firstName;
            student.MiddleName = jsonObject.middleName;

            student.Village = jsonObject.village;
            student.Atoll = jsonObject.atoll;
            student.PoBoxNo = jsonObject.poBoxNo;

            student.Father = new ParentGuardian(jsonObject.fatherName.ToString(), jsonObject.primaryLanguageOfParentGuardian.ToString());
            student.Mother = new ParentGuardian(jsonObject.motherName.ToString(), jsonObject.primaryLanguageOfParentGuardian.ToString());
            student.Guardian = jsonObject.guardianName != null ? new ParentGuardian(jsonObject.guardianName.ToString(), jsonObject.primaryLanguageOfParentGuardian.ToString()) : null;

            student.PhoneNumber = jsonObject.phoneNumber;
            student.Email = jsonObject.email;
            student.Sex = student.parseSex(jsonObject.sex.ToString());
            student.Age = jsonObject.age;
            student.Dob = DateOnly.FromDateTime(DateTime.Parse(jsonObject.dob.ToString()));
            student.HospitalNumber = jsonObject.hospitalNumber;
            student.Ssn = jsonObject.ssn;
            student.Grade = jsonObject.grade;
            student.PrimaryLanguage = jsonObject.primaryLanguageOfStudent;

            referralForm.StudentObj = student;

            return referralForm.validate();
        }
    }
}
