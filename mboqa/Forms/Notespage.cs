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
    public class Notespage
    {
        private static IWebDriver driver;

        public Notespage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public static IWebElement NotesTextArea
        {
            get { return driver.FindElement(By.Id("profile-form-input-profile-note")); }
        }

        public static IWebElement NotesSubmitButton
        {
            get { return driver.FindElement(By.Id("profile-form-note-save-button")); }
        }

        public static List<IWebElement> NotesSubmitedText
        {
            get { return driver.FindElements(By.CssSelector("#notesDialogBody > mat-card:nth-child(1)")).ToList(); }
        }

        public static List<IWebElement> PredectiveText
        {
            get { return driver.FindElements(By.CssSelector("mat-option.mat-option.ng-star-inserted")).ToList(); }
        }


        public static List<IWebElement> NotesList
        {
            get { return driver.FindElements(By.CssSelector("mat-card.profile-note.mat-card.ng-star-inserted")).ToList(); }
        }
        


    }
}
