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
    public class Talentsearchpage
    {
        private static IWebDriver driver;

        public Talentsearchpage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public static List<IWebElement> FindTalentButton
        {
            get { return driver.FindElements(By.CssSelector("#talentSearchCardActions > button.btn.btn__primary.btn__find-talent.mat-raised-button.mat-primary")).ToList(); }
        }

        
    }
}
