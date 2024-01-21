using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JataTestSpecFlowProject12122023.POM
{
    public class GmailInboxPage
    {
        private readonly IWebDriver driver;

        public GmailInboxPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
