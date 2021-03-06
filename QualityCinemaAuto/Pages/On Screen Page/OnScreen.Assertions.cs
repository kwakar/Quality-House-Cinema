﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace QualityCinemaAuto.Pages
{

    //Asserts for positive tests
    public partial class OnScreenPage
    {
        public void MoviesImageAssertion()
        {
            List<string> listOfMovies = new List<string>();

            for (int i = 0; i < MovieImages.Count(); i++)
            {
                listOfMovies.Add(MovieImages[i].GetAttribute("src").ToString().Substring(0, 1));

                Assert.AreEqual("d", listOfMovies[i]);
            }
        }

        public void MovieTextAssertion()
        {
            List<string> listOfTables = new List<string>();

            List<string> listOfContext = new List<string>()
            {"Title",
             "Running time",
             "Genre",
             "Description",
             "Release date"};

            for (int i = 0; i < MovieContent.Count(); i++)
            {
                List<string> listOfContent = new List<string>();

                listOfTables.Add(MovieContent[i].ToString());

                for (int j = 0; j < ContentText.Count(); j++)
                {
                    if (j == 0)
                    {
                        listOfContent.Add(ContentText[j].Text.Substring(0, 5));
                    }
                    if (j == 1)
                    {
                        listOfContent.Add(ContentText[j].Text.Substring(0, 12));
                    }
                    if (j == 2)
                    {
                        listOfContent.Add(ContentText[j].Text.Substring(0, 5));
                    }
                    if (j == 3)
                    {
                        listOfContent.Add(ContentText[j].Text.Substring(0, 11));
                    }
                    if (j == 4)
                    {
                        listOfContent.Add(ContentText[j].Text.Substring(0, 12));
                    }
                    Assert.AreEqual(listOfContext[j], listOfContent[j]);
                }
            }
        }

        public void MovieImageNegativeAssertion()
        {
            List<string> listOfMovies = new List<string>();

            for (int i = 0; i < MovieImages.Count(); i++)
            {
                listOfMovies.Add(MovieImages[i].GetAttribute("src").ToString().Substring(0, 1));

                Assert.AreNotSame("http", listOfMovies[i]);
            }
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void OnScreenRedirectionAssertion()
        {
            OnScreenButton.Click();
            StringAssert.Contains("On Screen - Quality Cinema", OnScreenPageTitle);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }
    }
}


