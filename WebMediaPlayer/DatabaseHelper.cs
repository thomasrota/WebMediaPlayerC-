using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMediaPlayer
{
    public class DatabaseHelper : IDisposable
    {
        private string connectionString = "Server=localhost;Database=wbm;User=root;Password=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        public MySqlDataReader ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            var connection = GetConnection();
            connection.Open();
            using (var command = new MySqlCommand(query, connection))
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
                return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
        }

        public void Dispose()
        {
            // Nothing to dispose
        }

        public bool ValidateLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM wbm_utente WHERE username = @username AND password = @password";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    return userCount > 0; // Ritorna true se le credenziali sono valide
                }
            }
        }

    }
}
