using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Address_book_PS
{
    public class ContactHelper : HelperBase
    {
        private string baseUrl;


        public ContactHelper(AppManager manager, string url) : base(manager)
        {
            baseUrl = url;
        }


       
        public ContactHelper Edit(int number, ContactData contact)
        {
            InitContactUpdate(number);
            FillContactData(contact);
            SubmitContactUpdate();

            return this;
        }

        
        
        public ContactHelper InitContactUpdate(int number)
        {

            driver.FindElements(By.CssSelector("img[alt='Edit']"))[number-1].Click();


            return this;
        }

        public ContactHelper SubmitContactUpdate()
        {
            driver.FindElement(By.Name("update")).Click();

            return this;
        }



        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();

            return this;
        }

        public ContactHelper FillContactData(ContactData contact)
        {
            TypeText(By.Name("firstname"), contact.FirstName);
            TypeText(By.Name("middlename"), contact.MiddleName);
            TypeText(By.Name("lastname"), contact.LastName);
            TypeText(By.Name("nickname"), contact.NickName);
            TypeText(By.Name("title"), contact.Title);
            TypeText(By.Name("company"), contact.Company);
            TypeText(By.Name("address"), contact.Address);
            TypeText(By.Name("home"), contact.TelHome);
            TypeText(By.Name("work"), contact.TelWork);
            TypeText(By.Name("fax"), contact.TelFax);
            TypeText(By.Name("email"), contact.Email);
            TypeText(By.Name("email2"), contact.Email2);
            TypeText(By.Name("email3"), contact.Email3);
            TypeText(By.Name("homepage"), contact.Homepage);
          
            TypeText(By.Name("byear"), contact.BirthYear);
            TypeText(By.Name("ayear"), contact.AnniversaryYear);
            TypeText(By.Name("address2"), contact.SecondaryAddress);
            TypeText(By.Name("phone2"), contact.SecondaryTelHome);
            TypeText(By.Name("notes"), contact.Notes);


            SelectDropDown(By.Name("bday"), contact.BirthDay);
            SelectDropDown(By.Name("bmonth"), contact.BirthMonth);
            SelectDropDown(By.Name("aday"), contact.AnniversaryDay);
            SelectDropDown(By.Name("amonth"), contact.AnniversaryMonth);

                       

            return this;
        }

        public ContactHelper Select(int number)
        {
            
            if(ContactExists() == false)
            {
                FillContactData(new ContactData());
                SubmitContactCreation();
                manager.Navigator.ReturnToHomePage();
            }

            driver.FindElement(By.XPath("//tr[" + (number+1).ToString() + "]/td/input")).Click();
         
            return this;
        }

        public ContactHelper Delete()
        {
            driver.FindElement(By.CssSelector("input[value='Delete']")).Click();
            return this;
        }

        public bool ContactExists()
        {
            if (IsElementPresent(By.Name("selected[]"))  &&  driver.Url == baseUrl )
            { return true; }
            else { return false; }
        }

    }
}
