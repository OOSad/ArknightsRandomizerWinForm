using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ArknightsRandomizerWinForm
{
    class PictureBoxUpdater
    {
        public static void Update_Pictureboxes_On_Form(Form targetForm, List<string> listOfOperatorsToPrintToPictureboxes)
        {
            
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            foreach (PictureBox pictureBox in targetForm.Controls.OfType<PictureBox>())
            {
                if (pictureBox.Name.Contains("opPicture"))
                {
                    pictureBoxes.Add(pictureBox);

                }
            }
            
            int x = 0;
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                try
                {
                    pictureBoxes[i].ImageLocation = (@"OperatorIcons\" + (listOfOperatorsToPrintToPictureboxes[x] + "_icon.png"));
                    Debug.WriteLine(@"OperatorIcons\" + (listOfOperatorsToPrintToPictureboxes[x] + "_icon.png"));
                    x++;
                                
                }
                            
                catch (ArgumentOutOfRangeException)
                {
                    pictureBoxes[i].ImageLocation = (@"OperatorIcons\NoOp_icon.gif");
                }

                
            }
        }
    }
}
