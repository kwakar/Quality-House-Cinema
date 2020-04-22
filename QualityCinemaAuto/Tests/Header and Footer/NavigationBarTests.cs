using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.HeaderAndFooter
{
    [TestFixture]
    [Author("Teodora Levkova")]

    class NavigationBarTests : BaseTest
    {
        private NavigationBar _navigationBar;

        [SetUp]
        public void SetUp()
        {
            _navigationBar = new NavigationBar(Driver);
        }


        [TestCase(TestName = "Navigation Bar is visible on Home Page")]
        [Description("Asserts that navigation bar is visible on Home Page")]
        public void NavigationBarIsVisible_OnHomePage()
        {

            HomePage homePage = _navigationBar.On_HomePage();

            homePage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on On Screen Page")]
        [Description("Asserts that navigation bar is visible on On Screen Page")]
        public void NavigationBarIsVisible_OnOnScreenPage()
        {
            OnScreenPage onScreenPage = _navigationBar.On_OnScreenPage();

            onScreenPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Coming Soon Page")]
        [Description("Asserts that navigation bar is visible on Coming Soon Page")]
        public void NavigationBarIsVisible_OnComingSoon()
        {
            ComingSoonPage comingSoon = _navigationBar.On_ComingSoonPage();

            comingSoon.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on About Page")]
        [Description("Asserts that navigation bar is visible on About Page")]
        public void NavigationBarIsVisible_OnAboutPage()
        {
            AboutPage aboutPage = _navigationBar.On_AboutPage();

            aboutPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Contacts Page")]
        [Description("Asserts that navigation bar is visible on Contacts Page")]
        public void NavigationBarIsVisible_OnContactsPage()
        {
            ContactsPage contactsPage = _navigationBar.On_ContactPage();

            contactsPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Login Page")]
        [Description("Asserts that navigation bar is visible on Login Page")]
        public void NavigationBarIsVisible_OnLoginPage()
        {
            LoginPage loginPage = _navigationBar.On_LoginPage();

            loginPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Register Page")]
        [Description("Asserts that navigation bar is visible on Register Page")]
        public void NavigationBarIsVisible_OnRegisterPage()
        {
            RegistrationPage registrationPage = _navigationBar.On_RegisterPage();

            registrationPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Reservation Page")]
        [Description("Asserts that navigation bar is visible on Reservation Page")]
        public void NavigationBarIsVisible_OnReservationPage()
        {
            ReservationPage reservationPage = _navigationBar.On_ReservationPage();

            reservationPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Home Page")]
        [Description("Click on logo leads to Home Page")]
        public void Logo_LeadsToHomePage()
        {
            _navigationBar.On_HomePage();
            HomePage homePage = _navigationBar.ClickOnLogo();

            homePage.LogoRedirectionAssertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Admin Reservation Page")]
        [Description("Asserts that navigation bar is visible on Admin Reservation Page")]
        public void NavigationBarIsVisible_OnAdminReservationPage()
        {
            AdminReservationsPage adminReservationPage = _navigationBar.On_AdminReservationPage();

            adminReservationPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Admin Create Reservation Page")]
        [Description("Asserts that navigation bar is visible on Admin Create Reservation Page")]
        public void NavigationBarIsVisible_OnAdminCreateReservationPage()
        {
            AdminCreateReservationPage adminCreateReservationPage = _navigationBar.On_AdminCreateReservationPage();

            adminCreateReservationPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Admin Edit Reservation Page")]
        [Description("Asserts that navigation bar is visible on Admin Edit Reservation Page")]
        public void NavigationBarIsVisible_OnAdminEditReservationPage()
        {
            AdminEditReservationPage adminEditReservationPage = _navigationBar.On_AdminEditReservationPage();

            adminEditReservationPage.NavigationBarIsVisible_Assertion();
        }

        [TestCase(TestName = "Navigation Bar is visible on Admin Delete Reservation Page")]
        [Description("Asserts that navigation bar is visible on Admin Delete Reservation Page")]
        public void NavigationBarIsVisible_OnAdminDeleteReservationPage()
        {
            AdminDeleteReservationPage adminDeleteReservationPage = _navigationBar.On_AdminDeleteReservationPage();

            adminDeleteReservationPage.NavigationBarIsVisible_Assertion();
        }


        [TestCase(TestName = "Navigation Bar - On Screen Button redirection")]
        [Description("Click on On Screen button leads to corresponding page")]
        public void OnScreenButton_LeadsToCorrespondingPage()
        {
            _navigationBar.On_HomePage();
            OnScreenPage onScreenPage = _navigationBar.ClickOnOnScreenButton();

            onScreenPage.OnScreenRedirectionAssertion();
        }

        [TestCase(TestName = "Navigation Bar - Coming Soon Button redirection")]
        [Description("Click on Coming Soon button leads to the corresponding page")]
        public void ComingSoonButton_LeadsToCorrespondingPage()
        {
            _navigationBar.On_HomePage();
            ComingSoonPage comingSoonPage = _navigationBar.ClickOnComingSoonButton();

            comingSoonPage.ComingSoonRedirectionAssertion();
        }

        [TestCase(TestName = "Navigation Bar - About Button redirection")]
        [Description("Click on About button leads to the corresponding page")]
        public void AboutButton_LeadsToCorrespondingPage()
        {
            _navigationBar.On_HomePage();
            AboutPage aboutPage = _navigationBar.ClickOnAboutButton();

            aboutPage.AboutRedirectionAssertion();
        }

        [TestCase(TestName = "Navigation Bar - Contacts Button redirection")]
        [Description("Click on Contacts button leads to the corresponding page")]
        public void ContactsButton_LeadsToCorrespondingPage()
        {
            _navigationBar.On_HomePage();
            ContactsPage contactsPage = _navigationBar.ClickOnContactsButton();

            contactsPage.ContactsRedirectionAssertion();
        }

        [TestCase(TestName = "Navigation Bar - Contacts Button redirection")]
        [Description("Click on Login button leads to the corresponding page")]
        public void LoginButton_LeadsToCorrespondingPage()
        {
            _navigationBar.On_HomePage();
            LoginPage loginPage = _navigationBar.ClickOnLoginButton();

            loginPage.LoginRedirectionAssertion();
        }

        [TestCase(TestName = "Navigation Bar - Register Button redirection")]
        [Description("Click on Register button leads to the corresponding page")]
        public void RegisterButton_LeadsToCorrespondingPage()
        {
            _navigationBar.On_HomePage();
            RegistrationPage registrationPage = _navigationBar.ClickOnRegisterButton();

            registrationPage.RegisterRedirectionAssertion();
        }
    }
}