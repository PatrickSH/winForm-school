using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergiForbrug
{
    class FormDisplayActions : FormDisplayActionsInterface
    {
        public void showNewFormAndCloseOld(Form oldForm, Form newForm)
        {
            oldForm.Hide();
            newForm.Closed += (s, args) => oldForm.Close();
            newForm.Show();
        }
    }
}
