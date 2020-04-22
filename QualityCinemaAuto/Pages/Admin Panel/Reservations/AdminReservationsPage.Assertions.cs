using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminReservationsPage
    {
        public void AdminReservationPageElements_Assertion()
        {
            Assert.True(ReservationIdColumn.Displayed);
            Assert.True(EmailColumn.Displayed);
            Assert.True(DisplayNameColumn.Displayed);
            Assert.True(EditReservationButton.Displayed);
            Assert.True(DeleteReservationButton.Displayed);
        }

        public void AdminCreateReservationBackRedirection_Assertion()
        {
            StringAssert.Contains("Manage Reservations - Quality Cinema", AdminReservationsTitle);
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }
    }
}
