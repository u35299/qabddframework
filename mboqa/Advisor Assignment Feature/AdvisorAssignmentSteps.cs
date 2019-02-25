using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace mboqa
{
    [Binding]
    public sealed class AdvisorAssignmentSteps
    {
        private readonly IWebDriver driver;
        WebDriverWait wait;        
        commonfunctions objcommonfunctions;
        Loginpage loginpage;
        Notespage notespage;
        Opportunitiespage opportunitiespage;
        Profilepage profilepage;
        Talentsearchpage talentsearchpage;
        Salesforcehomepage salesforcehomepage;

        public AdvisorAssignmentSteps()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            objcommonfunctions = new commonfunctions(driver);
            loginpage = new Loginpage(driver);
            notespage = new Notespage(driver);
            opportunitiespage = new Opportunitiespage(driver);
            profilepage = new Profilepage(driver);
            talentsearchpage = new Talentsearchpage(driver);
        }


        [Given(@"I am logged in as an Advisor")]
        public void GivenIAmLoggedInAsAnAdvisor()
        {
            objcommonfunctions.waituntillElementExist("Id", "username");

            Loginpage.loginUsername.Clear();
            Loginpage.loginPassword.Clear();

            Loginpage.loginUsername.SendKeys("tberg@mbo-tst.com");
            Loginpage.loginPassword.SendKeys("Mbo.2011");

            Loginpage.loginbtnSubmit.Click();
        }

        [When(@"I select the option Advisor Assignment from the menu Opportunities")]
        public void WhenISelectTheOptionAdvisorAssignmentFromTheMenuOpportunities()
        {
            objcommonfunctions.waituntillElementExist("Id", "opportunitiesLink");

            Opportunitiespage.OpportunityMenuLink.Click();

            Opportunitiespage.AdvisorAssignmentLink.Click();
        }

        [Then(@"I will see all my assigned Opportunities across all Clients")]
        public void ThenIWillSeeAllMyAssignedOpportunitiesAcrossAllClients()
        {
            objcommonfunctions.waituntillElementExist("Id", "closedOppButton");
            
        }
    }
}
