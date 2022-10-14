using Address_book_PS.appmanager;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_PS
{
    public class AppManager
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected ContactHelper contactHelper;
        protected GroupHelper groupHelper;

        public AppManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:8080/addressbook/";
            verificationErrors = new StringBuilder();

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            contactHelper = new ContactHelper(this);
            groupHelper = new GroupHelper(this);

        }

        public IWebDriver Driver 
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get { return loginHelper; }
        }

        public NavigationHelper Navigator
        {
            get { return navigationHelper; }
        }

        public ContactHelper Contact
        {
            get { return contactHelper; }
        }

        public GroupHelper Group
        {
            get { return groupHelper; }
        }

      

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
            }
        }
    }
    
}
