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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreditCeleste
{
    public partial class frmTestBDD : Form
    {
        private string connectionString = "Data Source=192.168.194.65; Initial Catalog=CreditCelesteProjet; User Id=cnxDaniels; password=mdpDaniels@;";

        public frmTestBDD()
        {
            InitializeComponent();
        }

        private void frmTestBDD_Load(object sender, EventArgs e)
        {

        }

        private void cmdLire_Click(object sender, EventArgs e)
        {
            lstTest.Items.Clear(); // Nettoie la ListBox

            using (SqlConnection oConnexion = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TEST"; // Assurez-vous que la table est correcte
                SqlCommand cmd = new SqlCommand(query, oConnexion);

                try
                {
                    oConnexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Crée une chaîne lisible pour afficher dans la ListBox
                        string creditInfo = $"Test1: {reader["test1"]} - Test2: {reader["test2"]}" + "\n";

                        lstTest.Items.Add(creditInfo); // Ajoute l'info à la ListBox
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des crédits : {ex.Message}");
                }
            }
        }

        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {


                // Vérifiez et récupérez les valeurs des TextBox
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs avant d'enregistrer.");
                    return;
                }


                string value1 = textBox1.Text;
                string value2 = textBox2.Text;

                // Requête SQL pour insérer les données
                string query = "INSERT INTO TEST (test1, test2) VALUES (@Value1, @Value2)";

                using (SqlConnection oConnexion = new SqlConnection(connectionString))
                {
                    oConnexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, oConnexion)) // VOIR AUTRE METHODE //
                    {
                        // Ajouter les paramètres avec les bons types
                        cmd.Parameters.Add(new SqlParameter("@Value1", SqlDbType.NVarChar) { Value = value1 });
                        cmd.Parameters.Add(new SqlParameter("@Value2", SqlDbType.NVarChar) { Value = value2 });

                        // Exécuter la commande
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Retour utilisateur
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Les données ont été enregistrées avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée n'a été enregistrée.");
                        }
                    }
                }

                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                lstTest.Items.Clear(); // Nettoie la ListBox

                // Requête SQL pour supprimer toutes les lignes de la table
                string query = "DELETE FROM TEST";

                using (SqlConnection oConnexion = new SqlConnection(connectionString))
                {
                    oConnexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, oConnexion))
                    {
                        // Exécute la commande
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Vérifie combien de lignes ont été supprimées
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Toutes les données ont été supprimées. {rowsAffected} ligne(s) affectée(s).");
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée n'a été supprimée.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression des données : {ex.Message}");
            }
        }



    }
}
