using OpenQA.Selenium;

namespace IMLite
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()

        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://imlite-demo.highqa.com/");

             
            // вводим логин, пароль, кликаем кнопку Login
            
            var fieldUsername = By.CssSelector("span[data-field='UsernameField'] > input");
            WaitFunctions.WaitUntilVisible(driver, fieldUsername);
            driver.FindElement(fieldUsername).SendKeys("admin");

            var fieldPassword = By.CssSelector("input[data-field='PasswordField']");
            WaitFunctions.WaitUntilVisible(driver, fieldPassword);
            driver.FindElement(fieldPassword).SendKeys("Admin");

            var buttonLogin = By.CssSelector("a[data-button='SignIn']");
            driver.FindElement(buttonLogin).Click();

            
            // нажимаем кнопку основного меню
            
            var buttonMenu = By.CssSelector("a[data-button='Menu']");
            WaitFunctions.WaitUntilVisible(driver, buttonMenu);
            driver.FindElement(buttonMenu).Click();




            var itemPurchaseOrders = By.CssSelector("a[title = 'Purchase Orders']");
            WaitFunctions.WaitUntilVisible(driver, itemPurchaseOrders);
            driver.FindElement(itemPurchaseOrders).Click();


          






        }
    }
}