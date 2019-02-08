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
    public class Profilepage
    {
        private static IWebDriver driver;

        public Profilepage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public static List<IWebElement> Profiles
        {
            get { return driver.FindElements(By.TagName("h4")).ToList(); }
        }

        public static IWebElement ProfilePopup
        {
            get { return driver.FindElement(By.Id("mat-dialog-0")); }
        }

        public static IWebElement NotesBtn
        {
            get { return ProfilePopup.FindElement(By.Id("manage-notes-button")); }
        }

        public static List<IWebElement> TaxonomyErrorMsg
        {
            get { return driver.FindElements(By.CssSelector("mat-hint.mat-hint.ng-star-inserted")).ToList(); }
        }

        


    }
}
