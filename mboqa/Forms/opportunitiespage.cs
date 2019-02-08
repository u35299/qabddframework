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
    public class Opportunitiespage
    {
        private static IWebDriver driver;

        public Opportunitiespage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public static List<IWebElement> HamburgerMenu
        {
            get { return driver.FindElements(By.Id("btnMenuTrigger")).ToList(); }
        }

        public static List<IWebElement> TalentMenu
        {
            get { return driver.FindElements(By.Id("talentLink")).ToList(); }
        }

        public static List<IWebElement> TalentSearchSubMenu
        {
            get { return driver.FindElements(By.Id("talentSearchLink")).ToList(); }
        }

        public static IWebElement ViewAllTalentButton
        {
            get { return driver.FindElement(By.Id("viewAllTalentButton")); }
        }

        public static List<IWebElement> SkillsTextbox
        {
            get { return driver.FindElements(By.CssSelector("#mat-chip-list-0 > div > mat-form-field > div > div.mat-form-field-flex > div > input")).ToList(); }
        }

        public static List<IWebElement> CreateOpportunityLink
        {
            get { return driver.FindElements(By.Id("createOpportunityLink")).ToList(); }
        }

    }
}
