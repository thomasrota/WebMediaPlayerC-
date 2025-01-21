using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WebMediaPlayer
{
	public partial class FormProfile : Form
	{
		private Homepage mainForm;

		public FormProfile(Homepage parentForm)
		{
			mainForm = parentForm;
			InitializeComponent();
			LoadUserProfile();
			buttonChangeImage.Visible = false;
		}

		private void LoadUserProfile()
		{
			using (var dbHelper = new DatabaseHelper())
			{
				string imgPath = dbHelper.GetUsrImg(mainForm.UserId);
				string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usrimg", imgPath);
				if (!File.Exists(fullPath))
				{
					fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usrimg", "default.jpg");
				}
				Image profileImage = Image.FromFile(fullPath);
				pictureBoxPfp.Image = new Bitmap(profileImage, new Size(100, 100)); 

				var user = dbHelper.GetUserById(mainForm.UserId);
				textBoxChangeUsername.Text = user.Username;
			}
		}

		private void pictureBoxPfp_MouseEnter(object sender, EventArgs e)
		{
			ShowChangeImageButton();
		}

		private void pictureBoxPfp_MouseLeave(object sender, EventArgs e)
		{
			HideChangeImageButton();
		}

		private void ShowChangeImageButton()
		{
			buttonChangeImage.Visible = true;
			pictureBoxPfp.Controls.Add(buttonChangeImage);
			buttonChangeImage.BringToFront();
		}

		private void HideChangeImageButton()
		{
			buttonChangeImage.Visible = false;
			pictureBoxPfp.Controls.Remove(buttonChangeImage);
		}

		private void buttonChangeImage_Click(object sender, EventArgs e)
		{
			ChangeProfileImage();
		}

		private void ChangeProfileImage()
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string newImagePath = openFileDialog.FileName;
					string targetDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usrimg");
					string targetFile = Path.Combine(targetDir, Path.GetFileName(newImagePath));

					try
					{
						File.Copy(newImagePath, targetFile, true);
						using (var dbHelper = new DatabaseHelper())
						{
							dbHelper.UpdateUserImage(mainForm.UserId, Path.GetFileName(newImagePath));
						}
						pictureBoxPfp.Image = Image.FromFile(targetFile);
						MessageBox.Show("Immagine aggiornata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Errore durante l'aggiornamento dell'immagine: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void SaveProfileChanges()
		{
			string newUsername = textBoxChangeUsername.Text;
			string newPassword = textBoxChangePassword.Text;
			string confirmPassword = textBoxConfirmChangePswd.Text;

			if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
			{
				MessageBox.Show("Compila tutti i campi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (newPassword != confirmPassword)
			{
				MessageBox.Show("Le password non corrispondono.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				using (var dbHelper = new DatabaseHelper())
				{
					dbHelper.UpdateUserProfile(mainForm.UserId, newUsername, newPassword);
					MessageBox.Show("Profilo aggiornato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore durante l'aggiornamento del profilo: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonUpdateProfile_Click(object sender, EventArgs e)
		{
			SaveProfileChanges();
		}
	}
}

