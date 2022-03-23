using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using JataSpecflow_Project;

namespace JataSpecflow_Project.Pages
{
    class EducationPage : DriverHelper
    {
      
        IWebElement Educationbanner => driver.FindElement(By.XPath("//a[@title='banner link']"));

        public void ClickBanner()
        {
            // Educationbanner.Click();
            Console.WriteLine("In EducationPage Class");
        }
    }
}
