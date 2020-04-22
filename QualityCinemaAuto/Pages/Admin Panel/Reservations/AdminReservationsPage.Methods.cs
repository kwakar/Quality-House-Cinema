using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminReservationsPage
    {
        public AdminCreateReservationPage ClickOn_CreateLink()
        {
            CreateNewReservationLink.Click();
            return new AdminCreateReservationPage(Driver);
        }

        public AdminEditReservationPage ClickOn_EditButton()
        {
            EditReservationButton.Click();
            return new AdminEditReservationPage(Driver);
        }

        public AdminDeleteReservationPage ClickOn_DeleteButton()
        {
            DeleteReservationButton.Click();
            return new AdminDeleteReservationPage(Driver);
        }
    }
}
