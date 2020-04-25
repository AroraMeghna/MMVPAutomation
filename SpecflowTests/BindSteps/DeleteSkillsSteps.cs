using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using MMVPAutomation.SpecflowPages.Pages;
using MMVPAutomation.SpecflowPages.Helpers;

namespace MMVPAutomation.SpecflowTests.BindSteps
{
    [Binding]
    public class DeleteSkillsSteps
    {
        [Given(@"I have logged in to MVP and on a skills tab")]
        public void GivenIHaveLoggedInToMVPAndOnASkillsTab()
        {
            //Login to MVP portal
            SignIn.SigninStep();

            //Go to skills tab
            Driver.driver.FindElement(By.XPath("//A[@data-tab='second'][text()='Skills']")).Click();
        }
        
        [When(@"I click on delete skills icon")]
        public void WhenIClickOnDeleteSkillsIcon()
        {
            try
            {
                Driver.driver.FindElement(By.XPath("//td[text()='Test Analyst1']//following-sibling::td[@class='right aligned']//i[@class='remove icon']")).Click();
                Thread.Sleep(10000);
                Driver.TurnOnWait();
            }
            catch (NoSuchElementException)
            {
                //System.out.println(“WebDriver couldn’t locate the element”);
                //Log($"Test Analyst1 skill not found to delete");
                Driver.NavigateUrl();
            }
        }

        [Then(@"I should be able to delete selected skills")]
        public void ThenIShouldBeAbleToDeleteSelectedSkills()
        {
            //Going to skills page for verification
            Driver.driver.FindElement(By.XPath("//A[@data-tab='second'][text()='Skills']")).Click();
            Thread.Sleep(5000);
            Driver.TurnOnWait();
            

            // Screenshot
            Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\Meghna\\source\\repos\\MMVPAutomation\\TestReports\\skillsDeleted_" + DateTime.Now.ToString(("_dd-mm-yyyy_mss")) + ".jpeg");
        }
    }
}
