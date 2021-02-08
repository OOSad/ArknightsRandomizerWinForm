using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    class UserOpsPopulator
    {
        
        public static void Populate_UserOps_Lists()
        {
            OperatorClassLists operatorClassesLists = Program.operatorClassesLists;
            List<string> userOps = Program.userOps;

            ListWiper.Wipe_Many_Lists_Clean(operatorClassesLists.userMedicOperators, operatorClassesLists.userSupporterOperators, operatorClassesLists.userSniperOperators, operatorClassesLists.userVanguardOperators, operatorClassesLists.userSpecialistOperators, operatorClassesLists.userDefenderOperators, operatorClassesLists.userGuardOperators, operatorClassesLists.userCasterOperators);

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
    }
}
