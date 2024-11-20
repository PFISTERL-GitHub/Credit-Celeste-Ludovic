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

        private string connectionString = "Data Source=HP-VICTUS16-DAN\\SQLEXPRESS;Initial Catalog=CreditCelesteProjet; Integrated Security=True; Encrypt=False";

        public frmTestBDD()
        {
            InitializeComponent();
        }

        private void frmTestBDD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection oConnexion = new SqlConnection(connectionString))
                {
                    // Open the connection
                    oConnexion.Open();

                    // SQL query to select data
                    string query = "SELECT * FROM ASSURANCE";

                    // Create the SqlCommand
                    SqlCommand cmd = new SqlCommand(query, oConnexion);

                    // Execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Example: Display first row's values in text boxes
                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow firstRow = dataTable.Rows[0];
                            textBox1.Text = firstRow["idAssurance"].ToString(); // Replace ColumnName1 with your column name
                            textBox2.Text = firstRow["nomAssurance"].ToString(); // Replace ColumnName2 with your column name
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des crédits : {ex.Message}");
            }
        }

    }
}
