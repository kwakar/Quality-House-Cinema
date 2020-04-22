using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QualityCinemaAccess.Repositories;
using System;
using System.IO;
using System.Reflection;

namespace QualityCinemaAuto.Tests
{
    [SetUpFixture]
    class SetupTest
    {
        public static IWebDriver Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        [OneTimeSetUp]
        public virtual void AllTestsOneTimeSetUp()
        {
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [OneTimeTearDown]
        public void AllTestsOneTimeTearDown()
        {
            Driver.Quit();
        }
    }

    public abstract class BaseTest
    {
        public static IWebDriver Driver = SetupTest.Driver;
        private static UserRepository _userRepository = new UserRepository();
        private static ScreeningRepository _screeningRepository = new ScreeningRepository();

        [TearDown]
        public void AllTestsTearDown()
        {
            TakeScreenshootIfTestFails();
            ClearCookies();
        }


        //COMMON VARIABLES

        public int invalidUserId = _userRepository.GetInvalidUserId();
        public int validUserId = GetValidUserFromDB();

        public int invalidScreeningID = _screeningRepository.GetInvalidScreeningID();


        //COMMON METHODS

        //Take screen-shot if any test fails
        public void TakeScreenshootIfTestFails()
        {
            var testResult = TestContext.CurrentContext.Result.Outcome;

            if (testResult != ResultState.Success)
            {
                var screenshoot = ((ITakesScreenshot)Driver).GetScreenshot();
                string path = Path.GetFullPath(@"..\..\..\Screenshots\");
                string testName = TestContext.CurrentContext.Test.Name.Replace(' ', '_');
                string testDate = DateTime.Now.ToString("dd-MM-yyyy_THHmmss");

                screenshoot.SaveAsFile(path + $"{testName}_{testDate}.png", ScreenshotImageFormat.Png);
            }
        }

        //Clear cookies after test ends
        public void ClearCookies()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        //Get valid user id for positive tests
        private static int GetValidUserFromDB()
        {
            int validUserId = 68;
            bool validUser = _userRepository.ValidUserCheck(validUserId);

            if (validUser == false)
            {
                validUserId = _userRepository.CreateNewUser();
            }

            return validUserId;
        }
    }
}