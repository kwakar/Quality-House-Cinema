using QualityCinemaAccess.Repositories;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminCreateReservationPage
    {
        private ReservationRepository reservationRepository = new ReservationRepository();
        private ScreeningRepository screeningRepository = new ScreeningRepository();


        public void LoginAsAdmin()
        {
            LoginPage loginpage = new LoginPage(Driver);
            loginpage.Navigate();
            loginpage.FillLoginFormAndClickLoginButton(LoginUserFactory.GetAdminUser());
        }


        public void CreateValidReservation(int userId)
        {
            //Before creating new reservation:
            //1. Check if there are already created reservations by this user
            reservationRepository.ReservationFromThisUserCheck(userId);

            //2. Find available screening id
            int screeningID = screeningRepository.SelectAvailableScreeningId();

            //3. Check if there are enough number of seats for this screening
            bool screeningCheck = screeningRepository.EnoughtSeatsNumberCheck(screeningID);

            if (screeningCheck == false)
            {
                screeningRepository.CreateMoreSeatsForThisScreening(screeningID);
            }

            //Create new reservation
            UserIdField.SendKeys(userId.ToString());
            ScreeningIdField.SendKeys(screeningID.ToString());
            SeatsField.SendKeys("2");
            CreateButton.Click();
        }


        public void FillReservationFieldsWithInvalidUserId(int InvalidUserId)
        {
            //Available screening check
            int screeningID = screeningRepository.SelectAvailableScreeningId();

            //Enough seats number check
            bool screeningCheck = screeningRepository.EnoughtSeatsNumberCheck(screeningID);

            if (screeningCheck == false)
            {
                screeningRepository.CreateMoreSeatsForThisScreening(screeningID);
            }

            UserIdField.SendKeys(InvalidUserId.ToString());
            ScreeningIdField.SendKeys(screeningID.ToString());
            SeatsField.SendKeys("2");
            CreateButton.Click();
        }


        public void FillReservationFieldsWithInvalidScreeningId(int userId, int InvalidScreeningId)
        {
            UserIdField.SendKeys(userId.ToString());
            ScreeningIdField.SendKeys(InvalidScreeningId.ToString());
            SeatsField.SendKeys("2");
            CreateButton.Click();
        }
        

        public void FillReservationFieldsWithInvalidSeatsNumber(int userId, int seats)
        {
            //Available screening check
            int screeningID = screeningRepository.SelectAvailableScreeningId();

            UserIdField.SendKeys(userId.ToString());
            ScreeningIdField.SendKeys(screeningID.ToString());
            SeatsField.SendKeys(seats.ToString());
            CreateButton.Click();
        }


        public void DeleteCreatedResevation()
        {
            ReservationEmailDeleteButton.Click();
            DeleteButton.Click();
        }

        
        public AdminReservationsPage ClickOn_BackToListButton()
        {
            BackToListButton.Click();
            return new AdminReservationsPage(Driver);
        }
    }
}