namespace CreditCeleste
{
    static class Globales   // pas la peine de faire un new, classe statique
    {
        // DTLA = Daniels, Thierry, Ludo, Alexandru

        // public string nomUtilisateur = "DTLA";      // un seul ;    attribut de l'objet

        // utilisateur et region
        public static string nomUtilisateur = "TLAD";   // un seul ;    attribut de classe
        public static string region = "Alsace";
        public static string Version = "V2.0.1-Beta";

        // forms
        public static frmAccueil fenAccueil;
        public static frmIntro fenIntro;
        public static frmVoitureNeuve fenVoiture;
        public static frmVoitureOccasion fenVoitureOccasion;
        public static frmAssurance fenAssurance;
        public static frmTestBDD fenTestBDD;

        // autre
        public static Concession uneConcession;
        public static Client unClient;
        public static Voiture uneVoiture;
        public static VoitureOccasion uneVoitureOccasion;
        public static VoitureNeuve uneVoitureNeuve;
        public static Assurance uneAssurance;

        public static string nomVendeur;
        public static string nomClient;
        public static int IdClient;
        public static string btnAgeCocher;
        public static string btnDureeCocher;
        public static string connectionString = "Data Source=192.168.1.13; Initial Catalog=CreditCelesteProjet; User Id=cnxDaniels; password=mdpDaniels@;";

    }
}
