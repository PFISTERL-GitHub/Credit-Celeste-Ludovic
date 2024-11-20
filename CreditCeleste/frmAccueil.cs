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

            // un vendeur
            Vendeur unVendeur = new Vendeur("M.", "SOARES", "Daniels");
            Vendeur un2Vendeur = new Vendeur("M.", "BELLER", "Thierry");
            Vendeur un3Vendeur = new Vendeur("M.", "PFISTER", "Ludo");
            Vendeur un4Vendeur = new Vendeur("M.", "CIOBOTARU", "Alexandru");

            // à stocker dans la liste des vendeurs.
            //      (une manière de faire)
            Globales.uneConcession.ajoutVendeur(unVendeur);
            Globales.uneConcession.ajoutVendeur(un2Vendeur);
            Globales.uneConcession.ajoutVendeur(un3Vendeur);
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
    }
}
