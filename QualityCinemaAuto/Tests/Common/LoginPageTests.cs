using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Common
{
    [TestFixture]
    [Author("Teodora Levkova")]

    class LoginPageTests_Positive : BaseTest
    {
        private LoginPage _loginPage;
        private LoginUserFactory _userFactory;
        private LoginUser _staticUser;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _loginPage = new LoginPage(Driver);
            _userFactory = new LoginUserFactory();
        }

        [SetUp]
        public void SetUp()
        {
            _staticUser = LoginUserFactory.GetStaticUser();
        }


        [TestCase(TestName = "Forgot Password hyperlink is available")]
        [Description("Forgot password hyperlink is visible on Login Page")]
        public void ForgotPasswordHyperlink_IsAvailable()
        {
            _loginPage.Navigate();

            _loginPage.ForgotPasswordHyperlinkIsVisibleAssert();
        }

        [TestCase(TestName = "Forgot Password hyperlink redirection")]
        [Description("Forgot password hyperlink redirects to the corresponding page")]
        public void ForgotPasswordHyperlink_RedirectsToCorrespondingPage()
        {
            _loginPage.Navigate();
            ForgotPasswordPage forgotPasswordPage = _loginPage.NavigateToForgotPasswordPage();

            forgotPasswordPage.ForgotPasswordPageAvailabilityAssertion();
        }

        [TestCase(TestName = "Login - hidden characters in password field")]
        [Description("Characters in the password field are hidden with dots")]
        public void CharactersInPasswordFieldAreHidden()
        {
            _loginPage.Navigate();

            _loginPage.PasswordHiddenCharactersAssert();
        }

        [TestCase(TestName = "Login with valid credentials")]
        [Description("User is able to login with valid credentials")]
        public void LoginValidCredentials()
        {
            _loginPage.Navigate();
            _loginPage.FillLoginForm(_staticUser);
            HomePage homePage = _loginPage.ClickOnLoginButton();

            homePage.LoginPageAssertion($"Hello, {_staticUser.DisplayName}");
        }
    }


    [TestFixture]
    [Author("Teodora Levkova")]

    class LoginPageTests_Negative : BaseTest
    {
        private LoginPage _loginPage;
        private LoginUserFactory _userFactory;
        private LoginUser _staticUser;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _loginPage = new LoginPage(Driver);
            _userFactory = new LoginUserFactory();
        }

        [SetUp]
        public void SetUp()
        {
            _staticUser = LoginUserFactory.GetStaticUser();
        }


        [TestCase(TestName = "Login - try to login with blank email")]
        [Description("Attempt to login with blank email returns error message")]
        public void LoginWithBlankEmail_ReturnsErrorMessage()
        {
            _loginPage.Navigate();
            _loginPage.FillLoginFormAndClickLoginButton(_userFactory.GetUserWithoutEmail());

            _loginPage.ErrorMessageAssertion();
        }

        [TestCase(TestName = "Login - try to login with blank password")]
        [Description("Attempt to login with blank password returns error message")]
        public void LoginWithBlankPassword_ReturnsErrorMessage()
        {
            _loginPage.Navigate();
            _loginPage.FillLoginFormAndClickLoginButton(_userFactory.GetUserWithoutPassword());

            _loginPage.ErrorMessageAssertion();
        }

        [TestCase(TestName = "Login - try to login with invalid email")]
        [Description("Attempt to login with invalid email returns error message")]
        public void LoginWithInvalidEmail_ReturnsErrorMessage()
        {
            _loginPage.Navigate();
            _loginPage.FillLoginFormAndClickLoginButton(_userFactory.GetUserWithInvalidEmail());

            _loginPage.ErrorMessageAssertion();
        }

        [TestCase(TestName = "Login - try to login with invalid email format")]
        [Description("Attempt to login with invalid email format is blocked from field validation")]
        public void LoginWithInvalidEmailFormat_BlockedFromFieldValidation()
        {
            _loginPage.Navigate();
            _loginPage.FillLoginFormAndClickLoginButton(_userFactory.GetUserWithInvalidEmailFormat());

            _loginPage.WrongEmailFormatAssertion();
        }

        [TestCase(TestName = "Login - try to login with invalid password")]
        [Description("Attempt to login with invalid password returns error message")]
        public void LoginWithInvalidPassword_ReturnsErrorMessage()
        {
            _loginPage.Navigate();
            _loginPage.FillLoginFormAndClickLoginButton(_userFactory.GetUserWithInvalidPassword());

            _loginPage.ErrorMessageAssertion();
        }


       

    }
}