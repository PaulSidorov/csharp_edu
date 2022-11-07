using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace Address_book_PS
{
    [TestFixture]
    public class ContactTests : TestBase
    {

        [Test]
        public void AddContactTest()
        {
           
            app.Navigator.AddContact();

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

            app.Contact.FillContactData(contact)
                              .SubmitContactCreation();
            app.Navigator.ReturnToHomePage();
        }

        [Test]
        public void ModifyContactTest()
        {
            int contactNumber = 1;

            if (app.Contact.ContactExists() == false)
            {
                ContactData contact1 = new ContactData();
                contact1.FirstName = "test_name";
                contact1.LastName = "test_surname";

                app.Navigator.AddContact();
                app.Contact.FillContactData(contact1)
                           .SubmitContactCreation();
                app.Navigator.ReturnToHomePage();
            }

                ContactData contact = new ContactData()
            {
                FirstName = "New First_name",
                MiddleName = "New Midname",
                LastName = "New Last_name",
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

            app.Contact.Edit(contactNumber, contact);
            app.Navigator.ReturnToHomePage();
        }

        [Test]
        public void DeleteContactTest()
        {
            int orderNumber = 1;

            if (app.Contact.ContactExists() == false)
            {
                ContactData contact = new ContactData();
                contact.FirstName = "test_name";
                contact.LastName = "test_surname";

                app.Navigator.AddContact();
                app.Contact.FillContactData(contact)
                           .SubmitContactCreation();
                app.Navigator.ReturnToHomePage();
            }


            app.Contact.Select(orderNumber)
                               .Delete();

            app.AcceptDeletion();
            app.Navigator.ReturnToHomePage();
        }
    }
}
