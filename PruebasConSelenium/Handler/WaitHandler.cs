using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PruebasConSelenium.Handler
{
    public class WaitHandler
    {
        public static bool ElementoPresente(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(dvr => dvr.FindElement(locator));
                return true;
            }
            catch { }
            return false;
        }
    }
}
