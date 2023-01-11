using NUnit.Framework;
using OpenQA.Selenium;
using Signoraware.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signoraware
{
    public class EditAcconutInformation : AutomationWrapper
    {
        [Test]

        public void EditAcconut()
        {
            driver.FindElement(By.XPath("//a[text()='Register']")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("wier");
            driver.FindElement(By.Id("lastname")).SendKeys("john");
            driver.FindElement(By.Id("email_address")).SendKeys("wier@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("wier@123");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("wier@123");
            driver.FindElement(By.XPath("//label[@for='accept_gdpr']")).Click();
            driver.FindElement(By.XPath("//span[text()='Create an Account']")).Click();
            driver.FindElement(By.XPath("//button[@class='action switch']")).Click();
            driver.FindElement(By.XPath("//a[@class='top-link-myaccount']")).Click();
            driver.FindElement(By.XPath("//a[text()='Account Information']")).Click();
            driver.FindElement(By.Id("lastname")).SendKeys("east");
        }
    }
}

