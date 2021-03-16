using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientJson
{
    class Contract
    {
        public string name { get; set; }
        public string commercial_name { get; set; }
        public string[] cities { get; set; }
        public string country_code { get; set; }
        override public string ToString()
        {
            string output = "Contrat:\n";
            output += "\tNom : " + name + "\n";
            output += "\tNom commercial: " + commercial_name + "\n";
            if (cities != null)
            {
                output += "\tVilles cible:\n";
                foreach (var item in cities)
                    output += "\t\t- " + item + "\n";
            }
            output += "Code du pays: " + country_code + "\n";
            return output;
        }
    }
}
