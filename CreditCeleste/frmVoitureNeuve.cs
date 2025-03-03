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

        /// <summary>
        /// Au chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVoiture_Load(object sender, EventArgs e)
        {
            lblVendeur.Text = Globales.nomVendeur;
            lblClient.Text = Globales.nomClient;

            ajoutVoitureNeuve();
        }

        /// <summary>
        /// Instancie et affiche fenAssurance. Masque fenVoiture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssurance_Click(object sender, EventArgs e)
        {
            Globales.fenAssurance = new frmAssurance();
            Globales.fenAssurance.FormClosed += new FormClosedEventHandler(FenAssurance_FormClosed);
            Globales.fenAssurance.Show();

            this.Hide();
        }

        /// <summary>
        /// Affiche fenVoiture à la fermeture de fenAssurance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            break; 
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher)) // TODO on peut mettre un if ... or ... ?
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
                {
                    if (xControl is RadioButton radioButton)
                    {
                        if (radioButton.Name == Globales.btnAgeCocher)
                        {
                            radioButton.Checked = true;
                            break; 
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ajoute la voiture au combobox cboNouvVhc
        /// </summary> 
        private void ajoutVoitureNeuve()
        {
            foreach (VoitureNeuve uneVoitureNeuve in Globales.uneConcession.GetVoitureNeuve())
            {
                cboNouvVhc.Items.Add(uneVoitureNeuve.getInfoVoiture());
            }
        }

        /// <summary>
        /// Met à jour le choix du véhicule 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboNouvVhc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboNouvVhc.SelectedIndex == -1) return; // Éviter une erreur si aucun élément n'est sélectionné

            string choixOcasText = cboNouvVhc.Text; // Exemple : "NumSerie Marque Modele"
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

        /// <summary>
        /// Enregistre l'achat du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcheter_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Fermer la fenêtre au clic sur le bouton Retour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}