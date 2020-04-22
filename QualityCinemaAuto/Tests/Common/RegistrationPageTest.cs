using NUnit.Framework;
using QualityCinemaAuto.Pages;
using QualityCinemaAccess.Repositories;
using QualityCinemaAccess.Entities;
using QualityCinemaAccess.Context;
using System.Linq;
using System;

namespace QualityCinemaAuto.Tests.Common
{
    [TestFixture]
    [Author("Ivaylo Nikolov")]

    class RegistrationPageTests_Positive : BaseTest
    {
        private RegistrationPage _registrationPage;
        private RegistrationUserFactory _userFactory;

        private UserRepository _userRepository;

        [OneTimeSetUp]

        public void OneTimeSetUp()
        {
            _registrationPage = new RegistrationPage(Driver);
            _userFactory = new RegistrationUserFactory();
            _userRepository = new UserRepository();
        }


        [TestCase(TestName = "Register - Labels and placeholders are correct")]
        [Description("Assert all placeholders and labels are correct")]
        public void RegPages()
        {
            _registrationPage.Navigate();
            _registrationPage.Watch();
            _registrationPage.Register1();
        }

        [TestCase(TestName = "Register with 3-character display name")]
        [Description("Assert successful registration with 3letters displayname")]
        public void Registrationwith3letter()
        {

            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUserWith3DisplayName());
            _registrationPage.AssertErrorMessageCreateUser("Your registration is successful.");
            _registrationPage.AssertIsUserInDatabaseDisplayname("Top");
        }

