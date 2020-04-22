using System.Collections.Generic;
using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminEditUsersPage : BasePage
    {
        public AdminEditUsersPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Users";

        public string EditUsersPageTitile => Driver.Title;
        public IList<IWebElement> UserPageName => Driver.FindElements(By.XPath(@"//*[@id='reg-form']/div/label"));
    }
}
