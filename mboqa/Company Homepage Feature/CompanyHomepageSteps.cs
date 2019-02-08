﻿using System;
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

        public CompanyHomepageSteps()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            random = new Random();
            randomnumber = random.Next().ToString();
        }

        [When(@"I Navigate to the Salesforce Homepage")]
        public void WhenINavigateToTheSalesforceHomepage()
        {
            //driver.Navigate().GoToUrl("http://localhost:4200/client/salesforce");
            driver.Navigate().GoToUrl("http://connect-qa.mbopartners.com/client/salesforce");
        }

        [Then(@"I validate the presence of FirstName, LastName, Email-Address fields")]
        public void ThenIValidateThePresenceOfFirstNameLastNameEmail_AddressFields()
        {
            bool Login_Box = driver.FindElement(By.XPath("//div[@class='signup-form-white']")).Displayed;
            Assert.IsTrue(Login_Box);
        }

        [When(@"I enter the following signup details with FirstName, LastName and EmailAddress")]
        public void WhenIEnterTheFollowingSignupDetailsWithFirstNameLastNameAndEmailAddress(Table table)
        {
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("signup-form-first-name-form-field")));
            List<IWebElement> Firstname = driver.FindElements(By.Id("signup-form-first-name-form-field")).ToList();
            List<IWebElement> Lastname = driver.FindElements(By.Id("signup-form-last-name-form-field")).ToList();
            List<IWebElement> EmailAddress = driver.FindElements(By.Id("signup-form-email")).Where(x => x.TagName == "input").ToList();

            Firstname.FirstOrDefault().Clear();
            Lastname.FirstOrDefault().Clear();
            EmailAddress.FirstOrDefault().Clear();

            Firstname.FirstOrDefault().SendKeys(table.Rows[0]["FirstName"]);
            Lastname.FirstOrDefault().SendKeys(table.Rows[0]["LastName"]);
            EmailAddress.FirstOrDefault().SendKeys(table.Rows[0]["EmailAddress"]);
        }

        [When(@"I click on Sign Up button")]
        public void WhenIClickOnSignUpButton()
        {
            List<IWebElement> SubmitButton = driver.FindElements(By.Id("signup-form-button")).ToList();

            SubmitButton.FirstOrDefault().Click();            
        }

        [Then(@"I get a confirmation message on the page")]
        public void ThenIGetAConfirmationMessageOnThePage()
        {
            Thread.Sleep(3000);
            IWebElement ConfirmationMessage = driver.FindElement(By.XPath("//h1[@class='display-4']"));

            Assert.AreEqual(ConfirmationMessage.Text, "Thank you!");
        }




    }
}
