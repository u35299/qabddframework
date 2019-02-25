using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace mboqa.AdvisorAssignment
{
    [Binding]
    public sealed class Opportunity
    {
        private readonly IWebDriver driver;
        WebDriverWait wait;
        Random random;
        string randomnumber;
        commonfunctions objcommonfunctions;
        Loginpage loginpage;
        Notespage notespage;
        Opportunitiespage opportunitiespage;
        Profilepage profilepage;
        Talentsearchpage talentsearchpage;
        Salesforcehomepage salesforcehomepage;

        public Opportunity()
        {

            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            random = new Random();
            randomnumber = random.Next().ToString();
            objcommonfunctions = new commonfunctions(driver);
            loginpage = new Loginpage(driver);
            notespage = new Notespage(driver);
            opportunitiespage = new Opportunitiespage(driver);
            profilepage = new Profilepage(driver);
            talentsearchpage = new Talentsearchpage(driver);
        }

        [When(@"I provide following information on create opportunity page")]
        public void WhenIProvideFollowingInformationOnCreateOpportunityPage(Table table)
        {
            try
            {
                //objcommonfunctions.waituntillElementExist("Title", "StartDate");
                System.Threading.Thread.Sleep(3000);
                Opportunitiespage.Title.Click();
                Opportunitiespage.Title.SendKeys(table.Rows[0]["Title"]);
                //Opportunitiespage.JobID.Clear();
                //Opportunitiespage.JobID.SendKeys(table.Rows[0]["Title"]);
                Opportunitiespage.StartDate.Clear();
                Opportunitiespage.StartDate.SendKeys(table.Rows[0]["StartDate"]);
                Opportunitiespage.EndDate.Clear();
                Opportunitiespage.EndDate.SendKeys(table.Rows[0]["EndDate"]);
                Opportunitiespage.RemoteWork_Yes.Click();

                Opportunitiespage.MinimumCharge.SendKeys(table.Rows[0]["Minimum charge"]);
                Opportunitiespage.MaximumCharge.SendKeys(table.Rows[0]["Maximum charge"]);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I selected ""(.*)"" for ""(.*)""")]
        public void WhenISelectedFor(string p0, string p1)
        {
            
            commonfunctions.MovetoElement("CssSelector", "#opportunityCreateForm > div > button.btn.btn__primary.btn-lg.mat-raised-button.mat-primary.stateful-init.ng-star-inserted");
            Opportunitiespage.AdvisoryNeeded_Yes.Click();
            
        }

        [Then(@"I clicked ""(.*)"" button")]
        public void ThenIClickedButton(string p0)
        {
            commonfunctions.ScrollPageDown(0, 1000);
            Opportunitiespage.Publish_btn.Click();
        }

        [Then(@"I saw created opportunity visible under ""(.*)"" on ""(.*)"" Page\.")]
        public void ThenISawCreatedOpportunityVisibleUnderOnPage_(string p0, string p1)
        {
            { 

            }
        }

    }
}
