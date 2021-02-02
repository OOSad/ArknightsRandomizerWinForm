using System;
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

        public static int squadSize = 1;
        public static int currentSquadSize = 1;
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


        


        public static CheckedListBox Check_All_The_Checkboxes_In_A_Page_Based_On_A_List(List<string> listOfOpsToApply, CheckedListBox checkboxesToApplyTo)
        {
            for (int i = 0; i < listOfOpsToApply.Count; i++)
            {
                for (int x = 0; x < checkboxesToApplyTo.Items.Count; x++)
                {
                    if ((string)checkboxesToApplyTo.Items[x] == listOfOpsToApply[i])
                    {
                        checkboxesToApplyTo.SetItemChecked(x, true);
                    }
                }
            }

            return checkboxesToApplyTo;
        }


        public static void Update_Operator_Labels_On_Form(Form targetForm)
        {
            int x = 0;
            for (int i = 0; i < targetForm.Controls.Count; i++)
            {
                if (targetForm.Controls[i] is Label && targetForm.Controls[i].Name.Contains("unit"))
                {
                    try
                    {
                        targetForm.Controls[i].Text = rolledOps[x];
                        x++;
                    }

                    catch (ArgumentOutOfRangeException)
                    {
                        targetForm.Controls[i].Text = "//";
                    }

                }
            }
        }
        public static void Update_Stage_Label_On_Form(Form targetForm)
        {
            for (int i = 0; i < targetForm.Controls.Count; i++)
            {
                if (targetForm.Controls[i] is Label && targetForm.Controls[i].Name == "StageLabel")
                {
                    targetForm.Controls[i].Text = selectedStage;
                }
            }
        }


        public static void Roll_Ops_And_Create_Roster(int maxSquadSize)
        {
            currentSquadSize = 0;

            Wipe_One_Or_More_Lists_Clean(rolledOps, userOps, potentialOpsToRoll);

            UserOpsFileHandler.Read_UserOps_From_File(userOps);

            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userMedicOperators, operatorClassesLists.defaultUserMedicOperators);
            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userSupporterOperators, operatorClassesLists.defaultUserSupporterOperators);
            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userSniperOperators, operatorClassesLists.defaultUserSniperOperators);
            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userVanguardOperators, operatorClassesLists.defaultUserVanguardOperators);
            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userSpecialistOperators, operatorClassesLists.defaultUserSpecialistOperators);
            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userDefenderOperators, operatorClassesLists.defaultUserDefenderOperators);
            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userGuardOperators, operatorClassesLists.defaultUserGuardOperators);
            Reset_A_List_To_Its_Default_Values(operatorClassesLists.userCasterOperators, operatorClassesLists.defaultUserCasterOperators);

            Filter_Out_Unselected_Classes_From_Pool_Of_UserOps();
            Filter_Out_Unselected_Rarities_From_Pool_Of_UserOps();

            Add_Ops_To_Potential_List(medicLimit, operatorClassesLists.userMedicOperators);
            Remove_Class_From_UserOps_List(medicLimit, userOps, operatorClassesLists.userMedicOperators);
            Add_Ops_To_Potential_List(supporterLimit, operatorClassesLists.userSupporterOperators);
            Remove_Class_From_UserOps_List(supporterLimit, userOps, operatorClassesLists.userSupporterOperators);
            Add_Ops_To_Potential_List(sniperLimit, operatorClassesLists.userSniperOperators);
            Remove_Class_From_UserOps_List(sniperLimit, userOps, operatorClassesLists.userSniperOperators);
            Add_Ops_To_Potential_List(vanguardLimit, operatorClassesLists.userVanguardOperators);
            Remove_Class_From_UserOps_List(vanguardLimit, userOps, operatorClassesLists.userVanguardOperators);
            Add_Ops_To_Potential_List(specialistLimit, operatorClassesLists.userSpecialistOperators);
            Remove_Class_From_UserOps_List(specialistLimit, userOps, operatorClassesLists.userSpecialistOperators);
            Add_Ops_To_Potential_List(defenderLimit, operatorClassesLists.userDefenderOperators);
            Remove_Class_From_UserOps_List(defenderLimit, userOps, operatorClassesLists.userDefenderOperators);
            Add_Ops_To_Potential_List(guardLimit, operatorClassesLists.userGuardOperators);
            Remove_Class_From_UserOps_List(guardLimit, userOps, operatorClassesLists.userGuardOperators);
            Add_Ops_To_Potential_List(casterLimit, operatorClassesLists.userCasterOperators);
            Remove_Class_From_UserOps_List(casterLimit, userOps, operatorClassesLists.userCasterOperators);

            Add_PotentialOps_List_To_List_Of_RolledOps_And_Increment_SquadSize();

            Remove_PotentialOps_From_The_List_Of_UserOps();

            Add_RandomUserOps_To_List_Of_RolledOps(maxSquadSize);

            Sort_A_List_Alphabetically(rolledOps);
        }

        public static void Wipe_One_Or_More_Lists_Clean(params List<string>[] values)
        {
            foreach (List<string> lists in values)
            {
                lists.Clear();
            }
        }
        public static void Reset_A_List_To_Its_Default_Values(List<string> listToReset, List<string> listOfDefaults)
        {
            Wipe_One_Or_More_Lists_Clean(listToReset);
            for (int i = 0; i < listOfDefaults.Count; i++)
            {
                listToReset.Add(listOfDefaults[i]);
            }
        }
        public static void Filter_Out_Unselected_Classes_From_Pool_Of_UserOps()
        {
            for (int i = 0; i < operatorClassesLists.classesToFilterOut.Count; i++)
            {
                switch (operatorClassesLists.classesToFilterOut[i])
                {
                    case "Medics":
                        {
                            for (int x = 0; x < operatorClassesLists.medicOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.medicOperators[x]);
                                operatorClassesLists.userMedicOperators.Remove(operatorClassesLists.medicOperators[x]);
                            }

                            break;
                        }

                    case "Supporters":
                        {
                            for (int x = 0; x < operatorClassesLists.supporterOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.supporterOperators[x]);
                                operatorClassesLists.userSupporterOperators.Remove(operatorClassesLists.supporterOperators[x]);
                            }

                            break;
                        }

                    case "Snipers":
                        {
                            for (int x = 0; x < operatorClassesLists.sniperOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.sniperOperators[x]);
                                operatorClassesLists.userSniperOperators.Remove(operatorClassesLists.sniperOperators[x]);
                            }

                            break;
                        }

                    case "Vanguards":
                        {
                            for (int x = 0; x < operatorClassesLists.vanguardOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.vanguardOperators[x]);
                                operatorClassesLists.userVanguardOperators.Remove(operatorClassesLists.vanguardOperators[x]);
                            }

                            break;
                        }

                    case "Specialists":
                        {
                            for (int x = 0; x < operatorClassesLists.specialistOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.specialistOperators[x]);
                                operatorClassesLists.userSpecialistOperators.Remove(operatorClassesLists.specialistOperators[x]);
                            }

                            break;
                        }

                    case "Defenders":
                        {
                            for (int x = 0; x < operatorClassesLists.defenderOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.defenderOperators[x]);
                                operatorClassesLists.userDefenderOperators.Remove(operatorClassesLists.defenderOperators[x]);
                            }

                            break;
                        }

                    case "Guards":
                        {
                            for (int x = 0; x < operatorClassesLists.guardOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.guardOperators[x]);
                                operatorClassesLists.userGuardOperators.Remove(operatorClassesLists.guardOperators[x]);
                            }

                            break;
                        }

                    case "Casters":
                        {
                            for (int x = 0; x < operatorClassesLists.casterOperators.Count; x++)
                            {
                                userOps.Remove(operatorClassesLists.casterOperators[x]);
                                operatorClassesLists.userCasterOperators.Remove(operatorClassesLists.casterOperators[x]);
                            }

                            break;
                        }

                    default: { break; }
                }
            }
        }
        public static void Filter_Out_Unselected_Rarities_From_Pool_Of_UserOps()

        {
            for (int i = 0; i < operatorRarityLists.raritiesToFilterOut.Count; i++)
            {
                switch (operatorRarityLists.raritiesToFilterOut[i])
                {
                    case "1*":
                        {
                            for (int x = 0; x < operatorRarityLists.oneStarOperators.Count; x++)
                            {
                                userOps.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userMedicOperators.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userSupporterOperators.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userSniperOperators.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userVanguardOperators.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userSpecialistOperators.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userDefenderOperators.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userGuardOperators.Remove(operatorRarityLists.oneStarOperators[x]);
                                operatorClassesLists.userCasterOperators.Remove(operatorRarityLists.oneStarOperators[x]);

                            }

                            break;
                        }

                    case "2*":
                        {
                            for (int x = 0; x < operatorRarityLists.twoStarOperators.Count; x++)
                            {
                                userOps.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userMedicOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userSupporterOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userSniperOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userVanguardOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userSpecialistOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userDefenderOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userGuardOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                                operatorClassesLists.userCasterOperators.Remove(operatorRarityLists.twoStarOperators[x]);
                            }

                            break;
                        }

                    case "3*":
                        {
                            for (int x = 0; x < operatorRarityLists.threeStarOperators.Count; x++)
                            {
                                userOps.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userMedicOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userSupporterOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userSniperOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userVanguardOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userSpecialistOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userDefenderOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userGuardOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                                operatorClassesLists.userCasterOperators.Remove(operatorRarityLists.threeStarOperators[x]);
                            }

                            break;
                        }

                    case "4*":
                        {
                            for (int x = 0; x < operatorRarityLists.fourStarOperators.Count; x++)
                            {
                                userOps.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userMedicOperators.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userSupporterOperators.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userSniperOperators.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userVanguardOperators.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userSpecialistOperators.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userDefenderOperators.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userGuardOperators.Remove(operatorRarityLists.fourStarOperators[x]);
                                operatorClassesLists.userCasterOperators.Remove(operatorRarityLists.fourStarOperators[x]);

                            }

                            break;
                        }

                    case "5*":
                        {
                            for (int x = 0; x < operatorRarityLists.fiveStarOperators.Count; x++)
                            {
                                userOps.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userMedicOperators.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userSupporterOperators.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userSniperOperators.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userVanguardOperators.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userSpecialistOperators.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userDefenderOperators.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userGuardOperators.Remove(operatorRarityLists.fiveStarOperators[x]);
                                operatorClassesLists.userCasterOperators.Remove(operatorRarityLists.fiveStarOperators[x]);

                            }

                            break;
                        }

                    case "6*":
                        {
                            for (int x = 0; x < operatorRarityLists.sixStarOperators.Count; x++)
                            {
                                userOps.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userMedicOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userSupporterOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userSniperOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userVanguardOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userSpecialistOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userDefenderOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userGuardOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                                operatorClassesLists.userCasterOperators.Remove(operatorRarityLists.sixStarOperators[x]);
                            }

                            break;
                        }
                }
            }
        }
        public static void Add_Ops_To_Potential_List(int specificClassLimit, List<string> userOpsListToRemoveFrom)
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
        public static void Add_PotentialOps_List_To_List_Of_RolledOps_And_Increment_SquadSize()
        {
            if (potentialOpsToRoll.Count != 0)
            {
                for (int i = 0; i < potentialOpsToRoll.Count; i++)
                {
                    rolledOps.Add(potentialOpsToRoll[i]);
                    currentSquadSize++;
                }
            }
        }
        public static void Remove_PotentialOps_From_The_List_Of_UserOps()
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
        public static void Add_RandomUserOps_To_List_Of_RolledOps(int maxSquadSize)
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
        public static void Sort_A_List_Alphabetically(List<string> listToSort)
        {
            listToSort.Sort();
        }


        public static void Roll_For_Stage()
        {
            Wipe_One_Or_More_Lists_Clean(stageLists.userStages);

            foreach (string stages in stageLists.userStagesDefault)
            {
                stageLists.userStages.Add(stages);
            }

            Filter_Out_Unselected_Stages_From_Pool_Of_Maps();

            try
            {
                selectedStage = stageLists.userStages[randomNumberGenerator.Next(0, stageLists.userStages.Count)];
            }
            catch (ArgumentOutOfRangeException)
            {
                selectedStage = "Stage Not Found!";
            }
        }
        public static void Filter_Out_Unselected_Stages_From_Pool_Of_Maps()
        {
            for (int i = 0; i < stageLists.chaptersToFilterOut.Count; i++)
            {
                switch (stageLists.chaptersToFilterOut[i])
                {
                    case "Prologue":
                        {
                            for (int x = 0; x < stageLists.prologueStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.prologueStages[x]);
                            }

                            break;
                        }

                    case "Chapter 1":
                        {
                            for (int x = 0; x < stageLists.chapterOneStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.chapterOneStages[x]);
                            }

                            break;
                        }

                    case "Chapter 2":
                        {
                            for (int x = 0; x < stageLists.chapterTwoStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.chapterTwoStages[x]);
                            }

                            break;
                        }

                    case "Chapter 3":
                        {
                            for (int x = 0; x < stageLists.chapterThreeStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.chapterThreeStages[x]);
                            }

                            break;
                        }

                    case "Chapter 4":
                        {
                            for (int x = 0; x < stageLists.chapterFourStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.chapterFourStages[x]);
                            }

                            break;
                        }

                    case "Chapter 5":
                        {
                            for (int x = 0; x < stageLists.chapterFiveStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.chapterFiveStages[x]);
                            }

                            break;
                        }

                    case "Chapter 6":
                        {
                            for (int x = 0; x < stageLists.chapterSixStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.chapterSixStages[x]);
                            }

                            break;
                        }

                    case "Chapter 7":
                        {
                            for (int x = 0; x < stageLists.chapterSevenStages.Count; x++)
                            {
                                stageLists.userStages.Remove(stageLists.chapterSevenStages[x]);
                            }

                            break;
                        }
                }
            }
        }


        public static void Populate_UserOps_Lists()
        {
            Wipe_One_Or_More_Lists_Clean(operatorClassesLists.userMedicOperators, operatorClassesLists.userSupporterOperators, operatorClassesLists.userSniperOperators, operatorClassesLists.userVanguardOperators, operatorClassesLists.userSpecialistOperators, operatorClassesLists.userDefenderOperators, operatorClassesLists.userGuardOperators, operatorClassesLists.userCasterOperators);

            for (int i = 0; i < userOps.Count; i++)
            {
                 for (int x = 0; x < operatorClassesLists.medicOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.medicOperators[x])
                    {
                        operatorClassesLists.userMedicOperators.Add(operatorClassesLists.medicOperators[x]);
                        operatorClassesLists.defaultUserMedicOperators.Add(operatorClassesLists.medicOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < operatorClassesLists.supporterOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.supporterOperators[x])
                    {
                        operatorClassesLists.userSupporterOperators.Add(operatorClassesLists.supporterOperators[x]);
                        operatorClassesLists.defaultUserSupporterOperators.Add(operatorClassesLists.supporterOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < operatorClassesLists.sniperOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.sniperOperators[x])
                    {
                        operatorClassesLists.userSniperOperators.Add(operatorClassesLists.sniperOperators[x]);
                        operatorClassesLists.defaultUserSniperOperators.Add(operatorClassesLists.sniperOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < operatorClassesLists.vanguardOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.vanguardOperators[x])
                    {
                        operatorClassesLists.userVanguardOperators.Add(operatorClassesLists.vanguardOperators[x]);
                        operatorClassesLists.defaultUserVanguardOperators.Add(operatorClassesLists.vanguardOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < operatorClassesLists.specialistOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.specialistOperators[x])
                    {
                        operatorClassesLists.userSpecialistOperators.Add(operatorClassesLists.specialistOperators[x]);
                        operatorClassesLists.defaultUserSpecialistOperators.Add(operatorClassesLists.specialistOperators[x]); 
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < operatorClassesLists.defenderOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.defenderOperators[x])
                    {
                        operatorClassesLists.userDefenderOperators.Add(operatorClassesLists.defenderOperators[x]);
                        operatorClassesLists.defaultUserDefenderOperators.Add(operatorClassesLists.defenderOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < operatorClassesLists.guardOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.guardOperators[x])
                    {
                        operatorClassesLists.userGuardOperators.Add(operatorClassesLists.guardOperators[x]);
                        operatorClassesLists.defaultUserGuardOperators.Add(operatorClassesLists.guardOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < operatorClassesLists.casterOperators.Count; x++)
                {
                    if (userOps[i] == operatorClassesLists.casterOperators[x])
                    {
                        operatorClassesLists.userCasterOperators.Add(operatorClassesLists.casterOperators[x]);
                        operatorClassesLists.defaultUserCasterOperators.Add(operatorClassesLists.casterOperators[x]);
                    }
                }
            }

        }


        public static void Set_SquadSize_To_Max()
        {
            squadSize = 12;
        }

    }
}
