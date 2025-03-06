using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OrangeHRM.BaseClasses;
using OrangeHRM.ComponentHelper;
using OrangeHRM.DataDriven;
using OrangeHRM.PageObject;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public sealed class LoginPageStep : LoginPage
    {

        ScenarioContext _Context;

        public LoginPageStep(ScenarioContext Context)
        {
            this._Context = Context;
        }


        #region Given

        [Given(@"The User Navigate to OrangeHRM Website")]
        public void GivenTheUserNavigateToOrangeHRMWebsite()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.Config.GetURL());

        }

        [Then("The User Navigate to OrangeHRM Login Page")]
        [Given(@"The User Navigate to OrangeHRM Login Page")]
        public void GivenTheUserNavigateToOrangeHRMLoginPage()
        {

            if (ElementHelper.GetPageTitle() == "OrangeHRM")
            {
                Assert.IsTrue(true);
            }

            else
            {
                Assert.IsTrue(false);
            }

        }

        #endregion

        #region When

        [When(@"The User Enter Username ""([^""]*)"" and Password ""([^""]*)""")]
        public void WhenTheUserEnterUsernameAndPassword(string Uname, string Pword)
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            if (UserName.Displayed && Password.Displayed)
            {

                TextBoxHelper.TypeIn(UserName, Uname);
                TextBoxHelper.TypeIn(Password, Pword);

            }
            else
            {

                throw new NoSuchElementException();


            }

            Assert.AreEqual(Uname, ObjectRepo.Config.GetUserName());
            Assert.AreEqual(Pword, ObjectRepo.Config.GetPassword());

        }

        [When(@"The User Enter Incorrect Username ""([^""]*)"" and Password ""([^""]*)""")]
        public void WhenTheUserEnterIncorrectUsernameAndPassword(string UserName01, string PassWord)
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            if (UserName.Displayed && Password.Displayed)
            {

                TextBoxHelper.TypeIn(UserName, UserName01);
                TextBoxHelper.TypeIn(Password, PassWord);
            }
            else
            {

                throw new NoSuchElementException();


            }

            Assert.AreNotEqual(UserName01, ObjectRepo.Config.GetUserName());
            Assert.AreNotEqual(PassWord, ObjectRepo.Config.GetPassword());
        }


        [When(@"The User Click the Login Button")]
        public void WhenTheUserClickTheLoginButton()
        {
            if (Loginbtn.Displayed)
            {
                ButtonHelper.ClickButton(Loginbtn);
            }

            else
            {
                throw new NoSuchElementException();

            }
        }

        [When(@"The User Click the Forgot Password Link")]
        public void WhenTheUserClickTheForgotPasswordLink()
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                if (ForgotPasswordBtn.Displayed && ObjectRepo.driver != null)
                {
                    Assert.IsTrue(true);
                    ButtonHelper.ClickButton(ForgotPasswordBtn);

                }

            }

            catch
            {

                throw new NoSuchElementException();


            }

        }

        [When(@"The User Enter the UserName ""([^""]*)""")]
        public void WhenTheUserEnterTheUserName(string ResetUserName)
        {
            try
            {
                if (ObjectRepo.driver != null)
                {
                    try
                    {
                        if (ResetUserNameObj.Displayed)
                        {
                            TextBoxHelper.TypeIn(ResetUserNameObj, ResetUserName);
                            Assert.AreEqual(ElementHelper.GetAttributeValue(ResetUserNameObj), ResetUserName);
                        }
                        else
                        {
                            Assert.IsTrue(false);
                        }

                    }

                    catch
                    {
                        throw new NoSuchElementException();
                    }
                }

            }

            catch
            {
                throw new NoSuchDriverException();
            }
        }

        [When(@"The User Click the Reset-Password Button")]
        public void WhenTheUserClickTheReset_PasswordButton()
        {
            try
            {
                if (ObjectRepo.driver != null)
                {
                    if (ResetPasswordBtn.Displayed)
                    {
                        ButtonHelper.ClickButton(ResetPasswordBtn);
                    }

                    else
                    {
                        throw new NoSuchElementException();
                    }

                }


            }

            catch
            {
                throw new NoSuchDriverException();
            }
        }

        [When("The User Logout of System")]
        public void ThenTheUserLogoutOfSystem()
        {
            if (LogoutBtn.Displayed)
            {
                ButtonHelper.ClickButton(LogoutBtn);
                ButtonHelper.ClickBtnOption(LogoutBtnoption, "Logout");
            }
            else
            {
                throw new NoSuchElementException();
            }

        }



        #endregion

        #region Then
        [Then(@"The User Login into System")]
        public void ThenTheUserLoginIntoSystem()
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            if (ElementHelper.GetPageURL().Contains("dashboard"))
            {
                Assert.IsTrue(true);

            }

            else
            {
                throw new NoSuchElementException();
            }

        }

        [Then(@"The error message should be appear as ""([^""]*)""")]
        public void ThenTheErrorMessageShouldBeAppearAs(string InvalidMessage)
        {
            if (ErrorMessage.Displayed && ElementHelper.GetText(ErrorMessage) != null)
            {
                Assert.AreEqual(InvalidMessage, ElementHelper.GetText(ErrorMessage));

            }

            else
            {
                throw new NoSuchElementException();
            }

        }



        [Then(@"The User Land on Forgot Password Page")]
        public void ThenTheUserLandOnForgotPasswordPage()
        {

            if (ObjectRepo.driver != null)
            {
                ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                try
                {
                    if (ElementHelper.GetPageURL().Contains("requestPasswordResetCode"))
                    {
                        Assert.IsTrue(true);
                    }

                    else
                    {

                        Assert.IsTrue(false);
                    }

                }

                catch
                {

                    throw new NoSuchElementException();

                }



            }

        }





        [Then(@"The User Get the notification text of ""([^""]*)""")]
        public void ThenTheUserGetTheNotificationTextOf(string ResetConfirmation)
        {
            try
            {
                if (ObjectRepo.driver != null)
                {
                    ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    if (ResetPasswordNotification.Displayed)
                    {
                        Assert.AreEqual(ElementHelper.GetText(ResetPasswordNotification), ResetConfirmation);
                    }

                    else
                    {
                        throw new NoSuchElementException();

                    }

                }

            }

            catch
            {
                throw new NoSuchDriverException();
            }
        }





        #endregion










    }
}
