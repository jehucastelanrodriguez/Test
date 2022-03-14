using System;
using OpenQA.Selenium;

namespace Test.pages
{
    public class YourInformation
    {
        WebDriver driver;

        By firstName = By.XPath("//*[@id='first-name']");
        By lastName = By.XPath("//*[@id='last-name']");
        By zipPostalcode = By.XPath("//*[@id='postal-code']");
        By continueButton = By.XPath("//*[@id='continue']");

        public YourInformation(WebDriver driver)
        {
            this.driver = driver;
        }

        public void setFirstName(String strFirstName)
        {
            driver.FindElement(firstName).SendKeys(strFirstName);
        }
        //Set password in password textbox
        public void setLastName(String strLastName)
        {
            driver.FindElement(lastName).SendKeys(strLastName);
        }

        public void setPostalCode(String strPostalCode)
        {
            driver.FindElement(zipPostalcode).SendKeys(strPostalCode);
        }

        public void clickContinuebutton()
        {
            driver.FindElement(continueButton).Click();
        }

        public void fillYourInformation(String strFirstName, String strLastName, String strPostalCode)
        {
            //Fill First Name
            this.setFirstName(strFirstName);
            //Fill Last Name
            this.setLastName(strLastName);
            //Fill Postal Code
            this.setPostalCode(strPostalCode);
            //Click Continue Button
            this.clickContinuebutton();
        }
    }
}
