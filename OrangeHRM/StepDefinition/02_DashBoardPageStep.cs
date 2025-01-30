using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OrangeHRM.ComponentHelper;
using OrangeHRM.PageObject;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public sealed class DashBoardPageStep

    {
        DashBoardObjects DbObjects = new DashBoardObjects();

        String WebUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewEmployeeList";

        [Given(@"The admin land on DashBoardPage")]
        public void GivenTheAdminLandOnDashBoardPage()
        {
            try
            {
                if (ObjectRepo.driver != null)
                {
                    Assert.IsTrue(ObjectRepo.driver.Url.Contains("dashboard"));
                    
                    
                }

                else
                {
                    Assert.Fail();
                }

            }

            catch
            {
                throw new NoSuchDriverException();
            }
        }

        [When(@"The User Navigate Employee Page")]
        public void WhenTheUserNavigateEmployeePage()
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            if (ObjectRepo.driver != null)
            {
                if (DbObjects.PIM.Displayed)
                {
                    ButtonHelper.ClickButton(DbObjects.PIM);
                }

                else
                {
                    throw new NoSuchElementException();
                }
            }
        }


        [Then(@"The User Land on Employee Page")]
        public void ThenTheUserLandOnEmployeePage()
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            if (ObjectRepo.driver != null)
            {
                Assert.AreEqual(ObjectRepo.driver.Url, WebUrl);    
                    
            }

            else
            {
                Assert.Fail();
            }

        }

    }
}
