using System.Threading;
using NUnit.Framework;
using SauceDemo.pages;

namespace Test.tests
{
    class SortProducts : BaseTest
    {
        LoginPage objLogin;
        HomePage objHomePage;

        /**
         * This test case will login in https://www.saucedemo.com/
         * Login to application
         * Click Filter Products button
         * Verify that the Products are filtered correctly from low to high
         */
        [Test]
        public void test_Products_Filter()
        {
            //Create Login Page object

            objLogin = new LoginPage(driver);

            //login to application
            objLogin.loginToSwagLabs("standard_user", "secret_sauce");
            Thread.Sleep(3000);
            // go the next page
            objHomePage = new HomePage(driver);
            //Verify home page
            objHomePage.clickFilterPriceLowtoHigh();
            Assert.IsTrue(objHomePage.getPriceoftheFirstProduct().Contains("$7.99"));
        }
    }
}




