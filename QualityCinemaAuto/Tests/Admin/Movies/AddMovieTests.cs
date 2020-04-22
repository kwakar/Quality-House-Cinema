using NUnit.Framework;
using QualityCinemaAuto.Pages;

namespace QualityCinemaAuto.Tests.Admin.Movies
{
    [TestFixture]
    [Author("Dilyan Radev")]
    class AddMovieTests : BaseTest
    {
        private AdminCreateReservationPage _adminCreateReservationPage;
        private AdminAddMoviePage _adminAddMoviePage;
        private AddMovieFactory _addMovieFactory;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _adminAddMoviePage = new AdminAddMoviePage(Driver);
            _addMovieFactory = new AddMovieFactory();
        }

        //TO BE FINISHED
        //[TestCase(TestName = "Admin Add Movie")]
        //[Description("Fill all the fields in the create movie form")]
        //public void AddMovie()
        //{
        //    _adminAddMoviePage.Navigate();
        //    _adminAddMoviePage.UploadImageMovieForm();
        //    _adminAddMoviePage.FillAddNewMovieForm(_addMovieFactory.GetMovieData());
        //}

        [TestCase(TestName = "Admin Add Movie - Trailer field is available")]
        [Description("Check if the Trailer field is available on the Add new movie Page")]
        public void TrailerFieldIsAvailable()
        {
            _adminAddMoviePage.Navigate();

            _adminAddMoviePage.TrailerFieldAvailability_Assertion();
        }

    }
}
