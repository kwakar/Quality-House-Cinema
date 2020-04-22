using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Movies
{
    [TestFixture]
    [Author("Dilyan Radev")]

    class OnScreenPageTests_Positive : BaseTest
    {
        private OnScreenPage _OnScreenPage;

        [SetUp]
        public void SetUp()
        {
            _OnScreenPage = new OnScreenPage(Driver);
        }


        [TestCase(TestName = "On Screen Page - Movie's descriptions are visible")]
        [Description("Asserts that the movies' information in On Screen Page is visible")]
        public void MovieTextContentConfirmation()
        {
            _OnScreenPage.Navigate();
            _OnScreenPage.MovieTextAssertion();
        }

        [TestCase(TestName = "On Screen Page - Movie's images are visible")]
        [Description("Asserts that the movies' images in On Screen Page are visible")]
        public void MovieImageContentConfirmation()
        {
            _OnScreenPage.Navigate();
            _OnScreenPage.MoviesImageAssertion();
        }
    }


    [TestFixture]
    [Author("Dilyan Radev")]

    class OnScreenPageTests_Negative : BaseTest
    {
        private OnScreenPage _OnScreenPage;
                
        [SetUp]
        public void SetUp()
        {
            _OnScreenPage = new OnScreenPage(Driver);
        }


        [TestCase(TestName = "On Screen Page - Movie's images are visible")]
        [Description("Negative test - Asserts that the movie/s image/s in OnScreen Page is/are visible")]
        public void MovieImageContentConfirmationNegative()
        {
            _OnScreenPage.Navigate();
            _OnScreenPage.MovieImageNegativeAssertion();
        }
    }
}