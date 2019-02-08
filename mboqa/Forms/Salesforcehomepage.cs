using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace mboqa
{
    public class Salesforcehomepage
    {
        private static IWebDriver driver;

        public Salesforcehomepage(IWebDriver _driver)
        {
            driver = _driver;

        }

        public static List<IWebElement> Firstname
        {
            get { return driver.FindElements(By.Id("signup-form-first-name-form-field")).ToList(); }
        }
        public static List<IWebElement> Lastname
        {
            get { return driver.FindElements(By.Id("signup-form-last-name-form-field")).ToList(); }
        }
        public static List<IWebElement> EmailAddress
        {
            get { return driver.FindElements(By.Id("signup-form-email")).Where(x => x.TagName == "input").ToList(); }
        }

        public static List<IWebElement> SubmitButton
        {
            get { return driver.FindElements(By.Id("signup-form-button")).ToList(); }
        }

        public static IWebElement ConfirmationMessage
        {
            get { return driver.FindElement(By.XPath("//h1[@class='display-4']")); }
        }        


    }
}
