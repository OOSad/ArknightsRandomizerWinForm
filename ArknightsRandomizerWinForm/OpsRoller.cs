using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ArknightsRandomizerWinForm
{
    class OpsRoller
    {
        public static void Roll_Ops_And_Create_Roster(int maxSquadSize)
        {
            int currentSquadSize = 1;
            List<string> rolledOps = Program.rolledOps;
            List<string> userOps = Program.userOps;
            List<string> potentialOpsToRoll = Program.potentialOpsToRoll;

            ListWiper.Wipe_Many_Lists_Clean(rolledOps, userOps, potentialOpsToRoll);

            UserOpsFileHandler.Read_UserOps_From_File(userOps);


            OperatorClassLists operatorClassLists = Program.operatorClassesLists;

            List<List<string>> listsToReset = new List<List<string>>() { operatorClassLists.userMedicOperators, operatorClassLists.userSupporterOperators, operatorClassLists.userSniperOperators, operatorClassLists.userVanguardOperators, operatorClassLists.userSpecialistOperators, operatorClassLists.userDefenderOperators, operatorClassLists.userGuardOperators, operatorClassLists.userCasterOperators };
            List<List<string>> listsOfDefaults = new List<List<string>>() { operatorClassLists.defaultUserMedicOperators, operatorClassLists.defaultUserSupporterOperators, operatorClassLists.defaultUserSniperOperators, operatorClassLists.defaultUserVanguardOperators, operatorClassLists.defaultUserSpecialistOperators, operatorClassLists.defaultUserDefenderOperators, operatorClassLists.defaultUserGuardOperators, operatorClassLists.defaultUserCasterOperators };

            for (int i = 0; i < listsOfDefaults.Count; i++)
            {
                ListResetter.Reset_A_List_To_Its_Default_Values(listsToReset[i], listsOfDefaults[i]);
            }


            OperatorRarityLists operatorRarityLists = Program.operatorRarityLists;

            ClassesFilter.Filter_Out_Unselected_Classes_From_Pool_Of_UserOps(operatorClassLists, userOps);
            RaritiesFilter.Filter_Out_Unselected_Rarities_From_Pool_Of_UserOps(operatorRarityLists, operatorClassLists, userOps);

            int medicLimit = Program.medicLimit;
            int supporterLimit = Program.supporterLimit;
            int sniperLimit = Program.sniperLimit;
            int vanguardLimit = Program.vanguardLimit;
            int specialistLimit = Program.specialistLimit;
            int defenderLimit = Program.defenderLimit;
            int guardLimit = Program.guardLimit;
            int casterLimit = Program.casterLimit;
            Random randomNumberGenerator = Program.randomNumberGenerator;


            PotentialOpsAdder.Add_Ops_To_Potential_List(medicLimit, operatorClassLists.userMedicOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(medicLimit, userOps, operatorClassLists.userMedicOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(supporterLimit, operatorClassLists.userSupporterOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(supporterLimit, userOps, operatorClassLists.userSupporterOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(sniperLimit, operatorClassLists.userSniperOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(sniperLimit, userOps, operatorClassLists.userSniperOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(vanguardLimit, operatorClassLists.userVanguardOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(vanguardLimit, userOps, operatorClassLists.userVanguardOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(specialistLimit, operatorClassLists.userSpecialistOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(specialistLimit, userOps, operatorClassLists.userSpecialistOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(defenderLimit, operatorClassLists.userDefenderOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(defenderLimit, userOps, operatorClassLists.userDefenderOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(guardLimit, operatorClassLists.userGuardOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(guardLimit, userOps, operatorClassLists.userGuardOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(casterLimit, operatorClassLists.userCasterOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(casterLimit, userOps, operatorClassLists.userCasterOperators);

            foreach (string operators in potentialOpsToRoll ){ Debug.Write(operators + " "); }
            Debug.WriteLine("");


            currentSquadSize = PotentialOpsToRolledOpsAdder.Add_PotentialOps_List_To_List_Of_RolledOps_And_Increment_SquadSize(potentialOpsToRoll, rolledOps, currentSquadSize);

            Debug.WriteLine(currentSquadSize);

            foreach (string operators in rolledOps) { Debug.Write(operators + " "); }
            Debug.WriteLine("");

            PotentialOpsFromUserOpsRemover.Remove_PotentialOps_From_The_List_Of_UserOps(potentialOpsToRoll, userOps);



            RandomUserOpsToRolledOpsAdder.Add_RandomUserOps_To_List_Of_RolledOps(maxSquadSize, currentSquadSize, randomNumberGenerator, userOps, rolledOps);

            foreach (string operators in rolledOps) { Debug.Write(operators + " "); }
            Debug.WriteLine("");


            ListSorter.Sort_A_List_Alphabetically(rolledOps);

            //foreach (string operators in rolledOps){Debug.Write(operators + " ");}

            Debug.WriteLine("");
        }
    }
}
