using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace mboqa.Company_Homepage_Feature
{
    [Binding]
    public sealed class CompanyHomepageSteps
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

        public CompanyHomepageSteps()
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
            salesforcehomepage = new Salesforcehomepage(driver);
        }

        [Given(@"I Navigate to the Salesforce Homepage")]
        public void WhenINavigateToTheSalesforceHomepage()
        {
            //driver.Navigate().GoToUrl("http://localhost:4200/client/salesforce");
            driver.Navigate().GoToUrl("http://connect-qa.mbopartners.com/client/salesforce");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='signup-form-white']")));
        }
        
        [Then(@"I validate the presence of FirstName, LastName, Email-Address fields")]
        public void ThenIValidateThePresenceOfFirstNameLastNameEmail_AddressFields()
        {
            //bool Login_Box = driver.FindElement(By.XPath("//div[@class='signup-form-white']")).Displayed;
            Assert.IsTrue(Loginpage.Login_Box.Displayed);
        }

        [When(@"I enter the following signup details with FirstName, LastName and EmailAddress")]
        public void WhenIEnterTheFollowingSignupDetailsWithFirstNameLastNameAndEmailAddress(Table table)
        {
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("signup-form-first-name-form-field")));
            //List<IWebElement> Firstname = driver.FindElements(By.Id("signup-form-first-name-form-field")).ToList();
            //List<IWebElement> Lastname = driver.FindElements(By.Id("signup-form-last-name-form-field")).ToList();
            //List<IWebElement> EmailAddress = driver.FindElements(By.Id("signup-form-email")).Where(x => x.TagName == "input").ToList();

            Salesforcehomepage.Firstname.FirstOrDefault().Clear();
            Salesforcehomepage.Lastname.FirstOrDefault().Clear();
            Salesforcehomepage.EmailAddress.FirstOrDefault().Clear();

            Salesforcehomepage.Firstname.FirstOrDefault().SendKeys(table.Rows[0]["FirstName"]);
            Salesforcehomepage.Lastname.FirstOrDefault().SendKeys(table.Rows[0]["LastName"]);
            Salesforcehomepage.EmailAddress.FirstOrDefault().SendKeys(table.Rows[0]["EmailAddress"]);
        }

        [When(@"I click on Sign Up button")]
        public void WhenIClickOnSignUpButton()
        {
            //List<IWebElement> SubmitButton = driver.FindElements(By.Id("signup-form-button")).ToList();

            Salesforcehomepage.SubmitButton.FirstOrDefault().Click();            
        }

        [Then(@"I get a confirmation message on the page")]
        public void ThenIGetAConfirmationMessageOnThePage()
        {
            Thread.Sleep(3000);
            //IWebElement ConfirmationMessage = driver.FindElement(By.XPath("//h1[@class='display-4']"));

            Assert.AreEqual(Salesforcehomepage.ConfirmationMessage.Text, "Thank you!");
        }

        [Then(@"the new skill ""(.*)"" should be saved in the Registration page skillset")]
        public void ThenTheNewSkillShouldBeSavedInTheRegistrationPageSkillset(string p0)
        {
            Assert.IsTrue(Profilepage.RegistrationpageSkillChips.Any(x => x.Text == p0));
        }
    }
}
