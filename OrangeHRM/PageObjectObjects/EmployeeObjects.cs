using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OrangeHRM.PageObject
{
    public class EmployeeObjects
    {
  
        public IWebElement PIMText => ObjectRepo.driver.FindElement(By.XPath("//h6[contains(@class,'oxd-text oxd-text--h6')]"));
        public IWebElement EmpIDTextBox => ObjectRepo.driver.FindElement(By.XPath("(//span[text()='Configuration ']/following::input)[2]"));

        public IWebElement EmpNameTextBox => ObjectRepo.driver.FindElement(By.XPath("//span[text()='Configuration ']/following::input[1]"));

        public IWebElement SearchBtn => ObjectRepo.driver.FindElement(By.XPath("//button[@type='submit']"));

        public IWebElement RecordText => ObjectRepo.driver.FindElement(By.XPath("//div[@class='orangehrm-horizontal-padding orangehrm-vertical-padding']//span[1]"));

        public IReadOnlyList<IWebElement> FirstNameValue => ObjectRepo.driver.FindElements(By.XPath("//div[@class='oxd-table-body']/div/div/div[3]/div"));
        public IReadOnlyList<IWebElement> ListOfId => ObjectRepo.driver.FindElements(By.XPath("//div[@role='row']/div[@role='cell'][2]"));

        public IWebElement Deltebtn => ObjectRepo.driver.FindElement(By.XPath("//i[@class='oxd-icon bi-trash']"));

        public IWebElement ConfirmDelete => ObjectRepo.driver.FindElement(By.XPath("//button[text()=' Yes, Delete ']"));

        public IWebElement Addbtn => ObjectRepo.driver.FindElement(By.XPath("(//button[contains(@class,'oxd-button oxd-button--medium')])[3]"));

        public IWebElement AddEmployeetxt => ObjectRepo.driver.FindElement(By.XPath("(//h6[contains(@class,'oxd-text oxd-text--h6')])[2]"));

        public IWebElement EmpFName => ObjectRepo.driver.FindElement(By.XPath("//input[@placeholder='First Name']"));

        public IWebElement EmpLName => ObjectRepo.driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));

        public IWebElement EmployeeID => ObjectRepo.driver.FindElement(By.XPath("//label[text()='Employee Id']/following::input"));

        public IWebElement Savebtn => ObjectRepo.driver.FindElement(By.XPath("(//button[contains(@class,'oxd-button oxd-button--medium')])[2]"));

        public IWebElement PersonalDetailTxt => ObjectRepo.driver.FindElement(By.XPath("//h6[text()='Personal Details']"));

        public IWebElement FullNameValue => ObjectRepo.driver.FindElement(By.XPath("//input[@placeholder='First Name']"));

        public IWebElement LastNameValue => ObjectRepo.driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));

        public IWebElement EmployeeIDValue => ObjectRepo.driver.FindElement(By.XPath("//label[text()='Employee Id']/following::input[1]"));

        public IWebElement NationalityArrowBtn => ObjectRepo.driver.FindElement(By.XPath("//div[@id='app']/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/i[1]"));

        public IReadOnlyList<IWebElement> Nationality => ObjectRepo.driver.FindElements(By.XPath("//div[@class = 'oxd-select-dropdown --positon-bottom']/div[@class='oxd-select-option']"));

        public IWebElement CalendarDD => ObjectRepo.driver.FindElement(By.XPath("(//input[@class='oxd-input oxd-input--active']/following-sibling::i)[2]"));

        public IWebElement CalenderMonthDD => ObjectRepo.driver.FindElement(By.XPath("//i[@class='oxd-icon bi-caret-down-fill oxd-icon-button__icon']"));

        public IReadOnlyList<IWebElement> CalenderMonth => ObjectRepo.driver.FindElements(By.XPath("//ul[@class='oxd-calendar-dropdown']/li"));

        public IWebElement CalendarYearDD => ObjectRepo.driver.FindElement(By.XPath("//div[@class='oxd-calendar-selector-year-selected']/i"));

        public IReadOnlyList<IWebElement> CalenderYear => ObjectRepo.driver.FindElements(By.XPath("//ul[@class='oxd-calendar-dropdown']/li"));

        public IReadOnlyList<IWebElement> CanlenderDate => ObjectRepo.driver.FindElements(By.XPath("//div[@class='oxd-calendar-dates-grid']/div"));

        public IWebElement CloseBtn => ObjectRepo.driver.FindElement(By.XPath("//div[@class='oxd-date-input-link --close']"));

        public IWebElement Male => ObjectRepo.driver.FindElement(By.XPath("//div[@class='--gender-grouped-field']/div[@class='oxd-input-group oxd-input-field-bottom-space'][1]/div[2]/div[@class='oxd-radio-wrapper']/label/span"));

        public IWebElement Female => ObjectRepo.driver.FindElement(By.XPath("//div[@class='--gender-grouped-field']/div[@class='oxd-input-group oxd-input-field-bottom-space'][2]/div[2]/div[@class='oxd-radio-wrapper']/label/span"));

        public IWebElement StatusDD => ObjectRepo.driver.FindElement(By.XPath("(//i[contains(@class,'oxd-icon bi-caret-down-fill')])[3]"));
        public IReadOnlyList<IWebElement> Status => ObjectRepo.driver.FindElements(By.XPath("//div[@class = 'oxd-select-dropdown --positon-bottom']/div"));

        public IWebElement SaveBtn => ObjectRepo.driver.FindElement(By.XPath("//p[text()=' * Required']/following-sibling::button"));


    }
}
