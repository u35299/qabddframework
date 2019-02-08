Feature: Advisor accessing Salesforce fields within Connect by ViewAll Talen option 


@notes
Scenario: Advisor accessing Salesforce fields within Connect by ViewAll Talent option
	Given Connect Application is loaded to login page in the browser	
	When I login to the application as an Advisor with the following credentials
	| Username                       | Password |
	| testmboconnect+hmceb@gmail.com | Mbo.2011 |
	And I select the option "Talent Search" from the menu "Talent" 
	And I provide the following skills in skill field to search
	| skills   |
	| java |
	And I select "Java" from the predective text
	And I click "FindTalent" button
	And From the list of profiles, I select one of the profiles and Click on the Name of the talent to open the complete profile in a popup
	And I click on "Add Message" to enter a message
	Then the notes window should be displayed with the following fields
	| Fields        |
	| Author        |
	| Date and Time |
	| Message       |	