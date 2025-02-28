using System;
using System.Data;
using System.Data.SqlClient;

namespace CreditCeleste
{
    public class DatabaseManager : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        // Le constructeur prend la chaîne de connexion en paramètre
        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString ??
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null");
        }

        // La méthode ExecuteReader retourne maintenant un DataTable
        public DataTable ExecuteReader(string query, Action<SqlCommand> parameterAction = null)
        {
            var dataTable = new DataTable();
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        parameterAction?.Invoke(command);
                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                return dataTable;
            }
            catch (SqlException ex)
            {
                // Journalisation des erreurs de base de données
                LogDatabaseError(ex, query);
                throw;
            }
        }

        // La méthode ExecuteQuery permet d'exécuter des requêtes sans retour de données
        public void ExecuteQuery(string query, Action<SqlCommand> parameterAction = null)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        parameterAction?.Invoke(command);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Journalisation des erreurs de base de données
                LogDatabaseError(ex, query);
                throw; // Renvoi de l'exception pour permettre à l'appelant de la gérer
            }
        }

        // Méthode de journalisation des erreurs de base de données
        private void LogDatabaseError(Exception ex, string query)
        {
            // Implémentez ici le mécanisme de journalisation de votre choix
            Console.WriteLine($"Database Error: {ex.Message}");
            Console.WriteLine($"Query: {query}");
        }

        // Implémentation de la méthode Dispose pour la gestion des ressources
        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}