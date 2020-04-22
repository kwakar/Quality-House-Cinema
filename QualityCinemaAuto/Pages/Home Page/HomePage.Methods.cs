using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class HomePage
    {
        public static string _titleOnHomePage;

        public ReservationPage Button_NavigatesToReservationPage()
        {
            _titleOnHomePage = MovieTitleOnHomePage.Text;

            WatchButtonOnHomePage.Click();
            return new ReservationPage(Driver);
        }

        public ReservationPage Cover_NavigatesToReservationPage()
        {
            _titleOnHomePage = MovieTitleOnHomePage.Text;

            MovieCoverOnHomePage.Click();
            return new ReservationPage(Driver);
        }

        public void LogOut()
        {
            LogutButton.Click();
        }
    }
}