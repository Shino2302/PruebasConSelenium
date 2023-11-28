using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PruebasConSelenium.PaginaObjetivo;
using PruebasConSelenium.Handler;

namespace PruebasConSelenium.CasoDePrueba
{
    //Con estos metadatos indicamos que esta sera una
    //clase donde se ejecutaran pruebas
    [TestFixture]
    public class LoginTest : TestBase
    {

        //Con TestCase se pueden automatizar varias formas de los casos de prueba
        //*Nota* cada uno de los TestCase hara que se ejecuten tantas pruebas como se
        //le indique, en este caso tendremos 3:
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
