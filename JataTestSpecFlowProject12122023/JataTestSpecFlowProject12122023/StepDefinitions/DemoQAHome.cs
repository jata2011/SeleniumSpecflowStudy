using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using OpenQA.Selenium.Firefox;
using Gherkin.CucumberMessages.Types;
using LivingDoc.Dtos;
using JataTestSpecFlowProject12122023.POM;
using OpenQA.Selenium.Interactions;


namespace JataTestSpecFlowProject12122023.StepDefinitions
{
    [Binding]
    public class DemoQA    {
        //Objects created for classes and selenium driver
        private readonly IWebDriver driver;
        private readonly DemoQAHomePage demoQAHomePage;

        // Constructor created to initialize objects created above
        public DemoQA()
        {

              driver = new ChromeDriver();
              demoQAHomePage = new DemoQAHomePage(driver);
        }



        [Given(@"I am on the DemoQA website")]
        public void GivenIAmOnTheDemoQAWebsite()
        {
            demoQAHomePage.OpenDemoQA();
        }


        [Then(@"I should see following Tabs Elements, Forms, Alerts Frame and Windows, Widgets, Interactions")]
        public void ThenIShouldSeeFollowingTabsElementsFormsAlertsFrameAndWindowsWidgetsInteractions()
        {
            demoQAHomePage.ValidateDemoQAHomePage();
            demoQAHomePage.BrowserClose();
        }

    }
}