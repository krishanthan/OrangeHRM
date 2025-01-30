using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OrangeHRM.ComponentHelper;
using OrangeHRM.Configuration;
using OrangeHRM.PageObject;
using OrangeHRM.ScreenshotTest;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrangeHRM.TestScript.LoginPages
{

    [TestClass]
    public class Login : LoginPage
    {



        [TestMethod]
        public void LoginAction()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.Config.GetURL());
            Thread.Sleep(3000);
            UserName.SendKeys(ObjectRepo.Config.GetUserName());
            //ObjectRepo.driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(ObjectRepo.Config.GetUserName());
            Password.SendKeys(ObjectRepo.Config.GetPassword());
            Loginbtn.Click();
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            TakeScreenShot.SaveScreenshot("ValidLogin.jpeg");
            ObjectRepo.driver.Navigate().Back();

        }

        [TestMethod]

        public void IncorrectPasswordLogin()
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            NavigationHelper.NavigatetoURL(ObjectRepo.Config.GetURL());
            TextBoxHelper.TypeIn(UserName, ObjectRepo.Config.GetUserName());
            TextBoxHelper.TypeIn(Password, "ADDDMIN123");
            ButtonHelper.ClickButton(Loginbtn);
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ElementHelper.GetText(ErrorMessage);
            try
            {
                if (ElementHelper.GetText(ErrorMessage) == "Invalid credentials")
                {
                    Assert.IsTrue(true);
                    TakeScreenShot.SaveScreenshot("ErrorMessage.jpeg");
                }

                else
                {
                    Assert.IsTrue(false);

                }

            }

            catch (Exception)
            {
                throw new NoSuchElementException();
            }


        }

        [TestMethod]
        public void CopyandPastePassword()
        {

            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            NavigationHelper.NavigatetoURL(ObjectRepo.Config.GetURL());
            MouseActionHelper.CopyText(UnameText);
            MouseActionHelper.PasteText(UserName);
            MouseActionHelper.CopyText(PwordText);
            MouseActionHelper.PasteText(Password);



        }












    }
}
