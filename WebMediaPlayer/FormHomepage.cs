using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebMediaPlayer
{
	public partial class FormHomepage : Form
	{
		private Homepage mainForm;

		public FormHomepage(Homepage parentForm)
		{
			mainForm = parentForm;
			InitializeComponent();
			LoadCards();
			if (DateTime.Now.Hour < 12)
				labelWelcome.Text = $"Buongiorno, {mainForm.Username}";
			else if (DateTime.Now.Hour < 18)
				labelWelcome.Text = $"Buon pomeriggio, {mainForm.Username}";
			else
				labelWelcome.Text = $"Buona sera, {mainForm.Username}";
			if (GetRecentItemsFromDatabase().Count > 0 && GetRecommendedItemsFromDatabase().Count > 0)
			{
				labelRecents.Visible = true;
				flowLayoutPanelRecents.Visible = true;
				labelRecomended.Visible = true;
				flowLayoutPanelRecomended.Visible = true;
			}
		}

		private void LoadCards()
		{
			var recentItems = GetRecentItemsFromDatabase();
			foreach (var item in recentItems)
			{
				var card = CreateCard(item, false); // false indica che è un artista
				flowLayoutPanelRecents.Controls.Add(card);
			}

			var recommendedItems = GetRecommendedItemsFromDatabase();
			foreach (var item in recommendedItems)
			{
				var card = CreateCard(item, true); // true indica che è un album
				flowLayoutPanelRecomended.Controls.Add(card);
			}
		}

		private List<(string, string)> GetRecentItemsFromDatabase()
		{
			var items = new List<(string, string)>();

			using (var dbHelper = new DatabaseHelper())
			{
				var recentArtists = dbHelper.GetRecentArtists(mainForm.UserId);

				foreach (var artist in recentArtists)
				{
					items.Add((artist.nome, artist.immagine));
				}
			}

			return items;
		}

		private List<(string, string)> GetRecommendedItemsFromDatabase()
		{
			var items = new List<(string, string)>();

			using (var dbHelper = new DatabaseHelper())
			{
				var recommendedAlbums = dbHelper.GetRecommendedAlbums(mainForm.UserId);

				foreach (var album in recommendedAlbums)
				{
					items.Add((album.titolo, album.immagine));
				}
			}

			return items;
		}

		private Panel CreateCard((string text, string imagePath) item, bool isAlbum)
		{
			var card = new Panel
			{
				Width = 200,
				Height = 250,
				Margin = new Padding(10),
				BorderStyle = BorderStyle.FixedSingle,
				BackColor = Color.FromArgb(51, 51, 51)
			};

			string imagePath = item.imagePath;
			if (!File.Exists(imagePath))
			{
				imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "default.jpg"); // Percorso assoluto dell'immagine predefinita
			}

			var pictureBox = new PictureBox
			{
				Image = Image.FromFile(imagePath),
				SizeMode = PictureBoxSizeMode.StretchImage,
				Dock = DockStyle.Top,
				Height = 200
			};

			var label = new Label
			{
				Text = item.text,
				Dock = DockStyle.Top,
				TextAlign = ContentAlignment.MiddleCenter,
				Font = new Font("Segoe UI", 9, FontStyle.Regular),
				ForeColor = Color.White
			};

			var button = new Button
			{
				Text = "Mostra Brani",
				Dock = DockStyle.Bottom,
				Height = 30,
				BackColor = Color.FromArgb(29, 185, 84),
				ForeColor = Color.White,
				Font = new Font("Segoe UI", 9, FontStyle.Bold),
				FlatStyle = FlatStyle.Flat,
				FlatAppearance = { BorderSize = 0 }
			};

			button.Click += (sender, e) => OpenModal(item.text, isAlbum, false);

			card.Controls.Add(label);
			card.Controls.Add(button);
			card.Controls.Add(pictureBox);
			return card;
		}

		private void OpenModal(string itemText, bool isAlbum, bool fromLibrary)
		{
			using (var modal = new FormModal(itemText, isAlbum, fromLibrary))
			{
				modal.ShowDialog();
			}
		}
	}
}