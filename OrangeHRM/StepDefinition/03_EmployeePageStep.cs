using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OrangeHRM.ComponentHelper;
using OrangeHRM.PageObject;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public sealed class EmployeePageStep
    {
        
        EmployeeObjects EmployeeObjects = new EmployeeObjects();
        ScenarioContext _scenarioContext;
        FeatureContext _featureCon;
        KeyBoardActions _keyBoardActions = new KeyBoardActions();

        String AddEmployeeURL = "https://opensource-demo.orangehrmlive.com/web/index.php/pim/addEmployee";
        String EmployeeLastName = "Abraham";

        public EmployeePageStep(ScenarioContext ScenarioContext, FeatureContext FeatureContext)
        {
            this._scenarioContext = ScenarioContext;
            this._featureCon = FeatureContext;
        }

        [Given(@"A Admin Navigate to Employee Page")]
        [Given(@"The Admin Navigate to Employee Page")]
        public void GivenAAdminNavigateToEmployeePage()
        {
            if (ObjectRepo.driver != null)
            {
                Assert.IsTrue(ElementHelper.GetText(EmployeeObjects.PIMText) == "PIM");
            }

            else
            {
                throw new NoSuchDriverException();
            }
        }

        [When(@"A Admin Enter the Employee Name ""([^""]*)"" and Employee ID ""([^""]*)""")]
        public void WhenAAdminEnterTheEmployeeNameAndEmployeeID(string EmpName, string EmpId)
        {


            if (ObjectRepo.driver != null)
            {
                Assert.IsTrue(EmployeeObjects.EmpNameTextBox.Displayed && EmployeeObjects.EmpIDTextBox.Displayed);
                TextBoxHelper.TypeIn(EmployeeObjects.EmpNameTextBox, EmpName);
                TextBoxHelper.TypeIn(EmployeeObjects.EmpIDTextBox, EmpId);
                _scenarioContext["EmployeeName"] = EmpName;
                _scenarioContext["EmployeeId"] = EmpId;
                Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.EmpNameTextBox), _scenarioContext["EmployeeName"]);
                Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.EmpIDTextBox), _scenarioContext["EmployeeId"]);
            }

            else
            {
                throw new NoSuchDriverException();
            }


        }



        [When(@"A Admin Click the Search button")]
        public void WhenAAdminClickTheSearchButton()
        {

            if (EmployeeObjects.SearchBtn.Displayed)
            {
                ButtonHelper.ClickButton(EmployeeObjects.SearchBtn);
                Thread.Sleep(10000);

            }

            else
            {
                throw new NoSuchElementException();
            }



        }

        [Then(@"Message should be appear as ""([^""]*)""")]
        public void ThenMessageShouldBeAppearAs(string RecordMessage)
        {

            _scenarioContext["RecordMessage"] = RecordMessage;
            if (EmployeeObjects.RecordText.Displayed)
            {

                Assert.AreEqual(ElementHelper.GetText(EmployeeObjects.RecordText), Convert.ToString(_scenarioContext["RecordMessage"]));
            }

            else
            {
                throw new NoSuchElementException();
            }
        }






        [Then(@"The Employee details Employee Name not present in table")]
        public void ThenTheEmployeeDetailsEmployeeNameAndEmployeeIdNotPresentInTable()
        {
            ObjectRepo.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            if (EmployeeObjects.FirstNameValue.Count == 0)
            {

                foreach (IWebElement ListofName in EmployeeObjects.FirstNameValue)
                {

                    if (Convert.ToString(ListofName.Text) == Convert.ToString(_scenarioContext["EmployeeName"]))
                    {
                        Assert.Fail();
                        break;
                    }

                    else
                    {
                        Assert.IsTrue(Convert.ToString(ListofName.Text) != (Convert.ToString(_scenarioContext["EmployeeName"])));
                    }
                }
            }

            else
            {
                throw new NoSuchElementException();

            }

        }


        [When(@"The Admin Click Employee Creation Add button")]
        public void WhenTheAdminClickEmployeeCreationAddButton()
        {
            if (EmployeeObjects.Addbtn.Displayed)
            {

                ButtonHelper.ClickButton(EmployeeObjects.Addbtn);

            }
            else
            {
                throw new NoSuchElementException();
            }



        }

        [Then(@"The Admin Land on Employee Page")]
        public void ThenTheAdminLandOnEmployeePage()
        {
            WebDriverWaitHelper.ImplicitWait(5);
            if (ObjectRepo.driver != null)
            {
                Assert.AreEqual(ElementHelper.GetPageURL(), AddEmployeeURL);
            }

            else
            {
                throw new NoSuchDriverException();
            }

        }

        [When(@"The Admin Employee Deatails")]
        public void WhenTheAdminEmployeeDeatails(Table table)
        {
            if (EmployeeObjects.EmpFName.Displayed && EmployeeObjects.EmpLName.Displayed && EmployeeObjects.EmployeeID.Displayed)
            {
                foreach (var row in table.Rows)
                {
                    _keyBoardActions.ClearTextBox(EmployeeObjects.EmpFName);
                    _keyBoardActions.ClearTextBox(EmployeeObjects.EmpLName);
                    _keyBoardActions.ClearTextBox(EmployeeObjects.EmployeeID);
                    TextBoxHelper.TypeIn(EmployeeObjects.EmpFName, row["Employee Name"]);
                    TextBoxHelper.TypeIn(EmployeeObjects.EmpLName, row["Last Name"]);
                    TextBoxHelper.TypeIn(EmployeeObjects.EmployeeID, row["Employee Id"]);
                    _scenarioContext["LastName"] = row["Last Name"];

                }

                Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.EmpFName), _scenarioContext["EmployeeName"]);
                Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.EmpLName), EmployeeLastName);
                Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.EmployeeID), _scenarioContext["EmployeeId"]);
            }

            else
            {
                throw new NoSuchElementException();
            }
        }

        [Then(@"The Admin Land on Employee Additional Details Page")]
        public void ThenTheAdminLandOnEmployeeAdditionalDetailsPage()
        {
            if (EmployeeObjects.PersonalDetailTxt.Displayed)
            {

                Assert.IsTrue(EmployeeObjects.PersonalDetailTxt.Text == "Personal Details");

            }

            else
            {
                throw new NoSuchElementException();
            }



        }

        [When(@"Admin Click the Save Button")]
        public void WhenAdminClickTheSaveButton()
        {
            if (EmployeeObjects.Savebtn.Displayed)
            {
                EmployeeObjects.Savebtn.Click();
            }
            else
            {
                throw new NoSuchElementException();
            }

            WebDriverWaitHelper.ImplicitWait(15);
        }

        [Then(@"User Details get saved as following")]
        public void ThenUserDetailsGetSavedAsFollowing(Table table)
        {
            try
            {
                foreach (var row in table.Rows)
                {
                    Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.FullNameValue), _scenarioContext["LastName"]);
                    Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.LastNameValue), _scenarioContext["LastName"]);
                    Assert.AreEqual(ElementHelper.GetAttributeValue(EmployeeObjects.EmployeeIDValue), _scenarioContext["EmployeeId"]);
                }

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Assert.Fail(ex.Message );
            }

        }
    }

}

