using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace mboqa
{
    public class commonfunctions
    {
        WebDriverWait wait;
        private readonly IWebDriver driver;

        public commonfunctions(IWebDriver _driver)
        {
            driver = _driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        public void waituntillElementExist(string selectby, string id)
        {
            {
                if (selectby == "CssSelector")
                {
                    wait.Until(ExpectedConditions.ElementExists(By.CssSelector(id)));
                }
                else if (selectby == "Id")
                {
                    wait.Until(ExpectedConditions.ElementExists(By.Id(id)));
                }
                else if (selectby == "TagName")
                {
                    wait.Until(ExpectedConditions.ElementExists(By.TagName(id)));
                }
                else if (selectby == "ClassName")
                {
                    wait.Until(ExpectedConditions.ElementExists(By.ClassName(id)));
                }
                else if (selectby == "Xpath")
                {
                    wait.Until(ExpectedConditions.ElementExists(By.XPath(id)));
                }
            }
        }

        public void waituntillElementVisible(string selectby, string id)
        {
            {
                if (selectby == "CssSelector")
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(id)));
                }
                else if (selectby == "Id")
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(id)));
                }
                else if (selectby == "TagName")
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(id)));
                }
                else if (selectby == "ClassName")
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(id)));
                }
                else if (selectby == "Xpath")
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(id)));
                }
            }
        }

        public static void ScrollPageUp(int x, int y)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(x,y)");


        }

        public static void ScrollPageDown(int x, int y)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");


        }



    }

}
