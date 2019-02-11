Feature: CONN2_4_Visual color coding for any unrecognized skill in the existing profile

@taxonomy
Scenario: CONN2_4_Visual color coding_IC updates his/her skills
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username            | Password |
	| anelson@mbo-tst.com | Mbo.2011 |
	And I Click "My Profile" from "My Account"
	And I Click on "Edit" button under skill
	Then Any unrecognized skill will be color coded appropriately