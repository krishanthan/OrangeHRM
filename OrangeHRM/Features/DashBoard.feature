@SmokeTest
@DashBoardTest

Feature: 02_OrangeHRM-DashBoard

Background: Pre-Requestive Navigate to DashBoard
	Given The User Navigate to OrangeHRM Website
	Given The User Navigate to OrangeHRM Login Page
	When The User Enter Username "Admin" and Password "admin123"
	When The User Click the Login Button


Scenario: 010 DashBoard Navigation to Employee Page
	Given The User Navigate to OrangeHRM Website
	Given The admin land on DashBoardPage
	When The User Navigate Employee Page
	Then The User Land on Employee Page






