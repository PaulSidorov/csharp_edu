using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Address_book_PS
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected AppManager manager;

        public HelperBase(AppManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }


        public bool IsElementPresent(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }

            catch (NoSuchElementException)
            {
                return false;
            }

        }

        public void TypeText(By element, string text)
        {
            driver.FindElement(element).Click();
            driver.FindElement(element).Clear();
            driver.FindElement(element).SendKeys(text);
        }

        public void SelectDropDown(By element, string text)
        {
            if (text != "")
            {
                driver.FindElement(element).Click();
                new SelectElement(driver.FindElement(element)).SelectByText(text);
            }
        }
    }
}