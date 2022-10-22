using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (IWebDriver driver = new ChromeDriver("C:\\chromedriver_win32"))
            {
                Console.WriteLine("Test Started");
                driver.Navigate().GoToUrl("https://www.google.com/");
                driver.Manage().Window.Maximize();
                IWebElement element = driver.FindElement(By.Name("q"));
                element.SendKeys("https://www.w3schools.com/cssref/css_selectors.asp");
                Thread.Sleep(1000);
                IWebElement btnElement = driver.FindElement(By.Name("btnK"));
                btnElement.Click();
                Thread.Sleep(2000);
                driver.FindElement(By.PartialLinkText("W3Schools")).Click();
                Thread.Sleep(10000);
                driver.Close();
                Console.WriteLine("Test Ended");
            }
        }
    }
}




