Feature: CONN2_6_Prevent duplicate entry of skills in the New opportunity by Manager

@taxonomy
Scenario: CONN2_6_Prevent duplicate entry of skills in the New opportunity by Manager
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username            | Password |
	| jpiazza@mbo-tst.com | Mbo.2015 |
	And I click "Create New Opportunity" menu
	And I enter the following skills in the skills field
	| skills |
	| java   |
	And I select "Java Swing" from the predective text
	And I enter the following skills in the skills field
	| skills |
	| java   |
	And I select "Java Swing" from the predective text
	Then skill should not be duplicated
	
	Scenario: CONN2_6_Manager should not be able to enter duplicate skills in the skills field for Existing opportunity creation

	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username           | Password |
	| dcooke@mbo-tst.com | Mbo.2015 |
	And I click on Edit button one of the opportunity
	And I provide the following skills in skill field to search
         | skills |
         | jav    |
	And I select "Java Swing" from the predective text
	And I provide the following skills in skill field to search
         | skills |
         | jav   |
	And I select "Java Swing" from the predective text
	Then skill should not be duplicated with count "2"