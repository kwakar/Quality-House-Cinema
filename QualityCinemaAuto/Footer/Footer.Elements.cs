using OpenQA.Selenium;

namespace QualityCinemaAuto
{
    public partial class Footer
    {
        private IWebDriver _driver;

        public Footer(IWebDriver driver)
        {
            _driver = driver;
        }

        //ELEMENTS
        public IWebElement MovieWatchButton => _driver.FindElement(By.XPath("//div[1]/div/a"));

        public IWebElement EditReservationButton => _driver.FindElement(By.CssSelector("a.btn.btn-default.tableButton"));

        public IWebElement DeleteReservationButton => _driver.FindElement(By.CssSelector("a.btn.btn-danger"));

    }
}
