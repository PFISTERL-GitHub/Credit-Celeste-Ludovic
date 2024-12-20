﻿using System;
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

        // Ce lance a l'ouverture du le page
        private void frmIntro_Load(object sender, EventArgs e)
        {
            // Recuperation des informations
            if (Globales.unClient != null)
            {
                // récupération des éléments du client
                cboCiv.Text = Globales.unClient.getCivClient();
                txtNom.Text = Globales.unClient.getNomClient();
                txtPrenom.Text = Globales.unClient.getPrenomClient();
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
        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // Sauvegarde les saisie dans des variables
            string civilite = cboCiv.Text;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;

            string vendeur = cboVendeur.Text;


            // Verification de la saisie
            if (verifierSaisie(civilite, nom, prenom, vendeur ))
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

        // Fonction pour vérifier si les saisies sont valides
        private bool verifierSaisie(string civilite, string nom, string prenom, string vendeur)
        {
            // Variable
            bool valeur = true;

            // Verifie les champs obligatoires
            if (string.IsNullOrWhiteSpace(civilite) || string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(vendeur))
            {
                // Affiche un message d'erreur
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valeur = false; // Retourne faux si une valeur n'est pas saisie
            }

            // Retourne la Variable
            return valeur;
        }

        // Fonction pour le bouton Voiture
        private void btnVoiture_Click(object sender, EventArgs e)
        {
            // Creation d'une page VoitureNeuve
            Globales.fenVoiture = new frmVoiture();
            Globales.fenVoiture.FormClosed += new FormClosedEventHandler(FenVoiture_FormClosed);

            // Masquer Intro
            this.Hide();

            // Ouverture de la page VoitureNeuve
            Globales.fenVoiture.Show();
        }

        // Que faire a la fermeture de Voiture
        void FenVoiture_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Affiche Intro a la fermeture de VoitureNeuve
            this.Show();
        }

        //Fonction pour le bouton VoitureOccasion
        private void btnVoitureOccasion_Click(object sender, EventArgs e)
        {
            // Creation d'une page VoitureNeuve
            Globales.fenVoitureOccasion = new frmVoitureOccasion();
            Globales.fenVoitureOccasion.FormClosed += new FormClosedEventHandler(FenVoitureOccasion_FormClosed);

            // Masque Intro
            this.Hide();

            // Ouverture de la page VoitureNeuve
            Globales.fenVoitureOccasion.Show();
        }

        // Que faire a la fermeture de VoitureOccasion
        void FenVoitureOccasion_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Affiche Intro a la fermeture de VoitureOccasion
            this.Show();
        }

        //Fonction pour le bouton Location
        private void btnLocation_Click(object sender, EventArgs e)
        {
            // Creation d'une page Location
            Globales.fenLocation = new frmLocation();
            Globales.fenLocation.FormClosed += new FormClosedEventHandler(FenLocation_FormClosed);

            // Masque Intro
            this.Hide();

            // Ouverture de la page Location
            Globales.fenLocation.Show();
        }

        // Que faire a la fermeture de Location
        void FenLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Affiche Intro a la fermeture de Location
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
                
        // Bouton Retour
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close(); // afficher Intro, retour en arrière, on affiche un écran à la fois 
        }

        private void btnLocation_Click_1(object sender, EventArgs e)
        {
            // Creation d'une page Location
            Globales.fenLocation = new frmLocation();
            Globales.fenLocation.FormClosed += new FormClosedEventHandler(FenLocation_FormClosed);

            // Masque Intro
            this.Hide();

            // Ouverture de la page Location
            Globales.fenLocation.Show();
        }
    }
}