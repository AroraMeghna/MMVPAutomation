using MMVPAutomation.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMVPAutomation.SpecflowPages.Pages
{
    public class SignIn
    {
        public static void SigninStep()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            //Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("mvpstudio.qa@gmail.com");             
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("meghna.arora@gmail.com");
            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("meghna");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }
    }
}
