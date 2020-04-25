Feature: Login
	In order to update profile on MVP Portal
	As a user
	I want to login successfully to my profile

@LogIn
Scenario: LogIn Link Takes User To The Sign In Page
Given I have navigated to MVP website
And I click the Sign In link
And I have entered username
And I have entered password
When I press the signin button
Then I am taken to the profile page