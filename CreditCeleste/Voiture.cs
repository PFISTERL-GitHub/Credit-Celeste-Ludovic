
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    class Voiture
    {
        private string nouveauVhc = "PG 208";
        private string date1ereImmat = "17/07/2005";
        private string numImmat = "44458884AE";
        private string numSerie = "12345777";
        private string puissance = "17ch";
        private string rdAge;

        public Voiture()
        {

        }

        public Voiture(string nvVH, string rdAge)
        {
            nouveauVhc = nvVH;

            this.rdAge = rdAge;
        }

        public Voiture(string nvVH, string date1Immat, string numI, string numS, string xPuissance, string rdAge)
        {
            nouveauVhc = nvVH;
            date1ereImmat = date1Immat;
            numImmat = numI;
            numSerie = numS;
            puissance = xPuissance;

            this.rdAge = rdAge;
        }

        public string getNomVehicule() { return nouveauVhc; }  
        public string getDate1ereImmat() { return date1ereImmat; }
        public string getNumImmat() { return numImmat; }
        public string getnumSerie() { return numSerie; }
        public string getPuissance() { return puissance; }
        public string getrdAge() { return rdAge; }
    }
}
