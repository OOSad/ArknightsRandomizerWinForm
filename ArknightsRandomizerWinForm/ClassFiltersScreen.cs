using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ArknightsRandomizerWinForm
{
    public partial class ClassFiltersScreen : Form
    {
        public ClassFiltersScreen()
        {
            InitializeComponent();
            CheckboxChecker.Check_Every_Checkbox_On_This_Form(this);
            Set_SquadSize_Slider_To_Max();
            Program.Set_SquadSize_To_Max();
            
        }



        private void RollButton_Click(object sender, EventArgs e)
        {
            Program.Roll_Ops_And_Create_Roster(Program.squadSize);
            Program.Update_Operator_Labels_On_Form(this);
        }
        private void RollStageButton_Click(object sender, EventArgs e)
        {
            Program.Roll_For_Stage();
            Program.Update_Stage_Label_On_Form(this);
        }
        private void BackToRosterButton_Click(object sender, EventArgs e)
        {
            FormSwapper.Hide_Current_Form_Then_Open_Next_Form(this, new UserRosterScreen());
        }


        private void ClassFiltersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Wipe_One_Or_More_Lists_Clean(Program.operatorClassesLists.classesToFilterOut);
            
            for (int i = 0; i < ClassFiltersBox.Items.Count; i++)
            {
                if (ClassFiltersBox.GetItemChecked(i) == false)
                {
                    Program.operatorClassesLists.classesToFilterOut.Add(ClassFiltersBox.Items[i].ToString());
                }
            }
        }
        private void RarityFiltersBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Program.Wipe_One_Or_More_Lists_Clean(Program.operatorRarityLists.raritiesToFilterOut);

            for (int i = 0; i < RarityFiltersBox.Items.Count; i++)
            {
                if (RarityFiltersBox.GetItemChecked(i) == false)
                {
                    Program.operatorRarityLists.raritiesToFilterOut.Add(RarityFiltersBox.Items[i].ToString());
                }
            }
        }
        private void ChapterFiltersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Wipe_One_Or_More_Lists_Clean(Program.stageLists.chaptersToFilterOut);

            for (int i = 0; i < ChapterFiltersBox.Items.Count; i++)
            {
                if (ChapterFiltersBox.GetItemChecked(i) == false)
                {
                    Program.stageLists.chaptersToFilterOut.Add(ChapterFiltersBox.Items[i].ToString());
                }
            }
        }


        private void SquadSizeTrackbar_Scroll(object sender, EventArgs e)
        {
            Program.squadSize = SquadSizeTrackbar.Value + 1;
        }
        private void Set_SquadSize_Slider_To_Max()
        {
            SquadSizeTrackbar.Value = 11;
        }


        private void MedicsLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.medicLimit = Convert.ToInt32(MedicsLimitBox.Text);
            }
            catch
            {
                MedicsLimitBox.Text = Convert.ToString(0);
            }
        }
        private void SupportersLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.supporterLimit = Convert.ToInt32(SupportersLimitBox.Text);
            }
            catch
            {
                SupportersLimitBox.Text = Convert.ToString(0);
            }
        }
        private void SnipersLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.sniperLimit = Convert.ToInt32(SnipersLimitBox.Text);
            }
            catch
            {
                SnipersLimitBox.Text = Convert.ToString(0);
            }
        }
        private void VanguardsLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.vanguardLimit = Convert.ToInt32(VanguardsLimitBox.Text);
            }
            catch
            {
                VanguardsLimitBox.Text = Convert.ToString(0);
            }
        }
        private void SpecialistsLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.specialistLimit = Convert.ToInt32(SpecialistsLimitBox.Text);
            }
            catch
            {
                SpecialistsLimitBox.Text = Convert.ToString(0);
            }
        }
        private void DefendersLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.defenderLimit = Convert.ToInt32(DefendersLimitBox.Text);
            }
            catch
            {
                DefendersLimitBox.Text = Convert.ToString(0);
            }
        }
        private void GuardsLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.guardLimit = Convert.ToInt32(GuardsLimitBox.Text);
            }
            catch
            {
                GuardsLimitBox.Text = Convert.ToString(0);
            }
        }
        private void CastersLimitBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.casterLimit = Convert.ToInt32(CastersLimitBox.Text);
            }
            catch
            {
                CastersLimitBox.Text = Convert.ToString(0);
            }
        }


        private void ClassFiltersScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
