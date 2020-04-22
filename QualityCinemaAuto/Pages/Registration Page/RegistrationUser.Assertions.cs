using NUnit.Framework;
using QualityCinemaAccess.Repositories;
using System;

namespace QualityCinemaAuto.Pages
{
    [Author("Ivaylo Nikolov")]
    public partial class RegistrationPage
    {
        public void AssertErrorMessage(string expected)
        {
            Assert.AreEqual(expected, ErrorMessageEmail.Text);
        }
        public void AssertErrorWrongMessage(string expected)
        {
            Assert.AreEqual(expected, ErrorMessageWrongEmail.Text);
        }

        public void AssertErrorMessagePass(string expected)
        {
            Assert.AreEqual(expected, ErrorMessagePass.Text);

        }
        public void AssertErrorMessagePassSpecSym(string expected)
        {
            Assert.AreEqual(expected, ErrorMessagePasswithoutspec.Text);

        }
        public void AssertErrorMessagePassConf(string expected)
        {
            Assert.AreEqual(expected, ErrorMessagePassConf.Text);

        }
        public void AssertErrorMessageCPass(string expected)
        {
            Assert.AreEqual(expected, ErrorMessageConfPass.Text);
        }
        public void AssertErrorMessageName(string expected)
        {
            Assert.AreEqual(expected, ErrorMessageDisName.Text);
        }
        public void AssertErrorMessageName65(string expected)
        {
            Assert.AreEqual(expected, ErrorMessageDisName65.Text);
        }
        public void AssertErrorMessageYear(string expected)
        {
            Assert.AreEqual(expected, ErrorMessagebirthYear.Text);
        }

        public void AssertErrorMessageExistUser(string expected)
        {

            Assert.AreEqual(expected, ErrorMessageExistUser.Text);
        }

        public void AssertErrorMessageCreateUser(string expected)
        {
            Assert.AreEqual(expected, ErrorMessageCreateUsern.Text);
        }
        public void AssertIsUserInDatabase32password(string user)
        {
            var userRepository = new UserRepository();
            var nullAssert = userRepository.GetUserByPassword(user);
            Assert.IsNotNull(nullAssert);
        }

        public void AssertIsUserInDatabase64Displayname(string user)
        {
            var userRepository = new UserRepository();
            var nullAssert = userRepository.GetUserByUserEmail(user);
            Assert.IsNotNull(nullAssert);
        }

        public void AssertErrorMessagePass32anConf(string expected)
        {
            Assert.AreEqual(expected, expected, ErrorMessagePasswithoutspec.Text, ErrorMessagePassConf.Text);
           
            
        }
        public void AssertIsUserInDatabase8password(string user)
        {
            var userRepository = new UserRepository();
            var nullAssert = userRepository.GetUserByPassword(user);
            Assert.IsNotNull(nullAssert);
        }

        public void AssertErrorMessagePassdiffConf(string expected)
        {
            Assert.AreEqual(expected, expected, ErrorMessagePass.Text, ErrorMessagePassConf.Text);


        }

        public void AssertIsUserInDatabase(Int16 Year)
        {
            var userRepository = new UserRepository();
            var nullAssert = userRepository.GetUserByYearOfBirth(Year);
            Assert.IsNotNull(nullAssert);
        }

        public void AssertIsUserInDatabaseDisplayname(string user)
        {
            var userRepository = new UserRepository();
            var nullAssert = userRepository.GetUserByUserEmail(user);
            Assert.IsNotNull(nullAssert);
        }

        public void AssertErrorMessagePassandConf(string expected)
        {
           
            Assert.AreEqual(expected,expected, ErrorMessagePass.Text, ErrorMessageConfPass.Text);
           
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void RegisterRedirectionAssertion()
        {
            RegisterButtonOnNavigationBar.Click();
            StringAssert.Contains("Sign Up - Quality Cinema", RegisterPageTitle);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }
    }
}
