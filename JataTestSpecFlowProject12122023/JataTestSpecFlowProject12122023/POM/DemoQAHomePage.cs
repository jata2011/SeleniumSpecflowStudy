using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace JataTestSpecFlowProject12122023.POM
{
    public class DemoQAHomePage
    {
        private readonly IWebDriver driver;
        readonly By elements = By.XPath("/html/body/div[2]/div/div/div[2]/div/div[1]/div/div[3]/h5"); //By.XPath("//h5[contains(.,'Elements')]");
        readonly By forms = By.XPath("/html/body/div[2]/div/div/div[2]/div/div[2]/div/div[3]/h5");  //h5[contains(.,'Forms')]");
        readonly By alerts = By.XPath("/html/body/div[2]/div/div/div[2]/div/div[3]/div/div[3]/h5");  //h5[contains(.,'Alerts, Frame & Windows')]");
        readonly By widgets = By.XPath("/html/body/div[2]/div/div/div[2]/div/div[4]/div/div[3]/h5");   //div[contains(.,'Widgets')]");
        readonly By interactions = By.XPath("/html/body/div[2]/div/div/div[2]/div/div[5]/div/div[3]/h5");  //h5[contains(.,'Interactions')]");

        public DemoQAHomePage(IWebDriver driver)
        {
           this.driver = driver;
        }
        
        public void OpenDemoQA()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            //Applying Implicit Wait command for 20 seconds

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

       
        public void ValidateDemoQAHomePage()
        {
             driver.FindElement(By.XPath("//h5[contains(.,'Elements')]"));
             driver.FindElement(By.XPath("//h5[contains(.,'Forms')]"));
             driver.FindElement(By.XPath("//h5[contains(.,'Alerts, Frame & Windows')]"));
             driver.FindElement(By.XPath("//div[contains(.,'Widgets')]"));
             driver.FindElement(By.XPath("//h5[contains(.,'Interactions')]"));
            

            /*
            String elementLinkText = driver.FindElement(elements).Text;
            Assert.Equal("Elements", elementLinkText);

            String formsLinkText = driver.FindElement(forms).Text;
            Assert.Equal("Forms", formsLinkText);


            String alertLinkText = driver.FindElement(alerts).Text;
            Assert.Equal("Alerts, Frame & Windows", alertLinkText);


            String widgetsLinkText = driver.FindElement(widgets).Text;
            Assert.Equal("Elements", widgetsLinkText);

            String interactionsLinkText = driver.FindElement(interactions).Text;
            Assert.Equal("Elements", interactionsLinkText);
            */


        }

        public void ClickOnElements()
        {
            driver.FindElement(elements).Click();
        }

        public void ClickOnForms()
        {
            driver.FindElement(forms).Click();
        }

        public void ClickOnAlerts()
        {
            driver.FindElement(alerts).Click();
        }


        public void ClickOnWidgets()
        {
            driver.FindElement(widgets).Click();
        }


        public void ClickOnInteractions()
        {
            driver.FindElement(interactions).Click();
        }

        //[AfterScenario]
        public void BrowserClose()
        {
            driver.Quit();
        }


    }
}
