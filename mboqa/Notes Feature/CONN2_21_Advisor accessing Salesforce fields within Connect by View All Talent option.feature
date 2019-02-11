Feature: Advisor accessing Salesforce fields within Connect by View All Talent option

@notes

Scenario: CONN2_21_Advisor accessing Salesforce fields within Connect by View All Talent option
	Given Connect Application is loaded to login page in the browser	
	When I login to the application as an Advisor with the following credentials
	| Username          | Password |
	| tberg@mbo-tst.com | Mbo.2011 |
	And I search for "Senior DevOps EngineerII" in the opportunity search bar
	And I Click on the first profile from the the search result
	And I click on "Add Message" from the profile page to enter a message
	Then the notes window should be displayed with the following fields
	| Fields        |
	| Author        |
	| Date and Time |
	| Message       |