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

        
    }
}
