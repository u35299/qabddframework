Feature: Preserve unrecognized historical skills

@taxonomy
Scenario: Associate updates his/her skills
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username                       | Password |
	| agreen@mbo-tst.com | Mbo.2011 |
	And I Click "My Profile" from "My Account"
	And I Click on "Edit" button under skill
	And I enter following valid Skills in the textbox
	 | skills |
	 | java   |
	And I select "Java" from the predective text
	And I click the save button
	Then existing skills should still be visible
	And the new skill should be saved
