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
    public partial class NHLStats : Form
    {
        private int _teamId;

        public NHLStats()
        {
            InitializeComponent();
        }

        public NHLStats(NHL_Class_Library.Team team, Image logo, int teamId)
        {
            InitializeComponent();
            _teamId = teamId;


            lblTeam.Text = team.TeamName;
            txtConference.Text = team.Conference;
            txtWins.Text = team.Wins.ToString();
            txtLosses.Text = team.Losses.ToString();
            txtTies.Text = team.Ties.ToString();
            txtOT.Text = team.OTLosses.ToString();
            txtPoints.Text = team.Points.ToString();

            pbxLogo.Image = logo;
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            DialogResult leaving = MessageBox.Show("Are you sure?", "Exiting "+ lblTeam.Text + "'s Team Stats", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (leaving == DialogResult.OK)
            {
                MessageBox.Show("Leaving " + lblTeam.Text + "'s Team Stats", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leaving " + lblTeam.Text + "'s Team Stats", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            NHLPlayersForm f = new NHLPlayersForm(_teamId, pbxLogo.Image, lblTeam.Text);
            f.ShowDialog();
        }
    }
}

