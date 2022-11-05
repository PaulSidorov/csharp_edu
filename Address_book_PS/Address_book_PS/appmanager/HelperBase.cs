using OpenQA.Selenium;

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

       

    }
}