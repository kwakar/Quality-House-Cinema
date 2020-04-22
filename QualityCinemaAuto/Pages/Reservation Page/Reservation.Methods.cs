using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    [Author("Ivaylo Nikolov")]
    public partial class ReservationPage
    {

        public void ClickOnReservefor()
        {
            ReserveImage.Click();
        }

        public void ClickOnReserve()
        {
            ReserveImage.Click();
            ReserveDate.Click();
            ReserveHours.Click();
            ReserveSeats.Click();
            Reserve.Click();
        }

        public void ClickOnReservewithout()
        {
            ReserveImage.Click();
            Reserve.Click();
        }


        public ReservationPage NavigateToLoginPage()
        {
            ReservePOpInLog.Click();
            return new ReservationPage(Driver);

        }

        public ReservationPage NavigateToRegisterPage()
        {
            ReservePOpInReg.Click();
            return new ReservationPage(Driver);
        }

        public void PlayTrailerVideo()
        {
            Driver.SwitchTo().Frame(TrailerVideo);
            TrailerVideoPlayButton.Click();
        }
    }
}
