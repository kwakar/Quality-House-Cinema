using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminDeleteReservationPage : BasePage
    {
        public AdminDeleteReservationPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Reservations";


        //ELEMENTS
        public IWebElement DeleteReservationButton => Driver.FindElement(By.CssSelector("a.btn.btn-danger"));
        

        public string DeleteReservationPageTitile => Driver.Title;



        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));

        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));
    }
}
