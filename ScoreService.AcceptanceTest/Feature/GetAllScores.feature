Feature: GetAllScores
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@smoke
Scenario: Get All Employees
	Given the user
    When a get request to /api/ScoreApi
    Then  response should be recieved