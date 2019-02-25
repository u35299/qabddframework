Feature: Create a New Opportunity.

@mytag
Scenario: Create a New Opportunity
    Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	  | Username                       | Password |
	  | testmboconnect+hmceb@gmail.com | Mbo.2011 |
    And I click "Create New Opportunity" menu
   	And I provide following information on create opportunity page
      |    Title     | StartDate  |  EndDate    | Minimum charge | Maximum charge   |
      | autoTest     | 02/01/2020 |  03/01/2020 |     50         |  100             |
    And I provide the following skills in skill field to search
         | skills |
         | JAVA   |
    And I select "Java" from the predective text
    And I selected "Yes" for "Is remote work allowed?"
    And I selected "Yes, Please" for "Would you like help from an Advisor on this opportunity?"
    Then I clicked "Publish" button 
	And I saw created opportunity visible under "Unassigned Opportunities" on "advisor-assignment" Page.
