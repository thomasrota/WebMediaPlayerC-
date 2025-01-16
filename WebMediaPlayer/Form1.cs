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
        public Homepage()
        {
            InitializeComponent();
            CloseFormsInput();
            OpenFormInput<FormLogin>();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Funzioni servizio
        // Funzione per aprire un form in un pannello
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