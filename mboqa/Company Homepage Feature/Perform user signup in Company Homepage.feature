Feature: Perform user signup in Company Homepage

@homepage
Scenario: Perform user signup in Company Homepage
	Given Connect Application is loaded to login page in the browser
	When I Navigate to the Salesforce Homepage
	And I enter the following signup details with FirstName, LastName and EmailAddress
	 | FirstName | LastName | EmailAddress       |
	 | Timothy   | Ketel    | xyz@ust-global.com |
	And I click on Sign Up button
	Then I get a confirmation message on the page	