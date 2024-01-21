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
    public class DemoQAElements
    {
        //Objects created for classes and selenium driver
        private readonly IWebDriver driver;
        private readonly DemoQAElementsPage demoQAElementspage;
        private readonly DemoQAHomePage demoQAHomePage;



        // Constructor created to initialize objects created above
        public DemoQAElements()
        {
            driver = new ChromeDriver();
            demoQAElementspage = new DemoQAElementsPage(driver);
            demoQAHomePage = new DemoQAHomePage(driver);

        }

        [Given(@"I am on DemoQA Home Page")]
        public void GivenIAmOnDemoQAHomePage()
        {
            demoQAHomePage.OpenDemoQA();
            demoQAElementspage.ValidateDemoQAHome();


        }

        [When(@"I Click on Elements link")]
        public void WhenIClickOnElementsLink()
        {
            demoQAElementspage.ClickOnElements();
        }


        [Then(@"I Can see the Elements Page")]
        public void ThenICanSeeTheElementsPage()
        {
            demoQAElementspage.ValidateElemntsPage();
            demoQAElementspage.closeBrowser();
        }

    }
}
