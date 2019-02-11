Feature: Advisor accessing Salesforce fields within Connect by Talent Search option	

@notes
Scenario: CONN2_22_Advisor accessing Salesforce fields within Connect by Talent Search option	
	Given Connect Application is loaded to login page in the browser	
	When I login to the application as an Advisor with the following credentials
	| Username          | Password |
	| tberg@mbo-tst.com | Mbo.2011 |
	And I select the option "Talent Search" from the menu "Talent" 
	And I provide the following skills in skill field to search
	| skills   |
	| java |
	And I select "Java" from the predective text
	And I provide the following name to search by name
	| name        |
	| edwan Hicks |
	And I click "FindTalent" button
	And From the list of profiles, I select one of the profiles and Click on the Name of the talent to open the complete profile in a popup
	And I click on "Add Message" to enter a message
	And I enter the message in the message box
	And I click on "Save" button to save the message
	Then the message is saved succssfully.

	Scenario: CONN2_22_Advisor accessing Salesforce fields within Connect by View All Talent option	
	Given Connect Application is loaded to login page in the browser	
	When I login to the application as an Advisor with the following credentials
	| Username          | Password |
	| tberg@mbo-tst.com | Mbo.2011 |
	And I search for "Senior DevOps EngineerII" in the opportunity search bar
	And I Click on the first profile from the the search result
	And I click on "Add Message" from the profile page to enter a message
	And I enter the message in the message box
	And I click on "Save" button to save the message
	Then the message is saved succssfully.