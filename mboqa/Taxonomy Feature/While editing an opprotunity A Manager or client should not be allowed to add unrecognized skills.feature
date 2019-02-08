Feature: Error messaging when unrecognized skills are entered As manager/client

@taxonomy
Scenario: While editing an opprotunity A Manager or client should not be allowed to add unrecognized skills
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username                       | Password |
	| testmboconnect+hmceb@gmail.com | Mbo.2011 |
	And I click on Edit button one of the opportunity
	And I provide the following skills in skill field to search
         | skills |
         | bbb    |
	Then the error message "Matching skills not available" should be displayed
	And skill should not be saved
