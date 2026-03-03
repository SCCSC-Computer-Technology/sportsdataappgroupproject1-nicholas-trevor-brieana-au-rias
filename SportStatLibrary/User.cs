using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStatLibrary
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public int FavNHLTeamID { get; set; }
        public int FavNFLTeamID { get; set; }

        public string WantsEmailUpdates { get; set; }

        public User(int iD, string username, string email,string password, string firstName, string wantsEmailUpdates)
        {
            ID = iD;
            Username = username;
            Email = email;
            Password = password;
            FirstName = firstName;
            FavNFLTeamID = -1;
            FavNHLTeamID = -1;
            WantsEmailUpdates = wantsEmailUpdates;

        }

        public User(int iD, string username, string email,string password, string firstName, int favNFLTeamID, int favNHLTeamID,string wantsEmailUpdates)
        {
            ID = iD;
            Username = username;
            Email = email;
            Password = password;
            FirstName = firstName;
            FavNFLTeamID = favNFLTeamID;
            FavNHLTeamID = favNHLTeamID;
            WantsEmailUpdates= wantsEmailUpdates;
        }


        public User() { }
    }

}

