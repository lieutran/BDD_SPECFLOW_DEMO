Feature: TC01
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@invalid
Scenario: Login with information invalid
 Given I am on LiveGuru site
 And I input username daominhdam123123@gmail.com and password 123123
 When I click Login button
 Then The error message should be displayed
 And I quit browser