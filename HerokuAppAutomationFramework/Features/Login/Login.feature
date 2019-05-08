@login
Feature: Login functionality for herokuapp
	As a user
	In order to use the secure area of herokuapp application
	I want to login with username and password

Scenario: Successful Login with valid credentials
	Given I am on Login page
	When I enter 'tomsmith' for Username and 'SuperSecretPassword!' for Password
	And I click Login button
	Then I should see successful login message
	And I should see Logout button

Scenario: Login with valid username and invalid password 
	Given I am on Login page
	When I enter 'tomsmith' for Username and 'test123' for Password
	And I click Login button
	Then I should see invalid password message 
	And I should see Login button

Scenario: Login with invalid username and valid password
	Given I am on Login page
	When I enter 'tom' for Username and 'SuperSecretPassword!' for Password
	And I click Login button
	Then I should see invalid username message 
	And I should see Login button
