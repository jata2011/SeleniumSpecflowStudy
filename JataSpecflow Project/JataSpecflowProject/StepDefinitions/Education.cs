using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using JataSpecflow_Project;
using JataSpecflow_Project.Pages;

namespace JataSpecflowProject
{
    [Binding]
    public class Education : DriverHelper
    {
                

        [Given(@"the user navigate Education Url")]
        public void GivenTheUserNavigateEducationUrl()
        {
            driver = new ChromeDriver(@"C:\\Users\\jata2\\source\\repos\\JataSpecflow Project\\JataSpecflowProject\\driver");

           // driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            //Navigate to Google.com
            driver.Navigate().GoToUrl("https://google.com");

            //Navigate back to education url
            driver.Navigate().Back();


           // driver.FindElement(By.Id("ContentPlaceholder1_Meal")).SendKeys("Tomato");

            //driver.FindElement(By.Id("ContentPlaceholder1_Meal")).SendKeys(Keys.Down);
            //driver.FindElement(By.Id("ContentPlaceholder1_Meal")).SendKeys(Keys.Return);


            // Storing Title name in String variable
            String Title = driver.Title;

            // Storing Title length in Int variable
            int TitleLength = driver.Title.Length;


            // Printing Title name on Console
            Console.WriteLine("Title of the page is : " + Title);

            // Printing Title length on console
            Console.WriteLine("Length if the page title is : " + TitleLength);
        }
        
        [Then(@"user see find out more element")]
        public void ThenUserSeeFindOutMoreElement()
        {

            EducationPage educationpage = new EducationPage();
            educationpage.ClickBanner();
        }
        
        [Then(@"Close the Browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
        }
    }
}
