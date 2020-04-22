using NUnit.Framework;
using QualityCinemaAccess.Repositories;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminCreateReservationPage
    {

        public void AdminCreateReservationRedirectionAssertion()
        {
            StringAssert.Contains("Create - Quality Cinema", AdminCreateReservationPageTitile);
        }


        public void SuccesfullyCreatedReservationAssertion()
        {
            StringAssert.Contains("cinematest@abv.bg", ReservationEmail.Text);
        }


        public void FailedReservationCreationAssertion()
        {
            StringAssert.Contains("Error.", ReservationErrorMessage.Text);
        }


        public void InvalidNumberOfSeatsAssertion()
        {
            StringAssert.Contains("is not valid for Seats.", InvalidSeatsNumberErrorMessage.Text);
        }


        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }


        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }

    }
}
