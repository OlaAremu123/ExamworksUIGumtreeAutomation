Feature: GumtreeSearch

Scenario: GumtreeCarSearch_01_Verify that a user can search for cars in London successfully
	Given that gumtree is launched and fully loaded
	When a user types cars into the search field
	And a user types London into the location field
	And a user clicks on the go button
	Then the user should navigate to the Used Cars For Sale in London page

Scenario: GumtreeCarSearch_02_Verify that a user can navigate to a cars link successfully
	Given that gumtree is launched and fully loaded
	When a user types cars into the search field
	And a user types London into the location field
	And a user clicks on the go button
	And a user clicks on a car link
	Then the user should be navigated to the clicked car link successfully

