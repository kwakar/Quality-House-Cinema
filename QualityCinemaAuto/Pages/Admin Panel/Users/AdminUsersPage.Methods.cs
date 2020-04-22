using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminUsersPage
    {
        public void LoginAsAdmin()
        {
            LoginPage loginpage = new LoginPage(Driver);
            loginpage.Navigate();
            loginpage.FillLoginFormAndClickLoginButton(LoginUserFactory.GetAdminUser());
        }
        public AdminEditUsersPage ClickOn_CreateLink()
        {
            EditUserButton.Click();
            return new AdminEditUsersPage(Driver);
        }

        public AdminDeleteUsersPage ClickOn_DeleteButton()
        {
            DeleteUserButton.Click();
            return new AdminDeleteUsersPage(Driver);
        }
    }
}
