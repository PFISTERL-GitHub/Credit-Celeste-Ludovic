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
    public partial class frmAssurance : Form
    {
        public frmAssurance()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerifierSaisie()
        {
            if (string.IsNullOrWhiteSpace(cboCiv.Text) || string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) || string.IsNullOrWhiteSpace(txtDtn.Text) || string.IsNullOrWhiteSpace(txtDtp.Text) || string.IsNullOrWhiteSpace(txtNumImmat.Text) || string.IsNullOrWhiteSpace(txtMarque.Text) || string.IsNullOrWhiteSpace(txtAdrGarage.Text) || string.IsNullOrWhiteSpace(txtTelGarage.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool radioSelected = false;

            foreach (Control xControl in gpbDureeAssurance.Controls)
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
                string affichage = "Détails : " +
                                   Environment.NewLine + "Numero Immatriculation' : " + txtNumImmat.Text +
                                   Environment.NewLine + "Numéro d'immatriculation : " + txtNumImmat.Text +
                                   Environment.NewLine + "Marque du véhicule : " + txtMarque.Text +
                                   Environment.NewLine + "Adresse du garage: " + txtAdrGarage.Text +
                                   Environment.NewLine + "Téléphone du garage : " + txtTelGarage.Text;

                string dateNaissance = txtDtn.Text;
                string datePermis = txtDtp.Text;
                string numImmat = txtNumImmat.Text;
                string marque = txtMarque.Text;
                string adresseGarage = txtAdrGarage.Text;
                string telGarage = txtTelGarage.Text;

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

                Globales.uneAssurance = new Assurance(dateNaissance, datePermis, numImmat, marque, adresseGarage, telGarage);

                MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAssurance_Load(object sender, EventArgs e)
        {
            lblVendeur.Text = Globales.nomVendeur;

            //if (Globales.uneVoiture != null)
            //{
            //    //foreach (Control xControl in gpbAgeVehicule.Controls)
            //    //{
            //    //    if (xControl is RadioButton radioButton)
            //    //    {

            //    //        if (radioButton.Name == Globales.btnAgeCocher)
            //    //        {
            //    //            radioButton.Checked = true;
            //    //            break; // Sort de la boucle une fois trouvé
            //    //        }
            //    //    }
            //    //}

            //    txtNouveauVhc.Text = Globales.uneVoiture.getnomvehicule();

            //    if (Globales.uneVoiture.getNumImma() != "44458884AE")
            //    {
            //        txtDate1ereImmat.Text = Globales.uneVoiture.getDate1erImma();
            //        txtNumImmat.Text = Globales.uneVoiture.getNumImma();
            //        txtNumSerie.Text = Globales.uneVoiture.getnumSerie();
            //        txtPuissance.Text = Globales.uneVoiture.getPuissance();

            //    }

            //}
            //else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            //{
            //    //foreach (Control xControl in gpbAgeVehicule.Controls)
            //    //{
            //    //    if (xControl is RadioButton radioButton)
            //    //    {

            //    //        if (radioButton.Name == Globales.btnAgeCocher)
            //    //        {
            //    //            radioButton.Checked = true;
            //    //            break; // Sort de la boucle une fois trouvé
            //    //        }
            //    //    }
            //    //}

            //}
        }

        private void gpbDureeAssurance_Enter(object sender, EventArgs e)
        {

        }
    }
}
