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
    public partial class CreateUsageForm : Form
    {
        private FormDisplayActions fda;
        public CreateUsageForm()
        {
            InitializeComponent();
            fda = new FormDisplayActions();
        }

        private void createUsagePage(object sender, EventArgs e)
        {
            fda.showNewFormAndCloseOld(this, new CreateUsageForm());
        }

        private void addUsageButtonClick(object sender, EventArgs e)
        {
            UsageDatabaseOperation usage = new UsageDatabaseOperation();
            usage.addUsage(usageType.Text, usageText.Text, usageDate.SelectionRange.Start.ToShortDateString());
        }

        private void overviewLink(object sender, EventArgs e)
        {
            fda.showNewFormAndCloseOld(this, new ViewForm());
        }
    }
}
