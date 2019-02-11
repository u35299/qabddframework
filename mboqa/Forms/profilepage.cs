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

        public static IWebElement NotesBtnfromProfile
        {
            get { return driver.FindElement(By.Id("manage-notes-button")); }
        }

        public static List<IWebElement> TaxonomyErrorMsg
        {
            get { return driver.FindElements(By.CssSelector("mat-hint.mat-hint.ng-star-inserted")).ToList(); }
        }

        public static List<IWebElement> EditSkill
        {
            get { return driver.FindElements(By.Id("profile-skills-form-edit-button")).ToList(); }
        }

        public static List<IWebElement> SkillTextBox
        {
            get { return driver.FindElements(By.CssSelector("#mat-chip-list-0 > div > mat-form-field > div > div.mat-form-field-flex > div > input")).ToList(); }
        }
        public static List<IWebElement> SaveSkill
        {
            get { return driver.FindElements(By.Id("profile-skills-form-save-button")).ToList(); }
        }
        public static List<IWebElement> SkillSet
        {
            get { return driver.FindElements(By.CssSelector("#profile-skills-chip>mat-chip-list>div>mbo-chip")).ToList(); }
        }
        public static List<IWebElement> SkillSetinIcProfile
        {
            get { return driver.FindElements(By.CssSelector("div.mat-form-field-infix>mbo-chip-list>mat-chip-list>div>mbo-chip")).ToList(); }
        }

        public static IWebElement NewRegistration_SkillsSection
        {
            get { return driver.FindElement(By.CssSelector("#registration-skill > div > mat-form-field > div > div.mat-form-field-flex > div > mbo-chip-list")); }
        }

        public static IWebElement btn_ChooseFiles
        {
            get { return driver.FindElement(By.XPath("//*[@id='registration - skill']/div/mat-form-field/div/div[1]/div/mbo-chip")); }
        }



    }
}
