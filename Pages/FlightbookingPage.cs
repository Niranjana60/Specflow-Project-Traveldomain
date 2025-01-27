using MakemyTrip_Project_Specflow.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MakemyTrip_Project_Specflow.Pages
{
    public class FlightbookingPage
    {
        private readonly IWebDriver _driver;

        public FlightbookingPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Locators
      
        [FindsBy(How = How.XPath, Using = "//p[@class='widgetTitle flexOne']")]
        private IWebElement BookInternationelDomesticFlights { get; set; }
        [FindsBy(How = How.ClassName, Using = "menu_Flights")]
        private IWebElement ClickOnFlightsIcon { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='chNavIcon appendBottom2 chSprite chFlights active']")]
        private IWebElement OneWayTrip { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='fromCity']")]
        private IWebElement From { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='From']")]
        private IWebElement FromSearchBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='react-autowhatever-1-section-0-item-0']/div/div/p[2]")]
        private IWebElement Dublinoption { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'cookiesModal__acceptCookiesBtn buttonCls btn__primary uppercase')]")]
        private IWebElement Acceptbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='commonModal__close']")]
        private IWebElement ClosebtnofPopUp { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='toCity']")]
        private IWebElement ToCityLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='To']")]
        private IWebElement Tocitybox { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Indira Gandhi International Airport']")]
        private IWebElement SelectToCity { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Sat Feb 01 2025']//div[@class='dateInnerCell']")]
        private IWebElement SelectDepartureDate { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='travellers']")]
        private IWebElement Traveller { get; set; }
        [FindsBy(How = How.CssSelector, Using = "li[data-cy='adults-1']")]
        private IWebElement NoOfAdults { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[normalize-space()='Premium Economy']")]
        private IWebElement TravelClass { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='APPLY']")]
        private IWebElement Applybtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Search']")]
        private IWebElement Searchbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[@class='font24 blackFont whiteText appendBottom20 journey-title makeFlex spaceBetween bottom']")]
        private IWebElement Flightvisibilitytext { get; set; }


        public void NavigateToFlightBookingPage()
        {
            _driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Acceptbtn.Click();
            Thread.Sleep(500);
          
        }

        public bool IAmOnTheFlightBookingPage()
        {
           bool isflightbookingpagedisplayed = BookInternationelDomesticFlights.Displayed;
            return isflightbookingpagedisplayed;                   
        }

        public void ClickOnFlights()
        {
            
          
            ClickOnFlightsIcon.Click();
            Wait.ElementToBeVisible(_driver, "XPath", "//span[@class='commonModal__close']", 1);
            ClosebtnofPopUp.Click();


        }

        public void SelectTripOption()
        {
            OneWayTrip.Click();
            
        }

        public void ClickFromSearchBox()
        {
            From.Click();
            
        }
        public void EnterValuesinFromSearchBox()
        {
            
            FromSearchBox.SendKeys("Dublin");
            
        }

        public void SelectDublinIrelandFromSuggestions()
        {
            Wait.ElementToBeVisible(_driver, "XPath", "//*[@id='react-autowhatever-1-section-0-item-0']/div/div/p[2]", 3);
            Dublinoption.Click();
        }

        public void ClickOnTwoCityLabel()
        {

            ToCityLabel.Click();
        }

        public void EnterTwoCity()
        {

            Tocitybox.SendKeys("Delhi");
        }

        public void SelectNewDelhiIndiaFromSuggestions()
        {
            SelectToCity.Click();
        }

        public void SelectADateAsDepartureDate()
        {
            SelectDepartureDate.Click();
        }

        public void ClickOnTravellersClass()
        {
            Traveller.Click();
        }

        public void SelectnoofAdults()
        {
            NoOfAdults.Click();
        }
        public void SelectTravelClass()
        {
            TravelClass.Click();
        }
        public void ClickApply()
        {
            Applybtn.Click();
        }

        public void ClickSearchbtn()
        {
            Searchbtn.Click();
        }

        public bool Flightvisibledublintodelhi()
        {
            bool isFlighDublintoDelhidisplayed =Flightvisibilitytext.Displayed;
            return isFlighDublintoDelhidisplayed;
        }
    }
}
