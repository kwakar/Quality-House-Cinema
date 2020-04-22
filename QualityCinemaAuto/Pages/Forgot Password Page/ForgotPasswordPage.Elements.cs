using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class ForgotPasswordPage : BasePage
    {
        public ForgotPasswordPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Account/ForgotPassword";

        //ELEMENTS

        public string ForgotPasswordPageTitle => Driver.Title;

        public IWebElement Email => Driver.FindElement(By.Id("email"));

        public IWebElement SendButton => Driver.FindElement(By.Id("button-send"));

        public IWebElement ResetPasswordConfirmationMessage => Driver.FindElement(By.CssSelector("div.popup-text"));

        public IWebElement ResertPasswordErrorMessage => Driver.FindElement(By.Id("emailError"));


    }
}
