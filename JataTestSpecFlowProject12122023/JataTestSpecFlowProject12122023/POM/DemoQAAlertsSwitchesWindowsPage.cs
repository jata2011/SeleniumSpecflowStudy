using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace JataTestSpecFlowProject12122023.POM
{
   
    public class DemoQAAlertsSwitchesWindowsPage
    {
        private readonly IWebDriver driver;
        By alertsswitcheswindows = By.XPath("//div[contains(.,'Please select an item from left to start practice.')]");  
        String alertsheadertext;
       

        public DemoQAAlertsSwitchesWindowsPage(IWebDriver driver)
        {

            this.driver = driver;
        }

        public void ValidateDemoQAAlertsSwitchesWindows()
        {

            alertsheadertext = driver.FindElement(alertsswitcheswindows).Text;
            Assert.Equal("Alerts, Frame & Windows\"", alertsheadertext);
        }

    }
}
