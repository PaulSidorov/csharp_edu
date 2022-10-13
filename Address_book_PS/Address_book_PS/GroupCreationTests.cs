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

            OpenHomePage();
            Login(new AccountData("admin","secret"));
            OpenGroupPage();
            CreateNewGroup();

            GroupData group = new GroupData();
            group.Name = "group_name";
            group.Header = "group_header";
            group.Footer = "group_footer";

            FillGroupData(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            Logout();
        }

    }
}
