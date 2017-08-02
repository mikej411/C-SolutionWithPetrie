Feature: Login
	To test that a user can login successfully
	If the user does not exist then they get an error message
	If the user enters invalid credentials then they get validation errors
	If the user does not enter any credentials then they get validation errors

@Integration @IntegrationQA
Scenario: Login_ValidUser
	Given I am on the Login page
	When I login as a valid user
	Then I am redirected to the next page

@Integration @IntegrationQA
Scenario: Login_NoCredentialsEntered
	Given I am on the Login page
	When I click on the Login button
	Then a validation error to enter my username is displayed
	And the username validation error text is red
	
@Integration @IntegrationQA
Scenario: Login_InvalidUser
	Given I am on the Login page
	When I login as an invalid user
	Then a login attempt validation error is displayed 

