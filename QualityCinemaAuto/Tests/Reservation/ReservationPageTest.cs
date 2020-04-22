using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Reservation
{
    [TestFixture]
    [Author("Ivaylo Nikolov")]

    class ReservationPageTest_Positive : BaseTest
    {
        private ReservationPage _reservationPage;

        [SetUp]
        public void SetUp()
        {
            _reservationPage = new ReservationPage(Driver);
        }


        [TestCase(TestName = "Reservation - Text for unregistered user popup is correct")]
        [Description("Assert all text in popup is correct")]
        public void ReservationHeader()
        {
            _reservationPage.Navigate();
            _reservationPage.ClickOnReserve();
            _reservationPage.AssertErrorMessagePopIn("Login required");
            _reservationPage.AssertErrorMessagePopInText("To books seets you need to be logged in. Please login or register.");
        }

        [TestCase(TestName = "Reservation - Text in buttons for unregistered user popup is correct")]
        [Description("Assert all text in popup buttons are correct")]
        public void AssertErrorMessageforTwoButton()
        {
            _reservationPage.Navigate();
            _reservationPage.ClickOnReserve();
            _reservationPage.AssertErrorMessageTwoButton("Login" + "Register");
        }

        [TestCase(TestName = "Reservation - Register Page redirection")]
        [Description("Assert redirect to Register Page")]
        public void ReservationRegRedir()
        {
            _reservationPage.Navigate();
            _reservationPage.ClickOnReserve();
            ReservationPage reservationPage = _reservationPage.NavigateToRegisterPage();
            reservationPage.AssertErrorMessageRedirect("Register");
        }

        [TestCase(TestName = "Reservation - Login Page redirection")]
        [Description("Assert redirect to Login")]
        public void ReservationLoginRedir()
        {
            _reservationPage.Navigate();
            _reservationPage.ClickOnReserve();
            ReservationPage reservationPage = _reservationPage.NavigateToLoginPage();
            reservationPage.AssertErrorMessageRedirectLog("Login");
        }

        [TestCase(TestName = "Reservation - Movie Trailer is available")]
        [Description("Movie trailer is available under Reserve button")]
        public void MovieTrailerIsAvailable()
        {
            _reservationPage.Navigate();
            _reservationPage.ClickOnReservefor();

            _reservationPage.TrailerAvailabiltiy_Assertion();
        }

        [TestCase(TestName = "Reservation - Movie Trailer is played")]
        [Description("Movie trailer is played after click on Play button")]
        public void MovieTrailerIsPlayed()
        {
            _reservationPage.Navigate();
            _reservationPage.ClickOnReservefor();
            _reservationPage.PlayTrailerVideo();

            _reservationPage.TrailerIsPlayed_Assertion();
        }
    }


    [TestFixture]
    [Author("Ivaylo Nikolov")]

    class ReservationPageTest_Negative : BaseTest
    {
        private ReservationPage _reservationPage;

        [SetUp]
        public void SetUp()
        {
            _reservationPage = new ReservationPage(Driver);
        }


        [TestCase(TestName = "Reservation - Text for unregistered user popup is visible")]
        [Description("Assert all text in popup is correct")]
        public void ReservationPressReserve()
        {
            _reservationPage.Navigate();
            _reservationPage.ClickOnReservewithout();
            _reservationPage.AssertErrorMessagePopInText("To books seets you need to be logged in. Please login or register.");
        }
    }
}