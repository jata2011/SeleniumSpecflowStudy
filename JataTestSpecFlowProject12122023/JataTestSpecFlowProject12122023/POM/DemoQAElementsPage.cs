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
    public class DemoQAElementsPage
    {
        private readonly IWebDriver driver;
        By elements = By.XPath("//h5[contains(.,'Elements')]");
        String abc;
        String elementLinkText;

        public DemoQAElementsPage(IWebDriver driver)
        {
           
            this.driver = driver;
        }

        public void ValidateDemoQAHome()
        {
            
            elementLinkText = driver.FindElement(elements).Text;
            Debug.WriteLine("Validate demo qa page testing in progress");
            Debug.WriteLine(elementLinkText);
            abc = "Elements";
            Debug.WriteLine(abc);
            Assert.Equal("Elements", elementLinkText);  
        }


        public void ClickOnElements()
        {
            driver.FindElement(elements).Click();
        }

        public void ValidateElemntsPage()
        {
            driver.FindElement(By.XPath("//div[@class='main-header']")); //driver.FindElement(By.XPath("//div[@class='main-header']"));
        }

      //  [AfterScenario]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
