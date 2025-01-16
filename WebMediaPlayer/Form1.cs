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
        private void OpenFormInput<MyForm>() where MyForm : Form, new()
        {
            Form FormInput;
            FormInput = panelApp.Controls.OfType<MyForm>().FirstOrDefault();
            if (FormInput == null)
            {
                FormInput = new MyForm();
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
        private void CloseFormsInput()
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