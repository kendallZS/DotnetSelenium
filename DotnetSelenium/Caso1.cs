using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // CASO DE PRUEBA 1: verificar que al hacer clic sobre la opción "Sign up", se muestre una ventana con el formulario.
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
        }
    }
}
