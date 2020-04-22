using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminDeleteUsersPage :BasePage
    {
        public AdminDeleteUsersPage(IWebDriver driver) :base(driver)
        {
        }
        public override string Url => "http://192.168.5.86:8080/Users";

        public IWebElement DeleteUserButton => Driver.FindElement(By.CssSelector("a.delete-button.btn.btn-danger"));
        public IWebElement DeleteUserMessage => Driver.FindElement(By.XPath(@"//*[@id='delete-message']"));
    }
}
