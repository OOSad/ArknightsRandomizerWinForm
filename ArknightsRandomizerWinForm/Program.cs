﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ArknightsRandomizerWinForm
{
    static class Program
    {
        public static StageLists stageLists = new StageLists();
        public static OperatorRarityLists operatorRarityLists = new OperatorRarityLists();
        public static OperatorClassLists operatorClassesLists = new OperatorClassLists();

        public static List<string> userOps = new List<string>() { };
        public static List<string> rolledOps = new List<string>() { };
        public static List<string> potentialOpsToRoll = new List<string> { };
        public static List<string> rolledStages = new List<string>() { };

        public static Random randomNumberGenerator = new Random();

        public static int maxSquadSize = 1;
        public static int medicLimit = 0;
        public static int supporterLimit = 0;
        public static int sniperLimit = 0;
        public static int vanguardLimit = 0;
        public static int specialistLimit = 0;
        public static int defenderLimit = 0;
        public static int guardLimit = 0;
        public static int casterLimit = 0;

        public static string selectedStage = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserRosterScreen());
        }

        public static void Roll_Ops_And_Create_Roster(int maxSquadSize)
        {
            int currentSquadSize = 0;

            ListWiper.Wipe_Many_Lists_Clean(rolledOps, userOps, potentialOpsToRoll);

            UserOpsFileHandler.Read_UserOps_From_File(userOps);

            List<List<string>> listsToReset = new List<List<string>>() { operatorClassesLists.userMedicOperators, operatorClassesLists.userSupporterOperators, operatorClassesLists.userSniperOperators, operatorClassesLists.userVanguardOperators, operatorClassesLists.userSpecialistOperators, operatorClassesLists.userDefenderOperators, operatorClassesLists.userGuardOperators, operatorClassesLists.userCasterOperators };
            List<List<string>> listsOfDefaults = new List<List<string>>() { operatorClassesLists.defaultUserMedicOperators, operatorClassesLists.defaultUserSupporterOperators, operatorClassesLists.defaultUserSniperOperators, operatorClassesLists.defaultUserVanguardOperators, operatorClassesLists.defaultUserSpecialistOperators, operatorClassesLists.defaultUserDefenderOperators, operatorClassesLists.defaultUserGuardOperators, operatorClassesLists.defaultUserCasterOperators };

            for (int i = 0; i < listsOfDefaults.Count; i++)
            {
                ListResetter.Reset_A_List_To_Its_Default_Values(listsToReset[i], listsOfDefaults[i]);
            }

            ClassesFilter.Filter_Out_Unselected_Classes_From_Pool_Of_UserOps(operatorClassesLists, userOps);
            RaritiesFilter.Filter_Out_Unselected_Rarities_From_Pool_Of_UserOps(operatorRarityLists, operatorClassesLists, userOps);

            PotentialOpsAdder.Add_Ops_To_Potential_List(medicLimit, operatorClassesLists.userMedicOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(medicLimit, userOps, operatorClassesLists.userMedicOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(supporterLimit, operatorClassesLists.userSupporterOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(supporterLimit, userOps, operatorClassesLists.userSupporterOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(sniperLimit, operatorClassesLists.userSniperOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(sniperLimit, userOps, operatorClassesLists.userSniperOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(vanguardLimit, operatorClassesLists.userVanguardOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(vanguardLimit, userOps, operatorClassesLists.userVanguardOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(specialistLimit, operatorClassesLists.userSpecialistOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(specialistLimit, userOps, operatorClassesLists.userSpecialistOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(defenderLimit, operatorClassesLists.userDefenderOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(defenderLimit, userOps, operatorClassesLists.userDefenderOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(guardLimit, operatorClassesLists.userGuardOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(guardLimit, userOps, operatorClassesLists.userGuardOperators);
            PotentialOpsAdder.Add_Ops_To_Potential_List(casterLimit, operatorClassesLists.userCasterOperators, randomNumberGenerator, potentialOpsToRoll);
            UserOpsClassRemover.Remove_Class_From_UserOps_List(casterLimit, userOps, operatorClassesLists.userCasterOperators);

            PotentialOpsToRolledOpsAdder.Add_PotentialOps_List_To_List_Of_RolledOps_And_Increment_SquadSize(potentialOpsToRoll, rolledOps, currentSquadSize);

            PotentialOpsFromUserOpsRemover.Remove_PotentialOps_From_The_List_Of_UserOps(potentialOpsToRoll, userOps);

            RandomUserOpsToRolledOpsAdder.Add_RandomUserOps_To_List_Of_RolledOps(maxSquadSize, currentSquadSize, randomNumberGenerator, userOps, rolledOps);

            ListSorter.Sort_A_List_Alphabetically(rolledOps);
        }

        

        


        

    }
}
