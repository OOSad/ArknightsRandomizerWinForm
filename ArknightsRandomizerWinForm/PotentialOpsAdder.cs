using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class PotentialOpsAdder
    {
        public static void Add_Ops_To_Potential_List(int specificClassLimit, List<string> userOpsListToRemoveFrom, Random randomNumberGenerator, List<string> potentialOpsToRoll)
        {
            if (specificClassLimit != 0)
            {
                try
                {
                    for (int i = 0; i < specificClassLimit; i++)
                    {
                        int x = randomNumberGenerator.Next(0, userOpsListToRemoveFrom.Count);
                        potentialOpsToRoll.Add(userOpsListToRemoveFrom[x]);
                        userOpsListToRemoveFrom.RemoveAt(x);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    potentialOpsToRoll.Add("No Ops Found!");
                }
            }
        }
    }
}
