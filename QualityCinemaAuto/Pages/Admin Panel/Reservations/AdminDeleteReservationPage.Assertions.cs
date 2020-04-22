using NUnit.Framework;
using System;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminDeleteReservationPage
    {
        public void EditReservationRedirectionAssertion()
        {
            StringAssert.Contains("Delete - Quality Cinema", DeleteReservationPageTitile);
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
