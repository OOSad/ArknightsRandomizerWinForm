using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsRandomizerWinForm
{
    static class FormSwapper
    {
        public static void Hide_Current_Form_Then_Open_Next_Form(Form currentForm, Form nextForm)
        {
            currentForm.Hide();
            nextForm.Show();
            nextForm.Location = new System.Drawing.Point(currentForm.Left, currentForm.Top);
        }
    }
}
