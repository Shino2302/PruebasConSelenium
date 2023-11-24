using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PruebasConSelenium.PaginaObjetivo;

namespace PruebasConSelenium.CasoDePrueba
{
    [TestFixture]
    public class LoginTest : TestBase
    {

        //Con TestCase se pueden automatizar varias formas de los casos de prueba
        [TestCase("admin", "123456")]
        [TestCase("admin1", "123456")]
        [TestCase("admin2", "123456")]
        public void PruebaLograda(string nombre, string password)
        {
            Login login = new Login(Driver);
            PrincipalPage paginaPrincipal = login.LoginAs(nombre, password);
            //En caso de encontrar el formulario principal se marca como prueba correcta
            Assert.IsTrue(paginaPrincipal.FormularioPresente());
        }
    }
}
