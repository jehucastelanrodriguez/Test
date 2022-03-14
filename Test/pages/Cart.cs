using OpenQA.Selenium;

namespace Test.pages
{
    public class Cart
    {
        WebDriver driver;

        By firstTitleItemCart = By.XPath("//*[@id='item_4_title_link']/div");
        By secondTitleItemCart = By.XPath("//*[@id='item_0_title_link']/div");//*[@id="checkout"]
        By checkoutButton = By.XPath("//*[@id='checkout']");

        public Cart(WebDriver driver)
        {
            this.driver = driver;
        }

        public string getFirstCartProduct()
        {

            return driver.FindElement(firstTitleItemCart).Text;

        }

        public string getSecondCartProduct()
        {

            return driver.FindElement(secondTitleItemCart).Text;

        }

        public void clickCheckoutbutton()
        {
            driver.FindElement(checkoutButton).Click();
        }

    }
}
