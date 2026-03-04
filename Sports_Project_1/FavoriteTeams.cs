using NHL_Class_Library;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace Sports_Project_1
{
    public partial class FavoriteTeams : Form
    {
        private User currentUser;
        public static string filePath = Path.Combine(Application.StartupPath, "UserLogins.csv");
        private readonly Methods m = new Methods();

        private static readonly Dictionary<int, Image> NflLogoById = new Dictionary<int, Image>
        {
            { 1, Properties.Resources.Cardinals },
            { 2, Properties.Resources.Falcons },
            { 3, Properties.Resources.Ravens },
            { 4, Properties.Resources.Bills },
            { 5, Properties.Resources.Panthers },
            { 6, Properties.Resources.Bears },
            { 7, Properties.Resources.Bengals },
            { 8, Properties.Resources.Browns },
            { 9, Properties.Resources.Cowboys },
            { 10, Properties.Resources.Broncos },
            { 11, Properties.Resources.Lions },
            { 12, Properties.Resources.Green_Bay },
            { 13, Properties.Resources.Texans },
            { 14, Properties.Resources.Colts },
            { 15, Properties.Resources.Jaguars },
            { 16, Properties.Resources.Chiefs },
            { 17, Properties.Resources.Raiders },
            { 18, Properties.Resources.Chargers },
            { 19, Properties.Resources.Rams },
            { 20, Properties.Resources.Dolphins },
            { 21, Properties.Resources.Vikings },
            { 22, Properties.Resources.Patriots },
            { 23, Properties.Resources.Saints },
            { 24, Properties.Resources.Giants },
            { 25, Properties.Resources.Jets },
             { 26, Properties.Resources.Eagles },
            { 27, Properties.Resources.Steelers },
            { 28, Properties.Resources._49ers },
            { 29, Properties.Resources.Seahawks },
            { 30, Properties.Resources.Buccaneers },
            { 31, Properties.Resources.Titans },
            { 32, Properties.Resources.Commanders },

        };

        private static readonly Dictionary<int, Image> NhlLogoById = new Dictionary<int, Image>
        {
            { 1, Properties.Resources._1 },
            { 2, Properties.Resources._2 },
            { 3, Properties.Resources._3 },
            { 4, Properties.Resources._4 },
            { 5, Properties.Resources._5 },
            { 6, Properties.Resources._6 },
            { 7, Properties.Resources._7 },
            { 8, Properties.Resources._8 },
            { 9, Properties.Resources._9 },
            { 10, Properties.Resources._10 },
            { 11, Properties.Resources._11 },
            { 12, Properties.Resources._12 },
            { 13, Properties.Resources._13 },
            { 14, Properties.Resources._14 },
            { 15, Properties.Resources._15 },
            { 16, Properties.Resources._16 },
            { 17, Properties.Resources._17 },
            { 18, Properties.Resources._18 },
            { 19, Properties.Resources._19 },
            { 20, Properties.Resources._20 },
            { 21, Properties.Resources._21 },
            { 22, Properties.Resources._22 },
            { 23, Properties.Resources._23 },
            { 24, Properties.Resources._24 },
            { 25, Properties.Resources._25 },
             { 26, Properties.Resources._26 },
            { 27, Properties.Resources._27 },
            { 28, Properties.Resources._28 },
            { 29, Properties.Resources._29 },
            { 30, Properties.Resources._30 },
            { 31, Properties.Resources._31 },
            { 32, Properties.Resources._32 },

        };
       

        //private static readonly Dictionary<int, string> NhlLogoById = new Dictionary<int, string>
        // {


        //};
        public FavoriteTeams(User person)
        {
            InitializeComponent();
            currentUser = person;
        }

        private void FavoriteTeams_Load(object sender, EventArgs e)
        {
            LoadFavoriteTeamsUI();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cbxReceiveUpdates_CheckedChanged(object sender, EventArgs e)
        {
            string message = "Would you like to unsubscribe from the mailing list?";
            string title = "Unsubscribe?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            string body = "";
            string subject = "";

            
            string email = currentUser.Email;
            string name = currentUser.FirstName;


            if (currentUser.WantsEmailUpdates == "false")
            {
                MessageBox.Show("Thank you for signing up for updates!");
                currentUser.WantsEmailUpdates = "true";

                //Create Subject Text
                subject = "Welcome aboard!";

                //Create Body Text
                body = "Welcome " + name + ","
                    + "\n\nThank you for signing up for email updates!"
                    + "\n\nYou will receive emails about upcoming matches, scores and highlights from the most recent match for your favorite teams "
                    + "\n\nWe're thrilled to have you as part of our family."
                    + "\n\nBest regards,"
                    + "\nThe Sport Aplication Team";



                //Send values to method
                //Use a try and except to make sure it works
                try
                {
                    await SendEmailAsync(email, subject, body);
                    MessageBox.Show("Welcome email sent! Check your email!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send email: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("You have already set up email updates. \n Thank you for being a loyal member");
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("We are sorry to see you go");
                    currentUser.WantsEmailUpdates = "false";
                    m.UpdateUserSubscription(filePath,currentUser.ID, "false");


                }
                else
                {
                    MessageBox.Show("Thank you for being a loyal member!");
                }
            }
        }

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

        private void LoadFavoriteTeamsUI()
        {
            flpNFL.Controls.Clear();
            flpNHL.Controls.Clear();

            if (currentUser.FavNFLTeamID > 0)
                flpNFL.Controls.Add(CreateTeamTile("NFL", currentUser.FavNFLTeamID));

            if (currentUser.FavNHLTeamID > 0)
                flpNHL.Controls.Add(CreateTeamTile("NHL", currentUser.FavNHLTeamID));
        }

        private Control CreateTeamTile(string league, int teamId)
        {
            var pb = new PictureBox
            {
                Width = 90,
                Height = 90,
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand,
                Tag = teamId
            };

            Image logo = null;

            if (league == "NFL")
                NflLogoById.TryGetValue(teamId, out logo);
            else
               NhlLogoById.TryGetValue(teamId, out logo);


         

            
                pb.Image = logo;

            var lbl = new Label
            {
                Text = $"{league} Team #{teamId}",
                AutoSize = false,
                Width = 90,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };

            pb.Click += (s, e) =>
            {
                int id = (int)((PictureBox)s).Tag;

                if (league == "NFL")
                {
                    var statForm = new NFLTeamStats(id, pb.Image);
                    Hide();
                    statForm.ShowDialog();
                    Show();
                }
                else
                {
                    OpenNHLStats(id,pb.Image);
                }
            };

            var panel = new Panel { Width = 100, Height = 130 };
            pb.Left = 5; pb.Top = 5;
            lbl.Left = 5; lbl.Top = 95;
            panel.Controls.Add(pb);
            panel.Controls.Add(lbl);
            return panel;
        }

    
        
            private void OpenNHLStats(int teamId, Image logo)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("No team found for that TeamID.");
                        return;
                    }

                    var team = new NHL_Class_Library.Team(
                        reader["Team"].ToString(),
                        reader["Conference"].ToString(),
                        Convert.ToInt32(reader["Wins"]),
                        Convert.ToInt32(reader["Losses"]),
                        Convert.ToInt32(reader["Tie"]),
                        Convert.ToInt32(reader["OT Losses"]),
                        Convert.ToInt32(reader["Points"])
                    );

                    var form = new NHLStats(team, logo, teamId);
                    Hide();
                    form.ShowDialog();
                    Show();
                }
            }
        }
    }
    
}

