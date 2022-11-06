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
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected ContactHelper contactHelper;
        protected GroupHelper groupHelper;

        private static AppManager instance;

        private AppManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:8080/addressbook/";

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            contactHelper = new ContactHelper(this, baseURL);
            groupHelper = new GroupHelper(this);

        }
        
        public static AppManager GetInstance()
        {
            if (instance == null)
            {
                instance = new AppManager();
            }
            return instance;
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

       
        public void AcceptDeletion()
        {
            driver.SwitchTo().Alert().Accept();
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
