using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakemyTrip_Project_Specflow.Helpers
{
    public class Wait
    {
        public static void ElementExists(IWebDriver driver, string locator, string locatorvalue,int seconds)
        {
            try
            {
                if(locator== "id")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorvalue)));
                }

                if (locator == "XPath")
                {
                    Console.WriteLine(">>>>>>>>>> Adding Wait");
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorvalue)));
                }

            }
            catch (Exception ex)
            {

                Assert.Fail("Test Failed waiting for element to exists",ex.Message);
            }
        }

        public static void ElementToBeVisible(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));
                }

                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
                }

            }

            catch(Exception ex)
            {
                Assert.Fail("Test failed waiting for element to click", ex.Message);
            }
        }
    }
}
