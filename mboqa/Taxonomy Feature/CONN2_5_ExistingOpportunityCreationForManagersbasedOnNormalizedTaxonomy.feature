Feature: Type ahead completion of skills for opportunity creation  for Managers based on normalized taxonomy (Existing Opportunity).

@taxonomy
Scenario: CONN2_5_While editing an opprotunity A Manager/client should not be allowed to add skills
	Given Connect Application is loaded to login page in the browser
	When I login to the application as an Advisor with the following credentials
	| Username                       | Password |
	| testmboconnect+hmceb@gmail.com | Mbo.2011 |
	And I click on Edit button one of the opportunity
	And I provide the following skills in skill field to search
         | skills |
         | JAVA    |
	And I select "Java" from the predective text
	Then the new skill "Java" should be saved
