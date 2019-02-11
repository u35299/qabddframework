using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace mboqa.Forms
{
    [Binding]
    public sealed class HeaderMenu
    {

        private static IWebDriver driver;

        public HeaderMenu(IWebDriver _driver)
        {
            driver = _driver;
        }

        public static IWebElement loginUsername
        {
            get { return driver.FindElement(By.XPath("//*[@id='myAccountLink']/span")); }
        }




    }
}
