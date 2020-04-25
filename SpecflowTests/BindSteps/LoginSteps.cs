using System;
using TechTalk.SpecFlow;
using MMVPAutomation.SpecflowPages.Helpers;
using OpenQA.Selenium;

namespace MMVPAutomation.SpecflowTests.BindSteps
{
    [Binding]
    public class LoginSteps
    {       
        [Given(@"I have navigated to MVP website")]
        public void GivenIHaveNavigatedToMVPWebsite()
        {            
            Driver.NavigateUrl();
        }
        
        [Given(@"I click the Sign In link")]
        public void GivenIClickTheSignInLink()
        {
            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
        }
        
        [Given(@"I have entered username")]
        public void GivenIHaveEnteredUsername()
        {
            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("meghna.arora@gmail.com");
        }
        
        [Given(@"I have entered password")]
        public void GivenIHaveEnteredPassword()
        {
            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("meghna");
        }
        
        [When(@"I press the signin button")]
        public void WhenIPressTheSigninButton()
        {
            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
         
        }
        
        [Then(@"I am taken to the profile page")]
        public void ThenIAmTakenToTheProfilePage()
        {
            Driver.TurnOnWait();            
            // Screenshot
            Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\Meghna\\source\\repos\\MMVPAutomation\\TestReports\\login_"+ DateTime.Now.ToString(("_dd-mm-yyyy_mss")) + ".jpeg");
            
            //Close the browser
            //Driver.driver.Close();
        }
    }
}
