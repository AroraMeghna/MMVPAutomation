Feature: DeleteSkills
	In order to delete skills on MVP Portal
	As a user
	I want to logged successfully and delete existing skills

@deleteSkills
Scenario: Logged in and deleting existing skills
	Given I have logged in to MVP and on a skills tab
	When I click on delete skills icon
	Then I should be able to delete selected skills