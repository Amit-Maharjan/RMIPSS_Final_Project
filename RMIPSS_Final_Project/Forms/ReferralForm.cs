using RMIPSS_Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMIPSS_Final_Project.Forms
{
    internal class ReferralForm: Form
    {
        private int type = 1;
        private String status;

        private Student studentObj;

        internal Student StudentObj { get => studentObj; set => studentObj = value; }

        public Boolean validate()
        {
            Boolean result = isValid(StudentObj.LastName);
            result = result && isValid(StudentObj.FirstName);
            result = result && isValid(StudentObj.Village);
            result = result && isValid(StudentObj.Atoll);
            result = result && isValid(StudentObj.PoBoxNo);
            result = result && isValid(StudentObj.Father);
            result = result && isValid(StudentObj.Mother);
            result = result && isValid(StudentObj.PhoneNumber);
            result = result && isValid(StudentObj.Email);
            result = result && isValid(StudentObj.Sex);
            result = result && isValid(StudentObj.Age);
            result = result && isValid(StudentObj.Dob);
            result = result && isValid(StudentObj.HospitalNumber);
            result = result && isValid(StudentObj.Ssn);
            result = result && isValid(StudentObj.Grade);
            result = result && isValid(StudentObj.PrimaryLanguage);

            return result;
        }

        private Boolean isValid(Object property)
        {
            return property != null;
        }
    }
}
