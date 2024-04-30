using RMIPSS_Final_Project.JSON;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System;
using RMIPSS_Final_Project.Model;
using RMIPSS_Final_Project.Services;
using RMIPSS_Final_Project.Forms;

namespace RMIPSS_Final_Project.Controller
{
    internal class ReferralFormHandler
    {
        StudentMapper studentMapper = new StudentMapper();
        ParentGuardianMapper parentGuardianMapper = new ParentGuardianMapper();
        FormFactoryBean formFactory = new FormFactoryBean();

        public void saveReferralForm(String parameter)
        {
            Console.WriteLine("Parameter from saveReferralForm :::: " + parameter);

            studentMapper.saveStudentDetails(parameter);

            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            parentGuardianMapper.saveParentGuardianDetails(parameter);
        }

        public void getReferralForm() 
        {
            Form form = formFactory.getForm("Referral");
        }
    }
}
