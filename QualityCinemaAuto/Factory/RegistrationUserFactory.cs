using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QualityCinemaAuto
{
    public class RegistrationUserFactory
    {
        List<RegistrationUser> _users;
        int _currentUserIndex = 0;


        public RegistrationUserFactory()
        {
            var jsonUserData = File.ReadAllText(@"Factory\RegistrationUserFactory.json");
            _users = JsonConvert.DeserializeObject<List<RegistrationUser>>(jsonUserData);
        }

        //This method creates new user for every referring test
        //reading information from Json file
        private RegistrationUser GetUser()
        {
            var returnIndex = _currentUserIndex;
            _currentUserIndex++;

            if (_currentUserIndex >= _users.Count)
            {
                returnIndex = 0;
            }

            return new RegistrationUser(_users[returnIndex]);
        }

        //This method creates randomizing email data
        public static string GenerateMailTemplate()
        {
            return $"{Guid.NewGuid().ToString().Substring(0, 8)}@test123.com";
        }


        //USER TYPES
        //TODO: Create all user types        
        public RegistrationUser GetValidUser()
        {
            var user = GetUser();
            user.Email = GenerateMailTemplate();
            return user;
        }

        public RegistrationUser GetValidUserWith64DisplayName()
        {
            var user = GetUser();
            user.Email = GenerateMailTemplate();
            user.DisplayName = "IvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvay";
            return user;
        }

        public RegistrationUser GetValidUserWith65DisplayName(string displayName)
        {
            var user = GetUser();
            user.DisplayName = "IvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayl";
            return user;
        }
        public RegistrationUser GetValidUserWith3DisplayName()
        {
            var user = GetUser();
            user.Email = GenerateMailTemplate();
            user.DisplayName = "Top";
            return user;
        }
        public RegistrationUser GetValidUserWith33Password(string Password)
        {
            var user = GetUser();
            user.Password = "Abcd123fG!Abcd123fGAbcd123fGAbcd123fGAbcd123fG!";
            return user;
        }

        public RegistrationUser GetValidUserWith32Password()
        {
            var user = GetUser();
            user.Email = GenerateMailTemplate();
            user.Password = user.ConfirmPassword = "Abcd123Abcd123Abcd123Abcd123Abc!";
            return user;
        }


        public RegistrationUser GetValidUserWith8Password()
        {
            var user = GetUser();
            user.Email = GenerateMailTemplate();
            user.Password = user.ConfirmPassword = "Abcd123&";
            return user;
        }

        public RegistrationUser GetValidUserWith7Password(string passWord)
        { 


            var user = GetUser();
            user.Password = user.ConfirmPassword = "Lp70572";
            return user;
        }

        public RegistrationUser GetValidUserWithoutSpecialsymbolPassword(string Password)
        {
            var user = GetUser();
            user.Password = user.ConfirmPassword = "7057261!";
            return user;
        }

        public RegistrationUser GetValidUserWithoutLowercasePassword(string passWord)
        {
            var user = GetUser();
            user.Password = "Abcd123fG";
            return user;
        }

        public RegistrationUser GetInvalidUserWithoutPassword()
        {
            var user = GetUser();
            user.Password = "";
            return user;
        }

        public RegistrationUser GetInvalidUserWithoutConfirmPassword()
        {
            var user = GetUser();
            user.ConfirmPassword = "";
            return user;
        }
        public RegistrationUser GetInvalidUserWithoutPasswordandConfPassword()
        {
            var user = GetUser();
            user.Password = user.ConfirmPassword = "";
            return user;
        }

        public RegistrationUser GetInvalidUserWithoutUppercasePassword(string passWord)
        {
            var user = GetUser();
            user.Password = user.ConfirmPassword = "lp7057261!";
            return user;
        }


        public RegistrationUser GetValidUserWithMissmatchpasswordandconfpassword()
        {
            var user = GetUser();
            user.Password = "Lp7057261!"; 
            user.ConfirmPassword = "Lp7057266!";
            return user;
        }
        public RegistrationUser GetUserWithoutEmail()
        {
            var user = GetUser();
            user.Email = "";
            return user;
        }

        public RegistrationUser GetUserWithoutatEmail()
        {
            var user = GetUser();
            user.Email = "inikolovqualirin.com";
            return user;
        }

        public RegistrationUser GetUserWitShortDisplayName(string displayName)
        {
            var user = GetUser();
            user.DisplayName = "Iv";
            return user;
        }

        public RegistrationUser GetUserWithoutDisplayName(string displayName)
        {
            var user = GetUser();
            user.DisplayName = "";
            return user;
        }

        public RegistrationUser GetUserWithoutYearofBirth()
        {
            var user = GetUser();
            user.YearofBirth = "Select your birth year";
            return user;
        }


        public static RegistrationUser GetStaticUser()
        {
            return new RegistrationUser
            {
                Email = "inikolov@qualityhouse.com",
                Password = "Lp7057261!",
                ConfirmPassword = "Lp7057261!",
                DisplayName = "Ivo",
                YearofBirth = "1995",
            };
        }
    }
}