using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class ForgotPasswordPage
    {
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
            SendButton.Click();
        }
    }
}
