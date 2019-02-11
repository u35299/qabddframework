Feature: Perform user signup in Company Homepage

@homepage
Scenario: CONN2_16_Signing up on own for a client network from Company Home Page
	Given I Navigate to the Salesforce Homepage
	Then I validate the presence of FirstName, LastName, Email-Address fields
	When I enter the following signup details with FirstName, LastName and EmailAddress
	 | FirstName | LastName | EmailAddress       |
	 | Timothy   | Ketel    | xyz@ust-global.com |
	And I click on Sign Up button
	Then I get a confirmation message on the page	