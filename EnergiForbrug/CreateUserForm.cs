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
    public partial class CreateUserForm : Form
    {
        private FormDisplayActions fda;
        public CreateUserForm()
        {
            InitializeComponent();
            fda = new FormDisplayActions();
        }

        private void createUserClick(object sender, EventArgs e)
        {
            UserDatabaseOperation user = new UserDatabaseOperation();
            user.addUser(usernameReg.Text, passwordReg.Text, freeOrNot.Checked);
            fda.showNewFormAndCloseOld(this, new LoginForm());
        }
    }
}
