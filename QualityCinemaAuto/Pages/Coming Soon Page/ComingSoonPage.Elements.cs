using OpenQA.Selenium;
using System.Collections.Generic;

namespace QualityCinemaAuto.Pages
{
    public partial class ComingSoonPage : BasePage
    {
        public ComingSoonPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Movies/ComingSoon";

        //ELEMENTS
        public IList<IWebElement> MoviesImages => Driver.FindElements(By.XPath(@"//table/tbody/tr/td/img"));
        public IList<IWebElement> MovieContent => Driver.FindElements(By.XPath(@"//table/tbody/tr/td[2]/ul"));
        public IList<IWebElement> ContentText => Driver.FindElements(By.XPath(@"//table/tbody/tr[1]/td[2]/ul[1]/li"));
        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));
        public IWebElement ComingSoonButton => Driver.FindElement(By.XPath("//nav[1]/ul/li[2]/a"));
        public string ComingSoonPageTitle => Driver.Title;
        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));

    }
}

