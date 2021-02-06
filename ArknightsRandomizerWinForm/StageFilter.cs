using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    static class StageFilter
    {
        public static void Filter_Out_Unselected_Stages_From_Pool_Of_Maps(StageLists stageLists)
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
    }
}
