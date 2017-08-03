Feature: Activity Form
	Verifying everything within the Enter a New CPD Activity form. Making sure the list boxes contain the correct data, any 
    validations that are in place when the Continue button is clicked, various element verification to login successfully

@Integration @IntegrationQA
Scenario: ActivityForm_Dropdowns
	Given I am on the Login page
	When I login as a valid user
	And I click on the Enter a CPD Activity form button
	Then the learning activities dropdown contains the following options
	| dropdownOption      |
	| Conference          |
	| Journal Club        |
	| Rounds              |
	| Small Group Session |                                
	

@Integration @IntegrationQA
Scenario: ActivityForm_AddActivity
	Given I am on the Login page
	When I login as a valid user
	And I click on the Enter a CPD Activity form button
	And I fill out the form
	Then the activity shows on the table

@Integration @IntegrationQA
Scenario: ActivityForm_DeleteActivity
	Given I am on the Login page
	When I login as a valid user
	And I delete the activity
	And I fill out the form
	Then the activity no longer appears on the table
