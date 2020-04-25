Feature: Skills
	In order to update skills on MVP Portal
	As a user
	I want to add and delete skills once logged in  successfully

@afterLoginSteps
Scenario: Logged in and click on skills tab to update and delete
Given I have logged in to MVP Portal and clicked on skills tab
When I click on add new button on skills tab
And I Add skills as 'Test Analyst1'
And I select skill level 'Beginner'
And I press click Add button to add skill
Then I should be able add and view new skills to my profile
Then I should be able to delete skills added