using System;
using System.Data;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmTestBDD : Form
    {
        public frmTestBDD()
        {
            InitializeComponent();
        }

        private void frmTestBDD_Load(object sender, EventArgs e)
        {
            // Initialisation si nécessaire
        }

        private void cmdLire_Click(object sender, EventArgs e)
        {
            try
            {
                // Effacer la liste
                lstTest.Items.Clear();

                // Exécuter la requête SELECT sur la table TEST
                string query = "SELECT * FROM TEST";
                DataTable resultTable = Globales.dbManager.ExecuteReader(query);

                // Parcourir les résultats et les ajouter à la liste
                foreach (DataRow row in resultTable.Rows)
                {
                    string creditInfo = $"Test1: {row["test1"]} - Test2: {row["test2"]}";
                    lstTest.Items.Add(creditInfo);
                }
            }
            catch (Exception ex)
            {
                // Afficher un message d'erreur à l'utilisateur
                MessageBox.Show($"Erreur lors de la lecture des données : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            // Vérifier que les champs sont remplis
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs avant d'enregistrer.");
                return;
            }

            try
            {
                // Récupérer les valeurs des champs
                string value1 = textBox1.Text;
                string value2 = textBox2.Text;

                // Exécuter la requête d'insertion
                string query = "INSERT INTO TEST (test1, test2) VALUES (@Value1, @Value2)";
                Globales.dbManager.ExecuteQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Value1", value1);
                    cmd.Parameters.AddWithValue("@Value2", value2);
                });

                // Afficher un message de confirmation
                MessageBox.Show("Les données ont été enregistrées avec succès !",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Effacer les champs
                textBox1.Clear();
                textBox2.Clear();

                // Rafraîchir la liste
                cmdLire_Click(sender, e);
            }
            catch (Exception ex)
            {
                // Afficher un message d'erreur à l'utilisateur
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // Exécuter la requête de suppression
                string query = "DELETE FROM TEST";
                Globales.dbManager.ExecuteQuery(query);

                // Afficher un message de confirmation
                MessageBox.Show("Toutes les données ont été supprimées.");

                // Rafraîchir la liste
                cmdLire_Click(sender, e);
            }
            catch (Exception ex)
            {
                // Afficher un message d'erreur à l'utilisateur
                MessageBox.Show($"Erreur lors de la suppression des données : {ex.Message}");
            }
        }
    }
}