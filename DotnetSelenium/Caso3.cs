using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests3
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // CASO DE PRUEBA 3: Registrar cuenta.
            // Crear la instancia de Selenium Web Driver
            IWebDriver driver = new ChromeDriver();
            // Navegar a la url del sitio de pruebas
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            // Maximizar la ventana del navegador
            driver.Manage().Window.Maximize();
            // Encontrar opción de menú
            IWebElement webElement = driver.FindElement(By.Id("signin2"));
            // Click en el elemento
            webElement.SendKeys(Keys.Return);

            // Esperar que el modal de login sea visible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            // Esperar hasta que el campo Username esté presente en el DOM y sea interactuable
            IWebElement webElement2 = wait.Until(drv =>
            {
                var element = drv.FindElement(By.Id("sign-username"));
                return element.Displayed && element.Enabled ? element : null;
            });
            // Escribir en el campo Username.
            webElement2.SendKeys("KendalSelenium@gmail.com");

            // Esperar hasta que el campo Password esté presente en el DOM y sea interactuable
            IWebElement webElement3 = wait.Until(drv =>
            {
                var element = drv.FindElement(By.Id("sign-password"));
                return element.Displayed && element.Enabled ? element : null;
            });
            // Escribir en el campo Password.
            webElement3.SendKeys("1234");

            // Esperar hasta que el botón "Sign up" sea interactuable y hacer clic
            IWebElement signUpButton = wait.Until(drv =>
            {
                var element = drv.FindElement(By.XPath("//button[contains(text(), 'Sign up')]"));
                return element.Displayed && element.Enabled ? element : null;
            });
            signUpButton.Click();
        }
    }
}
