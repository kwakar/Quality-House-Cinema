using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using QualityCinemaAuto.Pages;
using System;
using System.Threading;
using OpenQA.Selenium;

namespace QualityCinemaAuto.Tests.Admin.Users
{
    [TestFixture]
    [Author("Ivaylo Nikolov")]

    class AdminDeleteUsersPageTests : BaseTest
    {
        private AdminUsersPage _adminUsersPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminUsersPage = new AdminUsersPage(Driver);
            _adminUsersPage.LoginAsAdmin();
        }

        [TestCase(TestName = "Admin User Delete")]
        [Description("Delete User from Admin user page")]
        public void DeleteUser()
        {
            _adminUsersPage.Navigate();
            // scroll method
            Actions actions = new Actions(Driver);
            actions.MoveToElement(_adminUsersPage.UserDeleteButton);
            actions.Perform();
            _adminUsersPage.UserDeleteButton.Click();
            _adminUsersPage.UserDelete1Button.Click();
            Thread.Sleep(2000);
            _adminUsersPage.AdminUserPageElements_Assertion();
        }
    }
}
