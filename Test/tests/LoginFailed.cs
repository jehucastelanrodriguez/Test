using System.Threading;
using NUnit.Framework;
using SauceDemo.pages;

namespace Test.tests
{
    public class LoginFailed : BaseTest
    {
        LoginPage objLogin;

        /**
         * This test case will login fail on https://www.saucedemo.com/
         * Login to App using wrong credentials
         * Login to application
         * Verify that the user can navigate to the products page
         */
        [Test]
        public void test_Login_Failed()
        {
            //Create Login Page object

            objLogin = new LoginPage(driver);

            //login to application using wrong credentials
            objLogin.loginToSwagLabs("standard_use", "secret_sauce");
            Thread.Sleep(3000);
            //Verify Error Message when trying to login
            Assert.IsTrue(objLogin.getLoginPageErrorText().Contains("Epic sadface: Username and password do not match any user in this service"));
        }
    }
}
