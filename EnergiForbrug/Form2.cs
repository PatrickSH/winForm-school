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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void createUserClick(object sender, EventArgs e)
        {
            EnergiDKLib.User user = new EnergiDKLib.User();
            user.addUser(usernameReg.Text, passwordReg.Text, freeOrNot.Checked);
        }
    }
}
