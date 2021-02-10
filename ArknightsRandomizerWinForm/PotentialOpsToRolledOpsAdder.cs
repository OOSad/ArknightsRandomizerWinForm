using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class PotentialOpsToRolledOpsAdder
    {
        
        public static int Add_PotentialOps_List_To_List_Of_RolledOps_And_Increment_SquadSize(List<string> potentialOpsToRoll, List<string> rolledOps, int currentSquadSize)
        {
            
            if (potentialOpsToRoll.Count != 0)
            {
                for (int i = 0; i < potentialOpsToRoll.Count; i++)
                {
                    rolledOps.Add(potentialOpsToRoll[i]);
                    currentSquadSize++;
                }
            }

            return currentSquadSize;
        }
    }
}
