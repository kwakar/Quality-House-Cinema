using NUnit.Framework;
using QualityCinemaAuto.Pages;
using System;


namespace QualityCinemaAuto.Tests.Admin.Users
{
    [TestFixture]
    [Author("Ivaylo Nikolov")]

    class AdminUsersPageTests : BaseTest
    {
        private AdminUsersPage _adminUsersPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminUsersPage = new AdminUsersPage(Driver);
            _adminUsersPage.LoginAsAdmin();
        }

        [TestCase(TestName = "Admin User Page - Page elements are visible")]
        [Description("Create reservation link redirects to the corresponding page")]
        public void PageElementsAreVisible()
        {
            _adminUsersPage.Navigate();
            _adminUsersPage.AdminUserPageElements_Assertion();
        }

        [TestCase(TestName = "Admin UserEdit Page - Edit button redirection")]
        [Description("Edit reservation button redirects to the corresponding page")]
        public void EditButton_RedirectsToCorrespondingPage()
        {
            _adminUsersPage.Navigate();
            AdminEditUsersPage adminEditUsersPage = _adminUsersPage.ClickOn_CreateLink();
            adminEditUsersPage.EditUsersRedirectionAssertion();
        }

        [TestCase(TestName = "Admin User Page - Delete button redirection")]
        [Description("Delete Pop-up")]
        public void DeleteButton_Popup()
        {
            _adminUsersPage.Navigate();
            AdminDeleteUsersPage adminDeleteUsersPopup = _adminUsersPage.ClickOn_DeleteButton();
            adminDeleteUsersPopup.DeletePopupAssertion();
        }


    }
}