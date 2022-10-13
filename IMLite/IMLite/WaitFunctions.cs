using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMLite
{
    internal class WaitFunctions
    {
        public static void WaitUntilVisible (IWebDriver driver, By locator)
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

        }
    }
}
