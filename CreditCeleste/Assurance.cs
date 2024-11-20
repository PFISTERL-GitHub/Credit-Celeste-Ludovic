using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Assurance
    {
        private string dateNaissance = "01/01/2005";
        private string datePermis = "01/01/2024";
        private string numImmat = "44458884AE";
        private string marque = "Peugeot";
        private string adrGarage = "4 rue Schoch";
        private string telGarage = "012456789";

        public Assurance()
        {

        }

        public Assurance(string dtN, string dtP)
        {
            dateNaissance = dtN;
            datePermis = dtP;
        }

        public Assurance(string dtN, string dtP, string numI, string mrq, string adrG, string telG)
        {
            dateNaissance = dtN;
            datePermis = dtP;
            numImmat = numI;
            marque = mrq;
            adrGarage = adrG;
            telGarage = telG;
        }

        public string getDateNaissance() { return dateNaissance; }
        public string getDatePermis() { return datePermis; }
        public string getNumImmat() { return numImmat; }
        public string getMarque() { return marque; }
        public string getAdrGarage() { return adrGarage; }
        public string getTelGarage() { return telGarage; }
    }
}
