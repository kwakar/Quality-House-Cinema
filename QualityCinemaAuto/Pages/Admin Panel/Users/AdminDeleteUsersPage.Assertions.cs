using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminDeleteUsersPage
    {
        public void DeletePopupAssertion()
        {
            Assert.AreEqual("Are you sure you want to delete user with email admin@qc.com?", DeleteUserMessage.Text);

        }
    }
}
