using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PruebasConSelenium.CasoDePrueba
{
    [TestFixture]
    public class LoginTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("");
        }
        [Test]
        public void PruebaLograda()
        {
            //Login
        }
        [TearDown]
        public void AfterTest()
        {
            if(Driver != null)
                Driver.Quit();
        }
    }
}
