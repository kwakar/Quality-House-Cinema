using NUnit.Framework;

namespace QualityCinemaAuto.Pages
{
    public partial class AboutPage
    {
        //Asserts for positive tests

        public void AboutPageHeaderAssertion(string expected)
        {
            Assert.AreEqual(expected, Header.Text);
        }

        public void ParagraphAssertion(string expected)
        {
            Assert.AreEqual(expected, Paragraph.Text);
        }

        public void EndingAssertion(string expected)
        {
            Assert.AreEqual(expected, Ending.Text);
        }

        public void TeamAssertion(string expected)
        {
            Assert.AreEqual(expected, CinemaTeam.Text);
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void AboutRedirectionAssertion()
        {
            AboutButton.Click();
            StringAssert.Contains("About - Quality Cinema", AboutPageTitle);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }
    }
}
