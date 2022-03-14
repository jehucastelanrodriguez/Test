using System.Threading;
using OpenQA.Selenium;

namespace Test.pages
{
    public class Overview
    {
        WebDriver driver;

        By title = By.XPath("//*[@id='header_container']/div[2]/span");

        public Overview(WebDriver driver)
        {
            this.driver = driver;
        }

        public string getOverviewTitleText()
        {
            Thread.Sleep(1000);
            return driver.FindElement(title).Text;
        }
    }
}
