using QualityCinemaAuto.Pages;


namespace QualityCinemaAuto
{
    public partial class Footer
    {

        public HomePage On_HomePage()
        {
            _driver.Url = "http://192.168.5.86:8080";
            return new HomePage(_driver);
        }

        public OnScreenPage On_OnScreenPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Movies/OnScreen";
            return new OnScreenPage(_driver);
        }

        public ComingSoonPage On_ComingSoonPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Movies/ComingSoon";
            return new ComingSoonPage(_driver);
        }

        public AboutPage On_AboutPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Home/About";
            return new AboutPage(_driver);
        }

        public ContactsPage On_ContactPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Home/About";
            return new ContactsPage(_driver);
        }

        public LoginPage On_LoginPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Account/Login";
            return new LoginPage(_driver);
        }

        public RegistrationPage On_RegisterPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Account/SignUp";
            return new RegistrationPage(_driver);
        }

        public ReservationPage On_ReservationPage()
        {
            _driver.Url = "http://192.168.5.86:8080";
            MovieWatchButton.Click();
            return new ReservationPage(_driver);
        }

        public AdminReservationsPage On_AdminReservationPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Reservations";
            return new AdminReservationsPage(_driver);
        }

        public AdminCreateReservationPage On_AdminCreateReservationPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Reservations/Create";
            return new AdminCreateReservationPage(_driver);
        }

        public AdminEditReservationPage On_AdminEditReservationPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Reservations";
            EditReservationButton.Click();
            return new AdminEditReservationPage(_driver);
        }

        public AdminDeleteReservationPage On_AdminDeleteReservationPage()
        {
            _driver.Url = "http://192.168.5.86:8080/Reservations";
            DeleteReservationButton.Click();
            return new AdminDeleteReservationPage(_driver);
        }
    }
}