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
    public partial class NFLTeamStats : Form
    {
        public int teamID;

        public NFLTeamStats(int TeamID, Image logo)//teamid is here so anytime form is opened we can identify what team it is with this
        {
            InitializeComponent();
            pBoxLogo.Image = logo;
            teamID = TeamID;

        }

        private void NFLStats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDBDataSet.__NFL_Players__' table. You can move, or remove it, as needed.
            this._NFL_Players__TableAdapter.FillByTeam(this.sportsDBDataSet.@__NFL_Players__, teamID);  //used teamID passed from button as parameter for filling the table of players
            
            this._NFL_Team__TableAdapter.FillByTeamInfo(this.sportsDBDataSet.@__NFL_Team__, teamID);

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting....", "Exiting NFL Form", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        private void _NFL_Players__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._NFL_Players__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsDBDataSet);

        }

        private void _NFL_Players__DataGridView_CellClick(object sender, DataGridViewCellEventArgs e) //takes playerid from row clicked and opens playerstats form
        {
            if(e.RowIndex == 0)
            {
                MessageBox.Show("See their form!", "Click a Player",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            DataGridViewCell cell = _NFL_Players__DataGridView.Rows[e.RowIndex].Cells[0];
            int pID = int.Parse(cell.Value.ToString());
            NFLPlayerStats form = new NFLPlayerStats(pID, pBoxLogo.Image,teamID);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult leaving = MessageBox.Show("Are you sure?", "Exiting NFL Teams Stats", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (leaving == DialogResult.OK)
                {
                    MessageBox.Show("Leaving NFL Team Stats", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception bad)
            {
                MessageBox.Show("So thing bad happened..." + bad, "Uh Oh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
