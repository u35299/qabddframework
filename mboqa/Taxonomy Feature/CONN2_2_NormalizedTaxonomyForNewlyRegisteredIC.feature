Feature: Type ahead completion of skills based on normalized taxonomy for NewlyregisteredIC

@mytag
Scenario: CONN2_2_Type ahead completion of skills based on normalized taxonomy for Newlyregistered IC
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an IC with the following credentials
	| Username                       | Password |
	| sameer.mercury@gmail.com       | sp#d@rm6n |
	When I Clicked in Skills Section.
	And I provide the following skills in skill field to search
         | skills |
         | JAVA  |
    And I select "JAVA" from the predective text
	Then the new skill should be saved
	 
