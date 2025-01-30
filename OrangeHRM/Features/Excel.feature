@EndToEnd
@RegressionTest
Feature: Excel Functionality



@Triangle
Scenario Outline: 010_ Purge the Files
	Given The File Exsist in Directory Path "<FilePath>"
	When I purge the File
	Then The File not Exsist

Examples:
	| FilePath                                                   |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.csv  |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.xlsx |



@Triangle
Scenario Outline: 020_ Create The Files
	Given Excel File called "<FilePath>" not exsist
	When I create the new Excel File
	Then The Excel File is present

Examples:
	| FilePath                                                   |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.csv  |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.xlsx |


Scenario Outline: 030_Compare the Files
	Given I Retrieve the Master "<MasterFilePath>"
	Given I Retrieve the Comparison "<ComparisonFilePath>"
	When I Compare the Files
	Then I Retrieve the Output Difference File

Examples:
	| MasterFilePath                                             | ComparisonFilePath                                         |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.csv  | C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails-01.csv  |
	| C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails.xlsx | C:\\Users\\krish\\OrangeHRMExcelFile\\EmployeeDetails-01.xlsx |


Scenario: 040 Create the Database
	Given I Create the Database













