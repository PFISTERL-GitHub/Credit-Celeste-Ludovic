using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Concession
    {
        private string monNomConcession;
        private string monAdresseConcession;

        private string marque;
        private string modele;

        // Collection de vendeurs
        private List<Vendeur> lesVendeurs = new List<Vendeur>();
        private List<VoitureOccasion> lesVoituresOcas = new List<VoitureOccasion>();
        private List<VoitureOccasion> lesNumSeriesOcas = new List<VoitureOccasion>();


        private List<VoitureNeuve> lesVoituresNeuve = new List<VoitureNeuve>();
        private List<VoitureNeuve> lesNumSeriesNeuve = new List<VoitureNeuve>();


        public Concession() { }

        public Concession(string nomConcession, string adresseConcession)
        {
            monNomConcession = nomConcession;
            monAdresseConcession = adresseConcession;
        }




        public List<Vendeur> getLesVendeurs()
        {
            return lesVendeurs;
        }

        // ajouter un vendeur
        public void ajoutVendeur(Vendeur oVendeur)
        {
            lesVendeurs.Add(oVendeur);
        }

        public List<VoitureOccasion> GetVoitureOccasions()
        {
            return lesVoituresOcas;
        }


        public void ajoutVoiture(VoitureOccasion oVoiture)
        {
            lesVoituresOcas.Add(oVoiture);


        }



        public List<VoitureOccasion> GetNumSeriesOcas()
        {
            return lesNumSeriesOcas;
        }


        public void ajoutNumSeriesOcas(VoitureOccasion oNumeSeries)
        {
            lesNumSeriesOcas.Add(oNumeSeries);


        }

        // Voiture NEUVE


        public List<VoitureNeuve> GetVoitureNeuve()
        {
            return lesVoituresNeuve;
        }


        public void ajoutVoiture(VoitureNeuve oVoiture)
        {
            lesVoituresNeuve.Add(oVoiture);


        }



        public List<VoitureNeuve> GetNumSeriesNeuve()
        {
            return lesNumSeriesNeuve;
        }


        public void ajoutNumSeriesNeuve(VoitureNeuve oNumeSeries)
        {
            lesNumSeriesNeuve.Add(oNumeSeries);


        }


    }

}
