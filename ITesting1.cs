using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    class ITesting1
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
    public void testOpenBrowser()
    {
        driver.Url = "http://automationpractice.com/index.php?";
       
    }





    [Test]
    public void testRefresh()
    {
        driver.Url = "http://automationpractice.com/index.php?";
        driver.Navigate().Refresh();

    }





    [Test]
    public void testTagName()
    {
        driver.Url = "http://automationpractice.com/index.php?";
        IWebElement element = driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[2]/form/input[4]"));
        string tag = element.TagName;
        Console.WriteLine(tag);
    }


    [Test]
    public void testSendText()
    {
        driver.Url = "http://automationpractice.com/index.php?";
        IWebElement element = driver.FindElement(By.Name("search_query"));
        element.SendKeys("shirt");
        driver.FindElement(By.Name("submit_search")).Click();
        }

    [Test]
    public void testElementColor()
        {
            driver.Url = "http://automationpractice.com/index.php?";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[3]/div/a"));
            string color = element.GetCssValue("background");
            Console.WriteLine(color);
        }

    [Test]
    public void testFontWeight()
        {
            driver.Url = "http://automationpractice.com/index.php?";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[3]/div/a"));
            string weight = element.GetCssValue("font-weight");
            Console.WriteLine(weight);
        }




        public void closeBrowser()
    {

        driver.Close();
    }
    
    }
}
