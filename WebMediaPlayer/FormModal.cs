using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;
using Guna.UI2.WinForms;

namespace WebMediaPlayer
{
    public partial class FormModal : Form
    {
        private FlowLayoutPanel flowLayoutPanelRecentTracks;
        private FlowLayoutPanel flowLayoutPanelAlbumTracks;
        private FlowLayoutPanel flowLayoutPanelLibraryTracks;
        private WindowsMediaPlayer mediaPlayer;
        private Button buttonPlayPause;
        private Guna2TrackBar trackBarProgress;
        private Timer timer;
        private bool isPlaying = false;

        public FormModal(string itemText, bool isAlbum, bool fromLibrary)
        {
            InitializeComponent();
            InitializeFlowLayoutPanels();
            InitializeMediaControls();
            mediaPlayer = new WindowsMediaPlayer();
            mediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;
            if (!fromLibrary && !isAlbum)
            {
                labelModalTitle.Text = "Brani Aggiunti di Recente";
                LoadRecentTracks(itemText);
            }
            else if (!fromLibrary && isAlbum)
            {
                labelModalTitle.Text = "Brani dell'Album";
                LoadAlbumTracks(itemText);
            }
        }

        private void InitializeFlowLayoutPanels()
        {
            flowLayoutPanelRecentTracks = CreateFlowLayoutPanel();
            flowLayoutPanelAlbumTracks = CreateFlowLayoutPanel();
            flowLayoutPanelLibraryTracks = CreateFlowLayoutPanel();

            // Imposta manualmente le dimensioni e la posizione dei pannelli
            flowLayoutPanelRecentTracks.Size = new Size(594, 525);
            flowLayoutPanelRecentTracks.Location = new Point(0, 95);

            flowLayoutPanelAlbumTracks.Size = new Size(594, 525);
            flowLayoutPanelAlbumTracks.Location = new Point(0, 95);

            flowLayoutPanelLibraryTracks.Size = new Size(594, 525);
            flowLayoutPanelLibraryTracks.Location = new Point(0, 95);

            Controls.Add(flowLayoutPanelRecentTracks);
            Controls.Add(flowLayoutPanelAlbumTracks);
            Controls.Add(flowLayoutPanelLibraryTracks);
        }

