using System;
using OpenQA.Selenium;
using PruebasConSelenium.Handler;

namespace PruebasConSelenium.PaginaObjetivo
{
    public class PrincipalPage
    {
        protected IWebDriver Driver;

        protected By Formulario = By.Id("formularioPrincipal");

        public PrincipalPage(IWebDriver driver)
        {
            Driver = driver;

            //Titulo de nuestra página
            if (!Driver.Title.Equals("Inicio"))
                throw new Exception("No te encuentras en 'Inicio'");

        }
        public bool FormularioPresente()
        {
            return WaitHandler.ElementoPresente(Driver,Formulario);
        }
    }
}
