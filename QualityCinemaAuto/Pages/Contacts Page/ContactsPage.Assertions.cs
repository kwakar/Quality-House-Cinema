using NUnit.Framework;

namespace QualityCinemaAuto.Pages
{

    //Asserts for positive tests
    public partial class ContactsPage
    {
        public void IncFieldAssertion(string expected)
        {
            Assert.AreEqual(expected, IncText.Text);
        }
        public void AddressFieldAssertion(string expected)
        {
            Assert.AreEqual(expected, Address.Text);
        }

        public void EmailFieldAssertion(string expected)
        {
            Assert.AreEqual(expected, Email.Text);
        }

        public void SupportEmailFieldAssertion(string expected)
        {
            Assert.AreEqual(expected, Support.Text);
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void ContactsRedirectionAssertion()
        {
            ContactsButton.Click();
            StringAssert.Contains("Contact - Quality Cinema", ContactsPageTitle);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }
    }
}