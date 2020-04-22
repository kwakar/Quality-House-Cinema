using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Movies
{
    [Author("Dilyan Radev")]

    [TestFixture]
    class ComingSoonPageTests : BaseTest
    {
        private ComingSoonPage _comingSoonPage;

        [SetUp]
        public void SetUp()
        {
            _comingSoonPage = new ComingSoonPage(Driver);
        }


        [TestCase(TestName = "Coming Soon - Movie's images are visible")]
        [Description("Asserts that the movies' images in Coming Soon Page are visible")]
        public void ComingSoonImageContentConfirmation()
        {
            _comingSoonPage.Navigate();
            _comingSoonPage.MoviesImageAssertion();
        }

        [TestCase(TestName = "Coming Soon - Movie's descriptions are visible")]
        [Description("Asserts that the movies' information in Coming Soon Page is visible")]
        public void ComingSoonTextContentConfirmation()
        {
            _comingSoonPage.Navigate();
            _comingSoonPage.MovieTextAssertion();
        }
    }
}