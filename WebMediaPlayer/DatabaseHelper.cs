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

		public object ExecuteScalar(string query, Dictionary<string, object> parameters)
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
					return command.ExecuteScalar();
				}
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
					catch (MySqlException)
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
					var result = command.ExecuteScalar();
					if (result != null)
					{
						userId = Convert.ToInt32(result);
					}
				}
			}
			return userId;
		}

		public int GetUserIdById(int userId)
		{
			string query = "SELECT id FROM wbm_utente WHERE id = @userId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@userId", userId);
					var result = command.ExecuteScalar();
					return result != null ? Convert.ToInt32(result) : -1;
				}
			}
		}

		public string GetUsrImg(int userId)
		{
			string query = "SELECT immagine FROM wbm_utente WHERE id = @id";
			string img = "";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", userId);
					img = command.ExecuteScalar().ToString();
				}
			}
			return img;
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

		public int GetArtistId(string artistName)
		{
			string query = "SELECT id FROM WBM_artista WHERE nome = @artist";
			int artistId = -1;
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artist", artistName);
					var result = command.ExecuteScalar();
					if (result != null)
					{
						artistId = Convert.ToInt32(result);
					}
				}
			}
			return artistId;
		}
		public string GetArtistName(int artistId)
		{
			string query = "SELECT nome FROM WBM_artista WHERE id = @artistId";
			string artistName = "";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artistId", artistId);
					var result = command.ExecuteScalar();
					if (result != null)
					{
						artistName = result.ToString();
					}
				}
			}
			return artistName;
		}

		public List<(string titolo, string album, string mp3)> GetRecentTracksByArtist(string artist)
		{
			int artistId = GetArtistId(artist);
			string query = @"
                SELECT b.titolo, al.titolo AS album, b.mp3 
                FROM WBM_brano b
                JOIN WBM_album al ON b.id_album = al.id
                JOIN WBM_artista_album aa ON al.id = aa.id_album
                WHERE aa.id_artista = @artistId
                ORDER BY b.id DESC
                LIMIT 3";

			var tracks = new List<(string titolo, string album, string mp3)>();

			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artistId", artistId);

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							string titolo = reader.GetString("titolo");
							string album = reader.GetString("album");
							string mp3 = reader.GetString("mp3");
							tracks.Add((titolo, album, mp3));
						}
					}
				}
			}

			return tracks;
		}

		public List<(string titolo, string mp3)> GetTracksByAlbum(int albumId)
		{
			string query = @"
                SELECT b.titolo, b.mp3 
                FROM WBM_brano b
                WHERE b.id_album = @albumId
                ORDER BY b.id ASC";

			var tracks = new List<(string titolo, string mp3)>();

			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@albumId", albumId);

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							string titolo = reader.GetString("titolo");
							string mp3 = reader.GetString("mp3");
							tracks.Add((titolo, mp3));
						}
					}
				}
			}

			return tracks;
		}

		public int GetAlbumId(string albumTitle)
		{
			string query = "SELECT id FROM WBM_album WHERE titolo = @albumTitle";
			int albumId = -1;
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@albumTitle", albumTitle);
					var result = command.ExecuteScalar();
					if (result != null)
					{
						albumId = Convert.ToInt32(result);
					}
				}
			}
			return albumId;
		}

		public void InsertAlbum(string albumTitle, string year, string image)
		{
			string query = "INSERT INTO WBM_album (titolo, anno, immagine) VALUES (@albumTitle, @year, @image)";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@albumTitle", albumTitle);
					command.Parameters.AddWithValue("@year", year);
					command.Parameters.AddWithValue("@image", image);
					command.ExecuteNonQuery();
				}
			}
		}

		public void UpdateAlbumImage(int albumId, string image)
		{
			string query = "UPDATE WBM_album SET immagine = @image WHERE id = @albumId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@image", image);
					command.Parameters.AddWithValue("@albumId", albumId);
					command.ExecuteNonQuery();
				}
			}
		}

		public void InsertTrack(string trackTitle, int albumId, string filePath)
		{
			string query = "INSERT INTO WBM_brano (titolo, id_album, mp3) VALUES (@trackTitle, @albumId, @filePath)";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@trackTitle", trackTitle);
					command.Parameters.AddWithValue("@albumId", albumId);
					command.Parameters.AddWithValue("@filePath", filePath);
					command.ExecuteNonQuery();
				}
			}
		}

		public void InsertArtist(string artistName)
		{
			string query = "INSERT INTO WBM_artista (nome) VALUES (@artistName)";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artistName", artistName);
					command.ExecuteNonQuery();
				}
			}
		}

		public void LinkArtistToAlbum(int artistId, int albumId)
		{
			string query = "INSERT INTO WBM_artista_album (id_artista, id_album) VALUES (@artistId, @albumId)";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artistId", artistId);
					command.Parameters.AddWithValue("@albumId", albumId);
					command.ExecuteNonQuery();
				}
			}
		}

		public void LinkTrackToUser(int userId, int trackId)
		{
			string query = "INSERT INTO WBM_utente_brani (id_utente, id_brano) VALUES (@userId, @trackId)";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@userId", userId);
					command.Parameters.AddWithValue("@trackId", trackId);
					command.ExecuteNonQuery();
				}
			}
		}

		public int GetTrackId(string trackTitle, int albumId)
		{
			string query = "SELECT id FROM WBM_brano WHERE titolo = @trackTitle AND id_album = @albumId";
			int trackId = -1;
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@trackTitle", trackTitle);
					command.Parameters.AddWithValue("@albumId", albumId);
					var result = command.ExecuteScalar();
					if (result != null)
					{
						trackId = Convert.ToInt32(result);
					}
				}
			}
			return trackId;
		}
		public int GetTrackCountByArtist(int artistId)
		{
			string query = @"
		        SELECT COUNT(b.id) 
		        FROM WBM_brano b
		        JOIN WBM_artista_album aa ON b.id_album = aa.id_album
		        WHERE aa.id_artista = @artistId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artistId", artistId);
					var result = command.ExecuteScalar();
					return result != null ? Convert.ToInt32(result) : 0;
				}
			}
		}

		public void UpdateArtistImage(int artistId, string imagePath)
		{
			string query = "UPDATE WBM_artista SET immagine = @imagePath WHERE id = @artistId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@imagePath", imagePath);
					command.Parameters.AddWithValue("@artistId", artistId);
					command.ExecuteNonQuery();
				}
			}
		}
		public int GetAlbumCountByArtist(int artistId)
		{
			string query = @"
		        SELECT COUNT(al.id) 
		        FROM WBM_album al
		        JOIN WBM_artista_album aa ON al.id = aa.id_album
		        WHERE aa.id_artista = @artistId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artistId", artistId);
					var result = command.ExecuteScalar();
					return result != null ? Convert.ToInt32(result) : 0;
				}
			}
		}
		public List<(int id, string titolo, string immagine)> GetAlbumsByArtist(int artistId)
		{
			string query = @"
		        SELECT al.id, al.titolo, al.immagine 
		        FROM WBM_album al
		        JOIN WBM_artista_album aa ON al.id = aa.id_album
		        WHERE aa.id_artista = @artistId";

			var albums = new List<(int id, string titolo, string immagine)>();

			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@artistId", artistId);

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int id = reader.GetInt32("id");
							string titolo = reader.GetString("titolo");
							string immagine = reader.GetString("immagine");
							albums.Add((id, titolo, immagine));
						}
					}
				}
			}

			return albums;
		}
		public (string Username, string Email) GetUserById(int userId)
		{
			string query = "SELECT username, email FROM wbm_utente WHERE id = @userId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@userId", userId);
					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							string username = reader.GetString("username");
							string email = reader.GetString("email");
							return (username, email);
						}
					}
				}
			}
			return (null, null);
		}

		public void UpdateUserProfile(int userId, string newUsername, string newPassword)
		{
			string query = "UPDATE wbm_utente SET username = @newUsername, password = @newPassword WHERE id = @userId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@userId", userId);
					command.Parameters.AddWithValue("@newUsername", newUsername);
					command.Parameters.AddWithValue("@newPassword", BCrypt.Net.BCrypt.HashPassword(newPassword));
					command.ExecuteNonQuery();
				}
			}
		}

		public void UpdateUserImage(int userId, string imagePath)
		{
			string query = "UPDATE wbm_utente SET immagine = @imagePath WHERE id = @userId";
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@imagePath", imagePath);
					command.Parameters.AddWithValue("@userId", userId);
					command.ExecuteNonQuery();
				}
			}
		}


	}
}
