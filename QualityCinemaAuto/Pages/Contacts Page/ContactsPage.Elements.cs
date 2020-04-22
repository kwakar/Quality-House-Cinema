using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class ContactsPage : BasePage
    {
        public ContactsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Home/Contact";

        //ELEMENTS

        public IWebElement IncText => Driver.FindElement(By.XPath("//h2"));
        public IWebElement Address => Driver.FindElement(By.XPath("//address"));
        public IWebElement Email => Driver.FindElement(By.XPath("//div/div/address[2]"));
        public IWebElement Support => Driver.FindElement(By.Name("support-link"));

        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));

        public IWebElement ContactsButton => Driver.FindElement(By.XPath("//nav[1]/ul/li[4]/a"));

        public string ContactsPageTitle => Driver.Title;

        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));

    }
}
