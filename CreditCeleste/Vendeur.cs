using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Vendeur
    {
        private string monCcivVendeur; // Mme, Mlle, M.
        private string monNomVendeur;
        private string monPrenomVendeur;

        public Vendeur() { }

        public Vendeur(string CcivVendeur, string nomVendeur, string prenomVendeur)
        {
            monCcivVendeur = CcivVendeur;
            monNomVendeur = nomVendeur;
            monPrenomVendeur = prenomVendeur;
        }

        public string getInfoVendeur()
        {
            return monCcivVendeur + " " + monNomVendeur + " " + monPrenomVendeur;
        }

      
    }
}
