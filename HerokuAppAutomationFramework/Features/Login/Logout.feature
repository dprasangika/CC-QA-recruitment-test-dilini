@logout
Feature: Logout functionality for herokuapp
	As a logged in user
	I want to logout from herokuapp application

Scenario: Successful Logout
	Given I am logged in with 'tomsmith' Username and 'SuperSecretPassword!' Password
	When I click Logout button
	Then I should see successful logout message
	And I should see Login button