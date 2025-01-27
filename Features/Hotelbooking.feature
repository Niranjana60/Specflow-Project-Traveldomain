Feature: Search Hotel
As a user I want to Search hotels on Makemytrip.com to plan my stay


Scenario: Search hotels in Goa

Given I navigate to MakeMyTrip hotels page
When i search for Hotels in Goa
And I select Goa from Location suggestions
And I select Check-In as Today's date
And I click on checkout
And I select check-Out date as two days after today's date
And I select Rooms
And I click on Apply
When I select search
Then I should be able to view the Hotels in Goa


