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

        private bool VerifierSaisie()
        {
            //if (string.IsNullOrWhiteSpace(txtNouveauVhc.Text) || string.IsNullOrWhiteSpace(txtDate1ereImat.Text) || string.IsNullOrWhiteSpace(txtNumImmat.Text) || string.IsNullOrWhiteSpace(txtNumSerie.Text) || string.IsNullOrWhiteSpace(txtPuissance.Text))
            //{
            //    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            bool radioSelected = false;
            foreach (Control xControl in gpbAgeVehicule.Controls)
            {
                if (xControl is RadioButton radioButton && radioButton.Checked)
                {
                    radioSelected = true;
                    break;
                }
            }

            if (!radioSelected)
            {
                MessageBox.Show("Veuillez sélectionner une option d'âge pour le véhicule.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            if (VerifierSaisie())
            {
                // Si la saisie est valide, exécute le reste du code
                string affichage = "Détails du Nouveau Véhicule : " +
                                   //Environment.NewLine + "Nom du Véhicule : " + txtNouveauVhc.Text +
                                   Environment.NewLine + "Date de Première Immatriculation : " + txtDate1ereImat.Text +
                                   Environment.NewLine + "Numéro d'Immatriculation : " + txtNumImmat.Text +
                                   Environment.NewLine + "Numéro de Série : " + txtNumSerie.Text +
                                   Environment.NewLine + "Puissance : " + txtPuissance.Text;

                //string nvVehicule = txtNouveauVhc.Text;   // Modifier pour que ca soit txtChoixVhcOcca
                string Date1erImma = txtDate1ereImat.Text;
                string numImma = txtNumImmat.Text;
                string numSerie = txtNumSerie.Text;
                string Puissance = txtPuissance.Text;

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

                //Globales.uneVoiture = new Voiture(nvVehicule, Date1erImma, numImma, numSerie, Puissance, Globales.btnAgeCocher);

                MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

                //txtNouveauVhc.Text = Globales.uneVoiture.getnomvehicule();

                if (Globales.uneVoiture.getNumImmat() != "44458884AE")
                {
                    txtDate1ereImat.Text = Globales.uneVoiture.getDate1ereImmat();
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
