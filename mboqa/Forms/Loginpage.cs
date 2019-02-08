using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace mboqa
{
    public class Loginpage
    {
        private static IWebDriver driver;

        public Loginpage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public static IWebElement loginUsername
        {
            get { return driver.FindElement(By.Id("username")); }
        }

        public static IWebElement loginPassword
        {
            get { return driver.FindElement(By.Id("password")); }
        }

        public static IWebElement loginbtnSubmit
        {
            get { return driver.FindElement(By.Id("loginButton")); }
        }

        public static IWebElement Login_Box
        {
            get { return driver.FindElement(By.XPath("//div[@class='signup-form-white']")); }
        }        
    }
    
}
