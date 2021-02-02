using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsRandomizerWinForm
{
    static class CheckboxChecker
    {
        public static CheckedListBox Check_All_The_Checkboxes_In_A_Page_Based_On_A_List(List<string> listOfOpsToApply, CheckedListBox checkboxesToApplyTo)
        {
            for (int i = 0; i < listOfOpsToApply.Count; i++)
            {
                for (int x = 0; x < checkboxesToApplyTo.Items.Count; x++)
                {
                    if ((string)checkboxesToApplyTo.Items[x] == listOfOpsToApply[i])
                    {
                        checkboxesToApplyTo.SetItemChecked(x, true);
                    }
                }
            }

            return checkboxesToApplyTo;
        }

        public static void Check_Every_Checkbox_On_This_Form(Form targetForm)
        {
            List<Control> checkedListBoxes = new List<Control> ();
            
            for (int i = 0; i < targetForm.Controls.Count; i++)
            {
                if (targetForm.Controls[i] is CheckedListBox)
                {
                    checkedListBoxes.Add(targetForm.Controls[i]);
                }
            }


            foreach (CheckedListBox checkedListBox in checkedListBoxes)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, true);
                }
            }
        }

    }
}
