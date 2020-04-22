using NUnit.Framework;
using QualityCinemaAuto.Pages;


namespace QualityCinemaAuto.Tests.Admin.Reservations
{
    [TestFixture]
    [Author("Teodora Levkova")]

    class AdminReservationsPageTests : BaseTest
    {
        private AdminReservationsPage _adminReservationsPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminReservationsPage = new AdminReservationsPage(Driver);
        }

        [SetUp]
        public void SetUp()
        {
            _adminReservationsPage.Navigate();
        }


        [TestCase(TestName = "Admin Reservation Page - Page elements are visible")]
        [Description("Create reservation link redirects to the corresponding page")]
        public void PageElementsAreVisible()
        {
            _adminReservationsPage.AdminReservationPageElements_Assertion();
        }

        [TestCase(TestName = "Admin Reservation Page - Create New link redirection")]
        [Description("Create reservation link redirects to the corresponding page")]
        public void CreateNewLink_RedirectsToCorrespondingPage()
        {
            AdminCreateReservationPage adminCreateReservationPage = _adminReservationsPage.ClickOn_CreateLink();

            adminCreateReservationPage.AdminCreateReservationRedirectionAssertion();
        }

        [TestCase(TestName = "Admin Reservation Page - Edit button redirection")]
        [Description("Edit reservation button redirects to the corresponding page")]
        public void EditButton_RedirectsToCorrespondingPage()
        {
            AdminEditReservationPage adminEditReservationPage = _adminReservationsPage.ClickOn_EditButton();

            adminEditReservationPage.EditReservationRedirectionAssertion();
        }

        [TestCase(TestName = "Admin Reservation Page - Delete button redirection")]
        [Description("Delete reservation button redirects to the corresponding page")]
        public void DeleteButton_RedirectsToCorrespondingPage()
        {
            AdminDeleteReservationPage adminDeleteReservationPage = _adminReservationsPage.ClickOn_DeleteButton();

            adminDeleteReservationPage.EditReservationRedirectionAssertion();
        }
    }
}