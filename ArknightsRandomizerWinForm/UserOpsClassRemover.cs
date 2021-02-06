using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class UserOpsClassRemover
    {
        public static void Remove_Class_From_UserOps_List(int specificClassLimit, List<string> userOpsList, List<string> classListToRemove)
        {
            if (specificClassLimit != 0)
            {
                for (int i = 0; i < classListToRemove.Count; i++)
                {
                    for (int x = 0; x < userOpsList.Count; x++)
                    {
                        if (classListToRemove[i] == userOpsList[x])
                        {
                            userOpsList.RemoveAt(x);
                        }
                    }
                }
            }
        }

    }
}
