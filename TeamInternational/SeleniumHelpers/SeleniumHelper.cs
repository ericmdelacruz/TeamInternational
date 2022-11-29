using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TeamInternational.Selenium_Helpers
{
    class SeleniumHelper
    {
        public static IWebElement WaitForVisibilityAndSelectElement(IWebDriver driver, By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.System.ELEMENT_TIMEOUT));
            return wait.Until(ExpectedConditions.ElementIsVisible(selector));
        }

        public static IWebElement WaitForExistanceAndSelectElement(IWebDriver driver, By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.System.ELEMENT_TIMEOUT));
            return wait.Until(driver => driver.FindElement(selector));
        }

        public static IWebDriver SwitchFrame(IWebDriver driver, By selector)
        {
            driver.SwitchTo().Frame(WaitForExistanceAndSelectElement(driver, selector));
            return driver;
        }

    }
}
