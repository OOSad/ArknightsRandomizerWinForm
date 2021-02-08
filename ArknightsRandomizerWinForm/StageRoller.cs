using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class StageRoller
    {
        public static string Roll_For_Stage()
        {

            StageLists stageLists = Program.stageLists;

            ListWiper.Wipe_A_List_Clean(stageLists.userStages);

            foreach (string stages in stageLists.userStagesDefault)
            {
                stageLists.userStages.Add(stages);
            }

            StageFilter.Filter_Out_Unselected_Stages_From_Pool_Of_Maps(stageLists);

            Random randomNumberGenerator = Program.randomNumberGenerator;

            try
            {
                return stageLists.userStages[randomNumberGenerator.Next(0, stageLists.userStages.Count)];
            }
            catch (ArgumentOutOfRangeException)
            {
                return "Stage Not Found!";
            }
        }
    }
}
