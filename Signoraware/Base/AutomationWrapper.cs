using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Signoraware.Base                    
{
    public class AutomationWrapper
    {
            protected IWebDriver driver;
            [SetUp]
            public void BeforeMethod()
            {
                driver=new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);



                driver.Url = "https://signoraware.com/customer/account/login/referer/aHR0cHM6Ly9zaWdub3Jhd2FyZS5jb20v/";
            }
            [TearDown]
            public void AfterMethod()
            {
                driver.Quit();
            }
        }
    }

