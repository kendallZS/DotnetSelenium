using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests5
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // CASO DE PRUEBA 005: Clic en la categoría.
            // Crear la instancia de Selenium Web Driver
            IWebDriver driver = new ChromeDriver();
            // Navegar a la url del sitio de pruebas
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            // Maximizar la ventana del navegador
            driver.Manage().Window.Maximize();

            // Esperar hasta que el botón "Laptops" esté disponible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement categoryLaptops = wait.Until(drv =>
            {
                var element = drv.FindElement(By.XPath("//a[contains(text(), 'Laptops')]"));
                return element.Displayed && element.Enabled ? element : null;
            });

            // Hacer clic en la categoría "Laptops"
            categoryLaptops.Click();
        }
    }
}
