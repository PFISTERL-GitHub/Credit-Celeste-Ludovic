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
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        // Ce lance a l'ouverture du le page
        private void frmIntro_Load(object sender, EventArgs e) // FAIT AU PROPRE //
        {
            // Recuperation des informations
            if (Globales.unClient != null)
            {
                // récupération des éléments du client
                cboCiv.Text = Globales.unClient.getCivClient();
                txtNom.Text = Globales.unClient.getNomClient();
                txtPrenom.Text = Globales.unClient.getPrenomClient();
            }

            if (Globales.uneVoiture != null)
            {
                // récupération des éléments de voiture
                txtNouvVhc.Text = Globales.uneVoiture.getNomVehicule();
            }

            // FAIRE AUSSI POUR ANCIEN VEHICULE //

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

        // Fonction pour le bouton Enregistrer
        private void btnEnregistre_Click(object sender, EventArgs e) // FAIT AU PROPRE //
        {
            // Sauvegarde le texte saisi dans des variables
            string civilite = cboCiv.Text;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;

            string vendeur = cboVendeur.Text;

            string nouveauVehicule = txtNouvVhc.Text;
            string ancienVehicule = txtAncVhc.Text;

            // On verifie la saisie avant de continuer
            if (!verifierSaisie(civilite, nom, prenom, vendeur, nouveauVehicule, ancienVehicule))
            {
                // Si une des saisies est vide, on sort de la methode
                return;
            }

            // Sauvegarde dans Globales
            Globales.unClient = new Client(civilite, nom, prenom);

            Globales.nomVendeur = vendeur;

            // Création nouvelle voiture
            if (!string.IsNullOrEmpty(nouveauVehicule))
            {
                Globales.uneVoiture = new Voiture(nouveauVehicule, Globales.btnAgeCocher); // Globales.btnAgeCocher ???
            }
            else if (!string.IsNullOrEmpty(ancienVehicule))
            {
                Globales.uneVoiture = new Voiture(ancienVehicule, Globales.btnAgeCocher); // Globales.btnAgeCocher ???
            }

            // Affiche nom vendeur dans le label
            lblVendeur.Text = vendeur;

            // Affiche un message
            string affichage =
                "Client: " + civilite + " " + nom + " " + prenom + " " + Environment.NewLine +
                "Vendeur: " + vendeur + Environment.NewLine +
                "Nouveau Vehicule: " + nouveauVehicule + Environment.NewLine +
                "Ancien Vehicule: " + ancienVehicule;

            MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Active le bouton Valider
            btnValider.Enabled = true;
        }

        // Fonction pour vérifier si les saisies sont valides
        private bool verifierSaisie(string civilite, string nom, string prenom, string vendeur, string nouveauVehicule, string ancienVehicule) // FAIT AU PROPRE //
        {
            // Variable
            bool valeur = true;

            // A PATCH //
            // Verifie les champs obligatoires
            //if (verifChampsClients(civilite, nom, prenom, vendeur))
            //{
            //    // Affiche un message d'erreur
            //    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    // Retourne faux si une valeur est pas saisie
            //    valeur = false;
            //}
            //else if (verifChampsVoitures(nouveauVehicule, ancienVehicule))
            //{
            //    // Affiche un message d'erreur
            //    MessageBox.Show("Veuillez entrer un véhicule (nouveau ou ancien).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    // Retourne faux si une valeur est pas saisie
            //    valeur = false;
            //}

            // Retourne la Variable
            return valeur;
        }

        private bool verifChampsClients(string civilite, string nom, string prenom, string vendeur)
        {
            // Variable
            bool valeur = true;

            // Verifie les champs obligatoires
            if (string.IsNullOrWhiteSpace(civilite) || string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(vendeur))
            {
                // Retourne faux si une valeur est pas saisie
                valeur = false;
            }

            // Retourne la Variable
            return valeur;
        }

        private bool verifChampsVoitures(string nouveauVehicule, string ancienVehicule)
        {
            // Variable
            bool valeur = true;

            // Verifie les champs obligatoires
            if (string.IsNullOrWhiteSpace(nouveauVehicule) && string.IsNullOrWhiteSpace(ancienVehicule))
            {
                // Retourne faux si une valeur est pas saisie
                valeur = false;
            }

            // Retourne la Variable
            return valeur;
        }

        private void btnVoiture_Click(object sender, EventArgs e) // FAIT AU PROPRE //
        {
            // Creation d'une page VoitureNeuve
            Globales.fenVoiture = new frmVoiture();
            Globales.fenVoiture.FormClosed += new FormClosedEventHandler(FenVoiture_FormClosed);

            // Masquer Intro
            this.Hide();

            // Ouverture de la page VoitureNeuve
            Globales.fenVoiture.Show();
        }

        void FenVoiture_FormClosed(object sender, FormClosedEventArgs e) // FAIT AU PROPRE //
        {
            // Affiche intro a la fermeture de VoitureNeuve
            this.Show();
        }

        private void cboVendeur_SelectedIndexChanged(object sender, EventArgs e) // A FAIRE AU PROPRE //
        {
            // Que faire a la selection d'un item dans le combobox
            lblVendeur.Text = Globales.uneConcession.getLesVendeurs()[cboVendeur.SelectedIndex].getInfoVendeur(); // CA PEUT ETRE SIMPLIFIER?
        }


        //Fonction pour le bouton Valider
        private void btnValider_Click(object sender, EventArgs e) // A FAIRE //
        {
            CnxBDD();
        }


        //Fonction pour la connexion à la base de donnée
        private void CnxBDD()
        {
            try
            {
                // Sauvegarde le texte saisi dans des variables
                string civilite = cboCiv.Text;
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;

                string vendeur = cboVendeur.Text;

                string nouveauVehicule = txtNouvVhc.Text;
                string ancienVehicule = txtAncVhc.Text;

                // Requête SQL pour insérer les données
                string query = "INSERT INTO TEST (civ, nom, prenom, vendeur, anVhc, nvVhc) Values (@civ, @nom, @prenom, @vendeur, @nvvhc, @anvhc)";

                using (SqlConnection oConnexion = new SqlConnection(Globales.connectionString))
                {
                    oConnexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, oConnexion))
                    {

                        cmd.Parameters.Add(new SqlParameter("@civ", SqlDbType.NVarChar) { Value = civilite });
                        cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.NVarChar) { Value = nom });
                        cmd.Parameters.Add(new SqlParameter("@prenom", SqlDbType.NVarChar) { Value = prenom });
                        cmd.Parameters.Add(new SqlParameter("@vendeur", SqlDbType.NVarChar) { Value = vendeur });
                        cmd.Parameters.Add(new SqlParameter("@nvvhc", SqlDbType.NVarChar) { Value = nouveauVehicule });
                        cmd.Parameters.Add(new SqlParameter("@anvhc", SqlDbType.NVarChar) { Value = ancienVehicule });


                        //// Ajouter les paramètres avec les bons types
                        //if (verifChampsClients(civilite, nom, prenom, vendeur))
                        //{

                        //}
                        //else if (verifChampsVoitures(nouveauVehicule, ancienVehicule))
                        //{

                        //}

                        // Exécuter la commande
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Retour utilisateur
                        if (rowsAffected > 0) {
                            MessageBox.Show("Les données ont été enregistrées avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée n'a été enregistrée.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        //Fonction pour le bouton VoitureOccasion
        private void btnVoitureOccasion_Click(object sender, EventArgs e)
        {
            // Creation d'une page VoitureNeuve
            Globales.fenVoitureOccasion = new frmVoitureOccasion();
            Globales.fenVoitureOccasion.FormClosed += new FormClosedEventHandler(FenVoitureOccasion_FormClosed);

            // Masquer Intro
            this.Hide();

            // Ouverture de la page VoitureNeuve
            Globales.fenVoitureOccasion.Show();
        }

        // Que faire a la fermeture de VoitureOccasion
        void FenVoitureOccasion_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Afficher Intro si VoitureOccasion est fermée
            this.Show();
        }

        // Bouton Retour
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close(); // afficher Intro, retour en arrière, on affiche un écran à la fois 
        }
    }
}
