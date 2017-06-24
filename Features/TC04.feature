Feature: TC04
 As an automation tester
 I want use Page Object Pattern with Specflow

@page_object_model
Scenario: Login with email not signed
 Given I am on ZingPoll website
 And I click the SignIn button
 Then The SignIn form should be shown
 When I enter email damdm@gmail.com and password dam123456
 And I click Submit button
 Then I verify the error failure message This email is not registered
 And I quit the browser