using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\jshankar\source\repos\ConsoleApp2\ConsoleApp2\drivers", "geckodriver.exe");
            IWebDriver driver = new FirefoxDriver(service);
            driver.Url = "https://www.google.com";
        }
    }
}
