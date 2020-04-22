using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Common
{
    [TestFixture]
    [Author("Dilyan Radev")]

    class ContactsPageTests : BaseTest
    {
        private ContactsPage _contactsPage;

        [SetUp]
        public void SetUp()
        {
            _contactsPage = new ContactsPage(Driver);
        }

        [TestCase(TestName = "Contacts Page content is visible")]
        [Description("Asserts that the information in Contacts Page is visible")]
        public void ContactsPageContentConfirmation()
        {
            _contactsPage.Navigate();
            _contactsPage.IncFieldAssertion("Quality Cinema, Inc.");
            _contactsPage.AddressFieldAssertion("Address:\r\nSofia, BG 1408\r\nStr Balsha 1\r\nPhone:\r\n+359 111 111 111");
            _contactsPage.EmailFieldAssertion("Еmail: info@quality-cinema.com\r\nSupport: support@quality-cinema.com");
        }
    }
}