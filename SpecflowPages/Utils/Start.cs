using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TechTalk.SpecFlow;
using MMVPAutomation.SpecflowPages.Helpers;
using MMVPAutomation.SpecflowPages.Pages;

namespace MMVPAutomation.SpecflowPages.Utils
{
    [Binding]
    public class Start : Driver
    {  
        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            Thread.Sleep(5000);

            //call the SignIn class
            //SignIn.SigninStep();
        }
     /*   
        [AfterScenario]
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
           test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();
             
            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);
            
            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();
           

        }
        */
    }
}
