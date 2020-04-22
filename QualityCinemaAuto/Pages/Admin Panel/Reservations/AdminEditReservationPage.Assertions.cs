using NUnit.Framework;
using QualityCinemaAccess.Repositories;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminEditReservationPage
    {
        private ReservationRepository reservationRepository = new ReservationRepository();


        public void EditReservationRedirectionAssertion()
        {
            StringAssert.Contains("Edit - Quality Cinema", EditReservationPageTitile);
        }

        public void SuccesfullReservatonEditAssertion()
        {
            StringAssert.Contains("Reservations", AdminReservationsPageTitle.Text);
        }

        public void EditReservationWithoutDate_ThrowsErrorMessage_Assertion()
        {
            Assert.True(ErrorMessagePopUp.Displayed);
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }

        public void SeatsLeft_Assertion()
        {
            Assert.AreEqual(8, _seatsLeft);
        }

        public void ExceedingNumberOfSeats_Assertion()
        {
            Assert.True(ErrorMessagePopUp.Displayed);
        }
    }
}