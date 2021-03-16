using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientJson
{
    class Station
    {
        public int number { get; set; }
        public string contract_name { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public Position position { get; set; }
        public bool banking { get; set; }
        public bool bonus { get; set; }
        public int bike_stands { get; set; }
        public int available_bikes { get; set; }
        public string status { get; set; }
        //public int last_update { get; set; }

        public override string ToString()
        {
            string output = "Station:\n";
            output += "\tIdentifiant: " + number + "\n";
            output += "\tNom: " + name + "\n";
            output += "\tNom du contrat: " + contract_name + "\n";
            output += "\tAdresse: " + adress + "\n";
            output += "\tPosition: " + position + "\n";
            output += "\tSysteme de paiment: " + banking +"\n";
            output += "\tBonus: " + bonus + "\n";
            output += "\tNb de repose-velo: " + bike_stands + "\n";
            output += "\tNb de repose-velo disponible: " + available_bikes + "\n";
            output += "\tStatut: " + status + "\n";
            return output;
        }
    }
}
