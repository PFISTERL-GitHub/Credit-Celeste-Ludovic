using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Location
    {
        private string dateNaissance = "01/01/2005";
        private string datePermis = "01/01/2024";
        private string vhcLocation = "44458884AE";
        private string kilometrage = "100 000";
        private string adrGarage = "4 rue Schoch";
        private string telGarage = "012456789";
        private string rdDuree;

        public Location()
        {

        }

        public Location(string dtN, string dtP)
        {
            dateNaissance = dtN;
            datePermis = dtP;
        }

        public Location(string dtN, string dtP, string VHloc, string km, string adrG, string telG, string rdDuree)
        {
            dateNaissance = dtN;
            datePermis = dtP;
            vhcLocation = VHloc;
            kilometrage = km;
            adrGarage = adrG;
            telGarage = telG;

            this.rdDuree = rdDuree;
        }

        public string getDateNaissance() { return dateNaissance; }
        public string getDatePermis() { return datePermis; }
        public string getNomVehicule() { return vhcLocation; }
        public string getKilometrage() { return kilometrage; }
        public string getAdrGarage() { return adrGarage; }
        public string getTelGarage() { return telGarage; }
    }
}
