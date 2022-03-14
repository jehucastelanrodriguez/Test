using System.Threading;
using NUnit.Framework;
using SauceDemo.pages;
using Test.pages;

namespace Test.tests
{
    public class CompleteOrder : BaseTest
    {
        LoginPage objLogin;
        HomePage objHomePage;
        Cart objCart;
        YourInformation objYourInformation;
        Overview objOverview;

        /**
         * This test case will login in https://www.saucedemo.com/
         * Add Products to the Cart
         * Click the Checkout button
         * Fill Info in your information screen
         * Verify the user is on CheckoutPage
         */
        [Test]
        public void test_Complete_Order_Correctly()
        {
            //Create Login Page object

            objLogin = new LoginPage(driver);

            //login to application
            objLogin.loginToSwagLabs("standard_user", "secret_sauce");
            Thread.Sleep(3000);
            // go the next page
            objHomePage = new HomePage(driver);
            //Add Prodcuts to the Cart
            objHomePage.addCartProducts();
            objHomePage.clickCart();
            //Click Checkout button in Cart
            objCart = new Cart(driver);
            objCart.clickCheckoutbutton();
            //Fill Information on your information screen
            objYourInformation = new YourInformation(driver);
            objYourInformation.fillYourInformation("Jehu", "Castelan", "08800");
            //Verify user is on Checkout page
            objOverview = new Overview(driver);
            Assert.IsTrue(objOverview.getOverviewTitleText().Contains("CHECKOUT: OVERVIEW"));
        }
    }
}
