using System;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;

namespace PruebasConSelenium.PaginaObjetivo
{
    public class Login 
    {
        //Driver para uso de Selenium
        protected IWebDriver Driver;


        //Con estas variables representaremos los datos dentro
        //de nuestra página
        protected By UserInput = By.Name("username");
        protected By PasswordInput = By.Name("password");
        protected By LoginButton = By.Id("loginbtn");

        //Constructor para indicar en donde comenzaremos la prueba
        public Login(IWebDriver driver)
        {
            Driver = driver;

            //Titulo de nuestra página
            if (!Driver.Title.Equals("Campus Virtual Universitario: Ingresar al sitio"))
                throw new Exception("No te encuentras en el Login");

        }
        //Metodo para escribir al usuario:
        public void TypeUserName(string user)
        {
            Driver.FindElement(UserInput).SendKeys(user);
        }
        //Metodo para escribir la contraseña:
        public void TypePassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);
        }
        public void ClickButton()
        {
            Driver.FindElement(LoginButton).Click();
        }
        public PrincipalPage LoginAs(string user, string pass)
        {
            TypeUserName(user);
            TypePassword(pass);
            ClickButton();
            return new PrincipalPage(Driver);
        }
    }
}
