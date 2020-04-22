using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminUsersPage
    {
        public void AdminUserPageElements_Assertion()
        {
            Assert.True(EmailColumn.Displayed);
            Assert.True(DisplayNameColumn.Displayed);
            Assert.True(EditUserButton.Displayed);
            Assert.True(DeleteUserButton.Displayed);
        }
      
    }
}
