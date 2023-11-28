using OpenQA.Selenium;
using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace PruebasConSelenium.Handler
{
    public class Captura
    {
        private static string ImagePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static string TomarCaptura(IWebDriver driver)
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            string pathDeImagen = ImagePath + "//img" + milliseconds + ".png";
            Screenshot imagen = ((ITakesScreenshot)driver).GetScreenshot();
            imagen.SaveAsFile(ImagePath, ScreenshotImageFormat.Png);

            return pathDeImagen;
        }
    }
}
