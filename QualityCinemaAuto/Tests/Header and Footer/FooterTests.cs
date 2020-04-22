using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.HeaderAndFooter
{
    [TestFixture]
    [Author("Teodora Levkova")]

    class FooterTests : BaseTest
    {
        private Footer _footer;

        [SetUp]
        public void SetUp()
        {
            _footer = new Footer(Driver);
        }


        [TestCase(TestName = "Footer is visible on Home Page")]
        [Description("Asserts that the footer is visible on Home Page")]
        public void FooterIsVisible_OnHomePage()
        {
            HomePage homePage = _footer.On_HomePage();

            homePage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Screen Page")]
        [Description("Asserts that the footer is visible on On Screen Page")]
        public void FooterIsVisible_OnScreenPage()
        {
            OnScreenPage onScreenPage = _footer.On_OnScreenPage();

            onScreenPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Coming Soon Page")]
        [Description("Asserts that the footer is visible on Coming Soon Page")]
        public void FooterIsVisible_OnComingSoon()
        {
            ComingSoonPage comingSoonoPage = _footer.On_ComingSoonPage();

            comingSoonoPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on About Page")]
        [Description("Asserts that the footer is visible on About Page")]
        public void FooterIsVisible_OnAboutPage()
        {
            AboutPage aboutPage = _footer.On_AboutPage();

            aboutPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Contacts Page")]
        [Description("Asserts that the footer is visible on Contacts Page")]
        public void FooterIsVisible_OnContactsPage()
        {
            ContactsPage contactsPage = _footer.On_ContactPage();

            contactsPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Login Page")]
        [Description("Asserts that the footer is visible on Login Page")]
        public void FooterIsVisible_OnLoginPage()
        {
            LoginPage loginPage = _footer.On_LoginPage();

            loginPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Register Page")]
        [Description("Asserts that the footer is visible on Register Page")]
        public void FooterIsVisible_OnRegisterPage()
        {
            RegistrationPage registerrationPage = _footer.On_RegisterPage();

            registerrationPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Reservation Page")]
        [Description("Asserts that the footer is visible on Reservation Page")]
        public void FooterIsVisible_OnReservationPage()
        {
            ReservationPage reservationPage = _footer.On_ReservationPage();

            reservationPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Admin Reservation Page")]
        [Description("Asserts that the footer is visible on Admin Reservation Page")]
        public void FooterIsVisible_OnAdminReservationPage()
        {
            AdminReservationsPage adminReservationPage = _footer.On_AdminReservationPage();

            adminReservationPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Admin Create Reservation Page")]
        [Description("Asserts that the footer is visible on Admin Create Reservation Page")]
        public void FooterIsVisible_OnAdminCreateReservationPage()
        {
            AdminCreateReservationPage adminCreateReservationPage = _footer.On_AdminCreateReservationPage();

            adminCreateReservationPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Admin Edit Reservation Page")]
        [Description("Asserts that the footer is visible on Admin Edit Reservation Page")]
        public void FooterIsVisible_OnAdminEditReservationPage()
        {
            AdminEditReservationPage adminCreateReservationPage = _footer.On_AdminEditReservationPage();

            adminCreateReservationPage.FooterIsVisible_Assertion();
        }

        [TestCase(TestName = "Footer is visible on Admin Delete Reservation Page")]
        [Description("Asserts that the footer is visible on Admin Delete Reservation Page")]
        public void FooterIsVisible_OnAdminDeleteReservationPage()
        {
            AdminDeleteReservationPage adminDeleteReservationPage = _footer.On_AdminDeleteReservationPage();

            adminDeleteReservationPage.FooterIsVisible_Assertion();
        }
    }
}