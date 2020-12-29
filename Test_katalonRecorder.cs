using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace Selenium_demo
{
    [TestFixture]
    public class Test1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void The1Test()
        {
            driver.Navigate().GoToUrl("https://elp.duetbd.org/");
            driver.FindElement(By.Id("login_username")).Clear();
            driver.FindElement(By.Id("login_username")).SendKeys("170042034");
            driver.FindElement(By.Id("login_password")).Clear();
            driver.FindElement(By.Id("login_password")).SendKeys("Abc.1234");
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.XPath("//section[@id='region-main']/div/div[2]/div/div/div/div/div/div")).Click();
         
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("loginbtn")).Click();
          
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("170042034");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Abc.1234");
            driver.FindElement(By.Id("username")).Click();
          
            driver.FindElement(By.Id("loginbtn")).Click();
            driver.FindElement(By.Id("action-menu-toggle-1")).Click();
            driver.FindElement(By.Id("actionmenuaction-6")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}