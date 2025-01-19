using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebMediaPlayer
{
	public partial class Homepage : Form
	{
		public string Username { get; set; }
		public int UserId { get; set; }
		private Image initialProfileImage;

		public Homepage()
		{
			InitializeComponent();
			CloseFormsInput();
			SetButtons(false);
			OpenFormInput<FormLogin>();
			buttonViewProfile.Visible = false;
			buttonLogout.Visible = false;

			// Salva l'immagine iniziale del pulsante del profilo
			initialProfileImage = buttonProfile.Image;
		}

		#region Funzioni eventi

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonHome_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			OpenFormInput<FormHomepage>();
		}

		private void buttonSrc_Click(object sender, EventArgs e)
		{

		}

		private void buttonUpload_Click(object sender, EventArgs e)
		{

		}

		private void buttonLibrary_Click(object sender, EventArgs e)
		{

		}

		private void buttonViewProfile_Click(object sender, EventArgs e)
		{

		}

		private void buttonProfile_Click(object sender, EventArgs e)
		{
			ToggleProfileActions();
		}

		private void buttonLogout_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			SetButtons(false);
			buttonViewProfile.Visible = false;
			buttonLogout.Visible = false;
			buttonProfile.Text = "Profilo";
			buttonProfile.Image = initialProfileImage; // Ripristina l'immagine iniziale del profilo
			OpenFormInput<FormLogin>();
		}

		#endregion

		#region Funzioni servizio

		public void SetButtons(bool isEnabled)
		{
			buttonHome.Enabled = isEnabled;
			buttonSrc.Enabled = isEnabled;
			buttonUpload.Enabled = isEnabled;
			buttonLibrary.Enabled = isEnabled;
			buttonProfile.Enabled = isEnabled;
		}

		public void ToggleProfileActions()
		{
			if (buttonViewProfile.Visible && buttonLogout.Visible)
			{
				buttonViewProfile.Visible = false;
				buttonLogout.Visible = false;
			}
			else
			{
				buttonViewProfile.Visible = true;
				buttonLogout.Visible = true;
			}
		}

		// Funzione per aprire un form in un pannello
		public void OpenFormInput<TypeOfForm>() where TypeOfForm : Form
		{
			Form FormInput = panelApp.Controls.OfType<TypeOfForm>().FirstOrDefault();

			if (FormInput == null)
			{
				// Controlla il tipo del form e istanzialo con il costruttore appropriato
				if (typeof(TypeOfForm) == typeof(FormLogin))
				{
					FormInput = new FormLogin(this); // Passa il riferimento del form principale
					var loginForm = new FormLogin(this);
					loginForm.LoginSuccessful += () =>
					{
						SetButtons(true);
						buttonProfile.Text = Username;
						SetProfileImage(); // Imposta l'immagine del profilo
					};
					FormInput = loginForm;
				}
				else if (typeof(TypeOfForm) == typeof(FormRegister))
					FormInput = new FormRegister(this);
				else if (typeof(TypeOfForm) == typeof(FormHomepage))
					FormInput = new FormHomepage(this);
				else
				{
					// Usa il costruttore predefinito per altri form
					FormInput = Activator.CreateInstance<TypeOfForm>();
				}

				FormInput.TopLevel = false;
				FormInput.FormBorderStyle = FormBorderStyle.None;
				FormInput.Dock = DockStyle.Fill;
				panelApp.Controls.Add(FormInput);
				panelApp.Tag = FormInput;
				FormInput.Show();
				FormInput.BringToFront();
			}
			else
			{
				FormInput.BringToFront();
			}
		}

		private void SetProfileImage()
		{
			using (var dbHelper = new DatabaseHelper())
			{
				string imgPath = dbHelper.GetUsrImg(UserId);
				string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usrimg", imgPath);
				if (!File.Exists(fullPath))
				{
					fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usrimg", "default.jpg");
				}

				Image profileImage = Image.FromFile(fullPath);
				buttonProfile.Image = new Bitmap(profileImage, new Size(32, 32));
				buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
				buttonProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
			}
		}

		// Funzione per chiudere form nel pannello
		public void CloseFormsInput()
		{
			Form FormInput = panelApp.Controls.OfType<Form>().FirstOrDefault();
			if (FormInput != null)
			{
				FormInput.Close();
			}
		}

		#endregion
	}
}