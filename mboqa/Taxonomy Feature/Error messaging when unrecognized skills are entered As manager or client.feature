Feature: Error messaging when unrecognized skills are entered As manager or client

@taxonomy
Scenario: While creating an opprotunity A Manager/client should not be allowed to add unrecognized skills
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username                       | Password |
	| testmboconnect+hmceb@gmail.com | Mbo.2011 |
	And I click "Create New Opportunity" menu
	And I provide the following skills in skill field to search
         | skills |
         | bbb    |
	Then the error message "Matching skills not available" should be displayed
	And skill should not be saved