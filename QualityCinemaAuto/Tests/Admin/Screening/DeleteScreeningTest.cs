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

    class DeleteScreeningTest : BaseTest
    {
        private AdminScreeningPage _adminScreeningPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminScreeningPage = new AdminScreeningPage(Driver);
            _adminScreeningPage.LoginAsAdmin();
        }
     

        [TestCase(TestName = "Delete Screening")]
        [Description("delete Screening for existing Movie")]
        public void CreateScreeening()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.CreateScreeeningDeleteButton();
            _adminScreeningPage.DeleteCreateScreening();
        }

    }
}
