
Feature: Test2_Login

Verify Login Functionality

@tag1 
Scenario: TestLogin
	Given Verify Login Page Is Loaded
	Then Enter Username
	Then Enter Password
	Then Enter Captcha
	And Click On Loading Button
