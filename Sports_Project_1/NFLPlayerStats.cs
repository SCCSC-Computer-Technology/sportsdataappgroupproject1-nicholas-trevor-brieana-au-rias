using NHL_Class_Library;
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
        public int teamID;
        public int playerID;

        public NFLPlayerStats(int pID, Image logo, int TeamID)//playerid is here so anytime form is opened we can identify what player it is with this
        {
            InitializeComponent();

            playerID = pID;
            pBoxLogo.Image = logo;
            teamID = TeamID;
        }

        private void butExit_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Exit.....", "Leaving Player Stats", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult leaving = MessageBox.Show("Are you sure?", "Exiting NFL Player Stats", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (leaving == DialogResult.OK)
            {
                MessageBox.Show("Leaving NFL Player Stats", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Close();
            }
            else
            {
                return;
            }
        }

        private void NFLPlayerStats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDBDataSet.__NFL_Team__' table. You can move, or remove it, as needed.
            this._NFL_Players__TableAdapter.FillByTeam(this.sportsDBDataSet.@__NFL_Players__, teamID);  //used teamID passed from button as parameter for filling the table of players

            this._NFL_Players__TableAdapter.FillByPlayer(this.sportsDBDataSet.@__NFL_Players__, playerID);

            this._NFL_Team__TableAdapter.FillByTeamInfo(this.sportsDBDataSet.@__NFL_Team__, teamID);

            this._NFL_Player_Stats__TableAdapter.FillByPlayerStats(this.sportsDBDataSet.@__NFL_Player_Stats__,playerID);

            DataRowView currRow = (DataRowView)_NFL_Players__BindingSource.Current;

            if(currRow != null)
            {
                lblPName.Text = currRow["First Name"].ToString() +" "+currRow["Last Name"].ToString();
            }
        }



        //labels for player name and team name, textboxes for player info and player stats
    }
}
