using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AboutPage : BasePage
    {
        public AboutPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Home/About";

        //ELEMENTS

        public IWebElement Header => Driver.FindElement(By.XPath(@"//h1"));
        public IWebElement Paragraph => Driver.FindElement(By.XPath(@"//div/div/p[1]"));
        public IWebElement Ending => Driver.FindElement(By.XPath(@"//p[2]"));
        public IWebElement CinemaTeam => Driver.FindElement(By.XPath(@"//p[3]"));

        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));

        public IWebElement AboutButton => Driver.FindElement(By.XPath("//nav[1]/ul/li[3]/a"));

        public string AboutPageTitle => Driver.Title;

        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));
    }
}
