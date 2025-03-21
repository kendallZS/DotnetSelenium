using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //VERSIÓN  4.0 | CASO DE PRUEBA 006
            // Crear la instancia de Selenium Web Driver
            IWebDriver driver = new ChromeDriver();
            // Navegar a la url del sitio de pruebas
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            // Maximizar la ventana del navegador
            driver.Manage().Window.Maximize();

            // Esperar hasta que el botón de navegación del slider esté disponible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement sliderNextButton = wait.Until(drv =>
            {
                var element = drv.FindElement(By.ClassName("carousel-control-next-icon"));
                return element.Displayed && element.Enabled ? element : null;
            });

            // Hacer clic en el botón de navegación del slider
            sliderNextButton.Click();
        }
    }
}
