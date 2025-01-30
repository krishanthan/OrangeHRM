@RegressionTest
@EmployeeTest

Feature: 03_OrangeHRM-EmployeeFeature

Background: Pre-Condtion
	Given The User Navigate to OrangeHRM Website
	Given The User Navigate to OrangeHRM Login Page
	When The User Enter Username "Admin" and Password "admin123"
	When The User Click the Login Button
	Then The User Login into System
	When The User Navigate Employee Page



Scenario: 010_Verify The Employee Name is not exsist
	Given A Admin Navigate to Employee Page
	When A Admin Enter the Employee Name "Ab De Villiers" and Employee ID "12345"
	When A Admin Click the Search button
	Then Message should be appear as "No Records Found"
#	Then The Employee details Employee Name not present in table

Scenario: 020_Add Employee Details
	Given The Admin Navigate to Employee Page
	When A Admin Enter the Employee Name "Ab De Villiers" and Employee ID "12345"
	When The Admin Click Employee Creation Add button
	Then The Admin Land on Employee Page
	When The Admin Employee Deatails
		| Employee Name  | Last Name | Employee Id |
		| Ab De Villiers | Abraham   | 12345       |
	When Admin Click the Save Button
	Then The Admin Land on Employee Additional Details Page
	Then User Details get saved as following
		| Employee Name  | Last Name | Employee Id |
		| Ab De Villiers | Abraham   | 12345       |

@Triangle
Scenario Outline: 030_ Purge the Files
	Given The File Exsist in Directory Path "<FilePath>"
	When I purge the File
	Then The File not Exsist

Examples:
	| FilePath                                                   |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.csv  |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.xlsx |



@Triangle
Scenario Outline: 040_ Create The Files
	Given Excel File called "<FilePath>" not exsist
	When I create the new Excel File
	Then The Excel File is present

Examples:
	| FilePath                                                   |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.csv  |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.xlsx |

	
	



