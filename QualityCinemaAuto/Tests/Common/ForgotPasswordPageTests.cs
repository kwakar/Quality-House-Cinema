using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Common
{
    [TestFixture]
    [Author("Teodora Levkova")]

    class ForgotPasswordPageTests_Positive : BaseTest
    {
        private ForgotPasswordPage _forgotPasswordPage;

        [SetUp]
        public void Setup()
        {
            _forgotPasswordPage = new ForgotPasswordPage(Driver);
        }


        [TestCase(TestName = "Forgot Password - Enter valid email")]
        [Description("Entering valid email returns confirmation message")]
        public void EnterValidEmail_ReturnsConfirmationMessage()
        {
            _forgotPasswordPage.Navigate();
            _forgotPasswordPage.EnterEmail("tlevkova@qualityhouse.com");

            _forgotPasswordPage.ResetPasswordEmailAssertion();
        }
    }


    [TestFixture]
    [Author("Teodora Levkova")]

    class ForgotPasswordPageTests_Negative : BaseTest
    {
        private ForgotPasswordPage _forgotPasswordPage;

        [SetUp]
        public void Setup()
        {
            _forgotPasswordPage = new ForgotPasswordPage(Driver);
        }


        [TestCase(TestName = "Forgot Password - Enter invalid email")]
        [Description("Entering invalid email returns confirmation message")]
        //For security reasons entering invalid email returns confirmation message
        //that password has been reset successfully.
        public void EnterInvalidEmail_ReturnsConfirmationMessage()
        {
            _forgotPasswordPage.Navigate();
            _forgotPasswordPage.EnterEmail("hello@hello.com");

            _forgotPasswordPage.ResetPasswordEmailAssertion();
        }

        [TestCase(TestName = "Forgot Password - Enter blank email")]
        [Description("Entering blank email returns error message")]
        public void EnterBlankEmail_ThrowsErrorMessage()
        {
            _forgotPasswordPage.Navigate();
            _forgotPasswordPage.EnterEmail("");

            _forgotPasswordPage.ResetPasswordErrorMessageAssertion();
        }

        [TestCase(TestName = "Forgot Password - Enter invalid email format")]
        [Description("Entering invalid email format returns error message")]
        public void EntereInvalidEmailFormat_ThrowsErrorMessage()
        {
            _forgotPasswordPage.Navigate();
            _forgotPasswordPage.EnterEmail("test.test");

            _forgotPasswordPage.ResetPasswordErrorMessageAssertion();
        }
    }
}