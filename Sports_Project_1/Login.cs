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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Sports_Project_1
{
    public partial class Login : Form
    {
        public static string filePath = Path.Combine(Application.StartupPath, "UserLogins.csv");

        public List<User> savedUsers = new List<User>();

        public Methods m = new Methods();

        public bool namePop = false;

        public Login()
        {
            InitializeComponent();

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Come Back Soon", "Exiting Sports Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
            this.Close();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            savedUsers = m.FetchUserData(filePath);//method from class library to fill users into a list with data from csv file of saved logins

            string inputUser = txtBoxUser.Text.Trim();
            string inputPass = txtBoxPass.Text.Trim();

            //check if user and pass are same as any in savedUserslist and if they are assign that user
            User foundUser = savedUsers.FirstOrDefault(u => u.Username.Equals(inputUser, StringComparison.OrdinalIgnoreCase) && (u.Password ?? "").Trim().Equals((inputPass ?? "").Trim(), StringComparison.Ordinal));

            if (foundUser != null)
            {
                MainForm menu = new MainForm(foundUser, this);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Try Again!", "INVALID USERNAME OR PASSWORD !! ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void butCreateAcc_Click(object sender, EventArgs e)
        {
            Account_Creation account_Creation = new Account_Creation();

            account_Creation.ShowDialog();

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
            DialogResult leaving = MessageBox.Show("Are you sure?", "Exiting Sports Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (leaving == DialogResult.OK)
            {
                MessageBox.Show("Come Back Soon", "Exiting Sports Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ForgotPassword();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void lblForgot_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ForgotPassword();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
