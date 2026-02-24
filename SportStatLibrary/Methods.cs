using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO; //added micorosoft visual basic reference for textfield parser

namespace SportStatLibrary
{
    public class Methods
    {
        public List<User> FetchUserData(string filePath)
        {
            List<User> users = new List<User>();
            string[] columns = new string[6];
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;  

                //get rid of headings
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    columns = parser.ReadFields();

                    if (columns.Length < 6) { continue; }

                    int iD = 0;
                    int favNHLID = 0;
                    int favNFLID = 0;


                    int.TryParse(columns[0].Trim(), out iD);
                    int.TryParse(columns[4].Trim(), out favNFLID);
                    int.TryParse(columns[5].Trim(), out favNHLID);



                    User user = new User(iD, columns[1], columns[2], columns[3], favNHLID, favNFLID);
                    users.Add(user);

                }
                return users;
            }
        }

        public void AddUser(string filePath, User newUser)
        {
            string row = $"{newUser.ID},{newUser.Username},{newUser.Password},{newUser.FirstName},{newUser.FavNFLTeamID},{newUser.FavNHLTeamID}";

            File.AppendAllText(filePath, Environment.NewLine + row);
        }





    }
}
