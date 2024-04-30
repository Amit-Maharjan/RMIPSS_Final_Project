using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMIPSS_Final_Project.Model
{
    internal class ParentGuardian
    {
        private String fullName;
        private String primaryLanguage;

        public ParentGuardian()
        {
        }

        public ParentGuardian(String fullName, String primaryLanguage)
        {
            this.FullName = fullName;
            this.PrimaryLanguage = primaryLanguage;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string PrimaryLanguage { get => primaryLanguage; set => primaryLanguage = value; }

        public void save()
        {
            Console.WriteLine("Parent Guardian Details: " + JsonConvert.SerializeObject(this));
        }
    }
}
