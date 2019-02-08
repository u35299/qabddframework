Feature: Validate fileds in Company Hompage

@home
Scenario: Validate fileds in Company Hompage
	Given Connect Application is loaded to login page in the browser
	When I Navigate to the Salesforce Homepage
	Then I validate the presence of FirstName, LastName, Email-Address fields
