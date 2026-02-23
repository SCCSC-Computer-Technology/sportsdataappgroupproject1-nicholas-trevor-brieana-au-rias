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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxBruins_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            string query = "SELECT * FROM NHL Team$ WHERE TeamID = @TeamID";
        }
    }
}
