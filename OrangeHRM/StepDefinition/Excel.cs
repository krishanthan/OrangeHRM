using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrangeHRM.DataDriven;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.DataBase;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class Excel
    {

        EmployeeInformation EmployeeInformation;
        ScenarioContext scenarioContext;
        FileInfo File;
        DatabaseTest DbTest = new DatabaseTest();


        public Excel(ScenarioContext _context)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            this.scenarioContext = _context;

        }

        [Given(@"Excel File called ""([^""]*)"" not exsist")]
        public void GivenExcelFileCalledNotExsist(string FilPath)
        {


            File = new FileInfo(@FilPath);
            Assert.IsFalse(File.Exists);
            scenarioContext["FilePath"] = FilPath;
        }

        [When(@"I create the new Excel File")]
        public async Task WhenICreateTheNewExcelFile()
        {
            var File = new FileInfo(Convert.ToString(scenarioContext["FilePath"]));
            EmployeeInformation = new EmployeeInformation();
            var Employee = EmployeeInformation.GetSetupData();
            using (var package = new ExcelPackage(File))
            {
                var ws = package.Workbook.Worksheets.Add("EmployeeInformation");
                var range = ws.Cells["A1"].LoadFromCollection(Employee, true);
                range.AutoFitColumns();
                await package.SaveAsync();
                ws.Column(1).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Column(3).ColumnMax = 20;

            }

        }

        [Then(@"The Excel File is present")]
        public void ThenTheExcelFileIsPresent()
        {
            FileInfo file = new FileInfo(Convert.ToString(scenarioContext["FilePath"]));
            if (file.Exists)
            {
                Assert.IsTrue(file.Exists);
            }

            else
            {
                throw new FileNotFoundException();
            }

        }



        [Given(@"The File Exsist in Directory Path ""([^""]*)""")]
        public void GivenTheFileExsistInDirectoryPath(string FilePath)
        {
            var File = new FileInfo(@FilePath);
            if (File.Exists)
            {
                scenarioContext["FilePath"] = FilePath;

            }

            else
            {
                throw new FileNotFoundException();
            }

        }

        [When(@"I purge the File")]
        public void WhenIPurgeTheFile()
        {
            var File = new FileInfo(Convert.ToString(scenarioContext["FilePath"]));
            if (File.Exists)
            {
                File.Delete();
            }

            else
            {
                Assert.IsFalse(File.Exists);
            }

        }

        [Then(@"The File not Exsist")]
        public void ThenTheFileNotExsist()
        {
            var File = new FileInfo(Convert.ToString(scenarioContext["FilePath"]));
            if (!File.Exists)
            {
                Assert.IsTrue(!File.Exists);
            }

            else
            {
                Assert.IsFalse(File.Exists);
            }




        }

        [Given(@"I Retrieve the Master ""([^""]*)""")]
        public async Task GivenIRetrieveTheMaster(string masterFilePath)
        {
            EmployeeInformation = new EmployeeInformation();
            var File = new FileInfo("masterFilePath");
           var e= await EmployeeInformation.LoadExcelFile((File));
            foreach (var item in e)
            {
                Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            }





        }

        [Given(@"I Retrieve the Comparison ""([^""]*)""")]
        public void GivenIRetrieveTheComparison(string comparisonFilePath)
        {
            throw new PendingStepException();
        }


        [When(@"I Compare the Files")]
        public void WhenICompareTheFiles()
        {
            throw new PendingStepException();
        }

        [Then(@"I Retrieve the Output Difference File")]
        public void ThenIRetrieveTheOutputDifferenceFile()
        {
            throw new PendingStepException();
        }

        [Given(@"I Create the Database")]
        public void GivenICreateTheDatabase()
        {
            DbTest.TestCreateDatabase();
        }






    }
}
