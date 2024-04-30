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
        ReferralFormMapper referralFormMapper = new ReferralFormMapper();

        public void saveReferralForm(String parameter)
        {
            Console.WriteLine("Parameter from saveReferralForm :::: " + parameter);

            if (referralFormMapper.mapDetails(parameter))
            {
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

                studentMapper.saveStudentDetails(parameter);

                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

                parentGuardianMapper.saveParentGuardianDetails(parameter);
            } else
            {
                Console.WriteLine(":::::::::::::::::::::::::::::::VALIDATION FAILED::::::::::");
            }

            
        }

        public void getReferralForm() 
        {
            Form form = formFactory.getForm("Referral");
        }
    }
}
