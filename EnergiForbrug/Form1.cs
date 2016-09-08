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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkToRegister(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void login(object sender, EventArgs e)
        {
            EnergiDKLib.User user = new EnergiDKLib.User();
            if( user.validateLogin( username.Text, password.Text ) )
            {
                Form4 newForm = new Form4();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Der skete en fejl! prøv igen.");
            }
        }
    }
}
