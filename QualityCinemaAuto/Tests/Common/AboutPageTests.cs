using NUnit.Framework;
using QualityCinemaAuto.Pages;


namespace QualityCinemaAuto.Tests.Common
{
    [TestFixture]
    [Author("Dilyan Radev")]

    class AboutPageTests : BaseTest
    {
        private AboutPage _aboutPage;

        [SetUp]
        public void SetUp()
        {
            _aboutPage = new AboutPage(Driver);
        }

        [TestCase(TestName = "About Page content is visible")]
        [Description("Asserts that the information in About Page is visible")]
        public void AboutPageTextConfirmation()
        {
            _aboutPage.Navigate();
            _aboutPage.AboutPageHeaderAssertion("Hello movie lovers!");
            _aboutPage.ParagraphAssertion("Welcome to our site! In May 2019 a team of enthusiasts decided to challenge the existing cinema websites in Bulgaria. " +
                 "The Quality Cinema site provides information about actual movies on the big screen. We know you want to get the best experience of any movie " +
                 "and you time is precious. That is the reason why we offer a simple, reliable and easy to use online booking system. You can navigate to different " +
                 "movies on screen, see what is coming soon and choose you desired. Оur mission is to engender exciting experiences and see satisfied customers.");
            _aboutPage.EndingAssertion("We hope you would enjoy our service. Immerse yourself in the cinema world with us!");
            _aboutPage.TeamAssertion("Quality Cinema Team");
        }
    }
}