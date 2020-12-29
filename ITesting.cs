using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{ 

        class ITesting
        {
            IWebDriver driver;
            [SetUp]
            public void startBrowser()
            {
                driver = new ChromeDriver();
            }
            [Test]
            public void test()
            {
                driver.Url = "https://elp.duetbd.org/login/index.php";
                IWebElement element = driver.FindElement(By.Name("username"));
                element.SendKeys("170042034");
                IWebElement password = driver.FindElement(By.Name("password"));
                password.SendKeys("Abc.1234");
                driver.FindElement(By.Id("loginbtn")).Click();
             
              
            }
            //[TearDown]
            public void closeBrowser()
            {
            
                driver.Close();
            }
        }
    }


