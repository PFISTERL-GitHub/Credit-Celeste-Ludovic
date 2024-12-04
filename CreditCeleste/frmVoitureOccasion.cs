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
    //                                     INFORMATION IMPORTANTE                                    //
    // J'ai juste copié colé inteligament a la sauvegarde et validation il y a pas les bonnes valeurs //
    //                                     INFORMATION IMPORTANTE                                    //

    public partial class frmVoitureOccasion : Form
    {
        public frmVoitureOccasion()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // Sauvegarde le texte saisi dans des variables
            string nvVhcOccasion = txtChoixVhcOcca.Text;
            string Date1ereImmat = txtDate1ereImat.Text;
            string numImmat = txtNumImmat.Text;
            string numSerie = txtNumSerie.Text;
            string Puissance = txtPuissance.Text;
            string vendeur = Globales.nomVendeur;

            // On verifie la saisie avant de continuer
            if (verifierSaisie(nvVhcOccasion))
            {
                // Sauvegarde dans Globales
                Globales.uneVoitureOccasion = new VoitureOccasion(nvVhcOccasion, Date1ereImmat, numImmat, numSerie, Puissance, Globales.btnAgeCocher);

                // Création nouvelle voiture d'occasion
                if (!string.IsNullOrEmpty(nvVhcOccasion))
                {
                    Globales.uneVoitureOccasion = new VoitureOccasion(nvVhcOccasion, Globales.btnAgeCocher); // Globales.btnAgeCocher ???
                }

                // Affiche nom vendeur dans le label
                lblVendeur.Text = vendeur;

                // Affiche un message
                string affichage = "Détails du Nouveau Véhicule : " +
                Environment.NewLine + "Choix Vehicule Occasion : " + txtChoixVhcOcca.Text +
                Environment.NewLine + "Date de Première Immatriculation : " + txtDate1ereImat.Text +
                Environment.NewLine + "Numéro d'Immatriculation : " + txtNumImmat.Text +
                Environment.NewLine + "Numéro de Série : " + txtNumSerie.Text +
                Environment.NewLine + "Puissance : " + txtPuissance.Text;

                MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Active le bouton Valider
                btnValider.Enabled = true;
            }
        }

        private bool verifierSaisie(string unNvVhcOcca) // FAIT AU PROPRE //
        {
            // Variable
            bool valeur = true;

            // Verifie les champs obligatoires
            if (string.IsNullOrWhiteSpace(unNvVhcOcca))
            {
                // Affiche un message d'erreur
                MessageBox.Show("Veuiller choisir un nouveau véhicule d'occasion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valeur = false; // Retourne faux si une valeur n'est pas saisie
            }

            // Retourne la Variable
            return valeur;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmVoitureOccasion_Load(object sender, EventArgs e)
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

                txtChoixVhcOcca.Text = Globales.uneVoitureOccasion.getNomVehicule();

                // récupération des éléments du véhicule d'occasion
                if (Globales.uneVoitureOccasion != null)
                {
                    txtDate1ereImat.Text = Globales.uneVoitureOccasion.getDate1ereImmat();
                    txtNumImmat.Text = Globales.uneVoitureOccasion.getNumImmat();
                    txtNumSerie.Text = Globales.uneVoitureOccasion.getnumSerie();
                    txtPuissance.Text = Globales.uneVoitureOccasion.getPuissance();

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

        private void btnAssurance_Click(object sender, EventArgs e)
        {
            Globales.fenAssurance = new frmAssurance();
            Globales.fenAssurance.FormClosed += new FormClosedEventHandler(FenAssurance_FormClosed);
            Globales.fenAssurance.Show();

            this.Hide();
        }

        void FenAssurance_FormClosed(object sender, FormClosedEventArgs e)
        {
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
                    //txtNouvVhc.Text = Globales.uneVoiture.getnomvehicule();
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
