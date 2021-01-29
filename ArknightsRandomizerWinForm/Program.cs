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

        public static List<string> userOps = new List<string>() { };
        public static List<string> userStages = new List<string>() { "0-1", "0-2", "0-3", "0-4", "0-5", "0-6", "0-7", "0-8", "0-9", "0-10", "0-11", "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "1-9", "1-10", "1-12", "2-1", "S2-1", "2-2", "S2-2", "S2-3", "S2-4", "2-3", "2-4", "S2-5", "S2-6", "S2-7", "2-5", "2-6", "2-7", "S2-8", "S2-9", "2-8", "2-9", "S2-10", "S2-11", "S2-12", "2-10", "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8", "4-9", "4-10", "5-1", "5-2", "5-3", "5-4", "5-5", "5-6", "5-7", "5-8", "5-9", "5-10", "6-1", "6-2", "6-3", "6-4", "6-5", "6-7", "6-8", "6-9", "6-10", "6-11", "6-12", "6-14", "6-15", "6-16", "7-2", "7-3", "7-4", "7-5", "7-6", "7-8", "7-9", "7-10", "7-11", "7-12", "7-13", "7-14", "7-15", "7-16", "7-18", "S3-1", "S3-2", "S3-3", "S3-4", "S3-5", "S3-6", "S4-1", "S4-2", "S4-3", "S4-4", "S4-5", "S4-6", "S4-7", "S4-8", "S4-9", "S4-10", "S5-1", "S5-2", "S5-3", "S5-4", "S5-5", "S5-6", "S5-7", "S5-8", "H5-1", "H5-2", "H5-3", "H5-4", "H6-1", "H6-2", "H6-3", "H6-4", "H7-1", "H7-2", "H7-3", "H7-4" };
        public static List<string> userStagesDefault = new List<string>() { "0-1", "0-2", "0-3", "0-4", "0-5", "0-6", "0-7", "0-8", "0-9", "0-10", "0-11", "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "1-9", "1-10", "1-12", "2-1", "S2-1", "2-2", "S2-2", "S2-3", "S2-4", "2-3", "2-4", "S2-5", "S2-6", "S2-7", "2-5", "2-6", "2-7", "S2-8", "S2-9", "2-8", "2-9", "S2-10", "S2-11", "S2-12", "2-10", "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8", "4-9", "4-10", "5-1", "5-2", "5-3", "5-4", "5-5", "5-6", "5-7", "5-8", "5-9", "5-10", "6-1", "6-2", "6-3", "6-4", "6-5", "6-7", "6-8", "6-9", "6-10", "6-11", "6-12", "6-14", "6-15", "6-16", "7-2", "7-3", "7-4", "7-5", "7-6", "7-8", "7-9", "7-10", "7-11", "7-12", "7-13", "7-14", "7-15", "7-16", "7-18", "S3-1", "S3-2", "S3-3", "S3-4", "S3-5", "S3-6", "S4-1", "S4-2", "S4-3", "S4-4", "S4-5", "S4-6", "S4-7", "S4-8", "S4-9", "S4-10", "S5-1", "S5-2", "S5-3", "S5-4", "S5-5", "S5-6", "S5-7", "S5-8", "H5-1", "H5-2", "H5-3", "H5-4", "H6-1", "H6-2", "H6-3", "H6-4", "H7-1", "H7-2", "H7-3", "H7-4" };
        
        public static List<string> rolledOps = new List<string>() { };
        public static List<string> potentialOpsToRoll = new List<string> { };
        public static List<string> rolledStages = new List<string>() { };

        public static List<string> prologueStages = new List<string>() { "0-1", "0-2", "0-3", "0-4", "0-5", "0-6", "0-7", "0-8", "0-9", "0-10", "0-11" };
        public static List<string> chapterOneStages = new List<string>() { "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "1-9", "1-10", "1-12", "S2-1", "S2-2", "S2-3", "S2-4", "S2-5", "S2-6", "S2-7", "S2-8", "S2-9", "S2-10", "S2-11", "S2-12"};
        public static List<string> chapterTwoStages = new List<string>() { "2-1", "S2-1", "2-2", "S2-2", "S2-3", "S2-4", "2-3", "2-4", "S2-5", "S2-6", "S2-7", "2-5", "2-6", "2-7", "S2-8", "S2-9", "2-8", "2-9", "S2-10", "S2-11", "S2-12", "2-10"};
        public static List<string> chapterThreeStages = new List<string>() { "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "S3-1", "S3-2", "S3-3", "S3-4", "S3-5", "S3-6" };
        public static List<string> chapterFourStages = new List<string>() { "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8", "4-9", "4-10", "S4-1", "S4-2", "S4-3", "S4-4", "S4-5", "S4-6", "S4-7", "S4-8", "S4-9", "S4-10" };
        public static List<string> chapterFiveStages = new List<string>() { "5-1", "5-2", "5-3", "5-4", "5-5", "5-6", "5-7", "5-8", "5-9", "5-10", "S5-1", "S5-2", "S5-3", "S5-4", "S5-5", "S5-6", "S5-7", "S5-8", "H5-1", "H5-2", "H5-3", "H5-4" };
        public static List<string> chapterSixStages = new List<string>() { "6-1", "6-2", "6-3", "6-4", "6-5", "6-7", "6-8", "6-9", "6-10", "6-11", "6-12", "6-14", "6-15", "6-16", "S6-1", "S6-2", "S6-3", "S6-4", "H6-1", "H6-2", "H6-3", "H6-4" };
        public static List<string> chapterSevenStages = new List<string>() { "7-2", "7-3", "7-4", "7-5", "7-6", "7-8", "7-9", "7-10", "7-11", "7-12", "7-13", "7-14", "7-15", "7-16", "7-18", "S7-1", "S7-2", "H7-1", "H7-2", "H7-3", "H7-4" };

        public static List<string> classesToFilterOut = new List<string>() { };
        public static List<string> raritiesToFilterOut = new List<string>() { };
        public static List<string> chaptersToFilterOut = new List<string>() { };
        
        public static List<string> medicOperators = new List<string>() { "Folinic", "Ceylon", "Breeze", "Sussurro", "Nightingale", "Shining", "Warfarin", "Silence", "Ptilopsis", "Perfumer", "Gavial", "Myrrh", "Ansel", "Hibiscus", "Lancet-2" };
        public static List<string> userMedicOperators = new List<string>() { };
        public static List<string> defaultUserMedicOperators = new List<string>() {  };

        public static List<string> supporterOperators = new List<string>() { "Suzuran", "Podenco", "Tsukinogi", "Shamare", "Magallan", "Glaucus", "Angelina", "Sora", "Istina", "Pramanix", "Mayer", "Earthspirit", "Deepcolor", "Orchid" };
        public static List<string> userSupporterOperators = new List<string>() { };
        public static List<string> defaultUserSupporterOperators = new List<string>() { };

        public static List<string> sniperOperators = new List<string>() { "Andreana", "Rosa(Poca)", "W", "Sesa", "GreyThroat", "Ambriel", "May", "Executor", "Vermeil", "Schwarz", "Catapult", "Exusiai", "Firewatch", "Provence", "Meteorite", "Platinum", "Blue Poison", "Shirayuki", "Meteor", "Jessica", "Adnachiel", "Kroos", "Rangers" };
        public static List<string> userSniperOperators = new List<string>() { };
        public static List<string> defaultUserSniperOperators = new List<string>() { };

        public static List<string> vanguardOperators = new List<string>() { "Chiave", "Elysium", "Bagpipe", "Reed", "Myrtle", "Grani", "Siege", "Texas", "Zima", "Vigna", "Scavenger", "Courier", "Plume", "Vanilla", "Fang", "Yato" };
        public static List<string> userVanguardOperators = new List<string>() { };
        public static List<string> defaultUserVanguardOperators = new List<string>() { };

        public static List<string> specialistOperators = new List<string>() { "Jaye", "Weedy", "THRM-EX", "Phantom", "Aak", "Snowsant", "Waai Fu", "Ethan", "FEater", "Manticore", "Cliffheart", "Projekt Red", "Shaw", "Rope", "Gravel" };
        public static List<string> userSpecialistOperators = new List<string>() { };
        public static List<string> defaultUserSpecialistOperators = new List<string>() { };

        public static List<string> defenderOperators = new List<string>() { "Asbestos", "Nian", "Hung", "Bison", "Dur-nar", "Spot", "Saria", "Hoshiguma", "Vulcan", "Croissant", "Liskarm", "Nearl", "Gummy", "Cuora", "Matterhorn", "Beagle", "Cardigan", "Noir Corne" };
        public static List<string> userDefenderOperators = new List<string>() { };
        public static List<string> defaultUserDefenderOperators = new List<string>() { };

        public static List<string> guardOperators = new List<string>() { "Thorns", "Ayerscape", "Sideroca", "Cutter", "Bibeak", "Utage", "Blaze", "Broca", "Flamebringer", "Hellagur", "Astesia", "Ch'en", "Swire", "Popukar", "Skadi", "Beehunter", "Midnight", "Savage", "SilverAsh", "Specter", "Lappland", "Indra", "Franka", "Mousse", "Estelle", "Frostleaf", "Matoimaru", "Dobermann", "Melantha", "Castle-3" };
        public static List<string> userGuardOperators = new List<string>() { };
        public static List<string> defaultUserGuardOperators = new List<string>() { };

        public static List<string> casterOperators = new List<string>() { "Beeswax", "Click", "Leonhardt", "Absinthe", "Ceobe", "Leizi", "Mostima", "Greyy", "Nightmare", "Eyjafjalla", "Ifrit", "Skyfire", "Amiya", "Gitano", "Haze", "Steward", "Lava", "12F", "Durin" };
        public static List<string> userCasterOperators = new List<string>() { };
        public static List<string> defaultUserCasterOperators = new List<string>() { };

        public static List<string> oneStarOperators = new List<string>() { "THRM-EX", "Castle-3", "Lancet-2" };
        public static List<string> twoStarOperators = new List<string>() { "12F", "Durin", "Rangers", "Noir Corne", "Yato" };
        public static List<string> threeStarOperators = new List<string>() { "Spot", "Popukar", "Midnight", "Catapult", "Orchid", "Steward", "Ansel", "Hibiscus", "Lava", "Adnachiel", "Kroos", "Beagle", "Cardigan", "Melantha", "Plume", "Vanilla", "Fang" };
        public static List<string> fourStarOperators = new List<string>() { "Estelle", "Jaye", "Click", "Podenco", "Cutter", "Utage", "Ambriel", "May", "Ethan", "Dur-nar", "Vermeil", "Myrtle", "Sussurro", "Greyy", "Beehunter", "Shaw", "Earthspirit", "Deepcolor", "Gummy", "Cuora", "Matterhorn", "Perfumer", "Gavial", "Myrrh", "Rope", "Gravel", "Mousse", "Frostleaf", "Matoimaru", "Dobermann", "Vigna", "Scavenger", "Courier", "Shirayuki", "Meteor", "Jessica", "Gitano", "Haze" };
        public static List<string> fiveStarOperators = new List<string>() { "Andreana", "Chiave", "Beeswax", "Ayerscape", "Folinic", "Leonhardt", "Absinthe", "Tsukinogi", "Asbestos", "Elysium", "Shamare", "Sideroca", "Sesa", "Bibeak", "Leizi", "Hung", "Snowsant", "GreyThroat", "Broca", "Reed", "Bison", "Waai Fu", "Ceylon", "Flamebringer", "Breeze", "Executor", "Astesia", "Glaucus", "Swire", "Grani", "Nightmare", "Savage", "FEater", "Manticore", "Sora", "Istina", "Pramanix", "Cliffheart", "Firewatch", "Provence", "Vulcan", "Croissant", "Liskarm", "Projekt Red", "Nearl", "Warfarin", "Silence", "Mayer", "Skyfire", "Amiya", "Meteorite", "Platinum", "Blue Poison", "Specter", "Lappland", "Indra", "Franka", "Texas", "Zima", "Ptilopsis" };
        public static List<string> sixStarOperators = new List<string>() { "Thorns", "Suzuran", "Rosa(Poca)", "Weedy", "W", "Phantom", "Bagpipe", "Ceobe", "Nian", "Aak", "Blaze", "Mostima", "Magallan", "Hellagur", "Schwarz", "Ch'en", "Skadi", "SilverAsh", "Saria", "Hoshiguma", "Nightingale", "Shining", "Angelina", "Eyjafjalla", "Ifrit", "Siege", "Exusiai" };




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


        public static void Create_UserOps_File()
        {
            if (!File.Exists("userOps.txt"))
            {
                using (StreamWriter sw = File.CreateText("userOps.txt"))
                {
                    sw.WriteLine("");
                }
            }
        }
        public static List<string> Read_UserOps_From_File(List<string> listToSaveUserOpsTo)
        {

            foreach (string operators in File.ReadAllLines("userOps.txt"))
            {
                listToSaveUserOpsTo.Add(operators); 
            }

            return listToSaveUserOpsTo;
        }
        public static void Write_UserOps_To_File(CheckedListBox checkboxesToReadFrom)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("userOps.txt")))
            {
                for (int i = 0; i < checkboxesToReadFrom.Items.Count; i++)
                {
                    if (checkboxesToReadFrom.GetItemChecked(i) == true)
                    {
                        outputFile.WriteLine(checkboxesToReadFrom.Items[i]);
                    }
                }
            }
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


        public static void Hide_Current_Form_Then_Open_Next_Form(Form currentForm, Form nextForm)
        {
            currentForm.Hide();
            nextForm.Show();
            nextForm.Location = new System.Drawing.Point(currentForm.Left, currentForm.Top);
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

            Wipe_A_List_Clean(rolledOps);
            Wipe_A_List_Clean(userOps);
            Wipe_A_List_Clean(potentialOpsToRoll);

            Read_UserOps_From_File(userOps);

            Reset_A_List_To_Its_Default_Values(userMedicOperators, defaultUserMedicOperators);
            Reset_A_List_To_Its_Default_Values(userSupporterOperators, defaultUserSupporterOperators);
            Reset_A_List_To_Its_Default_Values(userSniperOperators, defaultUserSniperOperators);
            Reset_A_List_To_Its_Default_Values(userVanguardOperators, defaultUserVanguardOperators);
            Reset_A_List_To_Its_Default_Values(userSpecialistOperators, defaultUserSpecialistOperators);
            Reset_A_List_To_Its_Default_Values(userDefenderOperators, defaultUserDefenderOperators);
            Reset_A_List_To_Its_Default_Values(userGuardOperators, defaultUserGuardOperators);
            Reset_A_List_To_Its_Default_Values(userCasterOperators, defaultUserCasterOperators);

            Filter_Out_Unselected_Classes_From_Pool_Of_UserOps();
            Filter_Out_Unselected_Rarities_From_Pool_Of_UserOps();

            Add_Ops_To_Potential_List(medicLimit, userMedicOperators);
            Add_Ops_To_Potential_List(supporterLimit, userSupporterOperators);
            Add_Ops_To_Potential_List(sniperLimit, userSniperOperators);
            Add_Ops_To_Potential_List(vanguardLimit, userVanguardOperators);
            Add_Ops_To_Potential_List(specialistLimit, userSpecialistOperators);
            Add_Ops_To_Potential_List(defenderLimit, userDefenderOperators);
            Add_Ops_To_Potential_List(guardLimit, userGuardOperators);
            Add_Ops_To_Potential_List(casterLimit, userCasterOperators);

            Add_PotentialOps_List_To_List_Of_RolledOps_And_Increment_SquadSize();

            Remove_PotentialOps_From_The_List_Of_UserOps();

            Add_RandomUserOps_To_List_Of_RolledOps(maxSquadSize);

            Sort_A_List_Alphabetically(rolledOps);
        }
        public static void Wipe_A_List_Clean(List<string> listToClearOut)
        {
            listToClearOut.Clear();
        }
        public static void Reset_A_List_To_Its_Default_Values(List<string> listToReset, List<string> listOfDefaults)
        {
            Wipe_A_List_Clean(listToReset);
            for (int i = 0; i < listOfDefaults.Count; i++)
            {
                listToReset.Add(listOfDefaults[i]);
            }
        }
        public static void Filter_Out_Unselected_Classes_From_Pool_Of_UserOps()
        {
            for (int i = 0; i < classesToFilterOut.Count; i++)
            {
                switch (classesToFilterOut[i])
                {
                    case "Medics":
                        {
                            for (int x = 0; x < medicOperators.Count; x++)
                            {
                                userOps.Remove(medicOperators[x]);
                                userMedicOperators.Remove(medicOperators[x]);
                            }

                            break;
                        }

                    case "Supporters":
                        {
                            for (int x = 0; x < supporterOperators.Count; x++)
                            {
                                userOps.Remove(supporterOperators[x]);
                                userSupporterOperators.Remove(supporterOperators[x]);
                            }

                            break;
                        }

                    case "Snipers":
                        {
                            for (int x = 0; x < sniperOperators.Count; x++)
                            {
                                userOps.Remove(sniperOperators[x]);
                                userSniperOperators.Remove(sniperOperators[x]);
                            }

                            break;
                        }

                    case "Vanguards":
                        {
                            for (int x = 0; x < vanguardOperators.Count; x++)
                            {
                                userOps.Remove(vanguardOperators[x]);
                                userVanguardOperators.Remove(vanguardOperators[x]);
                            }

                            break;
                        }

                    case "Specialists":
                        {
                            for (int x = 0; x < specialistOperators.Count; x++)
                            {
                                userOps.Remove(specialistOperators[x]);
                                userSpecialistOperators.Remove(specialistOperators[x]);
                            }

                            break;
                        }

                    case "Defenders":
                        {
                            for (int x = 0; x < defenderOperators.Count; x++)
                            {
                                userOps.Remove(defenderOperators[x]);
                                userDefenderOperators.Remove(defenderOperators[x]);
                            }

                            break;
                        }

                    case "Guards":
                        {
                            for (int x = 0; x < guardOperators.Count; x++)
                            {
                                userOps.Remove(guardOperators[x]);
                                userGuardOperators.Remove(guardOperators[x]);
                            }

                            break;
                        }

                    case "Casters":
                        {
                            for (int x = 0; x < casterOperators.Count; x++)
                            {
                                userOps.Remove(casterOperators[x]);
                                userCasterOperators.Remove(casterOperators[x]);
                            }

                            break;
                        }

                    default: { break; }
                }
            }
        }
        public static void Filter_Out_Unselected_Rarities_From_Pool_Of_UserOps()
        {
            for (int i = 0; i < raritiesToFilterOut.Count; i++)
            {
                switch (raritiesToFilterOut[i])
                {
                    case "1*":
                        {
                            for (int x = 0; x < oneStarOperators.Count; x++)
                            {
                                userOps.Remove(oneStarOperators[x]);
                                userMedicOperators.Remove(oneStarOperators[x]);
                                userSupporterOperators.Remove(oneStarOperators[x]);
                                userSniperOperators.Remove(oneStarOperators[x]);
                                userVanguardOperators.Remove(oneStarOperators[x]);
                                userSpecialistOperators.Remove(oneStarOperators[x]);
                                userDefenderOperators.Remove(oneStarOperators[x]);
                                userGuardOperators.Remove(oneStarOperators[x]);
                                userCasterOperators.Remove(oneStarOperators[x]);

                            }

                            break;
                        }

                    case "2*":
                        {
                            for (int x = 0; x < twoStarOperators.Count; x++)
                            {
                                userOps.Remove(twoStarOperators[x]);
                                userMedicOperators.Remove(twoStarOperators[x]);
                                userSupporterOperators.Remove(twoStarOperators[x]);
                                userSniperOperators.Remove(twoStarOperators[x]);
                                userVanguardOperators.Remove(twoStarOperators[x]);
                                userSpecialistOperators.Remove(twoStarOperators[x]);
                                userDefenderOperators.Remove(twoStarOperators[x]);
                                userGuardOperators.Remove(twoStarOperators[x]);
                                userCasterOperators.Remove(twoStarOperators[x]);
                            }

                            break;
                        }

                    case "3*":
                        {
                            for (int x = 0; x < threeStarOperators.Count; x++)
                            {
                                userOps.Remove(threeStarOperators[x]);
                                userMedicOperators.Remove(threeStarOperators[x]);
                                userSupporterOperators.Remove(threeStarOperators[x]);
                                userSniperOperators.Remove(threeStarOperators[x]);
                                userVanguardOperators.Remove(threeStarOperators[x]);
                                userSpecialistOperators.Remove(threeStarOperators[x]);
                                userDefenderOperators.Remove(threeStarOperators[x]);
                                userGuardOperators.Remove(threeStarOperators[x]);
                                userCasterOperators.Remove(threeStarOperators[x]);
                            }

                            break;
                        }

                    case "4*":
                        {
                            for (int x = 0; x < fourStarOperators.Count; x++)
                            {
                                userOps.Remove(fourStarOperators[x]);
                                userMedicOperators.Remove(fourStarOperators[x]);
                                userSupporterOperators.Remove(fourStarOperators[x]);
                                userSniperOperators.Remove(fourStarOperators[x]);
                                userVanguardOperators.Remove(fourStarOperators[x]);
                                userSpecialistOperators.Remove(fourStarOperators[x]);
                                userDefenderOperators.Remove(fourStarOperators[x]);
                                userGuardOperators.Remove(fourStarOperators[x]);
                                userCasterOperators.Remove(fourStarOperators[x]);

                            }

                            break;
                        }

                    case "5*":
                        {
                            for (int x = 0; x < fiveStarOperators.Count; x++)
                            {
                                userOps.Remove(fiveStarOperators[x]);
                                userMedicOperators.Remove(fiveStarOperators[x]);
                                userSupporterOperators.Remove(fiveStarOperators[x]);
                                userSniperOperators.Remove(fiveStarOperators[x]);
                                userVanguardOperators.Remove(fiveStarOperators[x]);
                                userSpecialistOperators.Remove(fiveStarOperators[x]);
                                userDefenderOperators.Remove(fiveStarOperators[x]);
                                userGuardOperators.Remove(fiveStarOperators[x]);
                                userCasterOperators.Remove(fiveStarOperators[x]);

                            }

                            break;
                        }

                    case "6*":
                        {
                            for (int x = 0; x < sixStarOperators.Count; x++)
                            {
                                userOps.Remove(sixStarOperators[x]);
                                userMedicOperators.Remove(sixStarOperators[x]);
                                userSupporterOperators.Remove(sixStarOperators[x]);
                                userSniperOperators.Remove(sixStarOperators[x]);
                                userVanguardOperators.Remove(sixStarOperators[x]);
                                userSpecialistOperators.Remove(sixStarOperators[x]);
                                userDefenderOperators.Remove(sixStarOperators[x]);
                                userGuardOperators.Remove(sixStarOperators[x]);
                                userCasterOperators.Remove(sixStarOperators[x]);

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
            Wipe_A_List_Clean(userStages);

            foreach (string stages in userStagesDefault)
            {
                userStages.Add(stages);
            }

            Filter_Out_Unselected_Stages_From_Pool_Of_Maps();

            try
            {
                selectedStage = userStages[randomNumberGenerator.Next(0, userStages.Count)];
            }
            catch (ArgumentOutOfRangeException)
            {
                selectedStage = "Stage Not Found!";
            }
        }
        public static void Filter_Out_Unselected_Stages_From_Pool_Of_Maps()
        {
            for (int i = 0; i < chaptersToFilterOut.Count; i++)
            {
                switch (chaptersToFilterOut[i])
                {
                    case "Prologue":
                        {
                            for (int x = 0; x < prologueStages.Count; x++)
                            {
                                userStages.Remove(prologueStages[x]);
                            }

                            break;
                        }

                    case "Chapter 1":
                        {
                            for (int x = 0; x < chapterOneStages.Count; x++)
                            {
                                userStages.Remove(chapterOneStages[x]);
                            }

                            break;
                        }

                    case "Chapter 2":
                        {
                            for (int x = 0; x < chapterTwoStages.Count; x++)
                            {
                                userStages.Remove(chapterTwoStages[x]);
                            }

                            break;
                        }

                    case "Chapter 3":
                        {
                            for (int x = 0; x < chapterThreeStages.Count; x++)
                            {
                                userStages.Remove(chapterThreeStages[x]);
                            }

                            break;
                        }

                    case "Chapter 4":
                        {
                            for (int x = 0; x < chapterFourStages.Count; x++)
                            {
                                userStages.Remove(chapterFourStages[x]);
                            }

                            break;
                        }

                    case "Chapter 5":
                        {
                            for (int x = 0; x < chapterFiveStages.Count; x++)
                            {
                                userStages.Remove(chapterFiveStages[x]);
                            }

                            break;
                        }

                    case "Chapter 6":
                        {
                            for (int x = 0; x < chapterSixStages.Count; x++)
                            {
                                userStages.Remove(chapterSixStages[x]);
                            }

                            break;
                        }

                    case "Chapter 7":
                        {
                            for (int x = 0; x < chapterSevenStages.Count; x++)
                            {
                                userStages.Remove(chapterSevenStages[x]);
                            }

                            break;
                        }
                }
            }
        }


        public static void Populate_UserOps_Lists()
        {
            Wipe_A_List_Clean(userMedicOperators);
            Wipe_A_List_Clean(userSupporterOperators);
            Wipe_A_List_Clean(userSniperOperators);
            Wipe_A_List_Clean(userVanguardOperators);
            Wipe_A_List_Clean(userSpecialistOperators);
            Wipe_A_List_Clean(userDefenderOperators);
            Wipe_A_List_Clean(userGuardOperators);
            Wipe_A_List_Clean(userCasterOperators);

            for (int i = 0; i < userOps.Count; i++)
            {
                 for (int x = 0; x < medicOperators.Count; x++)
                {
                    if (userOps[i] == medicOperators[x])
                    {
                        userMedicOperators.Add(medicOperators[x]);
                        defaultUserMedicOperators.Add(medicOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < supporterOperators.Count; x++)
                {
                    if (userOps[i] == supporterOperators[x])
                    {
                        userSupporterOperators.Add(supporterOperators[x]);
                        defaultUserSupporterOperators.Add(supporterOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < sniperOperators.Count; x++)
                {
                    if (userOps[i] == sniperOperators[x])
                    {
                        userSniperOperators.Add(sniperOperators[x]);
                        defaultUserSniperOperators.Add(sniperOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < vanguardOperators.Count; x++)
                {
                    if (userOps[i] == vanguardOperators[x])
                    {
                        userVanguardOperators.Add(vanguardOperators[x]);
                        defaultUserVanguardOperators.Add(vanguardOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < specialistOperators.Count; x++)
                {
                    if (userOps[i] == specialistOperators[x])
                    {
                        userSpecialistOperators.Add(specialistOperators[x]);
                        defaultUserSpecialistOperators.Add(specialistOperators[x]); 
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < defenderOperators.Count; x++)
                {
                    if (userOps[i] == defenderOperators[x])
                    {
                        userDefenderOperators.Add(defenderOperators[x]);
                        defaultUserDefenderOperators.Add(defenderOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < guardOperators.Count; x++)
                {
                    if (userOps[i] == guardOperators[x])
                    {
                        userGuardOperators.Add(guardOperators[x]);
                        defaultUserGuardOperators.Add(guardOperators[x]);
                    }
                }
            }

            for (int i = 0; i < userOps.Count; i++)
            {
                for (int x = 0; x < casterOperators.Count; x++)
                {
                    if (userOps[i] == casterOperators[x])
                    {
                        userCasterOperators.Add(casterOperators[x]);
                        defaultUserCasterOperators.Add(casterOperators[x]);
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
