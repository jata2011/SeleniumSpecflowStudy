using JataTestSpecFlowProject12122023.POM;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JataTestSpecFlowProject12122023.StepDefinitions
{
    [Binding]
    public class DemoQAAlertsSwitchesWindows
    {
        //Objects created for classes and selenium driver
        private readonly IWebDriver driver;
        private readonly DemoQAAlertsSwitchesWindowsPage demoQAAlertsSwitchesWindows;
        private readonly DemoQAHomePage demoQAHomePage;



        // Constructor created to initialize objects created above
        public DemoQAAlertsSwitchesWindows()
        {
            driver = new ChromeDriver();
            demoQAAlertsSwitchesWindows = new DemoQAAlertsSwitchesWindowsPage(driver);
            demoQAHomePage = new DemoQAHomePage(driver);

        }

        [Given(@"I am on DemoQA Home Page")]
        public void GivenIAmOnDemoQAHomePage()
        {
            demoQAHomePage.OpenDemoQA();
            //Validate we are on home page


        }

        [When(@"I Click on AlertsSwitchesWindows link")]
        public void WhenIClickOnAlertsSwitchesWindowsLink()
        {
            
            
        }


        [Then(@"I Can see the AlertsSwitchesWindows Page")]
        public void ThenICanSeeTheAlertsSwitchesWindowsPage()
        {
           
        }

    }
}
