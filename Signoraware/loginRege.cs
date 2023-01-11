using NUnit.Framework;
using OpenQA.Selenium;
using Signoraware.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signoraware
{
    public class loginRege:AutomationWrapper
       
        
    {

        [Test]
        public void ValidLoginTest() 
        {

            driver.FindElement(By.LinkText("Sign In")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("email")).SendKeys("chetanayh@gmail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("pass")).SendKeys("chetankam@123");
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)", driver.FindElement(By.XPath("//label[@for='accept_gdpr']")));
           
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@for='accept_gdpr']")).Click();
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();
            
        }
        public void InvalidLoginTest(string username,string password,string expect)
        {

            driver.FindElement(By.LinkText("Sign In")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("email")).SendKeys(username);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("pass")).SendKeys(password);
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)", driver.FindElement(By.XPath("//label[@for='accept_gdpr']")));

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@for='accept_gdpr']")).Click();
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();
            string actualerror=driver.FindElement(By.XPath("//div[contains(text(),'The account sign-in was incorrect ')]")).Text;
            Assert.That(actualerror.Contains(expect));

        }
    }
}
