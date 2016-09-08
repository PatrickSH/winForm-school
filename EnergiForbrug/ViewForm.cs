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
    public partial class ViewForm : Form
    {
        private UsageDatabaseOperation usage;
        private FormDisplayActions fda;
        public ViewForm()
        {
            InitializeComponent();
            fda = new FormDisplayActions();
            this.usage = new UsageDatabaseOperation();
            
            foreach(string[] fields in usage.getAllUsage())
            {
                showUsageText.AppendText(Environment.NewLine + "Type: " + fields[0] + " Forbrug: " + fields[1] + " Dato: " + fields[2] + " liter benzin brugt: " + fields[3]);
                showUsageText.AppendText(Environment.NewLine + "--------------------");
            }
        }

        private void searchDates(object sender, EventArgs e)
        {
            showUsageText.Text = "";

            foreach (string[] fields in this.usage.getPeriodUsage(usageDateFrom.SelectionRange.Start.ToShortDateString(), usageDateTo.SelectionRange.Start.ToShortDateString()))
            {
                showUsageText.AppendText(Environment.NewLine + "Type: " + fields[0] + " Forbrug: " + fields[1] + " Dato: " + fields[2] + " liter benzin brugt: " + fields[3]);
                showUsageText.AppendText(Environment.NewLine + "--------------------");
            }
        }

        private void create_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fda.showNewFormAndCloseOld(this, new CreateUsageForm());
        }
    }
}
