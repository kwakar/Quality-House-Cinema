using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    [Author("Ivaylo Nikolov")]
    public partial class RegistrationPage
    {
        public void FillRegistrationForm(RegistrationUser user)
        {
            Email.SendKeys(user.Email);
            Password.SendKeys(user.Password);
            ConfirmPassword.SendKeys(user.ConfirmPassword);
            DisplayName.SendKeys(user.DisplayName);
            YearofBirth.SendKeys(user.YearofBirth);
            RegisterButton.Click();
        }
        public void Watch()
        {
            List<string> listOfRegs = new List<string>();

            for (int i = 0; i < RegPageName.Count(); i++)
            {
                listOfRegs.Add(RegPageName[i].GetAttribute("for").ToString());
            }

            string[] regElements = { "Email", "Password",
                        "Confirm_password", "Display_name", "Year_of_birth" };
            for (int j = 0; j < regElements.Count(); j++)
            {

                Assert.AreEqual(regElements[j], listOfRegs[j]);
            }
        }

        public void Register1()
        {
            List<string> listOfRegsPlaceHoldet = new List<string>();

            for (int n = 0; n < RegPagePlace.Count(); n++)
            {
                listOfRegsPlaceHoldet.Add(RegPagePlace[n].GetAttribute("placeholder").ToString());
            }

            string[] regPlaceholder = { "Email", "Password",
                        "Confirm Password", "User","Select your birth year" };
            for (int k = 0; k < regPlaceholder.Count(); k++)
            {
                if (regPlaceholder[4] == "Select your birth year")
                {
                    Assert.AreEqual("Select your birth year", SelectYearofBirth.Text);
                }
                else
                {
                    Assert.AreEqual(regPlaceholder[k], listOfRegsPlaceHoldet[k]);
                }
            }


        }
    }
}