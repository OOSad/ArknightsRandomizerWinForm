using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsRandomizerWinForm
{
    class StageLists
    {
        private List<string> listOfStages = new List<string> { };

        private List<string> prologueStages = new List<string>() { "0-1", "0-2", "0-3", "0-4", "0-5", "0-6", "0-7", "0-8", "0-9", "0-10", "0-11" };
        public List<string> PrologueStages
        {
            get { return prologueStages; }
        }

        private List<string> chapterOneStages = new List<string>() { "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "1-9", "1-10", "1-12", "S2-1", "S2-2", "S2-3", "S2-4", "S2-5", "S2-6", "S2-7", "S2-8", "S2-9", "S2-10", "S2-11", "S2-12" };
        public List<string> ChapterOneStages
        {
            get { return chapterOneStages; }
        }
        
        private List<string> chapterTwoStages = new List<string>() { "2-1", "S2-1", "2-2", "S2-2", "S2-3", "S2-4", "2-3", "2-4", "S2-5", "S2-6", "S2-7", "2-5", "2-6", "2-7", "S2-8", "S2-9", "2-8", "2-9", "S2-10", "S2-11", "S2-12", "2-10" };
        public List<string> ChapterTwoStages
        {
            get { return chapterTwoStages; }
        }

        private List<string> chapterThreeStages = new List<string>() { "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "S3-1", "S3-2", "S3-3", "S3-4", "S3-5", "S3-6" };
        public List<string> ChapterThreeStages
        {
            get { return chapterThreeStages; }
        }
        
        private List<string> chapterFourStages = new List<string>() { "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8", "4-9", "4-10", "S4-1", "S4-2", "S4-3", "S4-4", "S4-5", "S4-6", "S4-7", "S4-8", "S4-9", "S4-10" };
        public List<string> ChapterFourStages
        {
            get { return chapterFourStages; }
        }
        
        private List<string> chapterFiveStages = new List<string>() { "5-1", "5-2", "5-3", "5-4", "5-5", "5-6", "5-7", "5-8", "5-9", "5-10", "S5-1", "S5-2", "S5-3", "S5-4", "S5-5", "S5-6", "S5-7", "S5-8", "H5-1", "H5-2", "H5-3", "H5-4" };
        public List<string> ChapterFiveStages
        {
            get { return chapterFiveStages; }
        }
        
        private List<string> chapterSixStages = new List<string>() { "6-1", "6-2", "6-3", "6-4", "6-5", "6-7", "6-8", "6-9", "6-10", "6-11", "6-12", "6-14", "6-15", "6-16", "S6-1", "S6-2", "S6-3", "S6-4", "H6-1", "H6-2", "H6-3", "H6-4" };
        public List<string> ChapterSixStages
        {
            get { return chapterSixStages; }
        }

        private List<string> chapterSevenStages = new List<string>() { "7-2", "7-3", "7-4", "7-5", "7-6", "7-8", "7-9", "7-10", "7-11", "7-12", "7-13", "7-14", "7-15", "7-16", "7-18", "S7-1", "S7-2", "H7-1", "H7-2", "H7-3", "H7-4" };
        public List<string> ChapterSevenStages
        {
            get { return chapterSevenStages; }
        }


        private List<string> userStages = new List<string>() { "0-1", "0-2", "0-3", "0-4", "0-5", "0-6", "0-7", "0-8", "0-9", "0-10", "0-11", "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "1-9", "1-10", "1-12", "2-1", "S2-1", "2-2", "S2-2", "S2-3", "S2-4", "2-3", "2-4", "S2-5", "S2-6", "S2-7", "2-5", "2-6", "2-7", "S2-8", "S2-9", "2-8", "2-9", "S2-10", "S2-11", "S2-12", "2-10", "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8", "4-9", "4-10", "5-1", "5-2", "5-3", "5-4", "5-5", "5-6", "5-7", "5-8", "5-9", "5-10", "6-1", "6-2", "6-3", "6-4", "6-5", "6-7", "6-8", "6-9", "6-10", "6-11", "6-12", "6-14", "6-15", "6-16", "7-2", "7-3", "7-4", "7-5", "7-6", "7-8", "7-9", "7-10", "7-11", "7-12", "7-13", "7-14", "7-15", "7-16", "7-18", "S3-1", "S3-2", "S3-3", "S3-4", "S3-5", "S3-6", "S4-1", "S4-2", "S4-3", "S4-4", "S4-5", "S4-6", "S4-7", "S4-8", "S4-9", "S4-10", "S5-1", "S5-2", "S5-3", "S5-4", "S5-5", "S5-6", "S5-7", "S5-8", "H5-1", "H5-2", "H5-3", "H5-4", "H6-1", "H6-2", "H6-3", "H6-4", "H7-1", "H7-2", "H7-3", "H7-4" };
        public List<string> UserStages
        {
            get { return userStages; }
        }

        private List<string> userStagesDefault = new List<string>() { "0-1", "0-2", "0-3", "0-4", "0-5", "0-6", "0-7", "0-8", "0-9", "0-10", "0-11", "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "1-9", "1-10", "1-12", "2-1", "S2-1", "2-2", "S2-2", "S2-3", "S2-4", "2-3", "2-4", "S2-5", "S2-6", "S2-7", "2-5", "2-6", "2-7", "S2-8", "S2-9", "2-8", "2-9", "S2-10", "S2-11", "S2-12", "2-10", "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8", "4-9", "4-10", "5-1", "5-2", "5-3", "5-4", "5-5", "5-6", "5-7", "5-8", "5-9", "5-10", "6-1", "6-2", "6-3", "6-4", "6-5", "6-7", "6-8", "6-9", "6-10", "6-11", "6-12", "6-14", "6-15", "6-16", "7-2", "7-3", "7-4", "7-5", "7-6", "7-8", "7-9", "7-10", "7-11", "7-12", "7-13", "7-14", "7-15", "7-16", "7-18", "S3-1", "S3-2", "S3-3", "S3-4", "S3-5", "S3-6", "S4-1", "S4-2", "S4-3", "S4-4", "S4-5", "S4-6", "S4-7", "S4-8", "S4-9", "S4-10", "S5-1", "S5-2", "S5-3", "S5-4", "S5-5", "S5-6", "S5-7", "S5-8", "H5-1", "H5-2", "H5-3", "H5-4", "H6-1", "H6-2", "H6-3", "H6-4", "H7-1", "H7-2", "H7-3", "H7-4" };
        public List<string> UserStagesDefault
        {
            get { return userStagesDefault; }
        }
    }
}
