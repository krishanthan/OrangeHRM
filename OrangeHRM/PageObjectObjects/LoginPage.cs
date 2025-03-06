using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObject
{
    public class LoginPage
    {

        public  IWebElement UserName => ObjectRepo.driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        public  IWebElement Password => ObjectRepo.driver.FindElement(By.Name("password"));
        public  IWebElement Loginbtn => ObjectRepo.driver.FindElement(By.CssSelector("div#app>div>div>div>div>div:nth-of-type(2)>div:nth-of-type(2)>form>div:nth-of-type(3)>button"));
        public  IWebElement UnameText => ObjectRepo.driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p'][1]"));
        public  IWebElement PwordText => ObjectRepo.driver.FindElement(By.XPath("//p[text()='Password : admin123']"));

        public IWebElement ErrorMessage => ObjectRepo.driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']/p"));

        public IWebElement ForgotPasswordBtn => ObjectRepo.driver.FindElement(By.XPath("(//p[contains(@class,'oxd-text oxd-text--p')])[3]"));

        public IWebElement ResetUserNameObj => ObjectRepo.driver.FindElement(By.CssSelector("div#app>div>div>div>form>div>div>div:nth-of-type(2)>input"));

        public IWebElement ResetPasswordBtn => ObjectRepo.driver.FindElement(By.XPath("(//button[contains(@class,'oxd-button oxd-button--large')])[2]"));

        public IWebElement ResetPasswordNotification => ObjectRepo.driver.FindElement(By.XPath("//h6[contains(@class,'oxd-text oxd-text--h6')]"));

        public IWebElement LogoutBtn=>ObjectRepo.driver.FindElement(By.XPath("//p[@class='oxd-userdropdown-name']"));

        public IReadOnlyList <IWebElement> LogoutBtnoption=> ObjectRepo.driver.FindElements(By.XPath("//ul[@class='oxd-dropdown-menu']/li"));


    }

}
