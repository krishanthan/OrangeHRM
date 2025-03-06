
Feature: 01_OrangeHRM-LoginPage


Scenario Outline: 010 The User Login with Invalid Credentials
	Given The User Navigate to OrangeHRM Website
	Given The User Navigate to OrangeHRM Login Page
	When The User Enter Incorrect Username "<UserName>" and Password "<Password>"
	When The User Click the Login Button
	Then The error message should be appear as "Invalid credentials"

Examples:
	| UserName | Password   |
	| Aadmin   | Adddmin123 |
	| AadminS  | Krish132   |

Scenario: 020 The User Login Into Homepage
	Given The User Navigate to OrangeHRM Website
	Given The User Navigate to OrangeHRM Login Page
	When The User Enter Username "Admin" and Password "admin123"
	When The User Click the Login Button
	Then The User Login into System
	Then The User Logout of System

Scenario: 030 User Forgot Password
	Given The User Navigate to OrangeHRM Website
	Given The User Navigate to OrangeHRM Login Page
	When The User Click the Forgot Password Link
	Then The User Land on Forgot Password Page
	When The User Enter the UserName "Admin"
	When The User Click the Reset-Password Button
	Then The User Get the notification text of "Reset Password link sent successfully"































