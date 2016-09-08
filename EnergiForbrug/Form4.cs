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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void createUsagePage(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void addUsageButtonClick(object sender, EventArgs e)
        {
            UsageDatabaseOperation usage = new UsageDatabaseOperation();
            usage.addUsage(usageType.Text, usageText.Text, usageDate.SelectionRange.Start.ToShortDateString());
        }

        private void overviewLink(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }
    }
}
