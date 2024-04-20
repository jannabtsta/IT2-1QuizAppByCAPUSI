using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizAppDATAL;
using QuizAppMODEL;

namespace QuizAppBUSINESSL
{
    public class UserBusiness
    {
        public bool UserVerification(string username, string password)
        {
            UserData userData = new UserData();
            var result = userData.GetUser(username, password);

            return result.username != null ? true : false;
            return result.pass != null ? true : false;
        }
    }
}
