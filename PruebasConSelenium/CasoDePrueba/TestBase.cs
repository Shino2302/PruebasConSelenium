using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PruebasConSelenium.Handler;

namespace PruebasConSelenium.CasoDePrueba
{
    public class TestBase
    {
        protected IWebDriver Driver;


        //Esta es una Etiqueta de metadatos con la que le indicamos a NUnit
        //Que hacer antes de la prueba:
        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://campusvirtual.uts.edu.mx/login/index.php");
        }
        //Este es el caso contrario de la anterior y es donde indicamos que hacer
        //despues del Test
        [TearDown]
        public void AfterTest()
        {
            if (Driver != null)
                Driver.Quit();
        }
    }
}
