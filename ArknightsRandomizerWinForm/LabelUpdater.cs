using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsRandomizerWinForm
{
    static class LabelUpdater
    {
        public static void Update_Operator_Labels_On_Form(Form targetForm, List<string> listOfOperatorsToPrintToLabels)
        {
            int x = 0;
            for (int i = 0; i < targetForm.Controls.Count; i++)
            {
                if (targetForm.Controls[i] is Label && targetForm.Controls[i].Name.Contains("unit"))
                {
                    try
                    {
                        targetForm.Controls[i].Text = listOfOperatorsToPrintToLabels[x];
                        x++;
                    }

                    catch (ArgumentOutOfRangeException)
                    {
                        targetForm.Controls[i].Text = "//";
                    }

                }
            }
        }
        public static void Update_Stage_Label_On_Form(Form targetForm, string selectedStageToUpdateLabelWith)
        {
            for (int i = 0; i < targetForm.Controls.Count; i++)
            {
                if (targetForm.Controls[i] is Label && targetForm.Controls[i].Name == "StageLabel")
                {
                    targetForm.Controls[i].Text = selectedStageToUpdateLabelWith;
                }
            }
        }
    }
}
