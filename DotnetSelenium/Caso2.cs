using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // CASO DE PRUEBA 002: completar datos para registrarse y verificar que el campo "password" no permita visualizar los caracteres.
            // Crear la instancia de Selenium Web Driver
            IWebDriver driver = new ChromeDriver();
            // Navegar a la url del sitio de pruebas
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            // Maximizar la ventana del navegador
            driver.Manage().Window.Maximize();
            // Encontrar opci�n de men�
            IWebElement webElement = driver.FindElement(By.Id("signin2"));
            // Click en el elemento
            webElement.SendKeys(Keys.Return);

            // Agregar WebDriverWait para esperar que el modal de login sea visible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            // Esperar hasta que el campo Username est� presente en el DOM y sea interactuable
            IWebElement webElement2 = wait.Until(drv =>
            {
                var element = drv.FindElement(By.Id("sign-username"));
                return element.Displayed && element.Enabled ? element : null;
            });
            // Escribir en el campo Username.
            webElement2.SendKeys("KendalSelenium@gmail.com");

            // Esperar hasta que el campo Password est� presente en el DOM y sea interactuable
            IWebElement webElement3 = wait.Until(drv =>
            {
                var element = drv.FindElement(By.Id("sign-password"));
                return element.Displayed && element.Enabled ? element : null;
            });
            // Escribir en el campo Password.
            webElement3.SendKeys("1234");
        }
    }
}
