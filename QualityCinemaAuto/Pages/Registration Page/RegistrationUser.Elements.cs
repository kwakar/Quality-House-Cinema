using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace QualityCinemaAuto.Pages
{
    [Author("Ivaylo Nikolov")]
    public partial class RegistrationPage : BasePage
    {

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Account/SignUp";


        //ELEMENTS

        public IWebElement Email => Driver.FindElement(By.Id("email"));
        public IWebElement Password => Driver.FindElement(By.Id("password"));
        public IWebElement ConfirmPassword => Driver.FindElement(By.Id("confirmPass"));
        public IWebElement DisplayName => Driver.FindElement(By.Id("displayName"));
        public IWebElement YearofBirth => Driver.FindElement(By.Id("birthYear"));
        public IWebElement RegisterButton => Driver.FindElement(By.Id("btnSubmit"));
        public IList<IWebElement> RegPageName => Driver.FindElements(By.XPath(@"//*[@id='reg-form']/div/label"));
        public IList<IWebElement> RegPagePlace => Driver.FindElements(By.XPath(@"//*[@id='reg-form']/div/input"));

        public IWebElement SelectYearofBirth => Driver.FindElement(By.XPath(@"//*[@id='birthYear']/option[1]"));
        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));
        public IWebElement RegisterButtonOnNavigationBar => Driver.FindElement(By.XPath("//nav[2]/ul/li[2]/a"));
        public string RegisterPageTitle => Driver.Title;
        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));



        //ErrorMessage

        public IWebElement ErrorMessageEmail => Driver.FindElement(By.Id("emptyEmail"));
        public IWebElement ErrorMessageWrongEmail => Driver.FindElement(By.Id("wrongEmail"));
        public IWebElement ErrorMessagePass => Driver.FindElement(By.Id("passEmpty"));
        public IWebElement ErrorMessagePasswithoutspec => Driver.FindElement(By.Id("passLength"));
        public IWebElement ErrorMessagePassConf => Driver.FindElement(By.Id("confWrong"));
        public IWebElement ErrorMessageConfPass => Driver.FindElement(By.Id("confEmpty"));
        public IWebElement ErrorMessageDisName => Driver.FindElement(By.Id("displayNameEmpty"));
        public IWebElement ErrorMessageDisName65 => Driver.FindElement(By.Id("displayNameInvalid"));
        public IWebElement ErrorMessagebirthYear => Driver.FindElement(By.Id("yearWrong"));
        public IWebElement ErrorMessageExistUser => Driver.FindElement(By.XPath(@"//*[@id=""error-message""]/p"));
#pragma warning disable CS0618 // Type or member is obsolete
        public IWebElement ErrorMessageCreateUsern => this.Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#popup-body p")));
#pragma warning restore CS0618 // Type or member is obsolete

    }
}