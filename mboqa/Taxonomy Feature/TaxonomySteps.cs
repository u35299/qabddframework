﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace mboqa
{
    [Binding]
    public sealed class TaxonomySteps
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

        public TaxonomySteps()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver"); ;            
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

        [When(@"I click ""(.*)"" menu")]
        public void WhenIClickMenu(string p0)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("createOpportunityLink")));
                Opportunitiespage.CreateOpportunityLink.FirstOrDefault().Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I enter the following skills in the skills field")]
        public void WhenIEnterTheFollowingSkillsInTheSkillsField(Table table)
        {
            try
            {
                Thread.Sleep(5000);
                Opportunitiespage.OpportunitySkillTextbox.SendKeys(table.Rows[0]["skills"]);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [Then(@"the error message ""(.*)"" should be displayed")]
        public void ThenTheErrorMessageShouldBeDisplayed(string p0)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("mat-hint.mat-hint.ng-star-inserted")));
                Assert.AreEqual(Profilepage.TaxonomyErrorMsg.FirstOrDefault().Text, p0);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [Then(@"skill should not be duplicated")]
        public void ThenSkillShouldNotBeDuplicated()
        {
            Assert.AreEqual(1, Profilepage.SkillSetinIcProfile.Count);
        }

        [Then(@"skill should not be duplicated with count ""(.*)""")]
        public void ThenSkillShouldNotBeDuplicatedWithCount(string p0)
        {
            Assert.AreEqual(Convert.ToInt32(p0), Profilepage.SkillSetinIcProfile.Count);
        }



        [Then(@"skill should not be saved")]
        public void ThenSkillShouldNotBeSaved()
        {
            try
            {                
                Assert.AreEqual(0, Notespage.PredectiveText.Count);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I click on Edit button one of the opportunity")]
        public void WhenIClickOnEditButtonOneOfTheOpportunity()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("opportunityListScrollWrapper")));
                Opportunitiespage.EditButtonofFirstOpportunity.Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I Click ""(.*)"" from ""(.*)""")]
        public void WhenIClickFrom(string p0, string p1)
        {
            try
            {
                // my profile from my account
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("myAccountLink")));
                List<IWebElement> MyAccount = driver.FindElements(By.Id("myAccountLink")).ToList();
                //Opportunitiespage.MyAccount.FirstOrDefault().Click();
                MyAccount.FirstOrDefault().Click();

                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profileLink")));
                List<IWebElement> MyProfile = driver.FindElements(By.Id("profileLink")).ToList();
                //Opportunitiespage.MyProfile.FirstOrDefault().Click();
                MyProfile.FirstOrDefault().Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I Click on ""(.*)"" button under skill")]
        public void WhenIClickOnButtonUnderSkill(string p0)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile-skills-form-edit-button")));

                Actions actions = new Actions(driver);
                actions.MoveToElement(driver.FindElement(By.Id("profile-education-form-edit-button"))).Perform();
                Profilepage.EditSkill.FirstOrDefault().Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        [Then(@"Any unrecognized skill will be color coded appropriately")]
        public void ThenAnyUnrecognizedSkillWillBeColorCodedAppropriately()
        {
            try
            {
                Assert.IsTrue(Profilepage.SkillSetinIcProfile.Any(x => x.FindElement(By.CssSelector("mat-chip.chip__list-item.chip-standard.chip-input.chip-with-icon.mat-chip.mat-standard-chip.legacy-skill.mat-none")).Displayed));
            }

            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [When(@"I enter following valid Skills in the textbox")]
        public void WhenIEnterFollowingValidSkillsInTheTextbox(Table table)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#mat-chip-list-0 > div > mat-form-field > div > div.mat-form-field-flex > div > input")));
                Profilepage.SkillTextBox.FirstOrDefault().SendKeys(table.Rows[0]["skills"]);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [When(@"I click the save button")]
        public void WhenIClickTheSaveButton()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile-skills-form-save-button")));
                if (driver.FindElements(By.Id("profile-experience-description-5")).Count>0)
                    commonfunctions.MovetoElement("Id", "profile-experience-description-5");
                else
                    commonfunctions.MovetoElement("Id", "profile-skills-form-save-button");
                Profilepage.SaveSkill.FirstOrDefault().Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [Then(@"existing skills should still be visible")]
        public void ThenExistingSkillsShouldStillBeVisible()
        {
            try
            {                
                Assert.IsTrue(Profilepage.SkillSet.Any(x => x.Text != "JAVA"));
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [Then(@"the new skill should be saved")]
        public void ThenTheNewSkillShouldBeSaved()
        {
            try
            {
                Thread.Sleep(3000);
                Assert.IsTrue(Profilepage.SkillSet.Any(x => x.Text == "java"));
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [Then(@"the new skill ""(.*)"" should be saved")]
        public void ThenTheNewSkillShouldBeSaved(string p0)
        {
            try
            {
                Thread.Sleep(3000);                

                Assert.IsTrue(Opportunitiespage.OpportunitySkillList.Any(x => x.Text == p0));
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


        [When(@"I Clicked in Skills Section\.")]
        public void WhenIClickedInSkillsSection_()
        {
            Thread.Sleep(3000);

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.Id("registration-summary-form-field"))).Perform();

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#registration-skill > div > mat-form-field > div > div.mat-form-field-flex > div > mbo-chip-list")));
            Thread.Sleep(3000);
            Profilepage.NewRegistration_SkillsSection.Click();
        }


        [When(@"I provide the following Duplicate skills in skill field to search")]
        public void WhenIProvideTheFollowingDuplicateSkillsInSkillFieldToSearch(Table table)
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

        [Then(@"new skill should be saved")]
        public void ThenNewSkillShouldBeSaved()
        {
            try
            {
                Thread.Sleep(3000);
                Profilepage.SaveSkills.Click();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

        [Then(@"Duplicate skill should not be saved")]
        public void ThenDuplicateSkillShouldNotBeSaved()
        {
            try
            {
                int count;
                List<string> AuthorList = new List<string>();
                List<IWebElement> SkillName = driver.FindElements(By.XPath("//mat-chip[contains(@id,'profile-skills-chip')]")).ToList();
                foreach (IWebElement Skill in SkillName)
                   {
                    String SkillText = Skill.Text;

                    if(SkillText == "java")
                    {
                        
                        AuthorList.Add("java");
                                               
                    }                   
                }

                count = AuthorList.Count;
                Assert.IsTrue(count==1, "Duplicate has been added");

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
