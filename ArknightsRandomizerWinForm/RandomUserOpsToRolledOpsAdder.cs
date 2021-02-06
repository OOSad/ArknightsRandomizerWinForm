using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class RandomUserOpsToRolledOpsAdder
    {
        public static void Add_RandomUserOps_To_List_Of_RolledOps(int maxSquadSize, int currentSquadSize, Random randomNumberGenerator, List<string> userOps, List<string> rolledOps)
        {
            for (int i = currentSquadSize; i < maxSquadSize; i++)
            {
                try
                {
                    int x = randomNumberGenerator.Next(0, userOps.Count);
                    rolledOps.Add(userOps[x]);
                    userOps.RemoveAt(x);
                }
                catch (ArgumentOutOfRangeException)
                { rolledOps.Add("No Ops Found!"); }
            }
        }

    }
}
