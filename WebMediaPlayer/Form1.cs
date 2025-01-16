using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebMediaPlayer
{
    public partial class Homepage : Form
    {
        public string Username { get; set; }
		public Homepage()
        {
            InitializeComponent();
            CloseFormsInput();
            SetButtons(false);
            OpenFormInput<FormLogin>();
            buttonViewProfile.Visible = false;
            buttonLogout.Visible = false;
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
                    };
                    FormInput = loginForm;
                }
                else if (typeof(TypeOfForm) == typeof(FormRegister))
                {
                    FormInput = new FormRegister(this); // Passa il riferimento del form principale
                }
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