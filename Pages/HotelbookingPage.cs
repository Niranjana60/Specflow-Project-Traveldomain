using MakemyTrip_Project_Specflow.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Globalization;
using System.Threading;

namespace MakemyTrip_Project_Specflow.Pages
{

    public class HotelbookingPage 
    {
        private readonly IWebDriver _driver;
     

        public HotelbookingPage(IWebDriver driver)
        {
            _driver = driver;
           PageFactory.InitElements(driver, this);
        }

        //Locators
      
        [FindsBy(How = How.XPath, Using = "//input[@id='city']")]
        private IWebElement CitySearchplace { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Where do you want to stay?']")]
        private IWebElement CitySearchplaceinput { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[@id='react-autowhatever-1-section-0-item-0']//p[contains(@class,'sr_city')]")]
        private IWebElement Goainput { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[@id='react-autowhatever-1-section-0-item-0']//p[contains(@class,'sr_city')]")]
        private IWebElement goasuggestion { get; set; }
        [FindsBy(How = How.Id, Using = "checkout")]
        private IWebElement Checkout { get; set; }
        //[FindsBy(How = How.Id, Using = "//div[@class='rmsGst__body']//div[1]//div[2]//div[1]")]
        [FindsBy(How = How.XPath, Using = "//div[@class='rmsGst__body']//div[1]//div[2]//div[1]")]
        private IWebElement rooms{ get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Apply']")]
        private IWebElement applybtn { get; set; }
        [FindsBy(How = How.Id, Using = "hsw_search_button")]
        private IWebElement searchbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[@class='font26']")]
        private IWebElement showingpropertiesingoa { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='From']")]
        private IWebElement FromSearchtxtbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='bottomSheetModal']/div/div/div[2]/button")]
        private IWebElement Acceptbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='commonModal__close']")]
        private IWebElement ClosebtnofPopUp { get; set; }



        public void Navigate()
        {
            _driver.Navigate().GoToUrl("https://www.makemytrip.com/hotels/");
            _driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollBy(0,150)");
            Wait.ElementToBeVisible(_driver,"XPath","//*[@id='bottomSheetModal']/div/div/div[2]/button",2);
            Acceptbtn.Click();
           

        }

        public void SearchHotels()
        {
            
            CitySearchplace.Click();
            Wait.ElementToBeVisible(_driver, "XPath", "//span[@class='commonModal__close']", 2);
            ClosebtnofPopUp.Click();
            CitySearchplaceinput.SendKeys("Goa");
             Thread.Sleep(1000);
        }

        public void SelectGoaFromLocationSuggestions()
        {
           
           Wait.ElementExists(_driver, "XPath", "//li[@id='react-autowhatever-1-section-0-item-0']//p[contains(@class,'sr_city')]",5);
            Goainput.Click();
           

        }

        public void SelectCheckInAsTodaySDate()
        {
            DateTime today = DateTime.Now;
            string CheckinDate = today.ToString("ddd MMM dd yyyy", CultureInfo.InvariantCulture);
            IWebElement checkInElement = _driver.FindElement(By.XPath($"//div[@aria-label='{CheckinDate}']"));
            checkInElement.Click();      
        }

        public void ClickCheckOut()
        {
            Checkout.Click();
        }

        public void CheckOutDateAsTwoDaysAfterTodaySDate()
        {
            DateTime endDate = DateTime.Now.AddDays(2);
            string formattedTargetDate = endDate.ToString("ddd MMM dd yyyy", CultureInfo.InvariantCulture);
            IWebElement checkoutElement = _driver.FindElement(By.XPath($"//div[@aria-label='{formattedTargetDate}']"));
            checkoutElement.Click();
            //Thread.Sleep(1000);
        }

        public void SelectRooms()
        {
            rooms.Click();
        }
         public void ClickOnApply()
        {
            applybtn.Click();
        }
         public void SelectSearch()
        {
            searchbtn.Click();
        }

        public bool HotelsinGoaDisplayed()
        {
            bool ishotelsdisplayed = showingpropertiesingoa.Displayed;
            return ishotelsdisplayed;
        }

    }
}
