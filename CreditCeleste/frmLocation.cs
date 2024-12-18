﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // Sauvegarde le texte saisi dans des variables
            string civilite = cboCiv.Text;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string dateNaissance = txtDtn.Text;

            string datePermis = txtDtp.Text;
            string vhcLocation = txtChoixVhcLoc.Text;
            string kilometrage = txtKilometrage.Text;

            string adrGarage = txtAdrGarage.Text;
            string telGarage = txtTelGarage.Text;

            Globales.uneVoitureLocation = new VoitureLocation(vhcLocation, kilometrage);


            // Verification de la saisie
            if (verifierSaisie(civilite, nom, prenom, dateNaissance, datePermis, vhcLocation, kilometrage, adrGarage, telGarage))
            {
                // Sauvegarde radiobouton
                foreach (Control xControl in gpbDureeLocation.Controls)
                {
                    if (xControl is RadioButton)
                    {
                        RadioButton radioButton = xControl as RadioButton;

                        if (radioButton.Checked)
                        {
                            Globales.btnDureeCocher = radioButton.Name;
                            break;
                        }
                    }
                }

                // Sauvegarde dans Globales
                Globales.unClient = new Client(civilite, nom, prenom);

                // Création d'une assurance
                Globales.uneLocation = new Location(dateNaissance, datePermis, vhcLocation, kilometrage, adrGarage, telGarage, Globales.btnDureeCocher);

                // Affiche un message
                string affichage =
                    "Client: " + civilite + " " + nom + " " + prenom + " " + Environment.NewLine +
                    "Date de Naissance: " + dateNaissance + Environment.NewLine +
                    "Info Voiture: " + datePermis + " " + vhcLocation + " " + kilometrage + Environment.NewLine +
                    "Infos Garage: " + adrGarage + " " + telGarage;

                MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Active le bouton Valider
                btnValider.Enabled = true;
            }
        }

        // Fonction pour vérifier si les saisies sont valides
        private bool verifierSaisie(string civilite, string nom, string prenom, string dateNaissance, string datePermis, string numImmatriculation, string marqueVoiture, string adrGarage, string telGarage)
        {
            // Variable
            bool valeur = true;

            // A CHANGE //
            //// Verifie les champs obligatoires
            //if (string.IsNullOrWhiteSpace(civilite) || string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(vendeur))
            //{
            //    // Affiche un message d'erreur
            //    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    valeur = false; // Retourne faux si une valeur n'est pas saisie
            //}
            //else if (string.IsNullOrWhiteSpace(nouveauVehicule) && string.IsNullOrWhiteSpace(ancienVehicule))
            //{
            //    // Affiche un message d'erreur
            //    MessageBox.Show("Veuillez entrer un véhicule (nouveau ou ancien).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    valeur = false; // Retourne faux si les deux valeur sont pas saisie
            //}

            // Retourne la Variable
            return valeur;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            // Recuperation des informations
            if (Globales.unClient != null)
            {
                // récupération des éléments du client
                cboCiv.Text = Globales.unClient.getCivClient();
                txtNom.Text = Globales.unClient.getNomClient();
                txtPrenom.Text = Globales.unClient.getPrenomClient();
            }

            // Si il y a une Assurance
            if (Globales.uneLocation != null)
            {
                foreach (Control xControl in gpbDureeLocation.Controls)
                {
                    if (xControl is RadioButton radioButton)
                    {

                        if (radioButton.Name == Globales.btnDureeCocher)
                        {
                            radioButton.Checked = true;
                            break; // Sort de la boucle une fois trouvé
                        }
                    }
                }

                // Recupere numImmat
                if (Globales.uneVoitureLocation.getNumImmat() != "44458884AE")
                {
                    txtChoixVhcLoc.Text = Globales.uneVoitureLocation.getNumImmat();
                }

            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            {
                foreach (Control xControl in gpbDureeLocation.Controls)
                {
                    if (xControl is RadioButton radioButton)
                    {

                        if (radioButton.Name == Globales.btnAgeCocher)
                        {
                            radioButton.Checked = true;
                            break; // Sort de la boucle une fois trouvé
                        }
                    }
                }
            }

            // Affiche nom vendeur dans le label
            lblVendeur.Text = Globales.nomVendeur;

            // Desactive le bouton Valider
            btnValider.Enabled = false;
        }
    }
}