namespace Selenium_demo
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

  
    internal class ITesting
    {
        
        internal IWebDriver driver;

        /// <summary>
        /// The startBrowser.
        /// </summary>
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

      
        [Test]
        public void testLogin()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("170042034");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("Abc.1234");
            driver.FindElement(By.Id("loginbtn")).Click();
        }



    

        [Test]
        public void testNavigation()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            driver.Navigate().Refresh();
           
        }





        [Test]
        public void testTagName()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            IWebElement element =driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/button"));
            string tag = element.TagName;
            Console.WriteLine(tag);
        }


        [Test]
        public void testTextName()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/button"));
            string text = element.Text;
            Console.WriteLine(text);
        }


        public void closeBrowser()
        {

            driver.Close();
        }
    }
}
