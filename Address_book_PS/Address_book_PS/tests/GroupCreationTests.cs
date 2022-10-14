using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace Address_book_PS
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {

            GroupData group = new GroupData();
            group.Name = "group_name";
            group.Header = "group_header";
            group.Footer = "group_footer";

            appManager.Group.Create(group);
            appManager.Auth.Logout();
        }

    }
}
