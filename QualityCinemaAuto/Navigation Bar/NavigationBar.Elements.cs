using OpenQA.Selenium;

namespace QualityCinemaAuto
{
    public partial class NavigationBar
    {
        private IWebDriver _driver;

        public NavigationBar(IWebDriver driver)
        {
            _driver = driver;
        }

        //ELEMENTS
        public IWebElement NavigationBarHeader => _driver.FindElement(By.ClassName("nav-container"));

        public IWebElement MovieWatchButton => _driver.FindElement(By.XPath("//div[1]/div/a"));

        public IWebElement Logo => _driver.FindElement(By.ClassName("logo"));

        public IWebElement OnScreenButton => _driver.FindElement(By.XPath("//nav[1]/ul/li[1]/a"));

        public IWebElement ComingSoonButton => _driver.FindElement(By.XPath("//nav[1]/ul/li[2]/a"));

        public IWebElement AboutButton => _driver.FindElement(By.XPath("//nav[1]/ul/li[3]/a"));

        public IWebElement ContactsButton => _driver.FindElement(By.XPath("//nav[1]/ul/li[4]/a"));

        public IWebElement LoginButtonOnHomePage => _driver.FindElement(By.XPath("//nav[2]/ul/li[1]/a"));

        public IWebElement RegisterButton => _driver.FindElement(By.XPath("//nav[2]/ul/li[2]/a"));

        public IWebElement EditReservationButton => _driver.FindElement(By.CssSelector("a.btn.btn-default.tableButton"));

        public IWebElement DeleteReservationButton => _driver.FindElement(By.CssSelector("a.btn.btn-danger"));

    }


}
