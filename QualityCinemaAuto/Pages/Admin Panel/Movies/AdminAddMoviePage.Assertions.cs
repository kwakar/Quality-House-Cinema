using System;
using System.IO;
using System.Xml.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminAddMoviePage
    {
        public void TrailerFieldAvailability_Assertion()
        {
            Assert.True(TrailerField.Displayed);
        }

    }
}
