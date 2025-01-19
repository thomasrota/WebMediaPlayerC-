using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TagLib;

namespace WebMediaPlayer
{
	public partial class FormUpload : Form
	{
		private Label labelTrackFile;
		private System.Windows.Forms.TextBox textBoxTrackFile;
		private Button buttonBrowseTrack;
		private Label labelAlbumImage;
		private System.Windows.Forms.TextBox textBoxAlbumImage;
		private Button buttonBrowseAlbumImage;
		private Button buttonUpload;
		private Label labelTrackTitle;
		private System.Windows.Forms.TextBox textBoxTrackTitle;
		private Label labelArtist;
		private System.Windows.Forms.TextBox textBoxArtist;
		private Label labelAlbum;
		private System.Windows.Forms.TextBox textBoxAlbum;
		private Label labelYear;
		private System.Windows.Forms.TextBox textBoxYear;
		private Button buttonConfirm;
		private OpenFileDialog openFileDialog;
		private string trackFilePath;
		private string albumImagePath;

		public int UserId { get; set; }

		public FormUpload()
		{
			InitializeComponent();
			InitializeForm();
		}

		private void InitializeForm()
		{
			this.Text = "Carica Brano";
			this.Size = new Size(600, 400);

			labelTrackFile = new Label
			{
				Text = "File del brano",
				Location = new Point(20, 20),
				AutoSize = true
			};
			textBoxTrackFile = new System.Windows.Forms.TextBox
			{
				Location = new Point(150, 20),
				Width = 300
			};
			buttonBrowseTrack = new Button
			{
				Text = "Sfoglia",
				Location = new Point(460, 20)
			};
			buttonBrowseTrack.Click += ButtonBrowseTrack_Click;

			labelAlbumImage = new Label
			{
				Text = "Immagine dell'album (opzionale)",
				Location = new Point(20, 60),
				AutoSize = true
			};
			textBoxAlbumImage = new System.Windows.Forms.TextBox
			{
				Location = new Point(150, 60),
				Width = 300
			};
			buttonBrowseAlbumImage = new Button
			{
				Text = "Sfoglia",
				Location = new Point(460, 60)
			};
			buttonBrowseAlbumImage.Click += ButtonBrowseAlbumImage_Click;

			buttonUpload = new Button
			{
				Text = "Carica",
				Location = new Point(150, 100)
			};
			buttonUpload.Click += ButtonUpload_Click;

			labelTrackTitle = new Label
			{
				Text = "Titolo del brano",
				Location = new Point(20, 140),
				AutoSize = true
			};
			textBoxTrackTitle = new System.Windows.Forms.TextBox
			{
				Location = new Point(150, 140),
				Width = 300
			};

			labelArtist = new Label
			{
				Text = "Artista",
				Location = new Point(20, 180),
				AutoSize = true
			};
			textBoxArtist = new System.Windows.Forms.TextBox
			{
				Location = new Point(150, 180),
				Width = 300
			};

			labelAlbum = new Label
			{
				Text = "Album",
				Location = new Point(20, 220),
				AutoSize = true
			};
			textBoxAlbum = new System.Windows.Forms.TextBox
			{
				Location = new Point(150, 220),
				Width = 300
			};

			labelYear = new Label
			{
				Text = "Anno",
				Location = new Point(20, 260),
				AutoSize = true
			};
			textBoxYear = new System.Windows.Forms.TextBox
			{
				Location = new Point(150, 260),
				Width = 300
			};

			buttonConfirm = new Button
			{
				Text = "Conferma",
				Location = new Point(150, 300)
			};
			buttonConfirm.Click += ButtonConfirm_Click;

			this.Controls.Add(labelTrackFile);
			this.Controls.Add(textBoxTrackFile);
			this.Controls.Add(buttonBrowseTrack);
			this.Controls.Add(labelAlbumImage);
			this.Controls.Add(textBoxAlbumImage);
			this.Controls.Add(buttonBrowseAlbumImage);
			this.Controls.Add(buttonUpload);
			this.Controls.Add(labelTrackTitle);
			this.Controls.Add(textBoxTrackTitle);
			this.Controls.Add(labelArtist);
			this.Controls.Add(textBoxArtist);
			this.Controls.Add(labelAlbum);
			this.Controls.Add(textBoxAlbum);
			this.Controls.Add(labelYear);
			this.Controls.Add(textBoxYear);
			this.Controls.Add(buttonConfirm);

			openFileDialog = new OpenFileDialog();
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
			string trackTitle = textBoxTrackTitle.Text;
			string artist = textBoxArtist.Text;
			string album = textBoxAlbum.Text;
			string year = textBoxYear.Text;
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
				textBoxTrackTitle.Text = file.Tag.Title;
				textBoxArtist.Text = string.Join(", ", file.Tag.Performers);
				textBoxAlbum.Text = file.Tag.Album;
				textBoxYear.Text = file.Tag.Year.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore nell'estrazione dei metadati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}












