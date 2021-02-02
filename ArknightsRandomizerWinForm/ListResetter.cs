using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class ListResetter
    {
        public static void Reset_A_List_To_Its_Default_Values(List<string> listToReset, List<string> listOfDefaults)
        {
            ListWiper.Wipe_A_List_Clean(listToReset);

            for (int i = 0; i < listOfDefaults.Count; i++)
            {
                listToReset.Add(listOfDefaults[i]);
            }
        }
    }
}
