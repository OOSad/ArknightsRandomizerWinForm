using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class ListWiper
    {
        public static void Wipe_Many_Lists_Clean(params List<string>[] listsThatWillBeWiped)
        {
            foreach (List<string> lists in listsThatWillBeWiped)
            {
                lists.Clear();
            }
        }

        public static void Wipe_A_List_Clean(List<string> listThatWillBeWiped)
        {
            listThatWillBeWiped.Clear();
        }
    }
}
