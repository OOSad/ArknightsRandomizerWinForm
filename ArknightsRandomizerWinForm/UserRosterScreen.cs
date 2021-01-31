using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ArknightsRandomizerWinForm
{
    public partial class UserRosterScreen : Form
    {
        public UserRosterScreen()
        {
            InitializeComponent();

            Program.Create_UserOps_File();
            Program.Wipe_One_Or_More_Lists_Clean(Program.userOps);
            Program.Read_UserOps_From_File(Program.userOps);
            Program.Check_All_The_Checkboxes_In_A_Page_Based_On_A_List(Program.userOps, RosterBox);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Write_UserOps_To_File(RosterBox);
            Program.Populate_UserOps_Lists();
            Program.Hide_Current_Form_Then_Open_Next_Form(this, new ClassFiltersScreen());
        }

        private void UserRosterScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
