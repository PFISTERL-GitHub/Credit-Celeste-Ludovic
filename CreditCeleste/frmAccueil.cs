using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instancie une concession au chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccueil_Load(object sender, EventArgs e)
        {
            // Globales unGlobal = new Globales();

            lblMonApplication.Text = Globales.nomUtilisateur;
            lblRegion.Text = Globales.region;

            Globales.uneConcession = new Concession("Garage Soares", "66 rue des Voyages");
            ajoutVendeur();
        }

        /// <summary>
        /// Instancie et affiche fenIntroduction. Masque fenAccueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIntro_Click(object sender, EventArgs e)
        {
            Globales.fenIntro = new frmIntro();
            Globales.fenIntro.FormClosed += new FormClosedEventHandler(FenIntro_FormClosed);
            Globales.fenIntro.Show();

            this.Hide();
        }

        /// <summary>
        /// Affiche fenAccueil à la fermeture de fenIntro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FenIntro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnEtude_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Instancie et affiche fenTest. Masque fenAccueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            Globales.fenTestBDD = new frmTestBDD();
            Globales.fenTestBDD.FormClosed += new FormClosedEventHandler(FenIntro_FormClosed);
            Globales.fenTestBDD.Show();

            this.Hide();
        }

        private void ajoutVendeur()
        {
            // Récupère les données de la table Vendeur
            string query = "SELECT civV, nomV, prenomV FROM VENDEUR";

            // Utilisation de DatabaseManager pour exécuter la requête
            DataTable resultTable = Globales.dbManager.ExecuteReader(query);

            foreach (DataRow row in resultTable.Rows)
            {
                // Récupération des données et concaténation dans le format souhaité
                string civV = row["civV"].ToString();
                string nomV = row["nomV"].ToString();
                string prenomV = row["prenomV"].ToString();

                // Création du vendeur avec les données récupérées
                Vendeur unVendeur = new Vendeur(civV, nomV, prenomV);

                // Ajout du vendeur dans la concession
                Globales.uneConcession.ajoutVendeur(unVendeur);
            }
        }
    }
}