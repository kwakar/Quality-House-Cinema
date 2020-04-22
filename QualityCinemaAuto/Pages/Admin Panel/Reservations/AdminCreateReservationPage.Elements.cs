using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminCreateReservationPage : BasePage
    {
        public AdminCreateReservationPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Reservations/Create";

        //ELEMENTS
        public string AdminCreateReservationPageTitile => Driver.Title;

        public IWebElement NavigationBarHeader => Driver.FindElement(By.ClassName("nav-container"));

        public IWebElement FooterElement => Driver.FindElement(By.TagName("footer"));

        public IWebElement UserIdField => Driver.FindElement(By.Id("UserId"));

        public IWebElement ScreeningIdField => Driver.FindElement(By.Id("ScreeningId"));

        public IWebElement SeatsField => Driver.FindElement(By.Id("Seats"));

        public IWebElement CreateButton => Driver.FindElement(By.CssSelector("input.btn.btn-default"));

        public IWebElement ReservationEmail => Driver.FindElement(By.XPath("//td[contains(text(),'cinematest@abv.bg')]"));

        public IWebElement ReservationEmailDeleteButton => Driver.FindElement(By.XPath("//td[contains(text(),'cinematest@abv.bg')]/following-sibling::td[2]/a[2]"));

        public IWebElement DeleteButton => Driver.FindElement(By.CssSelector("input.btn.btn-default"));

        public IWebElement ReservationErrorMessage => Driver.FindElement(By.TagName("h1"));

        public IWebElement InvalidSeatsNumberErrorMessage => Driver.FindElement(By.XPath("//div[1]/div/form/div/div[4]/div/span"));

        public IWebElement BackToListButton => Driver.FindElement(By.XPath("//div[1]/div/div/a"));
    }
}
