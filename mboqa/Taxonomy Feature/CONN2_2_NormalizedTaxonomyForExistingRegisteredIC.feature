Feature: Type ahead completion of skills based on normalized taxonomy for Existing registeredIC

@mytag
Scenario: CONN2_2_Type ahead completion of skills based on normalized taxonomy for Existing registered IC
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an IC with the following credentials
	| Username                       | Password |
	| jleishman@mbo-tst.com            | Mbo.2011 |
	And I Click "My Profile" from "My Account"
	And I Click on "Edit" button under skill
	And I provide the following skills in skill field to search
         | skills |
         | JAVA   |
    And I select "JAVA" from the predective text
    Then the new skill should be saved
