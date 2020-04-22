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

    class CreateNewScreeningTests : BaseTest
    {
        private AdminScreeningPage _adminScreeningPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _adminScreeningPage = new AdminScreeningPage(Driver);

            _adminScreeningPage.LoginAsAdmin();
        }
       
        [TestCase(TestName = "Create Screening")]
        [Description("Create Screening for existing Movie")]
        public void CreateScreeening()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.CreateScreeeningID();
            _adminScreeningPage.CreateNewScreening();
        }

        [TestCase(TestName = "Create Screening without fill the field")]
        [Description("Create Screening for existing Movie")]
        public void CreateScreeeningnegative()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.CreateScreeeningwithoutfillfield();
            _adminScreeningPage.CreateScreeningwithoutfield();
        }

        [TestCase(TestName = "Check redirection of BackButton")]
        [Description("BackButton functionality")]
        public void CreateScreeeningPage()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.CreateScreeeningBackButton();
            _adminScreeningPage.ScreeningBackButton();
        }

        [TestCase(TestName = "Create Screening without fill date")]
        [Description("Create Screening for existing Movie")]
        public void CreateScreeeningnodate()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.CreateScreeeningnodate();
            _adminScreeningPage.CreateNewScreening();
        }

        [TestCase(TestName = "Create Screening without fill hours")]
        [Description("Create Screening for existing Movie")]
        public void CreateScreeeningnohours()
        {
            _adminScreeningPage.Navigate();
            _adminScreeningPage.CreateScreeeningnohours();
            _adminScreeningPage.CreateNewScreening();
        }
    }

}
