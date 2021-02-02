using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    class RaritiesFilter
    {
        public static void Filter_Out_Unselected_Rarities_From_Pool_Of_UserOps(OperatorRarityLists rarityLists, OperatorClassLists classesLists, List<string> listOfUserOps)

            //THIS CLASS IS BAD AND NEEDS FRAGMENTING INTO SMALLER CLASSES
        {
            for (int i = 0; i < rarityLists.raritiesToFilterOut.Count; i++)
            {
                switch (rarityLists.raritiesToFilterOut[i])
                {
                    case "1*":
                        {
                            for (int x = 0; x < rarityLists.oneStarOperators.Count; x++)
                            {
                                listOfUserOps.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userMedicOperators.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userSupporterOperators.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userSniperOperators.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userVanguardOperators.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userSpecialistOperators.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userDefenderOperators.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userGuardOperators.Remove(rarityLists.oneStarOperators[x]);
                                classesLists.userCasterOperators.Remove(rarityLists.oneStarOperators[x]);

                            }

                            break;
                        }

                    case "2*":
                        {
                            for (int x = 0; x < rarityLists.twoStarOperators.Count; x++)
                            {
                                listOfUserOps.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userMedicOperators.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userSupporterOperators.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userSniperOperators.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userVanguardOperators.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userSpecialistOperators.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userDefenderOperators.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userGuardOperators.Remove(rarityLists.twoStarOperators[x]);
                                classesLists.userCasterOperators.Remove(rarityLists.twoStarOperators[x]);
                            }

                            break;
                        }

                    case "3*":
                        {
                            for (int x = 0; x < rarityLists.threeStarOperators.Count; x++)
                            {
                                listOfUserOps.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userMedicOperators.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userSupporterOperators.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userSniperOperators.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userVanguardOperators.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userSpecialistOperators.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userDefenderOperators.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userGuardOperators.Remove(rarityLists.threeStarOperators[x]);
                                classesLists.userCasterOperators.Remove(rarityLists.threeStarOperators[x]);
                            }

                            break;
                        }

                    case "4*":
                        {
                            for (int x = 0; x < rarityLists.fourStarOperators.Count; x++)
                            {
                                listOfUserOps.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userMedicOperators.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userSupporterOperators.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userSniperOperators.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userVanguardOperators.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userSpecialistOperators.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userDefenderOperators.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userGuardOperators.Remove(rarityLists.fourStarOperators[x]);
                                classesLists.userCasterOperators.Remove(rarityLists.fourStarOperators[x]);

                            }

                            break;
                        }

                    case "5*":
                        {
                            for (int x = 0; x < rarityLists.fiveStarOperators.Count; x++)
                            {
                                listOfUserOps.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userMedicOperators.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userSupporterOperators.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userSniperOperators.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userVanguardOperators.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userSpecialistOperators.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userDefenderOperators.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userGuardOperators.Remove(rarityLists.fiveStarOperators[x]);
                                classesLists.userCasterOperators.Remove(rarityLists.fiveStarOperators[x]);

                            }

                            break;
                        }

                    case "6*":
                        {
                            for (int x = 0; x < rarityLists.sixStarOperators.Count; x++)
                            {
                                listOfUserOps.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userMedicOperators.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userSupporterOperators.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userSniperOperators.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userVanguardOperators.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userSpecialistOperators.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userDefenderOperators.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userGuardOperators.Remove(rarityLists.sixStarOperators[x]);
                                classesLists.userCasterOperators.Remove(rarityLists.sixStarOperators[x]);
                            }

                            break;
                        }
                }
            }
        }

    }
}
