using System;
using System.IO;
using System.Xml.Linq;
using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminAddMoviePage
    {
        public void FillAddNewMovieForm(AddMovie movie)
        {
            NameField.SendKeys(movie.Name);
            DescriptionField.SendKeys(movie.Description);
            ReleaseDate.SendKeys(movie.ReleaseDate);
            RunningTime.SendKeys(movie.RunningTime);
            Genre.SendKeys(movie.Genre);
            Position.SendKeys(movie.Position);
            AddButton.Click();
        }

        public void UploadImageMovieForm()
        {
            //ImageUploadButton.SendKeys(@"C:\Users\dradev\Desktop\backup volume 3\QualityCinemaAuto\Pictures\sonic.jpeg");

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            path = path.Substring(0, path.Length - 3);

            string relativePath = path + "Pictures\\sonic.jpeg";

            ImageUploadButton.SendKeys(relativePath);
        }
    }
}
