Feature: Flightbooking
As a user I want to search flights

@smoke
Scenario: Search flights from Dublin to Delhi

Given I navigate to MakeMyTrip Website
And I am on the flight booking page
And I click on flights
When I select "One Way" trip option
And I click on 'From' 
And I enter Dublin in search box
And I select Dublin,Ireland from suggestions
And I click on 'To' label
And I enter New Delhi in search box
And I select New Delhi,India from suggestions
And I select a date as Departure date
And I click on Travellers & class
And I select no of Adults
And I select Travel class
And I click on Apply to select traveller and class
When I click on Search button
Then Flights from Mumbai to New Delhi must be displayed

