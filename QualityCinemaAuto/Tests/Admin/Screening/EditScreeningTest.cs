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

    class EditScreeningTest : BaseTest
    {
        private AdminScreeningPage _adminScreeningPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminScreeningPage = new AdminScreeningPage(Driver);
            _adminScreeningPage.LoginAsAdmin();
        }

        [TestCase(TestName = "Screeening Page visible elements")]
        [Description("Create Screening for existing Movie")]
        public void CreateScreeening()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.ScreeningBackButton();
        }

        [TestCase(TestName = "Screeening Page Edit")]
        [Description("Editing Created Screening ")]
        public void CreateScreeeningEdit()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.CreateScreeeningEditButton();
            _adminScreeningPage.EditCreateScreening();
        }
    }
}
