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

        private static readonly Dictionary<int, string> NflLogoById = new Dictionary<int, string>
        {
            { 1, "cardinals.png" },
            { 2, "falcons.png" },
            { 3, "Ravens.png" },
            { 4, "bills.png" },
            { 5, "panthers.png" },
            { 6, "Bears.png" },
            { 7, "bengals.png" },
            { 8, "browns.png" },
            { 9, "cowboys.png" },
            { 10, "broncos.png" },
            { 11, "lions.png" },
            { 12, "Green Bay.png" },
            { 13, "texans.png" },
            { 14, "colts.png" },
            { 15, "jaguars.png" },
            { 16, "chiefs.png" },
            { 17, "raiders.png" },
            { 18, "chargers.png" },
            { 19, "rams.png" },
            { 20, "dolphins.png" },
            { 21, "vikings.png" },
            { 22, "patriots.png" },
            { 23, "saints.png" },
            { 24, "giants.png" },
            { 25, "jets.png" },
             { 26, "eagles.png" },
            { 27, "steelers.png" },
            { 28, "49ers.png" },
            { 29, "seahawks.png" },
            { 30, "buccaneers.png" },
            { 31, "titans.png" },
            { 32, "commanders.png" },

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

            string fileName = null;

            if (league == "NFL")
                NflLogoById.TryGetValue(teamId, out fileName);
            else
                NhlLogoById.TryGetValue(teamId, out fileName);

            if (string.IsNullOrWhiteSpace(fileName))
            {
                // fallback label if you don't have a mapping yet
                fileName = $"{teamId}.png";
            }

            string logoPath = Path.Combine(Application.StartupPath, "Logos", league, fileName);

            if (System.IO.File.Exists(logoPath))
                pb.Image = Image.FromFile(logoPath);

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

