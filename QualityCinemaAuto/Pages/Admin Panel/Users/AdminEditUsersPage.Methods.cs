using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminEditUsersPage 

    {
        public void EditUsersLists()
        {
            List<string> listOfUsers = new List<string>();

            for (int i = 0; i < UserPageName.Count(); i++)
            {
                listOfUsers.Add(UserPageName[i].GetAttribute("td").ToString());
            }

            string[] usersElements = { "Email", "Display_name" };
            for (int j = 0; j < usersElements.Count(); j++)
            {

                Assert.AreEqual(usersElements[j], listOfUsers[j]);
            }
        }




    }
}


