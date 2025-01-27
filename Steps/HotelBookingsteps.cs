using MakemyTrip_Project_Specflow.Helpers;
using MakemyTrip_Project_Specflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MakemyTrip_Project_Specflow.Steps
{
    [Binding]
    public class BookHotelSteps

    {
       // private readonly IWebDriver driver;
        private HotelbookingPage _hotelbookingPage;
        //private FlightbookingPage _flightbookingpage;




        [Given(@"I navigate to MakeMyTrip hotels page")]
        public void GivenINavigateToMakeMyTripHotelsPage()
        {

            Webdrivermanager.IntializeDriver();
            _hotelbookingPage = new HotelbookingPage(Webdrivermanager.Driver);
            _hotelbookingPage.Navigate();
        }
        
        [When(@"i search for Hotels in Goa")]
        public void WhenISearchForHotelsInGoa()
        {
            _hotelbookingPage.SearchHotels();
        }

        [When(@"I select Goa from Location suggestions")]
        public void WhenISelectGoaFromLocationSuggestions()
        {
            _hotelbookingPage.SelectGoaFromLocationSuggestions();
        }


        [When(@"I select Check-In as Today's date")]
        public void WhenISelectCheck_InAsTodaySDate()
        {
            _hotelbookingPage.SelectCheckInAsTodaySDate();
        }
        [When(@"I click on checkout")]
        public void WhenIClickOnCheckout()
        {
            _hotelbookingPage.ClickCheckOut();
        }


        [When(@"I select check-Out date as two days after today's date")]
        public void WhenISelectCheck_OutDateAsTwoDaysAfterTodaySDate()
        {
            _hotelbookingPage.CheckOutDateAsTwoDaysAfterTodaySDate();
        }

        [When(@"I select Rooms")]
        public void WhenISelectRooms()
        {
            _hotelbookingPage.SelectRooms();
        }

        [When(@"I click on Apply")]
        public void WhenIClickOnApply()
        {
            _hotelbookingPage.ClickOnApply();
        }

        [When(@"I select search")]
        public void WhenISelectSearch()
        {
            _hotelbookingPage.SelectSearch();
        }


        [Then(@"I should be able to view the Hotels in Goa")]
        public void ThenIShouldBeAbleToViewTheHotelsInGoa()
        {
            Assert.IsTrue(_hotelbookingPage.HotelsinGoaDisplayed());
        }

    }
}
