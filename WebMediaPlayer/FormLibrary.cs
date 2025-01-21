using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg;

namespace WebMediaPlayer
{
	public partial class FormLibrary : Form
	{
		private Homepage mainForm;
		public int UserId { get; set; }
		public FormLibrary(Homepage parentForm)
		{
			mainForm = parentForm;
			InitializeComponent();
			LoadArtists();
		}

		private void LoadArtists()
		{
			var artists = GetArtistsFromDatabase();

			foreach (var artist in artists)
			{
				var artistPanel = CreateArtistPanel(artist);
				flowLayoutPanelArtists.Controls.Add(artistPanel);
			}
		}

		private List<(int id, string nome, string immagine, int numeroAlbum, int numeroBrani)> GetArtistsFromDatabase()
		{
			var artists = new List<(int id, string nome, string immagine, int numeroAlbum, int numeroBrani)>();

			using (var dbHelper = new DatabaseHelper())
			{
				var recentArtists = dbHelper.GetRecentArtists(mainForm.UserId);

				foreach (var artist in recentArtists)
				{
					int numeroAlbum = dbHelper.GetAlbumCountByArtist(artist.id);
					int numeroBrani = dbHelper.GetTrackCountByArtist(artist.id);
					artists.Add((artist.id, artist.nome, artist.immagine, numeroAlbum, numeroBrani));
				}
			}

			return artists;
		}

		private Panel CreateArtistPanel((int id, string nome, string immagine, int numeroAlbum, int numeroBrani) artist)
		{
			var panel = new Panel
			{
				Width = 750,
				Height = 80,
				Margin = new Padding(10),
				Padding = new Padding(10),
				BorderStyle = BorderStyle.FixedSingle,
				BackColor = Color.FromArgb(30, 30, 30) // Nero più scuro
			};

			string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "artistimg", artist.immagine);
			if (!File.Exists(imagePath))
			{
				imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "artistimg", "default.jpg");
			}

			var pictureBox = new PictureBox
			{
				Image = Image.FromFile(imagePath),
				SizeMode = PictureBoxSizeMode.StretchImage,
				Width = 80,
				Height = 80,
				Cursor = Cursors.Hand
			};
			pictureBox.MouseEnter += (sender, e) => ShowChangeImageButton(pictureBox, artist.id);
			pictureBox.MouseLeave += (sender, e) => HideChangeImageButton(pictureBox);

			var labelName = new Label
			{
				Text = artist.nome,
				TextAlign = ContentAlignment.MiddleLeft,
				Font = new Font("Arial", 10, FontStyle.Bold),
				ForeColor = Color.White, // Testo bianco
				AutoSize = true,
				Location = new Point(89, 10)
			};

			var labelAlbumCount = new Label
			{
				Text = $"{artist.numeroAlbum} Album, {artist.numeroBrani} Tracce",
				TextAlign = ContentAlignment.MiddleLeft,
				Font = new Font("Arial", 9, FontStyle.Regular),
				ForeColor = Color.LightGray, // Testo grigio chiaro
				AutoSize = true,
				Location = new Point(89, 40)
			};

			var buttonViewAlbums = new Button
			{
				Text = "Mostra Album",
				Width = 100,
				Height = 30,
				BackColor = Color.FromArgb(29, 185, 84), // Verde come quello per l'accesso
				FlatStyle = FlatStyle.Flat,
				ForeColor = Color.White,
				Location = new Point(600, 25)
			};
			buttonViewAlbums.FlatAppearance.BorderSize = 0;
			buttonViewAlbums.Click += (sender, e) => OpenModal(artist.nome);

			panel.Controls.Add(pictureBox);
			panel.Controls.Add(labelName);
			panel.Controls.Add(labelAlbumCount);
			panel.Controls.Add(buttonViewAlbums);

			return panel;
		}

		private void ShowChangeImageButton(PictureBox pictureBox, int artistId)
		{
			var buttonChangeImage = new Button
			{
				Text = "Cambia Immagine",
				Width = pictureBox.Width,
				Height = 80,
				BackColor = Color.FromArgb(29, 185, 84), // Verde come quello per l'accesso
				FlatStyle = FlatStyle.Flat,
				ForeColor = Color.White, // Testo bianco
				Visible = true
			};
			buttonChangeImage.FlatAppearance.BorderSize = 0;
			buttonChangeImage.Click += (sender, e) => ChangeArtistImage(artistId);

			pictureBox.Controls.Add(buttonChangeImage);
			buttonChangeImage.BringToFront();
		}

		private void HideChangeImageButton(PictureBox pictureBox)
		{
			foreach (Control control in pictureBox.Controls)
			{
				if (control is Button button && button.Text == "Cambia Immagine")
				{
					pictureBox.Controls.Remove(button);
					break;
				}
			}
		}

		private void ChangeArtistImage(int artistId)
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string newImagePath = openFileDialog.FileName;
					string targetDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "artistimg");
					string targetFile = Path.Combine(targetDir, Path.GetFileName(newImagePath));

					try
					{
						File.Copy(newImagePath, targetFile, true);
						using (var dbHelper = new DatabaseHelper())
						{
							dbHelper.UpdateArtistImage(artistId, Path.GetFileName(newImagePath));
						}
						MessageBox.Show("Immagine aggiornata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Errore durante l'aggiornamento dell'immagine: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void OpenModal(string artistName)
		{
			using (var modal = new FormModal(artistName, false, true))
			{
				modal.ShowDialog();
			}
		}
	}
}

