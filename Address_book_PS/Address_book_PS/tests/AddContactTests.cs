using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Address_book_PS.model;
using Address_book_PS.tests;
using NUnit.Framework;


namespace Address_book_PS
{
    [TestFixture]
    public class AddContactTests : TestBase
    {

        [Test]
        public void AddContactTest()
        {
           
            appManager.Navigator.AddContact();

            ContactData contact = new ContactData()
            {
                FirstName = "First_name",
                MiddleName = "Midname",
                LastName = "Last_name",
                NickName = "nick",
                Title = "title data",
                Company = "company name",
                Address = "addr",
                TelHome = "123",
                TelMobile = "5-33",
                TelWork = "444",
                TelFax = "",
                Email = "mail@mail",
                Email2 = "mail2@mail",
                Email3 = "mail3@mail",
                Homepage = "homepage data",
                BirthDay = "2",
                BirthMonth = "May",
                BirthYear = "1988",
                AnniversaryDay = "5",
                AnniversaryMonth = "March",
                AnniversaryYear = "1977",
                SecondaryAddress = "sec addr",
                SecondaryTelHome = "home number",
                Notes = "some notes"
            };

            appManager.Contact.FillContactData(contact)
                              .SubmitContactCreation();
            appManager.Navigator.ReturnToHomePage();
        }

    }
}