        private void InitializeMediaControls()
        {
            buttonPlayPause = new Button
            {
                Width = 32,
                Height = 32,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(29, 185, 84),
                ForeColor = Color.White
            };
            buttonPlayPause.FlatAppearance.BorderSize = 0;
            buttonPlayPause.Click += ButtonPlayPause_Click;
            UpdatePlayPauseButtonImage();

            trackBarProgress = new Guna2TrackBar
            {
                Minimum = 0,
                Maximum = 100,
                Width = 400,
                Height = 10,
                FillColor = Color.FromArgb(30, 30, 30),
                ThumbColor = Color.FromArgb(29, 185, 84),
            };
            trackBarProgress.Scroll += TrackBarProgress_Scroll;

            var panelControls = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            panelControls.Controls.Add(buttonPlayPause);
            panelControls.Controls.Add(trackBarProgress);

            buttonPlayPause.Location = new Point(10, 10);
            trackBarProgress.Location = new Point(50, 20);

            Controls.Add(panelControls);

            timer = new Timer();
            timer.Interval = 1000; // Aggiorna ogni secondo
            timer.Tick += Timer_Tick;
        }

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                mediaPlayer.controls.pause();
                isPlaying = false;
            }
            else
            {
                mediaPlayer.controls.play();
                isPlaying = true;
            }
            UpdatePlayPauseButtonImage();
        }

        private void UpdatePlayPauseButtonImage()
        {
            string imagePath = isPlaying ? "pause.png" : "play.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", imagePath);
            if (File.Exists(fullPath))
            {
                buttonPlayPause.Image = new Bitmap(fullPath);
                buttonPlayPause.Image = new Bitmap(buttonPlayPause.Image, new Size(32, 32));
            }
        }

        private void TrackBarProgress_Scroll(object sender, EventArgs e)
        {
            if (mediaPlayer.currentMedia != null)
            {
                mediaPlayer.controls.currentPosition = mediaPlayer.currentMedia.duration * trackBarProgress.Value / 100.0;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.currentMedia != null)
            {
                trackBarProgress.Value = (int)(mediaPlayer.controls.currentPosition * 100 / mediaPlayer.currentMedia.duration);
            }
        }

        private void MediaPlayer_PlayStateChange(int newState)
        {
            if (newState == (int)WMPPlayState.wmppsPlaying)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private FlowLayoutPanel CreateFlowLayoutPanel()
        {
            return new FlowLayoutPanel
            {
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
                    var trackPanel = CreateRecentTrackPanel(track);
                    flowLayoutPanelRecentTracks.Controls.Add(trackPanel);
                }
            }

            flowLayoutPanelRecentTracks.Visible = true; // Mostra il pannello dei brani recenti
            flowLayoutPanelAlbumTracks.Visible = false;
            flowLayoutPanelLibraryTracks.Visible = false;
        }

        private void LoadAlbumTracks(string album)
        {
            using (var dbHelper = new DatabaseHelper())
            {
                int albumId = dbHelper.GetAlbumId(album); // Assumi che ci sia un metodo per ottenere l'ID dell'album
                var tracks = dbHelper.GetTracksByAlbum(albumId);

                foreach (var track in tracks)
                {
                    var trackPanel = CreateAlbumTrackPanel(track);
                    flowLayoutPanelAlbumTracks.Controls.Add(trackPanel);
                }
            }

            flowLayoutPanelAlbumTracks.Visible = true; // Mostra il pannello dei brani dell'album
            flowLayoutPanelRecentTracks.Visible = false;
            flowLayoutPanelLibraryTracks.Visible = false;
        }

        private Panel CreateRecentTrackPanel((string titolo, string album, string mp3) track)
        {
            var panel = new Panel
            {
                Width = flowLayoutPanelRecentTracks.Width - 25,
                Height = 100,
                Margin = new Padding(10),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(30, 30, 30) // Nero più scuro
            };

            var labelTitle = new Label
            {
                Text = $"Titolo: {track.titolo}",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.White // Testo bianco
            };

            var labelAlbum = new Label
            {
                Text = $"Album: {track.album}",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Arial", 9, FontStyle.Regular),
                ForeColor = Color.White // Testo bianco
            };

            var buttonPlay = new Button
            {
                Text = "Riproduci",
                Dock = DockStyle.Bottom,
                Height = 30,
                BackColor = Color.FromArgb(29, 185, 84), // Verde come quello per l'accesso
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White // Testo bianco
            };
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.Click += (sender, e) => PlayTrack(track.mp3);

            panel.Controls.Add(labelAlbum);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(buttonPlay);
            return panel;
        }

        private Panel CreateAlbumTrackPanel((string titolo, string mp3) track)
        {
            var panel = new Panel
            {
                Width = flowLayoutPanelAlbumTracks.Width - 25,
                Height = 100,
                Margin = new Padding(10),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(30, 30, 30) // Nero più scuro
            };

            var labelTitle = new Label
            {
                Text = $"Titolo: {track.titolo}",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.White // Testo bianco
            };

            var buttonPlay = new Button
            {
                Text = "Riproduci",
                Dock = DockStyle.Bottom,
                Height = 30,
                BackColor = Color.FromArgb(29, 185, 84), // Verde come quello per l'accesso
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White // Testo bianco
            };
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.Click += (sender, e) => PlayTrack(track.mp3);

            panel.Controls.Add(labelTitle);
            panel.Controls.Add(buttonPlay);
            return panel;
        }

        private void PlayTrack(string mp3FileName)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mp3", mp3FileName);
            if (File.Exists(fullPath))
            {
                try
                {
                    mediaPlayer.URL = fullPath;
                    mediaPlayer.controls.play();
                    isPlaying = true;
                    UpdatePlayPauseButtonImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante la riproduzione del file MP3: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File MP3 non trovato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCloseModal_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop();
            this.Close();
        }
    }
}
