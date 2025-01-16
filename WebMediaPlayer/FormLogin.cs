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

namespace WebMediaPlayer
{
    public partial class FormLogin : Form
    {
        private Homepage mainForm;
        public FormLogin(Homepage parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
        }
        private void buttonGoToRegister_Click(object sender, EventArgs e)
        {
            mainForm.CloseFormsInput();
            mainForm.OpenFormInput<FormRegister>();
        }
    }
}
