Feature: TC03
 As an automation tester
 I want use technical transform data to table

@transform_data_table
Scenario: Login with email not signed
 Given I am on LiveGuru site
 And I input username and password
 | email              | pass   |
 | dam11111@gmail.com | 111111 |
 When I click Login button
 Then I verify the failure message
 | error                      |
 | Invalid login or password. |
 And I quit browser