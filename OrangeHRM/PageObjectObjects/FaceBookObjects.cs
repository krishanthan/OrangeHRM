using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjectObjects
{
    public class FaceBookObjects 

    {
        public static IWebDriver driver { get; set; }

        public IWebElement Gender => driver.FindElement(By.XPath("//input[@name='sex']"));
        public IWebElement DropDownLink => driver.FindElement(By.LinkText("Dropdown"));

        public IWebElement SelectDropDown => driver.FindElement(By.XPath("//h3[text()='Dropdown List']/following-sibling::select"));





    }
}
