﻿Feature: Creating an opprotunity A Manager/client should be allowed to add the skills

@taxonomy
Scenario: CONN2_5_While creating an opprotunity A Manager/client should be allowed to add the skills
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username                       | Password |
	| testmboconnect+hmceb@gmail.com | Mbo.2011 |
	And I click "Create New Opportunity" menu
	And I provide the following skills in skill field to search
         | skills |
         | JAVA   |
	And I select "Java" from the predective text
	Then the new skill "Java" should be saved