        [TestCase(TestName = "Register with 8-character password")]
        [Description("Assert successful registration with same pass and confpass-Abcd123&")]
        public void Registrationwithpassword8()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUserWith8Password());
            _registrationPage.AssertErrorMessageCreateUser("Your registration is successful.");
            _registrationPage.AssertIsUserInDatabase8password("Abcd123&");
        }

        [TestCase(TestName = "Register with 32-character password")]
        [Description("Assert successful registration with same pass and confpass -Abcd123Abcd123Abcd123Abcd123Abc!")]
        public void Registrationwithpassword32()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUserWith32Password());
            _registrationPage.AssertErrorMessageCreateUser("Your registration is successful.");
            _registrationPage.AssertIsUserInDatabase32password("Abcd123Abcd123Abcd123Abcd123Abc!");
        }

        [TestCase(TestName = "Register with 64-character display name")]
        [Description("Assert successful registration with 64 letters displayname")]
        public void RegistrationwithDisplayName64()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUserWith64DisplayName());
            _registrationPage.AssertErrorMessageCreateUser("Your registration is successful.");
            _registrationPage.AssertIsUserInDatabase64Displayname("IvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvay");
        }

        [TestCase(TestName = "Register with valid credentials")]
        [Description("Assert successful registration")]
        public void SuccessfulReg()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUser());
            _registrationPage.AssertErrorMessageCreateUser("Your registration is successful.");
            _registrationPage.AssertIsUserInDatabase(Int16.Parse("1994"));
        }
    }


    [TestFixture]
    [Author("Ivaylo Nikolov")]

    class RegistrationPageTests_Negative : BaseTest
    {
        private RegistrationPage _registrationPage;
        private RegistrationUserFactory _userFactory;
        RegistrationUser _staticUser;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _registrationPage = new RegistrationPage(Driver);
            _userFactory = new RegistrationUserFactory();
        }

        [SetUp]
        public void SetUp()
        {
            _staticUser = RegistrationUserFactory.GetStaticUser();
        }

        [TestCase(TestName = "Register - try to register with invalid email format"), Order(16)]
        [Description("Assert registration without @ in Email")]
        public void Registrationwithoutemail1()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetUserWithoutatEmail());
            _registrationPage.AssertErrorWrongMessage("Wrong email format");
        }

        [TestCase(TestName = "Register - try to register with blank confirm password"), Order(2)]
        [Description("Assert registration without Confirmpassword")]
        public void RegistrationwithoutConfpassword()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetInvalidUserWithoutConfirmPassword());
            _registrationPage.AssertErrorMessageCPass("Confirm password filed is required");
        }

        [TestCase(TestName = "Register - try to register with blank password and confirm password"), Order(3)]
        [Description("Assert registration without Password and Confirmpassword")]
        public void RegistrationwithoutConfandpassword()
        {

            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetInvalidUserWithoutPasswordandConfPassword());
            _registrationPage.AssertErrorMessagePassandConf("Password field is required"+ "Confirm password filed is required");
        }

        [TestCase(TestName = "Register - try to register with blank password"), Order(4)]
        [Description("Assert registration without Password")]
        public void Registrationwithoutpassword()
        {

            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetInvalidUserWithoutPassword());
            _registrationPage.AssertErrorMessagePassdiffConf("Password field is required" + "Passwords don't match");
        }

        [TestCase("Lp70572", TestName = "Register - try to register with 7-character password and confirm password"), Order(5)]
        [TestCase("Abcd123fG", TestName = "Register - try to register without lowercase letter in password and confirm password"),]
        [TestCase("lp7057261!", TestName = "Register - try to register without special symbol in password and confirm password"), ]
        [Description("Assert registration without specialsymbol in pass and confirmpassword")]
        public void RegistrationwithpasswordnoUpperletter(string passWord)
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetInvalidUserWithoutUppercasePassword(passWord));
            _registrationPage.AssertErrorMessagePassSpecSym("Password should be between 8 and 32 characters and should consist of at least one uppercase letter, one lowercase letter, one numeric character and one special symbol");
        }

        [TestCase(TestName = "Register - try to register with mismatching password and confirm password"), Order(8)]
        [Description("Assert registration with different password and confirmpassword")]
        public void RegistrationwithdiffpasswordandConfpass()
        {

            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUserWithMissmatchpasswordandconfpassword());
            _registrationPage.AssertErrorMessagePassConf("Passwords don't match");
        }
        [TestCase("Abcd123fG!Abcd123fGAbcd123fGAbcd123fGAbcd123fG!", TestName = "Register - try to register with 33-character password"), Order(10)]
        [TestCase("7057261!", TestName = "Register - try to register without special symbol in password"),]
        [Description("Assert registration without specialsymbol, with 33symbols in password")]
        public void Registrationwithoutpasswordspecialsymbol(string Password)
        {

            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUserWithoutSpecialsymbolPassword(Password));
            _registrationPage.AssertErrorMessagePass32anConf("Password should be between 8 and 32 characters and should consist of at least one uppercase letter, one lowercase letter, one numeric character and one special symbol" + "Passwords don't match");
        }

        [TestCase("IvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayloIvayl",TestName = "Register - try to register with 65-letter display name")]
        [TestCase("iv", TestName = "Register - try to register with 2-letter display name")]
        [TestCase("",TestName = "Register - try to register with blank display name")]
        [Description("Assert registration with 65 letters displayname")]
        public void Registrationwithoutname(string displayName)
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetValidUserWith65DisplayName(displayName));
            _registrationPage.AssertErrorMessageName65("Display name should be between 3 and 64 characters. At least one letter required, numbers and spaces allowed.");
        }

       
        [TestCase(TestName = "Register - try to register with blank email"), Order(14)]
        [Description("Assert registration without Email")]
        public void Registrationwithoutemail()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetUserWithoutEmail());
            _registrationPage.AssertErrorMessage("Email field is required");
        }

        [TestCase(TestName = "Register - try to register without birth year"), Order(13)]
        [Description("Assert registration without birth Year")]
        public void RegistrationwithoutYear()
        {

            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_userFactory.GetUserWithoutYearofBirth());
            _registrationPage.AssertErrorMessageYear("Year of birth is required");
        }

        [TestCase(TestName = "Register - try to register with already registered user"), Order(1)]
        [Description("Assert registration with existsEmail")]
        public void ExistsUser()
        {
            _registrationPage.Navigate();
            _registrationPage.FillRegistrationForm(_staticUser);
            _registrationPage.AssertErrorMessageExistUser("Error! User with this email already exists");
        }
    }
}