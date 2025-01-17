using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebMediaPlayer
{
	public partial class FormModal : Form
	{
		private FlowLayoutPanel flowLayoutPanelRecentTracks;
		private FlowLayoutPanel flowLayoutPanelAlbumTracks;
		private FlowLayoutPanel flowLayoutPanelLibraryTracks;

		public FormModal(string itemText, bool isAlbum, bool fromLibrary)
		{
			InitializeComponent();
			InitializeFlowLayoutPanels();
			if (!fromLibrary && !isAlbum)
			{
				labelModalTitle.Text = "Brani Aggiunti di Recente";
				LoadRecentTracks(itemText);
			}
			else if (!fromLibrary && isAlbum)
			{
				labelModalTitle.Text = "Brani dell'Album";
			}
		}

		private void InitializeFlowLayoutPanels()
		{
			flowLayoutPanelRecentTracks = CreateFlowLayoutPanel();
			flowLayoutPanelAlbumTracks = CreateFlowLayoutPanel();
			flowLayoutPanelLibraryTracks = CreateFlowLayoutPanel();

			Controls.Add(flowLayoutPanelRecentTracks);
			Controls.Add(flowLayoutPanelAlbumTracks);
			Controls.Add(flowLayoutPanelLibraryTracks);
		}

		private FlowLayoutPanel CreateFlowLayoutPanel()
		{
			return new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				FlowDirection = FlowDirection.TopDown,
				WrapContents = false,
				AutoScroll = true,
				Visible = false
			};
		}

		private void LoadRecentTracks(string artist)
		{
			using (var dbHelper = new DatabaseHelper())
			{
				var tracks = dbHelper.GetRecentTracksByArtist(artist);

				foreach (var track in tracks)
				{
					var trackPanel = CreateTrackPanel(track);
					flowLayoutPanelRecentTracks.Controls.Add(trackPanel);
				}
			}

			flowLayoutPanelRecentTracks.Visible = true; // Mostra il pannello dei brani recenti
		}

		private Panel CreateTrackPanel((string titolo, string album, string mp3) track)
		{
			var panel = new Panel
			{
				Width = flowLayoutPanelRecentTracks.Width - 25,
				Height = 50,
				Margin = new Padding(5),
				BorderStyle = BorderStyle.FixedSingle
			};

			var labelTitle = new Label
			{
				Text = $"Titolo: {track.titolo}",
				Dock = DockStyle.Top,
				TextAlign = ContentAlignment.MiddleLeft
			};

			var labelAlbum = new Label
			{
				Text = $"Album: {track.album}",
				Dock = DockStyle.Top,
				TextAlign = ContentAlignment.MiddleLeft
			};

			panel.Controls.Add(labelAlbum);
			panel.Controls.Add(labelTitle);
			return panel;
		}

		private void buttonCloseModal_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}