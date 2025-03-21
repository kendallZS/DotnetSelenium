using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Test4
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // CASO DE PRUEBA 004: Inicio de sesión.
            // Crear la instancia de Selenium Web Driver
            IWebDriver driver = new ChromeDriver();
            // Navegar a la url del sitio de pruebas
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            // Maximizar la ventana del navegador
            driver.Manage().Window.Maximize();
            // Encontrar el botón "Log in"
            IWebElement webElement = driver.FindElement(By.Id("login2"));
            // Hacer clic en el botón "Log in" para abrir el modal
            webElement.Click();

            // Esperar que el modal de login sea visible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            // Esperar hasta que el campo Username del login sea interactuable
            IWebElement webElement2 = wait.Until(drv =>
            {
                var element = drv.FindElement(By.Id("loginusername"));
                return element.Displayed && element.Enabled ? element : null;
            });
            // Escribir en el campo Username del login.
            webElement2.SendKeys("KendalSelenium@gmail.com");

            // Esperar hasta que el campo Password del login sea interactuable
            IWebElement webElement3 = wait.Until(drv =>
            {
                var element = drv.FindElement(By.Id("loginpassword"));
                return element.Displayed && element.Enabled ? element : null;
            });
            // Escribir en el campo Password del login.
            webElement3.SendKeys("1234");

            // Esperar hasta que el botón "Log in" sea interactuable y hacer clic
            IWebElement loginButton = wait.Until(drv =>
            {
                var element = drv.FindElement(By.XPath("//button[contains(text(), 'Log in')]"));
                return element.Displayed && element.Enabled ? element : null;
            });
            loginButton.Click();
        }
    }
}
