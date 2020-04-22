using QualityCinemaAccess.Repositories;
using System.Collections.Generic;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminEditReservationPage
    {
        private int _seatsLeft;

        private ScreeningRepository _screeningRepository = new ScreeningRepository();
        private UserRepository _userRepository = new UserRepository();
        private int _returnedScreeningId;

        public void NavigateToCreatedReservation()
        {
            EditReservationButton.Click();
        }


        public void NavigateToPage()
        {
            AdminEditReservationPage adminEditReservationPage = new AdminEditReservationPage(Driver);
            adminEditReservationPage.Navigate();

            EditReservationButton.Click();
        }


        public void LoginAsAdmin()
        {
            LoginPage loginpage = new LoginPage(Driver);
            loginpage.Navigate();
            loginpage.FillLoginFormAndClickLoginButton(LoginUserFactory.GetAdminUser());
        }


        public void CreateNewReservation(int userId)
        {
            //Before creating new reservation:
            //1. Check if there are already created reservations by this user
            reservationRepository.ReservationFromThisUserCheck(userId);

            //2. Find available screening id
            int screeningId = _screeningRepository.SelectAvailableScreeningId();

            //3. Check if there are enough number of seats for this screening
            bool screeningCheck = _screeningRepository.EnoughtSeatsNumberCheck(screeningId);

            if (screeningCheck == false)
            {
                _screeningRepository.CreateMoreSeatsForThisScreening(screeningId);
            }

            _returnedScreeningId = screeningId;

            //4. Create new reservation
            reservationRepository.CreateNewReservation(userId, screeningId);
        }


        public void CreateNewReservationWith2Seats(int userId)
        {
            //Before creating new reservation:
            //Check if there are already created reservations by this user
            reservationRepository.ReservationFromThisUserCheck(userId);

            //Create new reservation
            reservationRepository.CreateNewReservationWith2Seats(userId, _returnedScreeningId);
        }


        public void CreateNewScreeningWith4Seats(int userId)
        {
            int screeningId = _screeningRepository.CreateNewScreeningWith4Seats(42); // !!!!movie id to become dynamic when Movie repo is created

            _returnedScreeningId = screeningId;
        }


        public void DeleteCreatedScreening()
        {
            _screeningRepository.DeleteScreening(_returnedScreeningId);
        }


        public void EditReservationWithValidData(int userId)
        {
            //Get user e-mail needed for Reservation button locator
            var currentUser = _userRepository.GetUserById(userId);
            _userEmail = currentUser.Email.ToString();

            EditUserReservationButton.Click();

            //Get screening id for current user's reservation for Date drop-down menu locator
            var currentScreening = _screeningRepository.GetScreeningById(_returnedScreeningId);
            _userScreeningDate = currentScreening.DateTime.ToString("dd.MM.yyyy");

            DateDropDownMenu.Click();

            //Set time for Time drop-down menu locator
            _userScreeningTime = currentScreening.DateTime.ToString("HH:mm:ss");

            TimeDropDownMenu.Click();

            //Enough Seats Number Check
            bool screeningCheck = _screeningRepository.EnoughtSeatsNumberCheck(_returnedScreeningId);

            if (screeningCheck == false)
            {
                _screeningRepository.CreateMoreSeatsForThisScreening(_returnedScreeningId);
            }

            NumberOfPeopleDropDownMenu.Click();
            SaveButton.Click();
        }


        public void EditReservationWihoutSelectingDate(int userId)
        {
            //Get user e-mail needed for Reservation button locator
            var currentUser = _userRepository.GetUserById(userId);
            _userEmail = currentUser.Email.ToString();

            EditUserReservationButton.Click();
            SaveButton.Click();
        }


        public void EditReservationWihoutSelectingTime(int userId)
        {
            //Get user e-mail needed for Reservation button locator
            var currentUser = _userRepository.GetUserById(userId);
            _userEmail = currentUser.Email.ToString();

            EditUserReservationButton.Click();

            //Get screening id for current user's reservation for Date drop-down menu locator
            var currentScreening = _screeningRepository.GetScreeningById(_returnedScreeningId);
            _userScreeningDate = currentScreening.DateTime.ToString("dd.MM.yyyy");

            DateDropDownMenu.Click();
            SaveButton.Click();
        }


        public void EditReservationSelecting3Seats(int userId)
        {
            //Get user e-mail needed for Reservation button locator
            var currentUser = _userRepository.GetUserById(userId);
            _userEmail = currentUser.Email.ToString();

            Navigate();
            EditUserReservationButton.Click();

            //Get screening id for current user's reservation for Date drop-down menu locator
            var currentScreening = _screeningRepository.GetScreeningById(_returnedScreeningId);
            _userScreeningDate = currentScreening.DateTime.ToString("dd.MM.yyyy");

            DateDropDownMenu.Click();

            //Set time for Time drop-down menu locator
            _userScreeningTime = currentScreening.DateTime.ToString("HH:mm:ss");
            TimeDropDownMenu.Click();

            Select3Seats.Click();
            SaveButton.Click();
        }


        public void CheckNumberOfSeatsLeft(int userId)
        {
            //Get user e-mail needed for Reservation button locator
            var currentUser = _userRepository.GetUserById(userId);
            _userEmail = currentUser.Email.ToString();

            EditUserReservationButton.Click();

            //Get screening id for current user's reservation for Date drop-down menu locator
            var currentScreening = _screeningRepository.GetScreeningById(_returnedScreeningId);
            _userScreeningDate = currentScreening.DateTime.ToString("dd.MM.yyyy");

            DateDropDownMenu.Click();

            //Set time for Time drop-down menu locator
            _userScreeningTime = currentScreening.DateTime.ToString("HH:mm:ss");

            TimeDropDownMenu.Click();

            _seatsLeft = NumberOfSeats.Count;
        }


        public void DeleteAllCreatedReservations(int expectedId)
        {
            var reservationRepository = new ReservationRepository();

            reservationRepository.DeleteAllReservationsFromUserId(expectedId);
        }
    }
}