using SportStatLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Project_1
{
    public partial class Account_Creation : Form
    {
        public static string filePath = Path.Combine(Application.StartupPath, "UserLogins.csv");

        public List<User> savedUsers = new List<User>();

        public Methods m = new Methods();
        public Account_Creation()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leaving Account Creating", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Close();
        }

        private void butCreateAcc_Click(object sender, EventArgs e)
        {
            savedUsers = m.FetchUserData(filePath);//method from class library to fill users into a list with data from csv file of saved logins
            string user = txtBoxUser.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtBoxPass.Text.Trim();
            string firstName = txtBoxFirstName.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Missing Field!! Add all Information!", "FILL ALL FIELDS !!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            bool userExists = savedUsers.Any(u => u.Username.Equals(user, StringComparison.OrdinalIgnoreCase)); //checks if username is taken

            if (userExists)
            {

                DialogResult results = MessageBox.Show("Username " + user + " is taken please try again", "THIS USER IS TAKEN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (results == DialogResult.Cancel)
                {
                    DialogResult leaving = MessageBox.Show("Leaving Account Creating", "Exiting...", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    if (leaving == DialogResult.OK)
                    {
                        Close();
                    }
                }
                return;
            }

            int newUserID;

            if (savedUsers.Count > 0)
            {
                newUserID = savedUsers.Max(u => u.ID) + 1;
            }
            else
            {
                newUserID = 1;
            }

            User newUser = new User(newUserID, user, email, pass, firstName, "false");

            m.AddUser(filePath, newUser); //writes to UserLogins csv file in debug folder, original UserLogins file in project does not change.

            //Configuring MessageBox
            MessageBox.Show("You've Created A Account!", "ACCOUNT CREATED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Close();

        }

        private void cBoxSeePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxSeePass.Checked)
            {
                txtBoxPass.PasswordChar = '\0';
            }

            if (!cBoxSeePass.Checked)
            {
                txtBoxPass.PasswordChar = '*';
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult leaving = MessageBox.Show("Are you sure?", "Exiting Account Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (leaving == DialogResult.OK)
            {
                MessageBox.Show("Leaving Account Creating", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
