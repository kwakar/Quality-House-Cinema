using NUnit.Framework;
using QualityCinemaAccess.Repositories;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Admin.Reservations
{
    [TestFixture]
    [Author("Teodora Levkova")]
    class AdminEditReservationPageTests_Positive : BaseTest
    {
        private AdminEditReservationPage _adminEditReservationPage;
        private ReservationRepository _reservationRepository;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminEditReservationPage = new AdminEditReservationPage(Driver);
            _reservationRepository = new ReservationRepository();
        }

        [SetUp]
        public void SetUp()
        {
            _adminEditReservationPage.LoginAsAdmin();
            _adminEditReservationPage.CreateNewReservation(validUserId);
            _adminEditReservationPage.Navigate();
        }


        [TestCase(TestName = "Admin Edit Reservation - Edit reservation with valid data")]
        [Description("Update reservation with valid data")]
        public void UpdateReservationWithValidData()
        {
            _adminEditReservationPage.EditReservationWithValidData(validUserId);

            _adminEditReservationPage.SuccesfullReservatonEditAssertion();
        }

        [TestCase(TestName = "Admin Edit Reservation - Number of seats follow the 10 seats limit for a single reservation")]
        [Description("")]
        public void NumberOfSeatsDecreaseFollowingTheSeatsLimit()
        {
            _adminEditReservationPage.Navigate();
            _adminEditReservationPage.CheckNumberOfSeatsLeft(validUserId);

            _adminEditReservationPage.SeatsLeft_Assertion();
        }


        [TearDown]
        public void TearDown()
        {
            _reservationRepository.DeleteAllReservationsFromUserId(validUserId);
        }
    }

    [TestFixture]
    [Author("Teodora Levkova")]
    class AdminEditReservationPageTests_Negative : BaseTest
    {
        private AdminEditReservationPage _adminEditReservationPage;
        private ReservationRepository _reservationRepository;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminEditReservationPage = new AdminEditReservationPage(Driver);
            _reservationRepository = new ReservationRepository();
        }

        [SetUp]
        public void SetUp()
        {
            _adminEditReservationPage.LoginAsAdmin();
            _adminEditReservationPage.Navigate();
        }


        [TestCase(TestName = "Admin Edit Reservation - Try to edit reservation without selecting date")]
        [Description("Attempt to update reservation without selecting date throws pop-up error message")]
        public void NotSelectingDate_ThrowErrorMessage()
        {
            _adminEditReservationPage.CreateNewReservation(validUserId);
            _adminEditReservationPage.EditReservationWihoutSelectingDate(validUserId);

            _adminEditReservationPage.EditReservationWithoutDate_ThrowsErrorMessage_Assertion();
        }

        [TestCase(TestName = "Admin Edit Reservation - Try to edit reservation without selecting time")]
        [Description("Attempt to update reservation without selecting time throws pop-up error message")]
        public void NotSelectingTime_ThrowErrorMessage()
        {
            _adminEditReservationPage.CreateNewReservation(validUserId);
            _adminEditReservationPage.EditReservationWihoutSelectingTime(validUserId);

            _adminEditReservationPage.EditReservationWithoutDate_ThrowsErrorMessage_Assertion();
        }

        [TestCase(TestName = "Admin Edit Reservation - Try to edit reservation with exceeding number of seats")]
        [Description("Attempt to edit reservation with more seats than the available seats number of the screening")]
        public void EditWithMoreSeatsThanAvailable()
        {
            _adminEditReservationPage.CreateNewScreeningWith4Seats(validUserId);
            _adminEditReservationPage.CreateNewReservationWith2Seats(validUserId);
            _adminEditReservationPage.EditReservationSelecting3Seats(validUserId);

            _adminEditReservationPage.ExceedingNumberOfSeats_Assertion();
            _adminEditReservationPage.DeleteCreatedScreening();
        }



        [TearDown]
        public void TearDown()
        {
            _reservationRepository.DeleteAllReservationsFromUserId(validUserId);
        }
    }
}