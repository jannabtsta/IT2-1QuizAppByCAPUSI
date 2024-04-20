using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using QuizAppMODEL;

namespace QuizAppDATAL
{
    public class UserData
    {
        List<User> users = new List<User>();

        public UserData()
        {
            UserInfo();
        }

        public void UserInfo()
        {
            User user1 = new User()
            {
                username = "JoanaB",
                pass = "password1"
            };

            User user2 = new User()
            {
                username = "RodB",
                pass = "password2"
            };

            User user3 = new User()
            {
                username = "EzraP",
                pass = "password3"
            };

            User user4 = new User()
            {
                username = "PearlT",
                pass = "password4"
            };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
        }

        public User GetUser(string username, string password)
        {
            User userfound = new User();

            foreach (var verify in users)
            {
                if (username == verify.username && password == verify.pass)
                {
                    userfound = verify;
                }
            }
            return userfound;
        }
    }
}
