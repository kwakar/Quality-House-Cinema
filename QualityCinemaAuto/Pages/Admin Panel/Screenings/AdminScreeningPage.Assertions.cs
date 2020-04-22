using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminScreeningPage
    {

        public void CreateNewScreening()
        { 
         Assert.AreEqual("A Dogs Purpose 2",NewScreening.Text);
         }

        public void CreateScreeningwithoutfield()
        {
            Assert.AreEqual("The MovieId field is required.", MovieIdmessage.Text);
            Assert.AreEqual("The DateTime field is required.", DateTime1message.Text);
        }

        public void ScreeningBackButton()
        {
            Assert.True(NavigationBarHeader.Displayed);
        }

        public void EditCreateScreening()
        {
            Assert.AreEqual("15:15", EditCreateScreening1);
        }

        public void DeleteCreateScreening()
        {
            
            Assert.AreNotEqual("17:17", EditCreateScreening1.Text);
        }
    }
}
