using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080";

        //ELEMENTS
                     
        public IList<IWebElement> MoviesOnPage => Driver.FindElements(By.XPath(@"//div/div/section/div/div/div/div/img"));
        public IWebElement MovieTitleOnHomePage => Driver.FindElement(By.CssSelector("h4.movie-title"));
        public IWebElement MovieCoverOnHomePage => Driver.FindElement(By.XPath("//div[1]//div//img"));
        public IWebElement WatchButtonOnHomePage => Driver.FindElement(By.XPath("//div[1]/div/a"));
        public IWebElement LoginPageDisplayName => Driver.FindElement(By.ClassName("hello-user"));
        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));
        public IWebElement Logo => Driver.FindElement(By.ClassName("logo"));
        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));
        public string HomePageTitle => Driver.Title;
        public IWebElement LogutButton => Driver.FindElement(By.CssSelector("a.btn.btn-default.btn-nav"));
    }

}
