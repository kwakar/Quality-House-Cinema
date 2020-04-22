using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class LoginPage
    {
        public void FillLoginForm(LoginUser user)
        {
            Email.SendKeys(user.Email);
            Password.SendKeys(user.Password);
        }

        public void FillLoginFormAndClickLoginButton(LoginUser user)
        {
            Email.SendKeys(user.Email);
            Password.SendKeys(user.Password);
            LoginButton.Click();
        }

        public HomePage ClickOnLoginButton()
        {
            LoginButton.Click();
            return new HomePage(Driver);
        }

        public ForgotPasswordPage NavigateToForgotPasswordPage()
        {
            ForgotPasswordHyperlink.Click();
            return new ForgotPasswordPage(Driver);
        }

    }
}