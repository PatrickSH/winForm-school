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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            EnergiDKLib.UsageDatabaseOperation usage = new EnergiDKLib.UsageDatabaseOperation();
            
            foreach(string[] fields in usage.getAllUsage())
            {
                showUsageText.AppendText(Environment.NewLine + "Type: " + fields[0] + " Forbrug: " + fields[1] + " Dato: " + fields[2] + " liter benzin brugt: " + fields[3]);
                showUsageText.AppendText(Environment.NewLine + "--------------------");
            }
        }

        private void searchDates(object sender, EventArgs e)
        {
            EnergiDKLib.UsageDatabaseOperation usage = new EnergiDKLib.UsageDatabaseOperation();

            showUsageText.Text = "";

            foreach (string[] fields in usage.getPeriodUsage(usageDateFrom.SelectionRange.Start.ToShortDateString(), usageDateTo.SelectionRange.Start.ToShortDateString()))
            {
                showUsageText.AppendText(Environment.NewLine + "Type: " + fields[0] + " Forbrug: " + fields[1] + " Dato: " + fields[2] + " liter benzin brugt: " + fields[3]);
                showUsageText.AppendText(Environment.NewLine + "--------------------");
            }
        }
    }
}
