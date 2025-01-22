using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WebMediaPlayer
{
    public partial class FormSearch : Form
    {
        private Homepage mainForm;

        public FormSearch(Homepage parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
            buttonSrc.Click += ButtonSrc_Click;
        }

        private void ButtonSrc_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchText = textBoxSrc.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Inserisci un testo per la ricerca.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dbHelper = new DatabaseHelper())
            {
                var results = dbHelper.SearchDatabase(mainForm.UserId, searchText);

                flowLayoutPanelSrcResults.Controls.Clear();

                foreach (var result in results)
                {
                    var resultPanel = CreateResultPanel(result);
                    flowLayoutPanelSrcResults.Controls.Add(resultPanel);
                }
            }
        }

        private Panel CreateResultPanel((string title, string imagePath) result)
        {
            var panel = new Panel
            {
                Width = flowLayoutPanelSrcResults.Width - 25,
                Height = 100,
                Margin = new Padding(10),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(30, 30, 30) // Nero più scuro
            };

            var pictureBox = new PictureBox
            {
				Image = new Bitmap(new Bitmap(File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "albumimg", result.imagePath))
					? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "albumimg", result.imagePath)
					: File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "artistimg", result.imagePath))
						? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "artistimg", result.imagePath)
						: Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "artistimg", "default.jpg")), 80, 80),
				Width = 80,
                Height = 80,
                Dock = DockStyle.Left
            };

            var labelTitle = new Label
            {
                Text = result.title,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Padding = new Padding(89, 0,0,0)
			};

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(labelTitle);

            return panel;
        }
    }
}
