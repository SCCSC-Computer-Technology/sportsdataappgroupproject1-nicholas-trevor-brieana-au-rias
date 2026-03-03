using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO; //added micorosoft visual basic reference for textfield parser

namespace SportStatLibrary
{
    public class Methods
    {
        public List<User> FetchUserData(string filePath)
        {
            List<User> users = new List<User>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;

                // skip header
                if (!parser.EndOfData) parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] columns = parser.ReadFields();
                    if (columns == null || columns.Length < 7) continue;

                    int.TryParse(columns[0].Trim(), out int id);
                    string username = columns[1].Trim();
                    string email = columns[2].Trim();
                    string password = columns[3];         
                    string firstName = columns[4].Trim();

                    int.TryParse(columns[5].Trim(), out int favNFLID);
                    int.TryParse(columns[6].Trim(), out int favNHLID);

                    User user = new User(id, username, password, firstName, email, favNFLID, favNHLID);

                    users.Add(user);
                }
            }

            return users;
        }


        public void AddUser(string filePath, User newUser)
        {
            string row = $"{newUser.ID},{newUser.Username},{newUser.Password},{newUser.FirstName},{newUser.FavNFLTeamID},{newUser.FavNHLTeamID}";

            File.AppendAllText(filePath, Environment.NewLine + row);
        }

        public bool UpdateUser(string filePath, User updatedUser)
        { 
            if(!File.Exists(filePath))
            {  return false; }

            var lines = File.ReadAllLines(filePath).ToList();
            if (lines.Count == 0) return false;

            bool updated = false;

            for (int i = 1; i < lines.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                string[] cols = lines[i].Split(',');
                if (cols.Length < 7) continue;

                if (int.TryParse(cols[0].Trim(), out int id) && id == updatedUser.ID)
                {
                    lines[i] = $"{updatedUser.ID},{updatedUser.Username},{updatedUser.Email},{updatedUser.Password},{updatedUser.FirstName},{updatedUser.FavNFLTeamID},{updatedUser.FavNHLTeamID}";
                    updated = true;
                    break;

                }
            }
            if (!updated) return false; 
            File.WriteAllLines(filePath, lines); 
            return true;
        }

        public void UpdatePasswordByEmail(string filePath, string email, string newPassword)
        {
            var users = FetchUserData(filePath);

            var user = users.FirstOrDefault(u =>
                !string.IsNullOrWhiteSpace(u.Email) &&
                u.Email.Trim().Equals(email.Trim(), StringComparison.OrdinalIgnoreCase));

            if (user == null) throw new Exception("Email not found.");

            user.Password = newPassword.Trim();

            using (var writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("ID,Username,Email,Password,FirstName,FavNFLTeamID,FavNHLTeamID");
                foreach (var u in users)
                {
                    writer.WriteLine($"{u.ID},{u.Username},{u.Email},{u.Password},{u.FirstName},{u.FavNFLTeamID},{u.FavNHLTeamID}");
                }
            }
        }




    }
}
