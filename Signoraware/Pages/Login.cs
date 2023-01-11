using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signoraware.Pages
{
    public class Login
    {
        protected IWebDriver driver;

        private By _usernameloc = By.Id("email");
        private By _passwordLoc= By.Id("pass");
        private By _clickonloginloc= By.XPath("//span[text()='Sign In']");
        public Login(IWebDriver driver ) 
        
        {
         this .driver = driver; 

        }
        public void EnterUserName(string username)
        {
            driver.FindElement(_usernameloc).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLoc).SendKeys(password);
     
        }

        public void ClickOnLogin()
        {

            driver.FindElement(_clickonloginloc).Click();
        }
    }
}
