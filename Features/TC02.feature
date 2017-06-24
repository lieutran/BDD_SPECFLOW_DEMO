Feature: TC02
 As an automation tester
 I want use simple function of Specflow

@example_keyword
Scenario Outline: Login with information invalid
 Given I am on LiveGuru site
 And I input username <email> and password <password>
 When I click Login button
 Then The error message <error_msg> should be shown on form
 And I quit browser

 Examples: 
 | email             | password | error_msg                  |
 | dmd0001@gmail.com | 123123   | Invalid login or password. |
 | dmd0002@gmail.com | 123123   | Invalid login or password. |
 | dmd0003@gmail.com | 123123   | Invalid login or password. |
 | dmd0004@gmail.com | 123123   | Invalid login or password. |