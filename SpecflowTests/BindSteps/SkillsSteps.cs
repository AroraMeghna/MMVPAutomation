using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using MMVPAutomation.SpecflowPages.Pages;
using MMVPAutomation.SpecflowPages.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MMVPAutomation.SpecflowTests.BindSteps
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"I have logged in to MVP Portal and clicked on skills tab")]
        public void GivenIHaveLoggedInToMVPPortalAndClickedOnSkillsTab()
        {
            //Login to MVP portal
            SignIn.SigninStep();

            //Go to skills tab
            Driver.driver.FindElement(By.XPath("//A[@data-tab='second'][text()='Skills']")).Click();
        }
        
        [When(@"I click on add new button on skills tab")]
        public void WhenIClickOnAddNewButtonOnSkillsTab()
        {
            //Clicking on adding new skills button
            Driver.driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[@class='ui teal button'][text()='Add New']")).Click();
        }
        
        [When(@"I Add skills as '(.*)'")]
        public void WhenIAddSkillsAs(string testSkills)
        {
            //Adding new skill
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text' and @placeholder='Add Skill'])")).SendKeys(testSkills);
        }
        
        [When(@"I select skill level '(.*)'")]
        public void WhenISelectSkillLevel(string levelSkills)
        {
            // select the drop down list
            var skillLevel = Driver.driver.FindElement(By.Name("level"));
            //create select element object 
            var selectElement = new SelectElement(skillLevel);
            // select by text
            selectElement.SelectByText(levelSkills);

            Thread.Sleep(2000);
        }

        [When(@"I press click Add button to add skill")]
        public void WhenIPressClickAddButtonToAddSkill()
        {
            // Adding skills as beginner
            Driver.driver.FindElement(By.XPath("(//input[@class='ui teal button '])")).Click();
        }

        [Then(@"I should be able add and view new skills to my profile")]
        public void ThenIShouldBeAbleAddAndViewNewSkillsToMyProfile()
        {
            //Going to skills page
            Driver.driver.FindElement(By.XPath("//A[@data-tab='second'][text()='Skills']")).Click();

            // Assert to verify that the "Test Analyst1" skills is added and is visible
            IWebElement element = Driver.driver.FindElement(By.XPath("//td[text()='Test Analyst1']"));            
            //IWebElement element = Driver.driver.FindElement(By.XPath("//td[text()='Test Analyst1'] or [text()='Selenium Web']"));
            Assert.IsTrue(element.Text.Equals("Test Analyst1"));                       
            Driver.TurnOnWait();

            // Screenshot
            Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\Meghna\\source\\repos\\MMVPAutomation\\TestReports\\skillsAdded_" + DateTime.Now.ToString(("_dd-mm-yyyy_HHmmss")) + ".jpeg");
        }
    }
}
