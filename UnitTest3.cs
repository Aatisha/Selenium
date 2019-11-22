using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    { 
 
        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver;
            driver = new FirefoxDriver("C:\\Selenium");
           // driver = new FirefoxDriver();
            string Vurl = "http://www.youcandealwithit.com/";
            driver.Url = Vurl;
            string vCalRes = "Calculators & Resources";
            string vCalculators = "Calculators";
            string vBudgetCalculator = "Budget Calculator";
            IWebElement vBorrower = driver.FindElement(By.XPath("//a[text()='Borrowers']"));
            Actions act = new Actions(driver);
            act.MoveToElement(vBorrower).Build().Perform();
            driver.FindElement(By.LinkText(vCalRes)).Click();
            Thread.Sleep(2000);
            if(driver.Title==vCalRes)
            {
                Console.WriteLine(" Calculators & Resources Passed");
            }
            else
            {
                Console.WriteLine(" Calculators & Resources Failed");
            }
            driver.FindElement(By.LinkText(vCalculators)).Click();
            Thread.Sleep(2000);
            if (driver.Title == vCalculators)
            {
                Console.WriteLine(" Calculators Passed");
            }
            else
            {
                Console.WriteLine(" Calculators Failed");
            }
            driver.FindElement(By.LinkText(vBudgetCalculator)).Click();
            Thread.Sleep(2000);
            if (driver.Title == vBudgetCalculator)
            {
                Console.WriteLine(" Budget Calculator Passed");
            }
            else
            {
                Console.WriteLine(" Budget Calculator Failed");
            }

            driver.FindElement(By.Id("food")).SendKeys("5000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("clothing")).SendKeys("1000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("shelter")).SendKeys("8000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("household")).SendKeys("6000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("transportation")).SendKeys("1700");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("health")).SendKeys("2500");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("studentLoans")).SendKeys("10000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("personal")).SendKeys("3000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("misc")).SendKeys("3000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("monthlyPay")).SendKeys("3000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("monthlyOther")).SendKeys("3000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("annualGifts")).SendKeys("3000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("annualTaxReturn")).SendKeys("3000");
            Thread.Sleep(2000);
            Console.WriteLine(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[5]/div[5]/input")).Text);
            string monthly_pay = driver.FindElement(By.Id("monthlyPay")).GetAttribute("value");
            double mon_pay = double.Parse(monthly_pay);
            string monthly_expense = driver.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value");
            double mon_exp = double.Parse(monthly_expense);
            if (mon_exp >= mon_pay)
                Console.WriteLine("You are Warren Buffet");
            else
                Console.WriteLine("You are VM");

        }

    }
}
