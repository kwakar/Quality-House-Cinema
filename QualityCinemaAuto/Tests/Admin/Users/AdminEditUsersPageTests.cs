using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using QualityCinemaAuto.Pages;


namespace QualityCinemaAuto.Tests.Admin.Users
{
    [TestFixture]
    [Author("Ivaylo Nikolov")]

    class AdminEditUsersPageTests : BaseTest
    {
        private AdminUsersPage _adminUsersPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminUsersPage = new AdminUsersPage(Driver);

            _adminUsersPage.LoginAsAdmin();
        }

     
        [TestCase(TestName = "Admin UserEdit Redirection - Edit button redirection")]
        [Description("Edit reservation button redirects to the corresponding page")]
        public void EditButtonRedirections()
        {
            _adminUsersPage.Navigate();
            //// scroll method
            Actions actions = new Actions(Driver);
            actions.MoveToElement(_adminUsersPage.UserEditButton);
            actions.Perform();
            _adminUsersPage.UserEditButton.Click();
            _adminUsersPage.UserEditCancelButton.Click();
            _adminUsersPage.AdminUserPageElements_Assertion();
        }
    }
}