using System.Windows.Forms;

namespace EnergiForbrug
{
    internal interface FormDisplayActionsInterface
    {
        void showNewFormAndCloseOld(Form oldForm, Form newForm);
    }
}