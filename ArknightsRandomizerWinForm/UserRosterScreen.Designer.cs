
namespace ArknightsRandomizerWinForm
{
    partial class UserRosterScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRosterScreen));
            this.RosterBox = new System.Windows.Forms.CheckedListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RosterBox
            // 
            this.RosterBox.CheckOnClick = true;
            this.RosterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RosterBox.FormattingEnabled = true;
            this.RosterBox.Items.AddRange(new object[] {
            "12F",
            "Aak",
            "Absinthe",
            "Aciddrop",
            "Adnachiel",
            "Ambriel",
            "Amiya",
            "Andreana",
            "Angelina",
            "Ansel",
            "Asbestos",
            "Astesia",
            "Ayerscarpe",
            "Bagpipe",
            "Beagle",
            "Beehunter",
            "Beeswax",
            "Bibeak",
            "Bison",
            "Blaze",
            "Blue Poison",
            "Breeze",
            "Broca",
            "Cardigan",
            "Castle-3",
            "Catapult",
            "Ceobe",
            "Ceylon",
            "Ch\'en",
            "Chiave",
            "Click",
            "Cliffheart",
            "Courier",
            "Croissant",
            "Cuora",
            "Cutter",
            "Deepcolor",
            "Dobermann",
            "Dur-nar",
            "Durin",
            "Earthspirit",
            "Elysium",
            "Estelle",
            "Ethan",
            "Eunectes",
            "Executor",
            "Exusiai",
            "Eyjafjalla",
            "Fang",
            "FEater",
            "Firewatch",
            "Flamebringer",
            "Flint",
            "Folinic",
            "Franka",
            "Frostleaf",
            "Gavial",
            "Gitano",
            "Glaucus",
            "Grani",
            "Gravel",
            "GreyThroat",
            "Greyy",
            "Gummy",
            "Haze",
            "Hellagur",
            "Hibiscus",
            "Hoshiguma",
            "Hung",
            "Ifrit",
            "Indra",
            "Istina",
            "Jaye",
            "Jessica",
            "Kroos",
            "Lancet-2",
            "Lappland",
            "Lava",
            "Leizi",
            "Leonhardt",
            "Liskarm",
            "Magallan",
            "Manticore",
            "Matoimaru",
            "Matterhorn",
            "May",
            "Mayer",
            "Melantha",
            "Meteor",
            "Meteorite",
            "Midnight",
            "Mostima",
            "Mousse",
            "Myrrh",
            "Myrtle",
            "Nearl",
            "Nian",
            "Nightingale",
            "Nightmare",
            "Noir Corne",
            "Orchid",
            "Perfumer",
            "Phantom",
            "Platinum",
            "Plume",
            "Podenco",
            "Popukar",
            "Pramanix",
            "Projekt Red",
            "Provence",
            "Ptilopsis",
            "Rangers",
            "Reed",
            "Rope",
            "Rosa(Poca)",
            "Saria",
            "Savage",
            "Scavenger",
            "Scene",
            "Schwarz",
            "Sesa",
            "Shamare",
            "Shaw",
            "Shining",
            "Shirayuki",
            "Sideroca",
            "Siege",
            "Silence",
            "SilverAsh",
            "Skadi",
            "Skyfire",
            "Snowsant",
            "Sora",
            "Specter",
            "Spot",
            "Steward",
            "Sussurro",
            "Suzuran",
            "Swire",
            "Texas",
            "Thorns",
            "THRM-EX",
            "Tomimi",
            "Tsukinogi",
            "Utage",
            "Vanilla",
            "Vermeil",
            "Vigna",
            "Vulcan",
            "W",
            "Waai Fu",
            "Warfarin",
            "Weedy",
            "Yato",
            "Zima"});
            this.RosterBox.Location = new System.Drawing.Point(12, 88);
            this.RosterBox.MultiColumn = true;
            this.RosterBox.Name = "RosterBox";
            this.RosterBox.Size = new System.Drawing.Size(776, 304);
            this.RosterBox.Sorted = true;
            this.RosterBox.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(713, 415);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor\'s Roster";
            // 
            // UserRosterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RosterBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserRosterScreen";
            this.Text = "Arknights Randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserRosterScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox RosterBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
    }
}

