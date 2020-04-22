using OpenQA.Selenium;
using System.Collections.Generic;

namespace QualityCinemaAuto.Pages
{
    public partial class OnScreenPage : BasePage
    {
        public OnScreenPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Movies/OnScreen";
        public IList<IWebElement> MovieImages => Driver.FindElements(By.XPath(@"//table/tbody/tr/td/img"));
        public IList<IWebElement> MovieContent => Driver.FindElements(By.XPath(@"//table/tbody/tr/td[2]/ul"));
        public IList<IWebElement> ContentText => Driver.FindElements(By.XPath(@"//table/tbody/tr[1]/td[2]/ul[1]/li"));
        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));
        public IWebElement OnScreenButton => Driver.FindElement(By.XPath("//nav[1]/ul/li[1]/a"));
        public string OnScreenPageTitle => Driver.Title;
        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));
    }
}

