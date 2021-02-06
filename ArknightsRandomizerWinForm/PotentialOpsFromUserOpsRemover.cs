using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class PotentialOpsFromUserOpsRemover
    {
        public static void Remove_PotentialOps_From_The_List_Of_UserOps(List<string> potentialOpsToRoll, List<string> userOps)
        {
            for (int i = 0; i < potentialOpsToRoll.Count; i++)
            {
                for (int x = 0; x < userOps.Count; x++)
                {
                    if (userOps[x] == potentialOpsToRoll[i])
                    {
                        userOps.RemoveAt(x);
                    }
                }
            }
        }

    }
}
