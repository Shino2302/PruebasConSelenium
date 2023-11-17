using System;
using OpenQA.Selenium;

namespace PruebasConSelenium.PaginaObjetivo
{
    public class PrincipalPage
    {
        protected IWebDriver Driver;

        protected By UserInput = By.Id("user");
        protected By PasswordInput = By.Id("pass");
        protected By LoginButton = By.Id("loginButton");

        public PrincipalPage(IWebDriver driver)
        {
            Driver = driver;

            //Titulo de nuestra página
            if (!Driver.Title.Equals("Inicio"))
                throw new Exception("No te encuentras en 'Inicio'");

        }
    }
}
