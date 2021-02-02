using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ArknightsRandomizerWinForm
{
    static class UserOpsFileHandler
    {
        public static void Create_UserOps_File()
        {
            if (!File.Exists("userOps.txt"))
            {
                using (StreamWriter sw = File.CreateText("userOps.txt"))
                {
                    sw.WriteLine("");
                }
            }
        }
        public static List<string> Read_UserOps_From_File(List<string> listToSaveUserOpsTo)
        {

            foreach (string operators in File.ReadAllLines("userOps.txt"))
            {
                listToSaveUserOpsTo.Add(operators);
            }

            return listToSaveUserOpsTo;
        }
        public static void Write_UserOps_To_File(CheckedListBox checkboxesToReadFrom)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("userOps.txt")))
            {
                for (int i = 0; i < checkboxesToReadFrom.Items.Count; i++)
                {
                    if (checkboxesToReadFrom.GetItemChecked(i) == true)
                    {
                        outputFile.WriteLine(checkboxesToReadFrom.Items[i]);
                    }
                }
            }
        }
    }
}
