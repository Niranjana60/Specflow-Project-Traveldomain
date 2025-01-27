using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakemyTrip_Project_Specflow.Helpers
{
    public class Webdrivermanager
    {
        public static IWebDriver Driver { get; private set; }

       
        public static void IntializeDriver()
        {
            // Initialize WebDriver
            Driver = new FirefoxDriver();

            // Maximize the browser window
            Driver.Manage().Window.Maximize();

            // Set implicit wait
           // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        
        public static void QuitDriver()
        {
            // Quit the driver after test completion
            Driver.Quit();
        }
        

        
    }
}
