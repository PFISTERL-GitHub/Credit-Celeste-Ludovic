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

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            // Globales unGlobal = new Globales();

            lblMonApplication.Text = Globales.nomUtilisateur;
            lblRegion.Text = Globales.region;

            Globales.uneConcession = new Concession("Garage Soares", "66 rue des Voyages");
            ajoutVendeur();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            //if(Globales.fenIntro == null)
            //{
            //}

            // creation et ouverture de Introduction
            Globales.fenIntro = new frmIntro();
            Globales.fenIntro.FormClosed += new FormClosedEventHandler(FenIntro_FormClosed);
            Globales.fenIntro.Show();

            this.Hide();
        }

        void FenIntro_FormClosed(object sender, FormClosedEventArgs e)  // que faire a la fermeture de Introduction
        {
            this.Show();
        }

        private void btnEtude_Click(object sender, EventArgs e)
        {

        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            // creation et ouverture de Introduction
            Globales.fenTestBDD = new frmTestBDD();
            Globales.fenTestBDD.FormClosed += new FormClosedEventHandler(FenIntro_FormClosed);
            Globales.fenTestBDD.Show();

            this.Hide();
        }

        private void ajoutVendeur()
        {
            using (SqlConnection connection = new SqlConnection(Globales.connectionString))
            {
                connection.Open();
                string query = "SELECT civV, nomV, prenomV FROM VENDEUR"; // Récupère uniquement les infos nécessaires

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Récupération des données et concaténation dans le format souhaité
                        string civV = reader.GetString(0);
                        string nomV = reader.GetString(1);
                        string prenomV = reader.GetString(2);

                        // Création du vendeur avec les données récupérées
                        Vendeur unVendeur = new Vendeur(civV, nomV, prenomV);

                        // Ajout du vendeur dans la concession
                        Globales.uneConcession.ajoutVendeur(unVendeur);
                    }
                }
            }
        }




    }
}
