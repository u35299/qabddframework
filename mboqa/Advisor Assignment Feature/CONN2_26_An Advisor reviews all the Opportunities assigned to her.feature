Feature: CONN2_26_An Advisor reviews all the Opportunities assigned to her

@advisorassignment
Scenario: CONN2_26_An Advisor reviews all the Opportunities assigned to her
	Given I am logged in as an Advisor	
	When I select the option Advisor Assignment from the menu Opportunities
	Then I will see all my assigned Opportunities across all Clients