using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]  
        public void TestMethod1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\Selenium");
            driver.Url = "https://www.google.com/";
            string vSearch = "DXC Technologies";
            Thread.Sleep(3000);
            driver.FindElement(By.Name("q")).SendKeys("vSearch");
            Thread.Sleep(2000);
            driver.FindElement(By.Name("btnK")).Click();
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.FindElement(By.Id("resultStats")).Text);
            if(driver.Title==vSearch)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
            driver.Close();
          
        }
        
    }
}
