using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace mboqa.Notes_Feature.Add_Notes_capability_for_advisors_in_Connect
{
    [Binding]
    public sealed class NotesSteps
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

        public NotesSteps()
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

        [Given(@"Connect Application is loaded to login page in the browser")]
        public void GivenConnectApplicationIsLoadedToLoginPageInTheBrowser()
        {
            try
            {

                driver.Navigate().GoToUrl("https://connect-qa.mbopartners.com");
                //driver.Navigate().GoToUrl("http://localhost:4200");

                objcommonfunctions.waituntillElementExist("Id", "username");
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I login to the application as an Advisor with the following credentials")]
        public void WhenILoginToTheApplicationAsAnAdvisorWithTheFollowingCredentials(Table table)
        {
            try
            {
                objcommonfunctions.waituntillElementExist("Id", "username");

                Loginpage.loginUsername.Clear();
                Loginpage.loginPassword.Clear();

                Loginpage.loginUsername.SendKeys(table.Rows[0]["Username"]);
                Loginpage.loginPassword.SendKeys(table.Rows[0]["Password"]);

                Loginpage.loginbtnSubmit.Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I select the option ""(.*)"" from the menu ""(.*)""")]
        public void WhenISelectTheOptionFromTheMenu(string p0, string p1)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("oppListSearchInput")));

            if (Opportunitiespage.HamburgerMenu.Count > 0)
            {

                try
                {
                    Opportunitiespage.HamburgerMenu[0].Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id("talentSearchLink")));
                    Opportunitiespage.TalentSearchSubMenu[0].Click();
                }
                catch (Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }

            }
            else
            {
                try
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id("talentLink")));
                    Opportunitiespage.TalentMenu[0].Click();
                    Thread.Sleep(2000);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id("talentSearchLink")));
                    Opportunitiespage.TalentSearchSubMenu[0].Click();
                }
                catch (Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }

            }
        }

        [When(@"I click ""(.*)""")]
        public void WhenIClick(string p0)
        {

            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id("viewAllTalentButton")));
                Opportunitiespage.ViewAllTalentButton.Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"From the list of profiles, I select one of the profiles and Click on the Name of the talent to open the complete profile in a popup")]
        public void WhenFromTheListOfProfilesISelectOneOfTheProfilesAndClickOnTheNameOfTheTalentToOpenTheCompleteProfileInAPopup()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("h4")));

                Assert.IsTrue(Profilepage.Profiles.Count > 0);

                Profilepage.Profiles[0].Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I Click on the first profile from the the search result")]
        public void WhenIClickOnTheFirstProfileFromTheTheSearchResult()
        {
            Opportunitiespage.OpportunitySearchResponseList.FirstOrDefault().Click();
        }

        [When(@"I provide the following name to search by name")]
        public void WhenIProvideTheFollowingNameToSearchByName(Table table)
        {
            Opportunitiespage.OpportunitySearchByNameTextbox.SendKeys(table.Rows[0]["name"]);
        }

        [When(@"I click on ""(.*)"" to enter a message")]
        public void WhenIClickOnToEnterAMessage(string p0)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id("mat-dialog-0")));

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                Thread.Sleep(2000);
                Profilepage.NotesBtn.Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I click on ""(.*)"" from the profile page to enter a message")]
        public void WhenIClickOnFromTheProfilePageToEnterAMessage(string p0)
        {
            try
            {
                Thread.Sleep(2000);
                Profilepage.NotesBtnfromProfile.Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I enter the message in the message box")]
        public void WhenIEnterTheMessageInTheMessageBox()
        {
            try
            {
                Thread.Sleep(2000);
                wait.Until(ExpectedConditions.ElementExists(By.Id("profile-form-input-profile-note")));

                Thread.Sleep(5000);
                Notespage.NotesTextArea.SendKeys("This is a Sample Notes in the Talent Profile with unique number = " + randomnumber);

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I click on ""(.*)"" button to save the message")]
        public void WhenIClickOnButtonToSaveTheMessage(string p0)
        {
            try
            {
                Notespage.NotesSubmitButton.Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [Then(@"the message is saved succssfully\.")]
        public void ThenTheMessageIsSavedSuccssfully_()
        {
            try
            {
                Thread.Sleep(8000);
                Assert.IsTrue(Notespage.NotesSubmitedText[0].Text.Contains("This is a Sample Notes in the Talent Profile with unique number = " + randomnumber));
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I select ""(.*)"" from the predective text")]
        public void WhenISelectFromThePredectiveText(string p0)
        {
            try
            {
                Thread.Sleep(3000);
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("mat-option.mat-option.ng-star-inserted")));

                Notespage.PredectiveText.FirstOrDefault(x => x.Text == p0).Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I provide the following skills in skill field to search")]
        public void WhenIProvideTheFollowingSkillsInSkillFieldToSearch(Table table)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector("#mat-chip-list-0 > div > mat-form-field > div > div.mat-form-field-flex > div > input")));

                Opportunitiespage.SkillsTextbox.FirstOrDefault().SendKeys(table.Rows[0]["skills"].ToString());
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I click ""(.*)"" button")]
        public void WhenIClickButton(string p0)
        {
            try
            {
                Talentsearchpage.FindTalentButton.FirstOrDefault().Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [Then(@"the notes window should be displayed with the following fields")]
        public void ThenTheNotesWindowShouldBeDisplayedWithTheFollowingFields(Table table)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("mat-card.profile-note.mat-card.ng-star-inserted")));

                foreach (IWebElement notes in Notespage.NotesList)
                {
                    Assert.IsTrue(notes.FindElement(By.TagName("img")).Displayed); // for name
                    Assert.IsTrue(notes.FindElement(By.TagName("mat-card-subtitle")).Displayed);  // for date and time
                    Assert.IsTrue(notes.FindElement(By.TagName("mat-card-content")).Displayed);  // for message
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [When(@"I search for ""(.*)"" in the opportunity search bar")]
        public void WhenISearchForInTheOpportunitySearchBar(string p0)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("oppListSearchInput")));
                Opportunitiespage.OpportunitypageSearchbar.SendKeys(p0);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }
    }
}