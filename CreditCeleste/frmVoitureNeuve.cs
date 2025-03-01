using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmVoitureNeuve : Form
    {
        public frmVoitureNeuve()
        {
            InitializeComponent();
        }

        private void frmVoiture_Load(object sender, EventArgs e)
        {
            lblVendeur.Text = Globales.nomVendeur;
            lblClient.Text = Globales.nomClient;

            ajoutVoitureNeuve();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            // Fermeture de la page VoitureNeuve
            this.Close();
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


        private void ajoutVoitureNeuve()
        {

            // Rajout des vendeurs au combobox
            foreach (VoitureNeuve uneVoitureNeuve in Globales.uneConcession.GetVoitureNeuve())
            {
                cbxNouvVhc.Items.Add(uneVoitureNeuve.getInfoVoiture());
            }
        }



        private void cbxNouvVhc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxNouvVhc.SelectedIndex == -1) return; // Éviter une erreur si aucun élément n'est sélectionné

            string choixOcasText = cbxNouvVhc.Text; // Exemple : "NumSerie Marque Modele"
            string[] parts = choixOcasText.Split(' ');

            if (parts.Length < 1) // Vérification minimale
            {
                MessageBox.Show("Format incorrect des données sélectionnées.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string numSerie = parts[0]; // Numéro de série

            // Requête SQL avec jointure pour récupérer les infos du véhicule
            string query = @"
            SELECT v.date1ereImmat, v.numImmat, v.numSerie, v.puissanceCh, v.ageVehicule, v.prixVente
            FROM VOITURE v 
            INNER JOIN VOITURE_NEUVE vo ON v.numSerie = vo.numSerie 
            WHERE v.numSerie = @NumSerie"; // Assure qu'une seule ligne est retournée

            using (SqlConnection oConnexion = new SqlConnection(Globales.connectionString))
            {
                oConnexion.Open();

                using (SqlCommand cmd = new SqlCommand(query, oConnexion))
                {
                    cmd.Parameters.Add(new SqlParameter("@NumSerie", SqlDbType.NVarChar) { Value = numSerie });

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Si des données sont trouvées
                        {
                            // Vérification et conversion sécurisée des données
                            txtDate1ereImmat.Text = reader["date1ereImmat"] != DBNull.Value
                                ? Convert.ToDateTime(reader["date1ereImmat"]).ToString("yyyy-MM-dd")
                                : "";

                            txtNumImmat.Text = reader["numImmat"]?.ToString() ?? "";
                            txtNumSerie.Text = reader["numSerie"]?.ToString() ?? "";
                            txtPuissance.Text = reader["puissanceCh"]?.ToString() ?? "";
                            txtPrixV.Text = reader["prixVente"]?.ToString() ?? "";

                            // Vérification et affichage de ageVehicule
                            if (reader["ageVehicule"] != DBNull.Value && int.TryParse(reader["ageVehicule"].ToString(), out int ageVehicule))
                            {
                                Console.WriteLine("Valeur de ageVehicule : " + ageVehicule);

                                // Reset des RadioButtons
                                rdbOccasMoins3.Checked = false;
                                rdbOccas3a5.Checked = false;
                                rdbOccas5OuPlus.Checked = false;

                                // Sélection du bon RadioButton selon l'âge du véhicule
                                if (ageVehicule < 3)
                                    rdbOccasMoins3.Checked = true;
                                else if (ageVehicule >= 3 && ageVehicule <= 5)
                                    rdbOccas3a5.Checked = true;
                                else
                                    rdbOccas5OuPlus.Checked = true;
                            }
                            else
                            {
                                MessageBox.Show("Erreur de récupération de l'âge du véhicule.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée trouvée pour ce véhicule.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier que le client est bien enregistré
                if (Globales.IdClient == 0)
                {
                    MessageBox.Show("Veuillez enregistrer le client avant de valider l'achat.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Vérifier que le véhicule est sélectionné
                if (string.IsNullOrEmpty(txtNumSerie.Text))
                {
                    MessageBox.Show("Veuillez sélectionner un véhicule avant de valider.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Récupérer les données
                int numC = Globales.IdClient;
                string numSerie = txtNumSerie.Text;

                using (SqlConnection oConnexion = new SqlConnection(Globales.connectionString))
                {
                    oConnexion.Open();

                    using (SqlTransaction transaction = oConnexion.BeginTransaction()) // Ajout d'une transaction
                    {
                        try
                        {
                            // Mise à jour sécurisée en une seule requête avec vérification
                            string query = @"
                                IF EXISTS (SELECT 1 FROM VOITURE WHERE numSerie = @numSerie AND stock = 'Acquis') 
                                BEGIN 
                                    THROW 50000, 'Impossible de mettre à jour numC car la voiture est déjà acquise.', 1; 
                                END 
                                ELSE 
                                BEGIN 
                                    UPDATE VOITURE 
                                    SET numC = @numC, stock = 'Acquis'
                                    WHERE numSerie = @numSerie; 
                                END";

                            using (SqlCommand cmd = new SqlCommand(query, oConnexion, transaction))
                            {
                                cmd.Parameters.Add(new SqlParameter("@numC", SqlDbType.Int) { Value = numC });
                                cmd.Parameters.Add(new SqlParameter("@numSerie", SqlDbType.NVarChar) { Value = numSerie });
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit(); // Valider la transaction

                            MessageBox.Show("Le véhicule a été attribué au client et marqué comme acquis !");
                        }
                        catch (SqlException ex) // Catch spécifique aux erreurs SQL
                        {
                            transaction.Rollback(); // Annule tout en cas d'erreur SQL
                            MessageBox.Show($"Erreur SQL : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex) // Catch global
                        {
                            transaction.Rollback(); // Annule tout en cas d'erreur générale
                            MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}