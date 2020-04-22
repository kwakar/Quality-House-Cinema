using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminAddMoviePage : BasePage
    {
        public AdminAddMoviePage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://192.168.5.86:8080/Movies/Create";

        //ELEMENTS

        public IWebElement NameField => Driver.FindElement(By.Id("Name"));
        public IWebElement DescriptionField => Driver.FindElement(By.Id("Description"));
        public IWebElement ReleaseDate => Driver.FindElement(By.Id("ReleaseDate"));
        public IWebElement RunningTime => Driver.FindElement(By.Id("RunningTime"));
        public IWebElement Genre => Driver.FindElement(By.Id("Genre"));
        public IWebElement Position => Driver.FindElement(By.Id("PositionOnHome"));
        public IWebElement AddButton => Driver.FindElement(By.XPath("//form/div/div[10]/input"));
        //public IWebElement Image => Driver.FindElement(By.XPath(@"C:\Users\dradev\Desktop\sonic.jpeg"));
        public IWebElement ImageUploadButton => Driver.FindElement(By.XPath("//form/div/div[7]/div/input"));
        public IWebElement TrailerField => Driver.FindElement(By.Id("Trailer"));
    }
}