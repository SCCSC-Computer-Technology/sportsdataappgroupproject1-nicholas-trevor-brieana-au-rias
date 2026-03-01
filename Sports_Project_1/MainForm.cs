using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportStatLibrary;

namespace Sports_Project_1
{
    public partial class MainForm : Form
    {

        private Form loginForm;

        public MainForm(User person, Login login)
        {
            InitializeComponent();
            lblName.Text = "Welcome Back " + person.FirstName;


            this.loginForm = login;

        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out ... returning to Login screen");
            this.Close();
            loginForm.Show();
        }

        private void butNFL_Click(object sender, EventArgs e)
        {
            NFLTeams NFLteams = new NFLTeams();
            this.Hide();
            NFLteams.ShowDialog();
            this.Show();
        }

        private void butNHL_Click(object sender, EventArgs e)
        {
            Form1 NHLteams = new Form1();
            this.Hide();
            NHLteams.ShowDialog();
            this.Show();
        }
    }
}
