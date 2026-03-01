using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Project_1
{
    public partial class NFLPlayerStats : Form
    {
        public int playerID;

        public NFLPlayerStats(int pID, Image logo)//playerid is here so anytime form is opened we can identify what player it is with this
        {
            InitializeComponent();

            playerID = pID;
            pBoxLogo.Image = logo;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //labels for player name and team name, textboxes for player info and player stats
    }
}
