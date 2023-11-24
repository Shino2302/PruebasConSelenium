using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PruebasConSelenium.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace PruebasConSelenium.CasoDePrueba
{
    public class TestBase
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://campusvirtual.uts.edu.mx/login/index.php");
        }
        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
                Captura.TomarCaptura(Driver);

            if (Driver != null)
                Driver.Quit();

        }
    }
}
