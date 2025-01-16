using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

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

		public bool ValidateLogin(string usernameOrEmail, string password)
		{
			string query = "SELECT password FROM wbm_utente WHERE username = @usernameOrEmail OR email = @usernameOrEmail";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);

					var storedHash = command.ExecuteScalar() as string;
					if (storedHash == null)
					{
						return false; // Username o email non trovati
					}

					// Confronta l'hash della password fornita con l'hash memorizzato
					return BCrypt.Net.BCrypt.Verify(password, storedHash);
				}
			}
		}

		public bool RegisterUser(string username, string email, string password)
		{
			string query = "INSERT INTO wbm_utente (username, email, password) VALUES (@username, @Email, @Password)";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@username", username);
					command.Parameters.AddWithValue("@Email", email);
					command.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(password));

					try
					{
						command.ExecuteNonQuery();
						return true; // Registrazione avvenuta con successo
					}
					catch (MySqlException ex)
					{
						return false;
					}
				}
			}
		}
	}
}

