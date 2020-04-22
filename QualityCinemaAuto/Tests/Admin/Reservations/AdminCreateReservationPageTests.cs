using NUnit.Framework;
using QualityCinemaAccess.Repositories;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Admin.Reservations
{
    [TestFixture]
    [Author("Teodora Levkova")]
    class AdminCreateReservationPageTests_Positive : BaseTest
    {
        private AdminCreateReservationPage _adminCreateReservationPage;
        private ReservationRepository _reservationRepository;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _adminCreateReservationPage = new AdminCreateReservationPage(Driver);
            _reservationRepository = new ReservationRepository();
        }

        [SetUp]
        public void SetUp()
        {
            _adminCreateReservationPage.LoginAsAdmin();
            _adminCreateReservationPage.Navigate();
        }


        [TestCase(TestName = "Admin Create Reservation - Create new valid reservation")]
        [Description("Create reservation with valid data")]
        public void CreateValidReservation()
        {
            _adminCreateReservationPage.CreateValidReservation(validUserId);

            _adminCreateReservationPage.SuccesfullyCreatedReservationAssertion();
        }

        [TestCase(TestName = "Admin Create Reservation - Back to List button redirection")]
        [Description("Click on Back to list button redirects to Admin Reservations Page")]
        public void BackToListButton_RedirectsToCorrespondingPage()
        {
            AdminReservationsPage adminReservationPage = _adminCreateReservationPage.ClickOn_BackToListButton();

            adminReservationPage.AdminCreateReservationBackRedirection_Assertion();
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _reservationRepository.DeleteAllReservationsFromUserId(validUserId);
        }
    }


    [TestFixture]
    [Author("Teodora Levkova")]
    class AdminCreateReservationPageTests_Negative : BaseTest
    {
        private AdminCreateReservationPage _adminCreateReservationPage;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _adminCreateReservationPage = new AdminCreateReservationPage(Driver);
        }

        [SetUp]
        public void SetUp()
        {
            _adminCreateReservationPage.LoginAsAdmin();
            _adminCreateReservationPage.Navigate();
        }


        [TestCase(-1, TestName = "Admin Create Reservation - Try to create reservation with invalid User Id -1")]
        [TestCase(0, TestName = "Admin Create Reservation - Try to create reservation with invalid User Id 0")]
        [TestCase(+9999, TestName = "Admin Create Reservation - Try to create reservation with invalid User Id +9999")]
        [Description("Attempt to create new reservation with invalid User Id")]
        public void EnterInvalidUserId_ThrowsErrorMessage(int userId)
        {
            _adminCreateReservationPage.FillReservationFieldsWithInvalidUserId(userId);

            _adminCreateReservationPage.FailedReservationCreationAssertion();
        }

        [TestCase(-1, TestName = "Admin Create Reservation - Try to create reservation with invalid Screening Id -1")]
        [TestCase(0, TestName = "Admin Create Reservation - Try to create reservation with invalid Screening Id 0")]
        [TestCase(+9999, TestName = "Admin Create Reservation - Try to create reservation with invalid Screening Id +9999")]
        [Description("Attempt to create new reservation with invalid Screening Id")]
        public void EnterInvalidScreeningId_ThrowsErrorMessage(int screeningId)
        {
            _adminCreateReservationPage.FillReservationFieldsWithInvalidScreeningId(validUserId, screeningId);

            _adminCreateReservationPage.FailedReservationCreationAssertion();
        }

        [TestCase(11, TestName = "Admin Create Reservation - Try to create reservation with 11 seats")]
        [TestCase(-1, TestName = "Admin Create Reservation - Try to create reservation with -1 seats")]
        [TestCase(0, TestName = "Admin Create Reservation - Try to create reservation with 0 seats")]
        [TestCase(+9999, TestName = "Admin Create Reservation - Try to create reservation with +9999 seats")]
        [Description("Attempt to create new reservation with invalid number of seats (maximum 10 allowed for a single user reservation)")]
        public void EnterInvalidSeatsNumber_ThrowsErrorMessage(int seats)
        {
            _adminCreateReservationPage.FillReservationFieldsWithInvalidSeatsNumber(validUserId, seats);

            _adminCreateReservationPage.InvalidNumberOfSeatsAssertion();
        }
    }
}