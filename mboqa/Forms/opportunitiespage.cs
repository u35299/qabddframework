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

        public static List<IWebElement> OpportunityList
        {
            get { return driver.FindElements(By.CssSelector("#opportunityListScrollWrapper > div")).ToList(); }
        }

        public static IWebElement EditButtonofFirstOpportunity
        {
            get { return OpportunityList.FirstOrDefault().FindElements(By.TagName("Button")).Where(x => x.Text == "Edit").FirstOrDefault(); }
        }

        public static List<IWebElement> MyAccount
        {
            get { return driver.FindElements(By.Id("myAccountLink")).ToList(); }
        }

        public static List<IWebElement> MyProfile
        {
            get { return driver.FindElements(By.Id("profileLink")).ToList(); }
        }

        public static IWebElement OpportunitypageSearchbar
        {
            get { return driver.FindElement(By.Id("oppListSearchInput")); }
        }

        public static List<IWebElement> OpportunitySearchResponseList
        {
            get { return driver.FindElements(By.CssSelector("#opportunityResponsesScrollWrapper>opportunity-responses>mat-card>mat-card-content>div>respondent-card>mat-card>div>div:nth-child(1)>mat-card-header>div")).ToList(); }
        }

        public static IWebElement OpportunitySearchByNameTextbox
        {
            get { return driver.FindElement(By.Id("talent-search-basic-name-form-field")); }
        }
        public static IWebElement OpportunitySkillTextbox
        {
            get { return driver.FindElement(By.Id("mat-input-7")); }
        }
        public static List<IWebElement> OpportunitySkillList
        {
            get { return driver.FindElements(By.CssSelector("#create-opportunity-skills > div > mat-form-field > div > div.mat-form-field-flex > div > mbo-chip-list >mat-chip-list > div>mbo-chip")).ToList(); }
        }

        public static IWebElement Title
        {
            get { return driver.FindElement(By.CssSelector("#create-opportunity-title-form-field")); }
        }

        public static IWebElement JobID
        {
            get { return driver.FindElement(By.CssSelector("#create-opportunity-job-id-form-field")); }

        }

        public static IWebElement StartDate
        {
            get { return driver.FindElement(By.CssSelector("#create-opportunity-date-range-start-date-picker-input")); }

        }

        public static IWebElement EndDate
        {
            get { return driver.FindElement(By.CssSelector("#create-opportunity-date-range-end-date-picker-input")); }

        }

        public static IWebElement Street
        {
            get { return driver.FindElement(By.XPath("//*[@id='create - opportunity - address']/div/address-form-v2/div/div[1]/text-form-field/div/mat-form-field/div/div[1]/div")); }

        }

        public static IWebElement City
        {
            get { return driver.FindElement(By.XPath("//*[@id='create - opportunity - address']/div/address-form-v2/div/div[2]/text-form-field/div/mat-form-field/div/div[1]/div")); }

        }

        public static IWebElement ZipCode
        {
            get { return driver.FindElement(By.XPath("//*[@id='create - opportunity - address']/div/address-form-v2/div/div[4]/zip-code-form-field/div/mat-form-field/div/div[1]/div")); }

        }
        
        public static IWebElement Description
        {
            get { return driver.FindElement(By.XPath("//div[@class='ql-editor ql-blank']")); }

        }

        public static IWebElement MinimumCharge
        {
            get { return driver.FindElement(By.CssSelector("#create-opportunity-budget-range-min")); }

        }

        public static IWebElement MaximumCharge
        {
            get { return driver.FindElement(By.CssSelector("#create-opportunity-budget-range-max")); }

        }

        public static IWebElement AdvisoryNeeded_Yes
        {
            get { return driver.FindElement(By.CssSelector("#is-help-note-is-help-required-1-form-field > label > div.mat-radio-label-content > span.form__radio-button-label")); }

        }

        public static IWebElement AdvisoryNeeded_No
        { 
            get { return driver.FindElement(By.CssSelector("#is-help-note-is-help-required-0-form-field > label > div.mat-radio-container > div.mat-radio-outer-circle")); }

        }
        
        public static IWebElement RemoteWork_No
        {
            get { return driver.FindElement(By.XPath("//*[@id='create - opportunity - address - remote - work - 0 - form - field']/label/div[1]/div[1]")); }

        }

        public static IWebElement RemoteWork_Yes
        {
            get { return driver.FindElement(By.CssSelector("#create-opportunity-address-remote-work-1-form-field > label > div.mat-radio-container > div.mat-radio-outer-circle")); }

        }

        public static IWebElement Publish_btn
        {
            get { return driver.FindElement(By.CssSelector("#opportunityCreateForm > div > button.btn.btn__primary.btn-lg.mat-raised-button.mat-primary.stateful-init.ng-star-inserted")); }

        }
        
        public static IWebElement Save_btn
        {
            get { return driver.FindElement(By.XPath("//button[@id='create-opportunity-save-button']")); }

        }

        public static IWebElement Cancel_Link
        {
            get { return driver.FindElement(By.XPath("//span[contains(text(),'Cancel')]")); }

        }

        public static IWebElement OpportunityMenuLink
        {
            get { return driver.FindElement(By.Id("opportunitiesLink")); }
        }
        public static IWebElement AdvisorAssignmentLink
        {
            get { return driver.FindElement(By.Id("advisorAssignmentLink")); }
        }        
    }
}