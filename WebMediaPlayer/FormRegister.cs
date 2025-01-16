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
    public partial class FormRegister : Form
    {
        private Homepage mainForm;
        public FormRegister(Homepage parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
	        string username = textBoxRegisterUsername.Text.Trim();
			string email = textBoxRegisterEmail.Text.Trim();
			string password = textBoxRegisterPassword.Text.Trim();
			string confirmPswd = textBoxRegConfirmPswd.Text.Trim();

	        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(confirmPswd))
	        {
		        MessageBox.Show("Compilare i campi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return;
	        }

	        using (var dbHelper = new DatabaseHelper())
	        {
                if(password != confirmPswd)
	                MessageBox.Show("Le password non corrispondono.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bool isValid = dbHelper.RegisterUser(username, email, password);
                if (isValid)
	                MessageBox.Show("Registrazione avvenuta con successo!", "WebMediaPlayer", MessageBoxButtons.OK,
		                MessageBoxIcon.Information);
                else
					MessageBox.Show("Errore durante la registrazione dell'utente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void buttonGoToLogin_Click(object sender, EventArgs e)
        {
            mainForm.CloseFormsInput();
            mainForm.OpenFormInput<FormLogin>();
        }
    }
}
