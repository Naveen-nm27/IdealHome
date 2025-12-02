using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealHome
{
    internal class User
    {
        public int UserId { get; set; }
        public String userName { get; set; }
        public String FullName { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
        public String Location { get; set; }
        public String UserImage { get; set; }

        public User()
        {

        }   

        public User(int userId, string userName, string fullName, string password, string role, string location, string userImage)
        {
            UserId = userId;
            this.userName = userName;
            FullName = fullName;
            Password = password;
            Role = role;
            Location = location;
            UserImage = userImage;
        }



    }
}
