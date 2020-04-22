using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminUsersPage : BasePage
    {
        public AdminUsersPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Users";

        public IWebElement DeleteUserButton => Driver.FindElement(By.CssSelector("a.delete-button.btn.btn-danger"));
        public IWebElement EditUserButton => Driver.FindElement(By.CssSelector("a.btn.btn-default.tableButton"));
        public IWebElement EmailColumn => Driver.FindElement(By.XPath("//tr/th[1]"));
        public IWebElement DisplayNameColumn => Driver.FindElement(By.XPath("//tr/th[2]"));
        public IWebElement  UserEditButton => Driver.FindElement(By.CssSelector("body > div > div > div > table > tbody > tr:nth-child(77) > td:nth-child(3) > a.btn.btn-default.tableButton"));
        public IWebElement UserEditCancelButton => Driver.FindElement(By.CssSelector("body > div > div > div > form > div > div:nth-child(8) > div > a:nth-child(2)"));
        public IWebElement UserDeleteButton => Driver.FindElement(By.CssSelector("body > div > div > div > table > tbody > tr:nth-child(87) > td:nth-child(3) > a.delete-button.btn.btn-danger"));
        public IWebElement UserDelete1Button => Driver.FindElement(By.Id("delete-item"));
    }
  
}