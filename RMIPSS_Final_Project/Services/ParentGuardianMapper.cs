using Newtonsoft.Json;
using RMIPSS_Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMIPSS_Final_Project.Services
{
    internal class ParentGuardianMapper
    {
        private List<ParentGuardian> parentguardianList = new List<ParentGuardian>();

        public void saveParentGuardianDetails(String parameter)
        {
            // Deserialize the JSON string into a dynamic object
            dynamic jsonObject = JsonConvert.DeserializeObject(parameter);

            ParentGuardian father = new ParentGuardian();
            father.FullName = jsonObject.fatherName;
            father.PrimaryLanguage = jsonObject.primaryLanguageOfParentGuardian;

            ParentGuardian mother = new ParentGuardian();
            mother.FullName = jsonObject.motherName;
            mother.PrimaryLanguage = jsonObject.primaryLanguageOfParentGuardian;

            father.save();
            mother.save();

            parentguardianList.Add(father);
            parentguardianList.Add(mother);
        }
    }
}
