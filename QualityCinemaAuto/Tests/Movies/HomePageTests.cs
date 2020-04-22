using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Movies
{
    [Author("Teodora Levkova")]

    [TestFixture]
    class HomePageTests : BaseTest
    {
        private HomePage _homePage;

        [SetUp]
        public void SetUp()
        {
            _homePage = new HomePage(Driver);
        }


        [TestCase(TestName = "Home Page - Movie's images are visible")]
        [Description("All the active movies are visible on Home Page")]
        public void PageContentIsVisible()
        {
            
            _homePage.Navigate();

            _homePage.MoviesAreVisibleAssertion();
        }

        [TestCase(TestName = "Home Page - Movie's cover redirection")]
        [Description("Movie cover redirects to the corresponding page")]
        public void MovieCoverRedirectsToCorrespondingPage()
        {
            _homePage.Navigate();
            ReservationPage reservationPage = _homePage.Cover_NavigatesToReservationPage();

            reservationPage.MovieCoverRedirectionAssertion();
        }

        [TestCase(TestName = "Home Page - Watch button redirection")]
        [Description("Movie button redirects to the corresponding page")]
        public void WatchButtonRedirectsToCorrespondingPage()
        {
            _homePage.Navigate();
            ReservationPage reservationPage = _homePage.Button_NavigatesToReservationPage();

            reservationPage.WatchButtonRedirectionAssertion();
        }
    }
}