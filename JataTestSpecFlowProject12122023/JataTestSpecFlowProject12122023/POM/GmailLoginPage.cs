using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JataTestSpecFlowProject12122023.POM
{
    public class GmailLoginPage
    {
        private readonly IWebDriver driver;

        public GmailLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenGooglOpenGmail()
        {
            driver.Navigate().GoToUrl("https://www.gmail.com");
        }

        public void EnterUserName(string UserName)
        {
            var userName = driver.FindElement(By.Id("identifierId"));
            var nextBtn = driver.FindElement(By.ClassName("VfPpkd - vQzf8d"));
            var submitNextBtn = driver.FindElement(By.ClassName("VfPpkd-RLmnJb"));
            userName.SendKeys(UserName);
            nextBtn.Click();

        }


        public void EnterPassword(string Password)
        {
            var password = driver.FindElement(By.Id("password"));
            var submitNextBtn = driver.FindElement(By.ClassName("VfPpkd-RLmnJb"));
            password.SendKeys(Password);
            submitNextBtn.Click();

        }

    }
}
