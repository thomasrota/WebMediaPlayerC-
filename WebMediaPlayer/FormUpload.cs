using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TagLib;

namespace WebMediaPlayer
{
	public partial class FormUpload : Form
	{
		private OpenFileDialog openFileDialog;
		private string trackFilePath;
		private string albumImagePath;

		public int UserId { get; set; }

		public FormUpload()
		{
			InitializeComponent();
		}

		private void ButtonBrowseTrack_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "Audio Files|*.mp3;*.wav";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				trackFilePath = openFileDialog.FileName;
				textBoxTrackFile.Text = trackFilePath;

				// Estrai i metadati dal file audio
				ExtractMetadata(trackFilePath);
			}
		}

		private void ButtonBrowseAlbumImage_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				albumImagePath = openFileDialog.FileName;
				textBoxAlbumImage.Text = albumImagePath;
			}
		}

		private void ButtonUpload_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(trackFilePath))
			{
				MessageBox.Show("Seleziona un file del brano.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string targetDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mp3");
			string targetFile = Path.Combine(targetDir, Path.GetFileName(trackFilePath));
			string fileType = Path.GetExtension(targetFile).ToLower();

			if (fileType != ".mp3" && fileType != ".wav")
			{
				MessageBox.Show("Solo file MP3 e WAV sono ammessi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				System.IO.File.Copy(trackFilePath, targetFile, true);
				MessageBox.Show("File caricato con successo! Compila i campi rimanenti e conferma.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore nel caricamento del file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonConfirm_Click(object sender, EventArgs e)
		{
			string trackTitle = textBoxConfirmTitle.Text;
			string artist = textBoxConfirmArtist.Text;
			string album = textBoxConfirmAlbum.Text;
			string year = textBoxConfirmYear.Text;
			string albumImage = string.IsNullOrEmpty(albumImagePath) ? "default.jpg" : Path.GetFileName(albumImagePath);

			if (string.IsNullOrEmpty(trackTitle) || string.IsNullOrEmpty(artist))
			{
				MessageBox.Show("Compila tutti i campi obbligatori.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				using (var dbHelper = new DatabaseHelper())
				{
					// Insert album if not exists
					int albumId = dbHelper.GetAlbumId(album);
					if (albumId == -1)
					{
						dbHelper.InsertAlbum(album, year, albumImage);
						albumId = dbHelper.GetAlbumId(album);
					}
					else
					{
						// Update album image if a new image was uploaded
						if (albumImage != "default.jpg")
						{
							dbHelper.UpdateAlbumImage(albumId, albumImage);
						}
					}

					// Insert track
					dbHelper.InsertTrack(trackTitle, albumId, Path.GetFileName(trackFilePath));

					// Insert artist and link to album
					var artists = artist.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (var artistName in artists)
					{
						int artistId = dbHelper.GetArtistId(artistName.Trim());
						if (artistId == -1)
						{
							dbHelper.InsertArtist(artistName.Trim());
							artistId = dbHelper.GetArtistId(artistName.Trim());
						}
						dbHelper.LinkArtistToAlbum(artistId, albumId);
					}

					// Link track to user
					dbHelper.LinkTrackToUser(UserId, dbHelper.GetTrackId(trackTitle, albumId));

					MessageBox.Show("Brano caricato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore di sistema: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ExtractMetadata(string filePath)
		{
			try
			{
				var file = TagLib.File.Create(filePath);
				textBoxConfirmTitle.Text = file.Tag.Title;
				textBoxConfirmArtist.Text = string.Join(", ", file.Tag.Performers);
				textBoxConfirmAlbum.Text = file.Tag.Album;
				textBoxConfirmYear.Text = file.Tag.Year.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore nell'estrazione dei metadati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}












