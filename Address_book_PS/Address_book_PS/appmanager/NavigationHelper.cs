using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS.appmanager
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(AppManager manager, string baseURL):base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }


        public void OpenGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }


        public void ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }


        public void AddContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }


    }
}
