using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Account/Login";
        
        //ELEMENTS
        public IWebElement Email => Driver.FindElement(By.Id("mail"));

        public IWebElement Password => Driver.FindElement(By.Id("pass"));
        
        public IWebElement LoginButton => Driver.FindElement(By.XPath(@"//*[@id=""login-div""]/form/div[4]/input"));

        public IWebElement ErrorMessage => Driver.FindElement(By.ClassName("field-validation-error"));

        public IWebElement LoginPageTitleOnPage => Driver.FindElement(By.XPath(@"//*[@id=""login-div""]/h2"));

        public IWebElement PasswordField => Driver.FindElement(By.Id("pass"));

        public IWebElement ForgotPasswordHyperlink => Driver.FindElement(By.Id("forgotPassText"));

        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));

        public IWebElement LoginButtonOnNavigationBar => Driver.FindElement(By.XPath("//nav[2]/ul/li[1]/a"));

        public string LoginPageTitle => Driver.Title;

        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));

    }
}
