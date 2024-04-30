using RMIPSS_Final_Project.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMIPSS_Final_Project.Services
{
    internal class FormFactoryBean
    {
        Dictionary<String, Form> formMap = new Dictionary<String, Form>();

        public Form getForm(String name)
        {
            //formMap.Add(name, new ReferralForm());

            displayMap();

            Form form = null;

            if (formMap.ContainsKey(name))
            {
                form = formMap[name];
            }
            else
            {
                Console.WriteLine("NEW FORM CREATED");
                form = new ReferralForm();
                formMap.Add(name, form);
            }

            displayMap();

            return form;
        }

        public void displayMap()
        {
            foreach (var pair in formMap)
            {
                Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
            }
        }
    }
}
