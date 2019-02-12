Feature: Completion of skills based on normalized taxonomy for Existing registeredIC

@mytag
Scenario: CONN2_3_Type ahead completion of skills based on normalized taxonomy for Existing registered IC
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an IC with the following credentials
	| Username                       | Password |
	| jleishman@mbo-tst.com            | Mbo.2011 |
	And I Click "My Profile" from "My Account"
	And I Click on "Edit" button under skill
	When I provide the following Duplicate skills in skill field to search
         | skills |
         | jav    |
   And I select "Java" from the predective text
   And I click the save button
   Then Duplicate skill should not be saved