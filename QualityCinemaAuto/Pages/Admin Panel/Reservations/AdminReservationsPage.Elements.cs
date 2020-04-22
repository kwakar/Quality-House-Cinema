using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminReservationsPage : BasePage
    {
        public AdminReservationsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Reservations";

        //ELEMENTS
        public IWebElement CreateNewReservationLink => Driver.FindElement(By.XPath("//div[1]/div/p/a"));

        public IWebElement EditReservationButton => Driver.FindElement(By.CssSelector("a.btn.btn-default.tableButton"));

        public IWebElement DeleteReservationButton => Driver.FindElement(By.CssSelector("a.btn.btn-danger"));

        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));

        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));

        public IWebElement ReservationIdColumn => Driver.FindElement(By.XPath("//tr/th[1]"));

        public IWebElement EmailColumn => Driver.FindElement(By.XPath("//tr/th[2]"));

        public IWebElement DisplayNameColumn => Driver.FindElement(By.XPath("//tr/th[3]"));

        public string AdminReservationsTitle => Driver.Title;

    }
}
