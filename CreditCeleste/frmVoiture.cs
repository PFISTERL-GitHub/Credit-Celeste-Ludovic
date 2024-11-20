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
                //foreach (Control xControl in gpbAgeVehicule.Controls)
                //{
                //    if (xControl is RadioButton radioButton)
                //    {

                //        if (radioButton.Name == Globales.btnAgeCocher)
                //        {
                //            radioButton.Checked = true;
                //            break; // Sort de la boucle une fois trouvé
                //        }
                //    }
                //}

                txtNouveauVhc.Text = Globales.uneVoiture.getNomVehicule();

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
                //foreach (Control xControl in gpbAgeVehicule.Controls)
                //{
                //    if (xControl is RadioButton radioButton)
                //    {

                //        if (radioButton.Name == Globales.btnAgeCocher)
                //        {
                //            radioButton.Checked = true;
                //            break; // Sort de la boucle une fois trouvé
                //        }
                //    }
                //}

            }
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fonction pour vérifier si les saisies sont valides
        private bool VerifierSaisie()
        {
            if (string.IsNullOrWhiteSpace(txtNouveauVhc.Text) || string.IsNullOrWhiteSpace(txtDate1ereImmat.Text) || string.IsNullOrWhiteSpace(txtNumImmat.Text) ||  string.IsNullOrWhiteSpace(txtNumSerie.Text) || string.IsNullOrWhiteSpace(txtPuissance.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
  
            //bool radioSelected = false;

            //foreach (Control xControl in gpbAgeVehicule.Controls)
            //{
            //    if (xControl is RadioButton radioButton && radioButton.Checked)
            //    {
            //        radioSelected = true;
            //        break;
            //    }
            //}

            // if (!radioSelected)
            // {
            //     MessageBox.Show("Veuillez sélectionner une option d'âge pour le véhicule.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return false; 
            // }

            return true; 
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            if (VerifierSaisie())
            {
                // Si la saisie est valide, exécute le reste du code
                string affichage = "Détails du Nouveau Véhicule : " +
                                   Environment.NewLine + "Nom du véhicule : " + txtNouveauVhc.Text +
                                   Environment.NewLine + "Date de première immatriculation : " + txtDate1ereImmat.Text +
                                   Environment.NewLine + "Numéro d'immatriculation : " + txtNumImmat.Text +
                                   Environment.NewLine + "Numéro de série : " + txtNumSerie.Text +
                                   Environment.NewLine + "Puissance : " + txtPuissance.Text;

                string nouveauVhc = txtNouveauVhc.Text;
                string date1ereImmat = txtDate1ereImmat.Text;
                string numImmat = txtNumImmat.Text;
                string numSerie = txtNumSerie.Text;
                string puissance = txtPuissance.Text;

                //foreach (Control xControl in gpbAgeVehicule.Controls)
                //{
                //    if (xControl is RadioButton)
                //    {
                //        RadioButton radioButton = xControl as RadioButton;

                //        if (radioButton.Checked)
                //        {
                //            Globales.btnAgeCocher = radioButton.Name;
                //            break;
                //        }
                //    }
                //}

                Globales.uneVoiture = new Voiture(nouveauVhc, date1ereImmat, numImmat, numSerie, puissance, Globales.btnAgeCocher);

                MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAssurance_Click(object sender, EventArgs e)
        {
            // creation et ouverture de Assurance
            Globales.fenAssurance = new frmAssurance();
            Globales.fenAssurance.FormClosed += new FormClosedEventHandler(FenAssurance_FormClosed);
            Globales.fenAssurance.Show();

            this.Hide();
        }

        void FenAssurance_FormClosed(object sender, FormClosedEventArgs e)  // que faire a la fermeture de Assurance
        {
            this.Show();

            if (Globales.uneVoiture != null)
            {
                //foreach (Control xControl in gpbAgeVehicule.Controls)
                //{
                //    if (xControl is RadioButton radioButton)
                //    {

                //        if (radioButton.Name == Globales.btnAgeCocher)
                //        {
                //            radioButton.Checked = true;
                //            break; // Sort de la boucle une fois trouvé
                //        }
                //    }
                //}

                if (!String.IsNullOrEmpty(Globales.uneVoiture.getNomVehicule()))
                {
                    txtNouveauVhc.Text = Globales.uneVoiture.getNomVehicule();
                }
            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            {
                //foreach (Control xControl in gpbAgeVehicule.Controls)
                //{
                //    if (xControl is RadioButton radioButton)
                //    {

                //        if (radioButton.Name == Globales.btnAgeCocher)
                //        {
                //            radioButton.Checked = true;
                //            break; // Sort de la boucle une fois trouvé
                //        }
                //    }
                //}

            }
        }

        private void txtDate1ereImmat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
