using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MakemyTrip_Project_Specflow.Helpers;
using MakemyTrip_Project_Specflow.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MakemyTrip_Project_Specflow.Steps
{
    [Binding]
    
    public class Flightbookingsteps
    {
        private FlightbookingPage _flightbookingpage;
       
        
       // private HotelbookingPage _hotelbookingPage;



        [Given(@"I navigate to MakeMyTrip Website")]
        public void GivenINavigateToMakeMyTripWebsite()
        {
          


            Webdrivermanager.IntializeDriver();
            _flightbookingpage = new FlightbookingPage(Webdrivermanager.Driver);
            _flightbookingpage.NavigateToFlightBookingPage();
            // ExtentReports rep = GenerateExtentReport.getInstance();          
            //ExtentTest feauturename = rep.CreateTest<Feature>("Flightbooking");
            //ExtentTest testscenario = feauturename.CreateNode<Scenario>("Search flights from Dublin to Delhi");
            //testscenario.CreateNode<Given>("I navigate to MakeMyTrip Website");
            //rep.Flush();


        }

        [Given(@"I am on the flight booking page")]
        public void GivenIAmOnTheFlightBookingPage()
        {
           
            _flightbookingpage.IAmOnTheFlightBookingPage();
        }

        [Given(@"I click on flights")]
        public void GivenIClickOnFlights()
        {
            _flightbookingpage.ClickOnFlights();
        }

        [When(@"I select ""(.*)"" trip option")]
        public void WhenISelectTripOption(string p0)
        {
            _flightbookingpage.SelectTripOption();
        }

        [When(@"I click on '(.*)'")]
        public void WhenIClickOnSearchBox(string p0)
        {
            _flightbookingpage.ClickFromSearchBox();
        }

        [When(@"I enter Dublin in search box")]
        public void WhenIEnterDublinInSearchBox()
        {
           _flightbookingpage.EnterValuesinFromSearchBox();
        }

        [When(@"I select Dublin,Ireland from suggestions")]
        public void WhenISelectDublinIrelandFromSuggestions()
        {
            _flightbookingpage.SelectDublinIrelandFromSuggestions();
        }

        [When(@"I click on '(.*)' label")]
        public void WhenIClickOnLabel(string p0)
        {
            _flightbookingpage.ClickOnTwoCityLabel();
        }


        [When(@"I enter New Delhi in search box")]
        public void WhenIEnterNewDelhiInSearchBox()
        {
            _flightbookingpage.EnterTwoCity();
        }

        [When(@"I select New Delhi,India from suggestions")]
        public void WhenISelectNewDelhiIndiaFromSuggestions()
        {
            _flightbookingpage.SelectNewDelhiIndiaFromSuggestions();
        }

        [When(@"I select a date as Departure date")]
        public void WhenISelectADateAsDepartureDate()
        {
            _flightbookingpage.SelectADateAsDepartureDate();
        }

        [When(@"I click on Travellers & class")]
        public void WhenIClickOnTravellersClass()
        {
            _flightbookingpage.ClickOnTravellersClass();
        }

        [When(@"I select no of Adults")]
        public void WhenISelectNoOfAdults()
        {
            _flightbookingpage.SelectnoofAdults();
        }

        [When(@"I select Travel class")]
        public void WhenISelectTravelClass()
        {
            _flightbookingpage.SelectTravelClass();
        }

        [When(@"I click on Apply to select traveller and class")]
        public void WhenIClickOnApplyToSelectTravellerAndClass()
        {
            _flightbookingpage.ClickApply();
        }


        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            _flightbookingpage.ClickSearchbtn();
        }

        [Then(@"Flights from Mumbai to New Delhi must be displayed")]
        public void ThenFlightsFromMumbaiToNewDelhiMustBeDisplayed()

        {
            Assert.IsTrue(_flightbookingpage.Flightvisibledublintodelhi());
           // _flightbookingpage.Flightvisibledublintodelhi();
        }

    }
}
