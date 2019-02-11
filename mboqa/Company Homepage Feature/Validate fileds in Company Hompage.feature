Feature: Validate fileds in Company Hompage

@smoke
Scenario: CONN2_16_Validate fileds in Company Hompage
	Given I Navigate to the Salesforce Homepage
	Then I validate the presence of FirstName, LastName, Email-Address fields
