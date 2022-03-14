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
         * Verify button page is LOGIN
         * Login to application
         * Verify that the user can navigate to the products page
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
            //Verify home page
            objHomePage.addCartProducts();
            objHomePage.clickCart();

            objCart = new Cart(driver);
            objCart.clickCheckoutbutton();

            objYourInformation = new YourInformation(driver);
            objYourInformation.fillYourInformation("Jehu", "Castelan", "08800");

            objOverview = new Overview(driver);
            Assert.IsTrue(objOverview.getOverviewTitleText().Contains("CHECKOUT: OVERVIEW"));
        }
    }
}
