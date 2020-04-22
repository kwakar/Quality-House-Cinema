using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class ForgotPasswordPage
    {

        public void ForgotPasswordPageAvailabilityAssertion()
        {
            StringAssert.Contains("Forgot Password", ForgotPasswordPageTitle);
        }

        public void ResetPasswordEmailAssertion()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
#pragma warning disable CS0618 // Type or member is obsolete
            wait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.CssSelector("div.popup-text")));
#pragma warning restore CS0618 // Type or member is obsolete
                
            StringAssert.Contains("Your password has been reset. Please check your e-mail", ResetPasswordConfirmationMessage.Text);
        }

        public void ResetPasswordErrorMessageAssertion()
        {
            StringAssert.Contains("Enter valid email", ResertPasswordErrorMessage.Text);
        }
    }
}