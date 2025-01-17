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

		public int GetUserId(string username)
		{
			string query = "SELECT id FROM wbm_utente WHERE username = @username";
			int userId = -1;
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@username", username);
					userId = Convert.ToInt32(command.ExecuteScalar());
				}
			}
			return userId;
		}

		public List<(int id, string nome, string immagine)> GetRecentArtists(int userId)
		{
			string query = @"
                SELECT a.id, a.nome, a.immagine 
                FROM WBM_artista a
                JOIN WBM_artista_album aa ON a.id = aa.id_artista
                JOIN WBM_album al ON aa.id_album = al.id
                JOIN WBM_brano b ON al.id = b.id_album
                JOIN WBM_utente_brani ub ON b.id = ub.id_brano
                WHERE ub.id_utente = @userId
                GROUP BY a.id
                ORDER BY a.id DESC
                LIMIT 6";

			var recentArtists = new List<(int id, string nome, string immagine)>();

			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@userId", userId);

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int id = reader.GetInt32("id");
							string nome = reader.GetString("nome");
							string immagine = reader.GetString("immagine");
							recentArtists.Add((id, nome, immagine));
						}
					}
				}
			}

			return recentArtists;
		}
		public List<(int id, string titolo, string immagine)> GetRecommendedAlbums(int userId)
		{
			string query = @"
                SELECT al.id, al.titolo, al.immagine 
                FROM WBM_album al
                JOIN WBM_brano b ON al.id = b.id_album
                JOIN WBM_utente_brani ub ON b.id = ub.id_brano
                WHERE ub.id_utente = @userId
                GROUP BY al.id, al.titolo, al.immagine
                ORDER BY RAND()
                LIMIT 10";

			var recommendedAlbums = new List<(int id, string titolo, string immagine)>();

			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@userId", userId);

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int id = reader.GetInt32("id");
							string titolo = reader.GetString("titolo");
							string immagine = reader.GetString("immagine");
							recommendedAlbums.Add((id, titolo, immagine));
						}
					}
				}
			}

			return recommendedAlbums;
		}
	}
}

