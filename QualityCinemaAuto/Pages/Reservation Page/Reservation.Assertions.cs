using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace QualityCinemaAuto.Pages
{
    [Author("Ivaylo Nikolov")]
    public partial class ReservationPage
    {


        public void Watch()
        {
            List<string> listOfElements = new List<string>();

            for (int i = 0; i < ReservpagElements.Count(); i++)
            {
                listOfElements.Add(ReservpagElements[i].Text.ToString());
            }

            string[] ConstantElements = { "Movie", "Summary", "Release Date","Genre", "Running Time","Screening date",
            "Screening time", "Available tickets", "Seats", ""};
            for (int j = 0; j < ConstantElements.Count(); j++)
            {

                Assert.AreEqual(ConstantElements[j], listOfElements[j]);
            }
        }

        public void AssertErrorMessageNote(string expected)
        {
            Assert.AreEqual(expected, ReservpagElementsNote.Text);
        }

        public void AssertErrorMessageNoteDown(string expected)
        {
            Assert.AreEqual(expected, ReservpagElementsNoteDown.Text);
        }

        public void AssertErrorMessageDropDown(string expected)
        {
            Assert.AreEqual(expected, ReservpagElementsdropdown.Text);
        }


        public void AssertErrorMessagePopIn(string expected)
        {
            Assert.AreEqual(expected, ReservePOpIn.Text);
        }
        public void AssertErrorMessagePopInText(string expected)
        {
            Assert.AreEqual(expected, ReservePOpInText.Text);
        }
        public void AssertErrorMessagePopInLog(string expected)
        {
            Assert.AreEqual(expected, ReservePOpInLog.Text);
        }
        public void AssertErrorMessagePopInReg(string expected)
        {
            Assert.AreEqual(expected, ReservePOpInReg.Text);
        }

        public void AssertErrorMessageRedirect(string expected)
        {
            Assert.AreEqual(expected, ReserveredirectReg.Text);
        }

        public void AssertErrorMessageRedirectLog(string expected)
        {
            Assert.AreEqual(expected, ReserveredirectLog.Text);
        }

        public void AssertErrorMessageNoteandLabel(string expected)
        {
            Assert.AreEqual(expected, expected, ReservpagElementsNoteDown.Text, ReservpagElementsNote.Text);
        }

        public void AssertErrorMessageTwoButton(string expected)
        {
            Assert.AreEqual(expected, expected, ReservePOpInLog.Text, ReservePOpInReg.Text);
        }

        public void NavigationBarIsVisible_Assertion()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void FooterIsVisible_Assertion()
        {
            Assert.True(FooterElement.Displayed);
        }

        public void WatchButtonRedirectionAssertion()
        {
            string movieTitleOnHomePage = HomePage._titleOnHomePage;

            StringAssert.Contains(movieTitleOnHomePage, MovieTitleOnMoviePage.Text);
        }

        public void MovieCoverRedirectionAssertion()
        {
            string movieTitleOnHomePage = HomePage._titleOnHomePage;

            StringAssert.Contains(movieTitleOnHomePage, MovieTitleOnMoviePage.Text);
        }

        public void TrailerAvailabiltiy_Assertion()
        {
            Assert.True(TrailerVideo.Displayed);
        }

        public void TrailerIsPlayed_Assertion()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(PlayingVideo);

            Assert.True(TrailerVidePauseButton.Displayed);
        }
    }
}