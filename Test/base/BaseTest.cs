using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    public class BaseTest
{
        public WebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            //  Start Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]
        public void close_Browser()
        {
            // Close Local Selenium WebDriver
            driver.Close();
        }


    }
}
