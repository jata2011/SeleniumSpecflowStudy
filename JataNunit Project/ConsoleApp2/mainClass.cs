﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class mainClass
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\jshankar\\source\\repos\\ConsoleApp2\\ConsoleApp2\\drivers");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}