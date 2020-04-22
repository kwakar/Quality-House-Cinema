using NUnit.Framework;

namespace QualityCinemaAuto.Pages
{
    public partial class AdminEditUsersPage
    {
        public void EditUsersRedirectionAssertion()
        {
            StringAssert.Contains("Edit - Quality Cinema", EditUsersPageTitile);
        }
    }
}
