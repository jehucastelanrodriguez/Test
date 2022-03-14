using System.Threading;
using NUnit.Framework;
using SauceDemo.pages;

namespace Test.tests
{
    public class LoginSuccess:BaseTest
    {
        LoginPage objLogin;
        HomePage objHomePage;

        /**
         * This test case will login in https://www.saucedemo.com/
         * Verify button page is LOGIN
         * Login to application
         * Verify that the user can navigate to the products page
         */
        [Test]
        public void test_Login_Success()
        {
            //Create Login Page object
 
            objLogin = new LoginPage(driver); 

            //login to application
            objLogin.loginToSwagLabs("standard_user", "secret_sauce");
            Thread.Sleep(3000);
            // go the next page
            objHomePage = new HomePage(driver);
            //Verify home page
            Assert.IsTrue(objHomePage.getHomePageDashboardProductText().Contains("PRODUCTS"));
        }
    }
}
