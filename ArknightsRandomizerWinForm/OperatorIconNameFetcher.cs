using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ArknightsRandomizerWinForm
{
    static class OperatorIconNameFetcher
    {
        public static List<string> GetListOfIconNames()
        {
            DirectoryInfo operatorIconsFilePath = new DirectoryInfo("OperatorIcons");
            List<string> operatorIconNamesList = new List<string>();
            foreach (var fi in operatorIconsFilePath.GetFiles())
            {
                operatorIconNamesList.Add(fi.ToString());
            }

            ListSorter.Sort_A_List_Alphabetically(operatorIconNamesList);
            return operatorIconNamesList;
        }

    }
}
