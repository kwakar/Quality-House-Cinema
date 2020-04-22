using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{

    public partial class LoginPage
    {

        public void ForgotPasswordHyperlinkIsVisibleAssert()
        {
            StringAssert.Contains("Forgot password?", ForgotPasswordHyperlink.Text);
        }

        public void PasswordHiddenCharactersAssert()
        {
            Assert.AreEqual("password", PasswordField.GetAttribute("type").ToString());
        }
                     
        public void ErrorMessageAssertion()
        {
            StringAssert.Contains("Wrong username/password", ErrorMessage.Text);
        }

        public void WrongEmailFormatAssertion()
        {
            StringAssert.Contains("Login", LoginPageTitleOnPage.Text);
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void LoginRedirectionAssertion()
        {
            LoginButtonOnNavigationBar.Click();
            StringAssert.Contains("Login - Quality Cinema", LoginPageTitle);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }
    }
}