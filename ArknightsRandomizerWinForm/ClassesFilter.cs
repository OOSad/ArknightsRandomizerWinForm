using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class ClassesFilter
    {
        public static void Filter_Out_Unselected_Classes_From_Pool_Of_UserOps(OperatorClassLists classesLists, List<string> listOfUserOps)
        {
            for (int i = 0; i < classesLists.classesToFilterOut.Count; i++)
            {
                switch (classesLists.classesToFilterOut[i])
                {
                    case "Medics":
                        {
                            for (int x = 0; x < classesLists.medicOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.medicOperators[x]);
                                classesLists.userMedicOperators.Remove(classesLists.medicOperators[x]);
                            }

                            break;
                        }

                    case "Supporters":
                        {
                            for (int x = 0; x < classesLists.supporterOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.supporterOperators[x]);
                                classesLists.userSupporterOperators.Remove(classesLists.supporterOperators[x]);
                            }

                            break;
                        }

                    case "Snipers":
                        {
                            for (int x = 0; x < classesLists.sniperOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.sniperOperators[x]);
                                classesLists.userSniperOperators.Remove(classesLists.sniperOperators[x]);
                            }

                            break;
                        }

                    case "Vanguards":
                        {
                            for (int x = 0; x < classesLists.vanguardOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.vanguardOperators[x]);
                                classesLists.userVanguardOperators.Remove(classesLists.vanguardOperators[x]);
                            }

                            break;
                        }

                    case "Specialists":
                        {
                            for (int x = 0; x < classesLists.specialistOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.specialistOperators[x]);
                                classesLists.userSpecialistOperators.Remove(classesLists.specialistOperators[x]);
                            }

                            break;
                        }

                    case "Defenders":
                        {
                            for (int x = 0; x < classesLists.defenderOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.defenderOperators[x]);
                                classesLists.userDefenderOperators.Remove(classesLists.defenderOperators[x]);
                            }

                            break;
                        }

                    case "Guards":
                        {
                            for (int x = 0; x < classesLists.guardOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.guardOperators[x]);
                                classesLists.userGuardOperators.Remove(classesLists.guardOperators[x]);
                            }

                            break;
                        }

                    case "Casters":
                        {
                            for (int x = 0; x < classesLists.casterOperators.Count; x++)
                            {
                                listOfUserOps.Remove(classesLists.casterOperators[x]);
                                classesLists.userCasterOperators.Remove(classesLists.casterOperators[x]);
                            }

                            break;
                        }

                    default: { break; }
                }
            }
        }

    }
}
