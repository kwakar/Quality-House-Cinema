using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class HomePage
    {

        public void MoviesAreVisibleAssertion()
        {
            List<string> listOfMovies = new List<string>();

            for (int i = 0; i < MoviesOnPage.Count; i++)
            {
                listOfMovies.Add(MoviesOnPage[i].GetAttribute("src").ToString().Substring(0, 10));
            }

            for (int j = 0; j < listOfMovies.Count; j++)
            {
                StringAssert.Contains("data:image", listOfMovies[j]);
            }
        }

        public void LoginPageAssertion(string expected)
        {
            Assert.AreEqual(expected, LoginPageDisplayName.Text);
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void LogoRedirectionAssertion()
        {
            Logo.Click();
            StringAssert.Contains("Home Page - Quality Cinema", HomePageTitle);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }

    }

}
