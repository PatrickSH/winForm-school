using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnergiDKLib;

namespace EnergiForbrug
{
    public partial class LoginForm : Form
    {
        private FormDisplayActions fda;
        public LoginForm()
        {
            InitializeComponent();
            fda = new FormDisplayActions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkToRegister(object sender, EventArgs e)
        {
            fda.showNewFormAndCloseOld(this, new CreateUserForm());
        }

        private void login(object sender, EventArgs e)
        {
            UserDatabaseOperation user = new UserDatabaseOperation();
            if( user.validateLogin( username.Text, password.Text ) )
            {
                fda.showNewFormAndCloseOld(this, new CreateUsageForm());
            }
            else
            {
                MessageBox.Show("Der skete en fejl! prøv igen.");
            }
        }
    }
}
