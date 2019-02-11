Feature: CONN2_6_Prevent duplicate entry of skills in the New opportunity by Manager

@taxonomy
Scenario: CONN2_6_Prevent duplicate entry of skills in the New opportunity by Manager
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username            | Password |
	| anelson@mbo-tst.com | Mbo.2011 |
	And I Click "My Profile" from "My Account"
	Then the result should be 120 on the screen
