using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace QualityCinemaAuto
{
    public class LoginUserFactory
    {
        List<LoginUser> _users;
        int _currentUserIndex = 0;

        public LoginUserFactory()
        {
            var jsonUserData = File.ReadAllText(@"Factory\LoginUserFactory.json");
            _users = JsonConvert.DeserializeObject<List<LoginUser>>(jsonUserData);
        }

        //This method creates new user for every referring test
        //reading information from Json file
        private LoginUser GetUser()
        {
            var returnIndex = _currentUserIndex;
            _currentUserIndex++;

            if (_currentUserIndex >= _users.Count)
            {
                returnIndex = 0;
            }

            return new LoginUser(_users[returnIndex]);
        }

        //USER TYPES
        public LoginUser GetUserWithoutEmail()
        {
            var user = GetUser();
            user.Email = "";
            return user;
        }

        public LoginUser GetUserWithoutPassword()
        {
            var user = GetUser();
            user.Password = "";
            return user;
        }

        public LoginUser GetUserWithInvalidEmail()
        {
            var user = GetUser();
            user.Email = "123@123.123";
            return user;
        }

        public LoginUser GetUserWithInvalidEmailFormat()
        {
            var user = GetUser();
            user.Email = "test.test";
            return user;
        }

        public LoginUser GetUserWithInvalidPassword()
        {
            var user = GetUser();
            user.Password = "111";
            return user;
        }

        public static LoginUser GetStaticUser()
        {
            return new LoginUser
            {
                Email = "cinematest@abv.bg",
                Password = "Km6588316%",
                DisplayName = "Cinema Test"
            };
        }

        public static LoginUser GetAdminUser()
        {
            return new LoginUser
            {
                Email = "admin@qc.com",
                Password = "admin",
                DisplayName = "Admin"
            };
        }
    }
}