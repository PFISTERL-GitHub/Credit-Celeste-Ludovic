using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    static class Globales
    {
        // Variables globales de l'application
        public static string nomUtilisateur = "TLAD";
        public static string region = "Alsace";

        // Références des formulaires
        public static frmAccueil fenAccueil;
        public static frmIntro fenIntro;
        public static frmVoiture fenVoiture;
        public static frmVoitureOccasion fenVoitureOccasion;
        public static frmAssurance fenAssurance;
        public static frmTestBDD fenTestBDD;

        // Objets principaux
        public static Concession uneConcession;
        public static Client unClient;
        public static Voiture uneVoiture;
        public static VoitureOccasion uneVoitureOccasion;
        public static Assurance uneAssurance;

        // Autres variables globales
        public static string nomVendeur;
        public static string btnAgeCocher;
        public static string btnDureeCocher;

        // Chaîne de connexion à la base de données
        private static string connectionString =
            "Data Source=192.168.2.65; " +
            "Initial Catalog=CreditCelesteProjet; " +
            "User Id=cnxDaniels; " +
            "password=mdpDaniels@;";

        // Instance unique de DatabaseManager
        public static DatabaseManager dbManager =
            new DatabaseManager(connectionString);
    }
}