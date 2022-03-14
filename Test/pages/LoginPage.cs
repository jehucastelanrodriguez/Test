using System;
using OpenQA.Selenium;

namespace SauceDemo.pages
{
    public class LoginPage
    {
        WebDriver driver;
        By Username = By.Name("user-name");
        By Password = By.Name("password");
        By Login = By.Name("login-button");
        By ErrorMessage = By.XPath("//*[@id='login_button_container']/div/form/div[3]/h3");

        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
        }
        //Set user name in username textbox
        public void setUserName(String strUserName)
        {
            driver.FindElement(Username).SendKeys(strUserName);
        }
        //Set password in password textbox
        public void setPassword(String strPassword)
        {
            driver.FindElement(Password).SendKeys(strPassword);
        }
        //Click on login button
        public void clickLogin()
        {
            driver.FindElement(Login).Click();
        }

        public String getLoginPageErrorText()
        {
            return driver.FindElement(ErrorMessage).Text;
        }

        public void loginToSwagLabs(String strUserName, String strPassword)
        {
            //Fill user name
            this.setUserName(strUserName);
            //Fill password
            this.setPassword(strPassword);
            //Click Login button
            this.clickLogin();
        }
    }
}
