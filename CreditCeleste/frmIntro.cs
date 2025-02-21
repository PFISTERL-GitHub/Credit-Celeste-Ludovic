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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreditCeleste
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Au chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIntro_Load(object sender, EventArgs e)
        {
            // Recuperation des informations
            if (Globales.unClient != null)
            {
                // Récupération des éléments du client
                cboCiv.Text = Globales.unClient.getCivClient();
                txtNom.Text = Globales.unClient.getNomClient();
                txtPrenom.Text = Globales.unClient.getPrenomClient();
            }

            // TODO FAIRE AUSSI POUR ANCIEN VEHICULE 

            // Affiche nom vendeur dans le label
            lblVendeur.Text = Globales.nomVendeur;

            // Rajout des vendeurs au combobox
            foreach (Vendeur unVendeur in Globales.uneConcession.getLesVendeurs())
            {
                cboVendeur.Items.Add(unVendeur.getInfoVendeur());
            }

            // Desactive le bouton Valider
            btnValider.Enabled = false;
        }

        /// <summary>
        /// Enregistre la saisie du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // Sauvegarde les saisie dans des variables
            string civilite = cboCiv.Text;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;

            string vendeur = cboVendeur.Text;


            // Verification de la saisie
            if (verifierSaisie(civilite, nom, prenom, vendeur))
            {
                // Sauvegarde dans Globales
                Globales.unClient = new Client(civilite, nom, prenom);
                Globales.nomVendeur = vendeur;


                // Affiche nom vendeur
                lblVendeur.Text = vendeur;

                // Affiche un message
                string affichage =
                    "Client: " + civilite + " " + nom + " " + prenom + " " + Environment.NewLine +
                    "Vendeur: " + vendeur + Environment.NewLine;

                MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Active le bouton Valider
                btnValider.Enabled = true;
            }
        }

        /// <summary>
        /// Verifie la saisie du client
        /// </summary>
        /// <param name="civilite"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="vendeur"></param>
        /// <returns>Faux si une valeur n'est pas saisie, sinon vrai</returns>
        private bool verifierSaisie(string civilite, string nom, string prenom, string vendeur)
        {
            bool valeur = true;

            // Verifie les champs obligatoires
            if (string.IsNullOrWhiteSpace(civilite) || string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(vendeur))
            {
                // Affiche un message d'erreur
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valeur = false;
            }

            return valeur;
        }

        /// <summary>
        /// Instancie et affiche fenVoiture. Masque fenIntro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoiture_Click(object sender, EventArgs e)
        {
            Globales.fenVoiture = new frmVoiture();
            Globales.fenVoiture.FormClosed += new FormClosedEventHandler(FenVoiture_FormClosed);
            Globales.fenVoiture.Show();

            this.Hide(); // TODO vérifier l'ordre pour les fonctions Click : d'abord hide ou show ?
        }

        /// <summary>
        /// Affiche fenIntro à la fermeture de fenVoiture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FenVoiture_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Instancie et affiche fenVoitureOccasion. Masque fenIntro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoitureOccasion_Click(object sender, EventArgs e)
        {
            Globales.fenVoitureOccasion = new frmVoitureOccasion();
            Globales.fenVoitureOccasion.FormClosed += new FormClosedEventHandler(FenVoitureOccasion_FormClosed);
            Globales.fenVoitureOccasion.Show();

            this.Hide();
        }

        /// <summary>
        /// Affiche fenIntro à la fermeture de fenVoitureOccasion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FenVoitureOccasion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Instancie et affiche fenLocation. Masque fenIntro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Click(object sender, EventArgs e)
        {
            Globales.fenLocation = new frmLocation();
            Globales.fenLocation.FormClosed += new FormClosedEventHandler(FenLocation_FormClosed);
            Globales.fenLocation.Show();

            this.Hide();
        }

        /// <summary>
        /// Affiche fenIntro à la fermeture de fenLocation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FenLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Met à jour le nom du vendeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboVendeur_SelectedIndexChanged(object sender, EventArgs e) // A FAIRE AU PROPRE //
        {
            lblVendeur.Text = Globales.uneConcession.getLesVendeurs()[cboVendeur.SelectedIndex].getInfoVendeur(); // TODO CA PEUT ETRE SIMPLIFIER?
        }

        /// <summary>
        /// Se connecte à la base de données à la validation du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e) // TODO Fonction Valider, connexion à la BDD
        {
            CnxBDD();
        }

        /// <summary>
        /// Connexion à la base de données
        /// </summary>
        private void CnxBDD()
        {
            try
            {
                // Sauvegarde le texte saisi dans des variables
                string civiliteC = cboCiv.Text;
                string nomC = txtNom.Text;
                string prenomC = txtPrenom.Text;
                int numV = cboVendeur.SelectedIndex + 1;

                // Requête SQL pour insérer les données
                string query = "INSERT INTO CLIENT (civ, nom, prenom, numV) Values (@civC, @nomC, @prenomC, @numV) ";

                // Utilisation de DatabaseManager pour exécuter la requête
                Globales.dbManager.ExecuteQuery(query, cmd =>
                {
                    cmd.Parameters.Add(new SqlParameter("@civC", SqlDbType.NVarChar) { Value = civiliteC });
                    cmd.Parameters.Add(new SqlParameter("@nomC", SqlDbType.NVarChar) { Value = nomC });
                    cmd.Parameters.Add(new SqlParameter("@prenomC", SqlDbType.NVarChar) { Value = prenomC });
                    cmd.Parameters.Add(new SqlParameter("@numV", SqlDbType.Int) { Value = numV });
                });

                MessageBox.Show("Les données ont été enregistrées avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        /// <summary>
        /// Instancie et affiche fenLocation. Masque fenIntro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Click_1(object sender, EventArgs e)
        {
            Globales.fenLocation = new frmLocation();
            Globales.fenLocation.FormClosed += new FormClosedEventHandler(FenLocation_FormClosed);
            Globales.fenLocation.Show();

            this.Hide();
        }

        /// <summary>
        /// Fermer fenInfo au clic sur le bouton Retour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}