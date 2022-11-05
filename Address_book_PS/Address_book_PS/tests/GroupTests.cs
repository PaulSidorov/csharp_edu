using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace Address_book_PS
{
    [TestFixture]
    public class GroupTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {

            GroupData group = new GroupData();
            group.Name = "group_name";
            group.Header = "group_header";
            group.Footer = "group_footer";

            app.Group.Create(group);
            app.Auth.Logout();
        }

        [Test]

        public void GroupUpdateTest()
        {
            int groupNumber = 1;
            GroupData groupUpdated = new GroupData();
            groupUpdated.Name = "new group_name";
            groupUpdated.Header = "new group_header";
            groupUpdated.Footer = "new group_footer";

            app.Navigator.OpenGroupsPage();
            app.Group.Edit(groupNumber,groupUpdated)
                     .ReturnToGroupPage();

        }

        [Test]

        public void GroupDeleteTest()
        {
            int groupNumber = 1;
            app.Navigator.OpenGroupsPage();
            app.Group.SelectGroup(groupNumber)
                     .InitDeleteGroup()
                     .ReturnToGroupPage();

        }

    }
}
