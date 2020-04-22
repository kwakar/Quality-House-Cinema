using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminScreeningPage : BasePage
    {

        public AdminScreeningPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Screenings";

        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));
        public IWebElement CreateScreeening => Driver.FindElement(By.CssSelector("body > div > div > p > a"));
        public IWebElement EditCreateScreeningButton => Driver.FindElement(By.XPath(@"(//tr)[last()]//td//a[1]"));
        public IWebElement DeleteCreateScreeningButton => Driver.FindElement(By.XPath(@"(//tr)[last()]//td//a[2]"));
        public IWebElement DeleteScreeningButton => Driver.FindElement(By.CssSelector("body>div>div>div>form>div>input"));
        public IWebElement EditCreateScreening1 => Driver.FindElement(By.XPath(@"(//tr)[last()]//td[3]"));
        public IWebElement DeleteScreeening => Driver.FindElement(By.CssSelector("body > div > div > table > tbody > tr:nth-child(2) > td:nth-child(4) > a.btn.btn-danger"));
        public IWebElement BacktoScreening => Driver.FindElement(By.CssSelector("body > div > div > div > a"));
        //public IWebElement FooterElementCreateScreening => Driver.FindElement(By.TagName("footer"));
        //public IWebElement MovieidRequired => Driver.FindElement(By.CssSelector("body > div > div > form > div > div:nth-child(4) > div > span"));
        //public IWebElement DateTimeRequired => Driver.FindElement(By.CssSelector("body > div > div > form > div > div:nth-child(5) > div > span"));
        public IWebElement MovieId => Driver.FindElement(By.Id("MovieId"));
        public IWebElement MovieIdmessage => Driver.FindElement(By.CssSelector("body > div > div > form > div > div:nth-child(4) > div > span"));
        public IWebElement DateTime1message => Driver.FindElement(By.CssSelector("body > div > div > form > div > div:nth-child(5) > div > span"));
        public IWebElement DateTime1 => Driver.FindElement(By.Id("DateTime"));
        public IWebElement dateTime1 => Driver.FindElement(By.Id("dateTime"));
        public IWebElement SaveButton => Driver.FindElement(By.Id("save-button"));
        public IWebElement CreateButton => Driver.FindElement(By.Id("create-button"));
        public IWebElement NewScreening => Driver.FindElement(By.CssSelector("body > div > div > table > tbody > tr:nth-child(117) > td:nth-child(1)"));
        

    }
}
