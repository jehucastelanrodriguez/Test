using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SauceDemo.pages
{
    public class HomePage
    {
        WebDriver driver;

        By homePageProductText = By.ClassName("title");
        By burgerMenu = By.XPath("//*[@id='react-burger-menu-btn']");
        By Logout = By.Id("logout_sidebar_link");
        By Filter = By.ClassName("product_sort_container");
        By FirstPrice = By.XPath("//*[@id='inventory_container']/div/div[1]/div[2]/div[2]/div");
        By Backpack = By.XPath("//*[@id='add-to-cart-sauce-labs-backpack']"); 
        By Bikelight = By.XPath("//*[@id='add-to-cart-sauce-labs-bike-light']");
        By Cart = By.XPath("//*[@id='shopping_cart_container']/a");

        public HomePage(WebDriver driver)
        {
            this.driver = driver;
        }

        //Get the User name from Home Page

        public string getHomePageDashboardProductText()
        {
            return driver.FindElement(homePageProductText).Text;
        }

        public string getPriceoftheFirstProduct()
        {
            return driver.FindElement(FirstPrice).Text;
        }

        public void clickHamburguerMenu()
        {
            driver.FindElement(burgerMenu).Click();
            new WebDriverWait(driver,TimeSpan.FromSeconds(10)).Until(
            ExpectedConditions.VisibilityOfAllElementsLocatedBy(Logout));
        }

        public void clickLogout()
        {
            driver.FindElement(Logout).Click();
        }

        public void clickFilterPriceLowtoHigh()
        {
            IWebElement element = driver.FindElement(Filter);
            SelectElement select = new SelectElement(element);
            select.SelectByText("Price (low to high)");
        }

        public void addCartProducts()
        {
            driver.FindElement(Backpack).Click();
            Thread.Sleep(1000);
            driver.FindElement(Bikelight).Click();
        }

        public void clickCart()
        {
            driver.FindElement(Cart).Click();
        }

        public void logoutSwagLabs()
        {
            //Click Hamburguer Menu
            this.clickHamburguerMenu();
            //Click Logout Option
            this.clickLogout();
        }

    }
}

