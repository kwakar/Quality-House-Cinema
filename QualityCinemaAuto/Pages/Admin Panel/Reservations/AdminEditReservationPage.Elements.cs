using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminEditReservationPage : BasePage
    {
        private string _userEmail;
        private string _userScreeningDate;
        private string _userScreeningTime;

        public AdminEditReservationPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Reservations";

        //ELEMENTS
        public IWebElement EditReservationButton => Driver.FindElement(By.CssSelector("a.btn.btn-default.tableButton"));

        public IWebElement EditUserReservationButton => Driver.FindElement(By.XPath($"//td[contains(text(),'{_userEmail}')]/following-sibling::td[2]/a[1]"));

        public string EditReservationPageTitile => Driver.Title;

        public IWebElement AdminReservationsPageTitle => Driver.FindElement(By.XPath("//div[1]/div/h2[contains(text(),'Reservations')]"));

        public IWebElement LogoutButton => Driver.FindElement(By.CssSelector("a.btn.btn-default.btn-nav"));

        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));

        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));

        public IWebElement DateDropDownMenu => Driver.FindElement(By.XPath($"//div[1]/div/form/div/div/div[3]/select/option[contains(text(), '{_userScreeningDate}')]"));

        public IWebElement TimeDropDownMenu => Driver.FindElement(By.XPath($"//div[1]/div/form/div/div/div[4]/select/option[contains(text(), '{_userScreeningTime}')]"));

        public IList<IWebElement> NumberOfSeats => Driver.FindElements(By.XPath("//div[1]/div/form/div/div/div[6]/select/option"));

        public IWebElement Select3Seats => Driver.FindElement(By.XPath($"//div[1]/div/form/div/div/div[4]/select/option[contains(text(), '3')]"));

        public IWebElement NumberOfPeopleDropDownMenu => Driver.FindElement(By.XPath("//*[@id='numPeople']/option[1]"));

        public IWebElement SaveButton => Driver.FindElement(By.Id("button-save"));

        public IWebElement CancelButton => Driver.FindElement(By.XPath("//div[1]/div/form/div/div/div[7]/div/a[2]"));

        public IWebElement CreateNewReservationLink => Driver.FindElement(By.XPath("//div[1]/div/p/a"));

        public IWebElement UserIdField => Driver.FindElement(By.Id("UserId"));

        public IWebElement ScreeningIdField => Driver.FindElement(By.Id("ScreeningId"));

        public IWebElement SeatsField => Driver.FindElement(By.Id("Seats"));

        public IWebElement CreateButton => Driver.FindElement(By.CssSelector("input.btn.btn-default"));

        public IWebElement ErrorMessagePopUp => Driver.FindElement(By.ClassName("popup"));
    }
}
