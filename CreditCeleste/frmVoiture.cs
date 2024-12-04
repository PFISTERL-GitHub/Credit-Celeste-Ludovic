using System;
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
    public partial class frmVoiture : Form
    {
        public frmVoiture()
        {
            InitializeComponent();
        }

        private void frmVoiture_Load(object sender, EventArgs e)
        {
            lblVendeur.Text = Globales.nomVendeur;

            if (Globales.uneVoiture != null)
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
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

                txtNouvVhc.Text = Globales.uneVoiture.getNomVehicule();

                if (Globales.uneVoiture.getNumImmat() != "44458884AE")
                {
                    txtDate1ereImmat.Text = Globales.uneVoiture.getDate1ereImmat();
                    txtNumImmat.Text = Globales.uneVoiture.getNumImmat();
                    txtNumSerie.Text = Globales.uneVoiture.getnumSerie();
                    txtPuissance.Text = Globales.uneVoiture.getPuissance();

                }

            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
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

            // Desactive le bouton Valider
            btnValider.Enabled = false;
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            // Fermeture de la page VoitureNeuve
            this.Close();
        }

        // Fonction pour vérifier les champs obligatoires dans VoitureNeuve
        private bool verifChampsVoitures(string unNouvVhc)
        {
            // Variable
            bool valeur = true;

            // Verifie les champs obligatoires (méthode "est nul ou vide")
            if (string.IsNullOrWhiteSpace(unNouvVhc))
            {
                // Retourne faux si la valeur n'est pas saisie
                valeur = false;
            }

            // Retourne la variable
            return valeur;
        }

        // Fonction pour vérifier si les saisies sont valides
        private bool verifierSaisie(string unNouvVhc)
        {
            // Variable
            bool valeur = true;

            //if (string.IsNullOrWhiteSpace(txtNouvVhc.Text) || string.IsNullOrWhiteSpace(txtDate1ereImmat.Text) || string.IsNullOrWhiteSpace(txtNumImmat.Text) ||  string.IsNullOrWhiteSpace(txtNumSerie.Text) || string.IsNullOrWhiteSpace(txtPuissance.Text))
            if (!verifChampsVoitures(unNouvVhc))
            {
                MessageBox.Show("Veuillez choisir un véhicule.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valeur = false; // Retourne faux si une valeur n'est pas saisie
            }

            // Retourne la variable
            return valeur;
        }

        // Fonction pour le bouton Enregistrer
        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // Sauvegarde le texte saisi dans des variables
            string nouvVhc = txtNouvVhc.Text;
            string date1ereImmat = txtDate1ereImmat.Text;
            string numImmat = txtNumImmat.Text;
            string numSerie = txtNumSerie.Text;
            string puissance = txtPuissance.Text;

            // On vérifie la saisie avant de continuer
            if (verifierSaisie(nouvVhc))
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
                {
                    if (xControl is RadioButton)
                    {
                        RadioButton radioButton = xControl as RadioButton;
                        if (radioButton.Checked)
                        {
                            Globales.btnAgeCocher = radioButton.Name;
                            break;
                        }
                    }
                }

                // Création nouvelle voiture
                if (!string.IsNullOrEmpty(nouvVhc))
                {
                    Globales.uneVoiture = new Voiture(nouvVhc, Globales.btnAgeCocher); // Globales.btnAgeCocher ???
                }

                // Affiche un message
                string affichage = "Détails du Nouveau Véhicule : " +
                                   Environment.NewLine + "Nom du véhicule : " + txtNouvVhc.Text +
                                   Environment.NewLine + "Date de première immatriculation : " + txtDate1ereImmat.Text +
                                   Environment.NewLine + "Numéro d'immatriculation : " + txtNumImmat.Text +
                                   Environment.NewLine + "Numéro de série : " + txtNumSerie.Text +
                                   Environment.NewLine + "Puissance : " + txtPuissance.Text;

                // L'affichage de la boîte de dialogue
                MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Active le bouton Valider
                btnValider.Enabled = true;
            }
        }

        // Fonction pour le bouton Valider
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Ferme l'application
            Application.Exit();
        }

        // Redirection vers la page Assurance
        private void btnAssurance_Click(object sender, EventArgs e)
        {
            // Création et ouverture de Assurance
            Globales.fenAssurance = new frmAssurance();
            Globales.fenAssurance.FormClosed += new FormClosedEventHandler(FenAssurance_FormClosed);

            // Masquer Voiture
            this.Hide();

            // Ouverture de la page Assurance
            Globales.fenAssurance.Show();
        }

        void FenAssurance_FormClosed(object sender, FormClosedEventArgs e)  // que faire a la fermeture de Assurance
        {
            // Affiche VoitureNeuve à la fermeture de Assurance
            this.Show();

            if (Globales.uneVoiture != null)
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
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

                if (!String.IsNullOrEmpty(Globales.uneVoiture.getNomVehicule()))
                {
                    txtNouvVhc.Text = Globales.uneVoiture.getNomVehicule();
                }
            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
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
        }
    }
}