using SportStatLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace Sports_Project_1
{
    public partial class ForgotPassword : Form
    {
        private Random rnd = new Random();
        private int fourDigitNumber;
        private string email;
        public static string filePath = Path.Combine(Application.StartupPath, "UserLogins.csv");
        public Methods m = new Methods();
        private List<User> savedUsers = new List<User>();
        private User foundUser;
        public ForgotPassword()
        {
            InitializeComponent();

            //Generates a 4 digit code to later send to the user
            fourDigitNumber = rnd.Next(1000, 10000);
        }

        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            //Declare Variables
            string email = "";
            string subject = "";
            string body = "";



            //Get the email the user entered
            email = txtEmail.Text.Trim();
            this.email = email;

            //Ensures that something was entered in the textbox
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            else
            {
                savedUsers = m.FetchUserData(filePath);

                foundUser = savedUsers.FirstOrDefault(u =>
                    u.Email != null && u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

                if (foundUser == null)
                {
                    MessageBox.Show("That email is not found.");
                    return;
                }
                else
                {
                    //Create Subject Text
                    subject = "Your Sports App Password Reset Code";

                    //Create Body Text
                    body = "Your recovery code is: " + (fourDigitNumber)
                        + "\n\n Enter this code on the sports application";


                    //Send values to method
                    //Use a try and except to make sure it works
                    try
                    {
                        await SendEmailAsync(email, subject, body);
                        MessageBox.Show("Recovery code sent! Check your email.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to send email: " + ex.Message);
                    }

                    //Makes code textbox visible
                    lblEmail.Visible = false;
                    txtEmail.Visible = false;
                    lblCode.Visible = true;
                    txtCode.Visible = true;
                    btnSendCode.Visible = false;
                    btnSendCode.Enabled = false;
                    btnVerify.Visible = true;
                    btnVerify.Enabled = true;
                }
            }
        }






        //Sends the 4 digit code to the users email
        public async Task SendEmailAsync(string recipientEmail, string subject, string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("sportsapplication206@gmail.com", "Sports Application");
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = body;

                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential("sportsapplication206@gmail.com", "sgvfuyijajyhopll");
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                    await smtpClient.SendMailAsync(mail);
                   
                }
            }
        }

        //Verifies the code sent
        private void btnVerify_Click(object sender, EventArgs e)
        {
            string entered = txtCode.Text.Trim();
            int userInput = Convert.ToInt32(entered);

            if (userInput == fourDigitNumber)
            {
                DialogResult results = MessageBox.Show("You can now set a new password.", "CODE VERIFIED!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                cbxSee.Visible = true;
                btnVerify.Visible = false;
                lblCode.Visible = false;
                txtCode.Visible = false;
                txtCode.Enabled = true;
                lblPass.Visible = true;
                txtBoxPass.Visible = true;
                lblConfirm.Visible = true;
                txtConfirm.Visible = true;
                btnUpdate.Enabled = true;
                btnUpdate.Visible = true;

            }
            else
            {
               MessageBox.Show("Invalid code try again.", "VERIFICATION FAILED!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Updates password in database


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string newPassword = txtBoxPass.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (newPassword != confirm)
            {
                MessageBox.Show("These passwords do not match please try again!","ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            try
            {
                m.UpdatePasswordByEmail(filePath, email, newPassword);
                MessageBox.Show("Password Updated!","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cBoxSeePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSee.Checked)
            {
                txtBoxPass.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }

            if (!cbxSee.Checked)
            {
                txtBoxPass.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult leaving = MessageBox.Show("Are you sure?", "Exiting Password Recovery", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (leaving == DialogResult.OK)
            {
                MessageBox.Show("Leaving Password Recovery", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Close();
            }
            else
            {
                return;
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leaving Password Recovery", "Exiting...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Close();
        }
    }
}
