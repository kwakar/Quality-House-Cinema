using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    [Author("Ivaylo Nikolov")]
    public partial class ReservationPage : BasePage
    {

        public ReservationPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080";


        //ELEMENTS
        public IList<IWebElement> ReservpagElements => Driver.FindElements(By.XPath(@"/html/body/div/div/div[1]/div/div[2]/dl/dt"));
        public IWebElement ReservpagElementsNote => Driver.FindElement(By.XPath(@"/html/body/div/div/div[1]/div/div[2]/dl/dd[10]"));
        public IWebElement ReservpagElementsNoteDown => Driver.FindElement(By.XPath(@"/html/body/div/footer/p"));
        public IWebElement ReservpagElementsdropdown => Driver.FindElement(By.XPath(@"/html/body/div/div/div[1]/div/div[2]/dl/dd[6]/form/select"));
        public IWebElement Reserve => Driver.FindElement(By.Id("book-button"));
        public IWebElement ReserveImage => Driver.FindElement(By.XPath(@"/html/body/div/div/section/div/div/div[5]/div/img"));
        public IWebElement ReserveDate => Driver.FindElement(By.XPath(@"//*[@id='dates-dropdown']/option[2]"));
        public IWebElement ReserveHours => Driver.FindElement(By.XPath(@"//*[@id='screeningTimeDropdown']/option[2]"));
        public IWebElement ReserveSeats => Driver.FindElement(By.XPath(@"//*[@id='selectSeats']/option[3]"));
#pragma warning disable CS0618 // Type or member is obsolete
        public IWebElement ReservePOpIn => this.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(@"//*[@id='popup-body']/h2")));
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
        public IWebElement ReservePOpInText => this.Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#popup-body > div.popup-text > p")));
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
        public IWebElement ReservePOpInLog => this.Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#popup-body > div.button-container-popup > a.btn.btn-primary.button-popup")));
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
        public IWebElement ReservePOpInReg => this.Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#popup-body > div.button-container-popup > a.btn.btn-success.button-popup")));
#pragma warning restore CS0618 // Type or member is obsolete
        public IWebElement ReserveredirectReg => Driver.FindElement(By.XPath(@"//*[@id='regcont']/h1"));
        public IWebElement ReserveredirectLog => Driver.FindElement(By.XPath(@"//*[@id='login-div']/h2"));
        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));
        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));
        public IWebElement MovieTitleOnHomePage => Driver.FindElement(By.CssSelector("h4.movie-title"));
        public IWebElement MovieTitleOnMoviePage => Driver.FindElement(By.XPath("//dl//dd[1]"));
        public IWebElement TrailerVideo => Driver.FindElement(By.XPath("//iframe"));
        public IWebElement PlayingVideo => Driver.FindElement(By.ClassName("html5-video-container"));
        public IWebElement TrailerVideoPlayButton => Driver.FindElement(By.XPath("//div[4]/button[@aria-label='Play']"));
        public IWebElement TrailerVidePauseButton => Driver.FindElement(By.XPath("//div[1]/button[@aria-label='Pause (k)']"));
 

    }
}