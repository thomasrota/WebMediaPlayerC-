using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WebMediaPlayer
{
    public partial class FormLogin : Form
    {
        private Homepage mainForm;
        public event Action LoginSuccessful;
        public FormLogin(Homepage parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
        }

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string username = textBoxUsername.Text.Trim();
			string password = textBoxPswd.Text.Trim();

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Username e password non possono essere vuoti.", "Errore di login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (var dbHelper = new DatabaseHelper())
			{
				bool isValid = dbHelper.ValidateLogin(username, password);

				if (isValid)
				{
					mainForm.Username = username;
					mainForm.UserId = dbHelper.GetUserId(username);
					LoginSuccessful?.Invoke(); // Invia l'evento per abilitare i pulsanti nella Homepage
					mainForm.CloseFormsInput(); // Chiude il form di login
				}
				else
				{
					MessageBox.Show("Username o password errati.", "Errore di login", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBoxUsername.Text = "";
					textBoxPswd.Text = "";
				}
			}
		}
        private void buttonGoToRegister_Click(object sender, EventArgs e)
        {
            mainForm.CloseFormsInput();
            mainForm.OpenFormInput<FormRegister>();
        }
    }
}
