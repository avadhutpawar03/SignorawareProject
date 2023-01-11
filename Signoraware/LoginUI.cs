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
    public class LoginUI : AutomationWrapper
    {
        [Test]
        public void ValidateLogoTest()
        {
            bool LogoPresent = driver.FindElement(By.XPath("//img[@title='SignoraWare']")).Displayed;
            Assert.IsTrue(LogoPresent);

        }

        [Test]
        public void ValidateSearchTextTest() {
            bool SearchtextBox = driver.FindElement(By.XPath("//div[@class='search-area']")).Displayed;
            Assert.IsTrue(SearchtextBox);
        }


        [Test]

        public void ValidateWishlist()
        {
            bool WishList = driver.FindElement(By.XPath("//span[@class='fa fa-heart']")).Displayed;
            Assert.IsTrue(WishList);
        }

        [Test]

        public void ValidateMyCart()
        {
            bool MyCart = driver.FindElement(By.XPath("//span[@class='counter-number']")).Displayed;
            Assert.IsTrue(MyCart);
        }











    
    
    }
    }
