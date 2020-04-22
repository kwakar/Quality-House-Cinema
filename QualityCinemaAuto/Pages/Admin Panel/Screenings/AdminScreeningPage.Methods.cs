using System;
using QualityCinemaAccess.Repositories;



namespace QualityCinemaAuto.Pages
{

    public partial class AdminScreeningPage : BasePage
    {
        private ScreeningRepository screeningRepository = new ScreeningRepository();
        
        private Random gen = new Random();
        DateTime RandomDate()
        {
            DateTime Date = DateTime.Now;
            return Date.AddDays(6);
            
        }

        public void LoginAsAdmin()
        {
            LoginPage loginpage = new LoginPage(Driver);
            loginpage.Navigate();
            loginpage.FillLoginFormAndClickLoginButton(LoginUserFactory.GetAdminUser());
        }

        public void CreateScreeeningID()
        {             
            CreateScreeening.Click();
            MovieId.SendKeys("2");
            DateTime1.SendKeys(RandomDate().ToString("dd/MM/yyyy, HH:00"));
            CreateButton.Click();
        }
        public void CreateScreeeningwithoutfillfield()
        {
            CreateScreeening.Click();
            CreateButton.Click();
        }

        public void CreateScreeeningBackButton()
        {
            CreateScreeening.Click();
            BacktoScreening.Click();
        }
        public void CreateScreeeningnodate()
        {
            CreateScreeening.Click();
            MovieId.SendKeys("2");
            DateTime1.SendKeys(RandomDate().ToString("dd/MM/yyyy,"));
            CreateButton.Click();
        }

        public void CreateScreeeningnohours()
        {
            CreateScreeening.Click();
            MovieId.SendKeys("2");
            DateTime1.SendKeys(RandomDate().ToString(" HH:00"));
            CreateButton.Click();
        }

        public void CreateScreeeningEditButton()
        {
            CreateScreeening.Click();
            MovieId.SendKeys("2");
            DateTime1.SendKeys(RandomDate().ToString("dd/MM/yyyy, 15:15"));
            CreateButton.Click();
            EditCreateScreeningButton.Click();
            dateTime1.Clear();
            dateTime1.SendKeys(RandomDate().ToString("dd/MM/yyyy HH:00"));
            SaveButton.Click();
        }

        public void CreateScreeeningDeleteButton()
        {
            CreateScreeening.Click();
            MovieId.SendKeys("2");
            DateTime1.SendKeys(RandomDate().ToString("dd/MM/yyyy, 17:17"));
            CreateButton.Click();
            DeleteCreateScreeningButton.Click();
            DeleteScreeningButton.Click();
        }
    }
}
